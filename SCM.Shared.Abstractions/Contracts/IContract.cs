using System;
using System.Collections.Generic;

namespace SCM.SharedEnabler.Contracts;

public interface IContract
{
    Type Type { get; }
    public IEnumerable<string> Required { get; }
}