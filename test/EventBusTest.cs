using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shadowsocks.Event;

namespace test
{
    class LoginedEvent : IEvent<string>
    {
        public LoginedEvent()
        {
            Data = "td";
        }
        public object Source { get; set; }
        public string Data { get; set; }
    }

    [TestClass]
    public class EventBusTest
    {
        [TestMethod]
        public void TestSingle()
        {
            var loginedEvent = new LoginedEvent();
            EventBus.Subscribe<string>(loginedEvent.GetType(), (e) =>
            {
                Console.WriteLine($@"received {e.Data} at " + DateTime.Now.ToString());
            });
            EventBus.Trigger(loginedEvent);
        }

        [TestMethod]
        public void TestMultipleSuccess()
        {
            var loginedEvent = new LoginedEvent();
            EventBus.Subscribe(loginedEvent, (e) =>
            {
                Console.WriteLine($@"received {e.Data} at " + DateTime.Now.ToString());
            });
            EventBus.Subscribe<string>(loginedEvent.GetType(), e =>
            {
                Console.WriteLine($@"received {e.Data} at " + DateTime.Now.ToString());
            });
            EventBus.Trigger(loginedEvent);

        }
    }
}