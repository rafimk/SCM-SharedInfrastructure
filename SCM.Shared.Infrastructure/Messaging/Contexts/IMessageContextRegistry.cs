using SCM.SharedEnabler.Messaging;

namespace SCM.Shared.Infrastructure.Messaging.Contexts;

public interface IMessageContextRegistry
{
    void Set(IMessage message, IMessageContext context);
}