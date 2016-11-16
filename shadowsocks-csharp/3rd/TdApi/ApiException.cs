using System;

namespace Shadowsocks.TdApi
{
    public class ApiException : Exception
    {
        public ApiException(int code, string msg) : base(msg)
        {
            Code = code;
        }

        public int Code { get; set; }
    }
}