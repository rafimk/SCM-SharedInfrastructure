using System.Threading;
using System.Threading.Tasks;
using SCM.SharedEnabler.Messaging;

namespace SCM.Shared.Infrastructure.Messaging.Dispatchers;

public interface IAsyncMessageDispatcher
{
    Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken = default)
        where TMessage : class, IMessage;
}