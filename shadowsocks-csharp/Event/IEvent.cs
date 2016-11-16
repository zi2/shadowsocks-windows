namespace Shadowsocks.Event
{
    public interface IEvent<out TData>
    {
        object Source { get; }
        TData Data { get; }
    }
}