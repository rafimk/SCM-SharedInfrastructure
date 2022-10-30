using System.Threading.Tasks;

namespace SCM.Shared.Infrastructure;

public interface IInitializer
{
    Task InitAsync();
}