using SCM.SharedEnabler.Exceptions;

namespace SCM.SharedEnabler.Kernel.Exceptions;

public class InvalidNationalityException : SCMException
{
    public string Nationality { get; }

    public InvalidNationalityException(string nationality) : base($"Nationality: '{nationality}' is invalid.")
    {
        Nationality = nationality;
    }
}