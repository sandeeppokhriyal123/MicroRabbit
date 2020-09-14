using MircroRabbit.Domain.Core.Commands;
using MircroRabbit.Domain.Core.Events;
using System.Threading.Tasks;

namespace MircroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Public<T>(T @event) where T : Event;
        void Subcribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
