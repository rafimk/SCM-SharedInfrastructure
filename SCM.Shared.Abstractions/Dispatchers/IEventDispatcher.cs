using System.Threading;
using System.Threading.Tasks;
using SCM.SharedEnabler.Events;

namespace SCM.SharedEnabler.Dispatchers;

public interface IEventDispatcher
{
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : class, IEvent;
}