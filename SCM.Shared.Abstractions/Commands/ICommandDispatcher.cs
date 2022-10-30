using System.Threading;
using System.Threading.Tasks;

namespace SCM.SharedEnabler.Commands;

public interface ICommandDispatcher
{
    Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default) where TCommand : class, ICommand;
}