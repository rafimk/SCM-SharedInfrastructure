using SCM.SharedEnabler.Events;

namespace SCM.Testing.Api.Events;

internal record AccountCreated(Guid Id, Guid CustomerId, string Currency, decimal Amount) : IEvent;