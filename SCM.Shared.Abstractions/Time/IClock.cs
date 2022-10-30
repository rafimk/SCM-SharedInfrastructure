using System;

namespace SCM.SharedEnabler.Time;

public interface IClock
{
    DateTime CurrentDate();
}