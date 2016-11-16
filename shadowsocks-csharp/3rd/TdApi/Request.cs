using System.Collections.Specialized;
using System.Configuration;

namespace Shadowsocks.TdApi
{
    public class Request<TData> : IRequest<TData>
    {
        protected string Site => ConfigurationManager.AppSettings?["entry"] ?? "https://zi2.cc";

        protected Request(string path)
        {
            Url = $"{Site}{path}";
            HttpMethod = "GET";
        }

        public string Url { get; set; }

        public string HttpMethod { get; protected set; }

        public virtual NameValueCollection Parameters { get; protected set; }
    }
}