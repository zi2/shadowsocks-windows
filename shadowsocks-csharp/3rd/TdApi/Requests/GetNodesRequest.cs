using System.Collections.Generic;

namespace Shadowsocks.TdApi.Requests
{
    public class GetNodesRequest : Request<List<Node>>
    {
        public GetNodesRequest() : base("/api/node")
        {
        }
    }
}