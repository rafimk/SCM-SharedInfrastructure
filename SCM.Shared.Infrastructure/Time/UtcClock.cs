using System;
using SCM.SharedEnabler.Time;

namespace SCM.Shared.Infrastructure.Time;

public class UtcClock : IClock
{
    public DateTime CurrentDate() => DateTime.UtcNow;
}