using System.Reflection;
using SCM.Shared.Infrastructure;
using SCM.Shared.Infrastructure.Messaging.Outbox;
using SCM.Shared.Infrastructure.Modules;
using SCM.Shared.Infrastructure.Postgres;
using SCM.SharedEnabler.Modules;
using SCM.Testing.Api.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IList<Assembly> _assemblies = ModuleLoader.LoadAssemblies(builder.Configuration, "SCM.");
IList<IModule> _modules = ModuleLoader.LoadModules(_assemblies);

builder.Services.AddModularInfrastructure(_assemblies, _modules);
foreach (var module in _modules)
{
    module.Register(builder.Services);
}

builder.Services.AddPostgres<TestDbContext>()
    .AddOutbox<TestDbContext>()
    .AddUnitOfWork<TestUnitOfWork>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();

app.UseModularInfrastructure();
foreach (var module in _modules)
{
    module.Use(app);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();