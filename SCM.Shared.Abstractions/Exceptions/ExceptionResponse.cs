using System.Net;

namespace SCM.SharedEnabler.Exceptions;

public record ExceptionResponse(object Response, HttpStatusCode StatusCode);