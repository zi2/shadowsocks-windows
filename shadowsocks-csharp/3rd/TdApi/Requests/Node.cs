namespace Shadowsocks.TdApi.Requests
{
    public class Node
    {
        public int id { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public string server { get; set; }
        public string method { get; set; }
        public int custom_method { get; set; }
        public float traffic_rate { get; set; }
        public string info { get; set; }
        public string status { get; set; }
        public int offset { get; set; }
        public int sort { get; set; }
    }
}