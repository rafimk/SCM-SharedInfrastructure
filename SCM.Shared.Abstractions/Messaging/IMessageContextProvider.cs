namespace SCM.SharedEnabler.Messaging;

public interface IMessageContextProvider
{
    IMessageContext Get(IMessage message);
}