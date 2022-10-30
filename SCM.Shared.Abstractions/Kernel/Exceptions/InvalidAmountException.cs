using SCM.SharedEnabler.Exceptions;

namespace SCM.SharedEnabler.Kernel.Exceptions;

public class InvalidAmountException : SCMException
{
    public decimal Amount { get; }

    public InvalidAmountException(decimal amount) : base($"Amount: '{amount}' is invalid.")
    {
        Amount = amount;
    }
}