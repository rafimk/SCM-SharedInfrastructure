using SCM.Shared.Infrastructure.Postgres;

namespace SCM.Testing.Api.DAL;

internal class TestUnitOfWork : PostgresUnitOfWork<TestDbContext>
{
    public TestUnitOfWork(TestDbContext dbContext) : base(dbContext)
    {
    }
}