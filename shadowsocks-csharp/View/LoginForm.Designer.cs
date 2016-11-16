namespace Shadowsocks.View
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnklBuy = new System.Windows.Forms.LinkLabel();
            this.lnklHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "注册邮箱";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 21);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "登录密码";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(71, 72);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(201, 21);
            this.txtPasswd.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(97, 117);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登 录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnklBuy
            // 
            this.lnklBuy.AutoSize = true;
            this.lnklBuy.Location = new System.Drawing.Point(178, 122);
            this.lnklBuy.Name = "lnklBuy";
            this.lnklBuy.Size = new System.Drawing.Size(53, 12);
            this.lnklBuy.TabIndex = 5;
            this.lnklBuy.TabStop = true;
            this.lnklBuy.Tag = "1";
            this.lnklBuy.Text = "我要充值";
            this.lnklBuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklBuy_LinkClicked);
            // 
            // lnklHelp
            // 
            this.lnklHelp.AutoSize = true;
            this.lnklHelp.Location = new System.Drawing.Point(243, 122);
            this.lnklHelp.Name = "lnklHelp";
            this.lnklHelp.Size = new System.Drawing.Size(29, 12);
            this.lnklHelp.TabIndex = 5;
            this.lnklHelp.TabStop = true;
            this.lnklHelp.Tag = "2";
            this.lnklHelp.Text = "帮助";
            this.lnklHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklBuy_LinkClicked);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.lnklHelp);
            this.Controls.Add(this.lnklBuy);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "使用注册账号登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnklBuy;
        private System.Windows.Forms.LinkLabel lnklHelp;
    }
}