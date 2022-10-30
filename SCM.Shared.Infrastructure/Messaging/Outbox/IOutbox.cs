using System;
using System.Threading.Tasks;
using SCM.SharedEnabler.Messaging;

namespace SCM.Shared.Infrastructure.Messaging.Outbox;

public interface IOutbox
{
    bool Enabled { get; }
    Task SaveAsync(params IMessage[] messages);
    Task PublishUnsentAsync();
    Task CleanupAsync(DateTime? to = null);
}