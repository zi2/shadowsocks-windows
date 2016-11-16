namespace Shadowsocks.TdApi.Requests
{
    public class GetUserRequest : Request<User>
    {
        public GetUserRequest(int uid) : base($"/api/user/{uid}")
        {

        }
    }
}