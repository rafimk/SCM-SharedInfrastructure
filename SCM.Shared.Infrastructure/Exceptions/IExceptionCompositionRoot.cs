using System;
using SCM.SharedEnabler.Exceptions;

namespace SCM.Shared.Infrastructure.Exceptions;

public interface IExceptionCompositionRoot
{
    ExceptionResponse Map(Exception exception);
}