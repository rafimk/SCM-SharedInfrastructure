namespace SCM.Testing.Api.Messages;

public interface ITypedConsumer<in T>
{
    public Task ConsumeAsync(T message, CancellationToken cancellationToken);
}