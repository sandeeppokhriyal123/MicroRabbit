using MircroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MircroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}

