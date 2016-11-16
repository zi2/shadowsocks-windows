using System.Collections.Specialized;

namespace Shadowsocks.TdApi
{
    public interface IRequest<TData>
    {
        string Url { get; set; }
        string HttpMethod { get; }
        NameValueCollection Parameters { get; }
    }
}