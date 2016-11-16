using System.Collections.Specialized;
using System.Windows.Forms;

namespace Shadowsocks.TdApi.Requests
{
    public class TokenRequest : Request<TokenData>
    {
        public string Email { get; set; }
        public string Passwd { get; set; }

        public TokenRequest() : base("/api/token")
        {
            HttpMethod = "POST";
        }

        public override NameValueCollection Parameters => new NameValueCollection() { { "email", Email }, { "passwd", Passwd } };
    }

    public class TokenData
    {
        public string token { get; set; }
        public int user_id { get; set; }
    }

}
