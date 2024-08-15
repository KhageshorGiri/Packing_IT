using Microsoft.Extensions.DependencyInjection;
using PackingIT.Shared.Abstraction.Commands;
using PackingIT.Shared.Abstraction.Queries;
using PackingIT.Shared.Commands;
using System.Reflection;

namespace PackingIT.Shared.Queries;

public static class Extension
{
    public static IServiceCollection AddQueries(this IServiceCollection services)
    {
        var assembly = Assembly.GetCallingAssembly();

        services.AddSingleton<IQueryDispatcher, InMemoryQueryDispatcher>();
        services.Scan(s => s.FromAssemblies(assembly)
            .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        return services;
    }
}
