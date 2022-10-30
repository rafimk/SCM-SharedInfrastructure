using SCM.SharedEnabler.Messaging;

namespace SCM.Shared.Infrastructure.Messaging.Dispatchers;

internal record MessageEnvelope(IMessage Message, IMessageContext MessageContext);