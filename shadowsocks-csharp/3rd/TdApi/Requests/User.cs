namespace Shadowsocks.TdApi
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string passwd { get; set; }
        public int t { get; set; }
        public int u { get; set; }
        public long d { get; set; }
        public long transfer_enable { get; set; }
        public int port { get; set; }
        public string protocol { get; set; }
        public string obfs { get; set; }
        public int _switch { get; set; }
        public int enable { get; set; }
        public int type { get; set; }
        public int last_check_in_time { get; set; }
        public string reg_date { get; set; }
        public int invite_num { get; set; }
        public int expire_time { get; set; }
        public string method { get; set; }
    }
}