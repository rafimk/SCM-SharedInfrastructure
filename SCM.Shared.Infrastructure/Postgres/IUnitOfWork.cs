using System;
using System.Threading.Tasks;

namespace SCM.Shared.Infrastructure.Postgres;

public interface IUnitOfWork
{
    Task ExecuteAsync(Func<Task> action);
}