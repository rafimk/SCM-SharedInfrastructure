using SCM.SharedEnabler.Exceptions;

namespace SCM.SharedEnabler.Kernel.Exceptions;

public class InvalidCurrencyException : SCMException
{
    public string Currency { get; }

    public InvalidCurrencyException(string currency) : base($"Currency: '{currency}' is invalid.")
    {
        Currency = currency;
    }
}