﻿using System;
using System.Collections.Concurrent;
using System.Net;
using Humanizer;
using SCM.SharedEnabler.Exceptions;

namespace SCM.Shared.Infrastructure.Exceptions;

internal sealed class ExceptionToResponseMapper : IExceptionToResponseMapper
{
    private static readonly ConcurrentDictionary<Type, string> Codes = new();

    public ExceptionResponse Map(Exception exception)
        => exception switch
        {
            SCMException ex => new ExceptionResponse(new ErrorsResponse(new Error(GetErrorCode(ex), ex.Message))
                , HttpStatusCode.BadRequest),
            _ => new ExceptionResponse(new ErrorsResponse(new Error("error", "There was an error.")),
                HttpStatusCode.InternalServerError)
        };

    private record Error(string Code, string Message);

    private record ErrorsResponse(params Error[] Errors);

    private static string GetErrorCode(object exception)
    {
        var type = exception.GetType();
        return Codes.GetOrAdd(type, type.Name.Underscore().Replace("_exception", string.Empty));
    }
}