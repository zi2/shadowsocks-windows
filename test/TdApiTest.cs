using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shadowsocks.TdApi;
using Shadowsocks.TdApi.Requests;

namespace test
{
    [TestClass]
    public class TdApiTest
    {
        private string token = "yeugN6iKI06PJSU9gwJTLv2Frts5W62oAl8w2XtkTGwcgqcC1vRS0zMfni0ApiD0";

        [TestMethod]
        public void GetTokenSuccess()
        {
            var c = new DefaultClient();
            var ret = c.Execute(new TokenRequest()
            {
                Email = "test1@zi2.cc",
                Passwd = "wobuzd123"
            });
            Console.WriteLine(token = ret.token);
        }

        [TestMethod]
        public void GetUserSuccess()
        {
            var c = new DefaultClient(token);
            var ret = c.Execute(new GetUserRequest(2));
            Console.WriteLine(ret.email);
        }

        [TestMethod]
        public void GetNodesSuccess()
        {
            var c=new DefaultClient(token);
            var ls = c.Execute(new GetNodesRequest());
            Console.WriteLine(ls.Count);
        }
    }
}