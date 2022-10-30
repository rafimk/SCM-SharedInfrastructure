using System;
using SCM.SharedEnabler.Contexts;

namespace SCM.SharedEnabler.Messaging;

public interface IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }
}