﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameExChange.Events
{
    /// <summary>
    /// 事件聚合器
    /// </summary>
    public interface IEventAggregator
    {
        void Register<TEvent>(IEventHandler<TEvent> domainEventHandler)
   where TEvent : class, IEvent;
        void Register<TEvent>(IEnumerable<IEventHandler<TEvent>> domainEventHandlers)
            where TEvent : class, IEvent;

        void Handle<TEvent>(TEvent domainEvent)
           where TEvent : class, IEvent;
        void Handle<TEvent>(TEvent domainEvent, Action<TEvent, bool, Exception> callback, TimeSpan? timeout = null)
            where TEvent : class, IEvent;
    }
}
