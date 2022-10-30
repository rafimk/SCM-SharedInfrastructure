using SCM.SharedEnabler.Exceptions;

namespace SCM.SharedEnabler.Kernel.Exceptions;

public class UnsupportedCurrencyException : SCMException
{
    public string Currency { get; }

    public UnsupportedCurrencyException(string currency) : base($"Currency: '{currency}' is unsupported.")
    {
        Currency = currency;
    }
}