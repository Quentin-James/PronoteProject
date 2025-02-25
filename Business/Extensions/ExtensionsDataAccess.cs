namespace Business.Extensions;

using Business.Interfaces;
using DataAccess.Extensions;
using DataAccess.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ExtensionsDataAccess
{
    /// <summary>
    /// Configures the application database context and SQL Server context.
    /// </summary>
    /// <param name="services">The service collection to add the services to.</param>
    /// <param name="builder">The identity builder to configure the identity services.</param>
    /// <param name="config">The configuration to use for setting up the SQL Server context.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AppDbContextMini(this IServiceCollection services, IdentityBuilder builder, IConfiguration config)
    {
        services.ConfigureSqlServerContext(config);

        services.AddRepositories(config);
        return services;
    }

    /// <summary>
    /// Adds a hosted service to the service collection.
    /// </summary>
    /// <param name="services">The service collection to add the hosted service to.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddHostedService(this IServiceCollection services)
    {
        services.AddHostedService<HostedService>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IServiceStudents, StudentsServices>();
        return services;
    }
}