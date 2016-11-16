using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shadowsocks.Controller;
using Shadowsocks.Model;
using Shadowsocks.TdApi;
using Shadowsocks.TdApi.Requests;

namespace Shadowsocks.View
{
    public partial class LoginForm : Form
    {
        private readonly ShadowsocksController _controller;


        public LoginForm(ShadowsocksController controller = null)
        {
            if (!DesignMode && controller == null)
                throw new ArgumentNullException(nameof(controller));
            _controller = controller;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.IsNullOrEmpty() || txtPasswd.Text.IsNullOrEmpty())
                return;
            btnLogin.Text = "登录中，请稍候...";
            btnLogin.Enabled = false;

            var client = new DefaultClient();
            TokenData tokenData;

            try
            {
                tokenData = client.Execute(new TokenRequest() { Email = txtEmail.Text.Trim(), Passwd = txtPasswd.Text });
                client.Token = tokenData.token;

                //获取用户信息
                var user = client.Execute(new GetUserRequest(tokenData.user_id));
                if (user.enable != 1)
                    throw new UserFriendlyException("你的账号已经到期，请先充值后再畅游世界"); //todo:how to charge
                if (user.transfer_enable < user.u + user.d)
                    throw new UserFriendlyException("哦，你的流量都用完了，请先充值吧！");

                //获取节点
                var nodes = client.Execute(new GetNodesRequest());
                var config = _controller.GetCurrentConfiguration();
                config.configs = nodes.Select(n => new Server()
                {
                    server = n.server,
                    server_port = user.port,
                    method = user.method,
                    password = user.passwd,
                    timeout = 10,
                    auth = false
                }).ToList();
                config.enabled = true;
                config.autoCheckUpdate = false;
                config.index = new Random().Next(1, config.configs.Count);
                Configuration.Save(config);

                ShadowsocksControllerExtension.SetUser(user);

                Close();
            }
            catch (Exception ex)
            {
                btnLogin.Text = "登录";
                btnLogin.Enabled = true;

                MessageBox.Show($"出错了：{ex.Message}");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_controller.Authed())
                Environment.Exit(0);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lnklBuy.Links.Add(new LinkLabel.Link() { LinkData = "https://item.taobao.com/item.htm?id=539951097575", Enabled = true });
            lnklHelp.Links.Add(new LinkLabel.Link() { LinkData = "http://zi2.cc", Enabled = true });
        }

        private void lnklBuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((string)e.Link.LinkData);
        }
    }


    public static class ShadowsocksControllerExtension
    {
        private static User _currentUser;

        public static void SetUser(User user)
        {
            _currentUser = user;
        }

        public static User GetCurrentUser(this ShadowsocksController controller)
        {
            return _currentUser;
        }

        public static bool Authed(this ShadowsocksController controller)
        {
            return controller.GetCurrentUser() != null;
        }
    }
}
