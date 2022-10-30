using SCM.SharedEnabler.Exceptions;

namespace SCM.SharedEnabler.Kernel.Exceptions;

public class UnsupportedNationalityException : SCMException
{
    public string Nationality { get; }

    public UnsupportedNationalityException(string nationality) : base($"Nationality: '{nationality}' is unsupported.")
    {
        Nationality = nationality;
    }
}