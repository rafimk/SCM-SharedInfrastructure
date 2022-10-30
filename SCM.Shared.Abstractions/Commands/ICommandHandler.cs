using System.Threading;
using System.Threading.Tasks;

namespace SCM.SharedEnabler.Commands;

public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
{
    Task HandleAsync(TCommand command, CancellationToken cancellationToken = default);
}