using System.Threading;
using System.Threading.Tasks;
using SCM.SharedEnabler.Commands;
using SCM.SharedEnabler.Events;
using SCM.SharedEnabler.Queries;

namespace SCM.SharedEnabler.Dispatchers;

public interface IDispatcher
{
    Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
    Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : class, IEvent;
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}