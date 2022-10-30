using System.Threading.Tasks;
using SCM.SharedEnabler.Messaging;

namespace SCM.Shared.Infrastructure.Messaging.Outbox;

public interface IOutboxBroker
{
    bool Enabled { get; }
    Task SendAsync(params IMessage[] messages);
}