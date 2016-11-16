using System;
using System.Collections.Generic;
using Shadowsocks.TdApi.Requests;

namespace Shadowsocks.Event
{
    public class EventBus
    {
        delegate void myEventHandler(object e);

        private static Dictionary<Type, myEventHandler> events = new Dictionary<Type, myEventHandler>();

        public static void Subscribe<TData>(IEvent<TData> ev, Action<IEvent<TData>> action)
        {
            Subscribe(ev.GetType(), action);
        }


        public static void Subscribe<TData>(Type typeOfEvent, Action<IEvent<TData>> action)
        {
            if (events.ContainsKey(typeOfEvent))
                events[typeOfEvent] += e => action(e as IEvent<TData>);
            else
                events.Add(typeOfEvent, e => action(e as IEvent<TData>));
        }

        public static void Trigger<TData>(IEvent<TData> e)
        {
            if (events.ContainsKey(e.GetType()))
                events[e.GetType()].Invoke(e);
        }


    }
}