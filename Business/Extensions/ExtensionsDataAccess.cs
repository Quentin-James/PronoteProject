namespace Business.Extensions;

using DataAccess.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ExtensionsDataAccess
{
    public static IServiceCollection AppDbContextMini(this IServiceCollection services, IdentityBuilder builder, IConfiguration config)
    {
        services.AddDbContextMini(builder);
        services.ConfigureSqlServerContext(config);
        return services;
    }

    public static IServiceCollection AddHostedService(this IServiceCollection services)
    {
        services.AddHostedService<HostedService>();
        return services;
    }
}