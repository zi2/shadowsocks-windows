using System;

namespace Shadowsocks.TdApi
{
    public class Response<TData>
    {
        public int ret { get; set; }
        public string msg { get; set; }
        public TData data { get; }

        public Response()
        {
            data = Activator.CreateInstance<TData>();
        }
    }
}