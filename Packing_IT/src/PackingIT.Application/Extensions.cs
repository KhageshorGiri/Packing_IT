using Microsoft.Extensions.DependencyInjection;
using PackingIT.Domain.Factories;
using PackingIT.Domain.Policies;
using PackingIT.Shared.Commands;

namespace PackingIT.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddCommands();
        services.AddSingleton<IPackingListFactory, PackingListFactory>();

        services.Scan(b => b.FromAssemblies(typeof(IPackingItemsPolicy).Assembly)
            .AddClasses(c => c.AssignableTo<IPackingItemsPolicy>())
            .AsImplementedInterfaces()
            .WithSingletonLifetime());

        return services;
    }
}
