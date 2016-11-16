using System;

namespace Shadowsocks.TdApi
{
    public class UserFriendlyException : Exception
    {
        public UserFriendlyException(string msg) : base(msg)
        {

        }
    }
}