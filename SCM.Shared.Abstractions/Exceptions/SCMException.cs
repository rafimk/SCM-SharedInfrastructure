using System;

namespace SCM.SharedEnabler.Exceptions;

public abstract class SCMException : Exception
{
    protected SCMException(string message) : base(message)
    {
    }
}