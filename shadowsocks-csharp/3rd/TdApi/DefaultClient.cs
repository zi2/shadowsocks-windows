using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Shadowsocks.TdApi.Requests;

namespace Shadowsocks.TdApi
{
    public class DefaultClient : IClient
    {
        private WebClient _client;
        private string _site;
        public string Token;

        public DefaultClient(string token = null, string site = null)
        {
            _client = new WebClient();
            Token = token;
        }

        public T Execute<T>(IRequest<T> request)
        {
            var parms = request.Parameters ?? new NameValueCollection();
            parms.Add("access_token", Token);
            var bytes = "post".Equals(request.HttpMethod, StringComparison.CurrentCultureIgnoreCase)
                        ? _client.UploadValues(request.Url, request.HttpMethod, parms)
                        : _client.DownloadData($"{request.Url}?{Join(parms)}");
            Response<T> root;
            try { root = JsonConvert.DeserializeObject<Response<T>>(Encoding.UTF8.GetString(bytes)); }
            catch { throw new InvalidCastException("解析服务器数据失败"); }
            if (root.ret != 1)
                throw new ApiException(root.ret, root.msg);
            return root.data;
        }

        private string Join(NameValueCollection vs)
        {
            return vs == null ? "" : $"{string.Join("&", vs.Cast<string>().Select(k => $"{k}={Uri.EscapeDataString(vs[k])}"))}";
        }
    }
}