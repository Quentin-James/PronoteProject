﻿namespace DataAccess.Extensions;

using DataAccess.Repository;
using DataAccess.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models.Models;

public static class ExtensionsDb
{
    /// <summary>
    /// Adds the DbContext and Identity framework stores to the service collection.
    /// </summary>
    /// <param name="services">The service collection to add the DbContext to.</param>
    /// <param name="builder">The IdentityBuilder to add the Entity Framework stores to.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddDbContextMini(this IServiceCollection services, IdentityBuilder builder)
    {
        services.AddScoped<IDbDataAccess>(service => service.GetRequiredService<DbDataAccess>());
        builder.AddEntityFrameworkStores<DbDataAccess>();
        return services;
    }

    /// <summary>
    /// Configures the SQL Server context for the application.
    /// </summary>
    /// <param name="services">The service collection to add the DbContext to.</param>
    /// <param name="config">The configuration containing the connection string.</param>
    public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("DefaultConnection");

        services.AddDbContext<DbDataAccess>
       (opt => opt.UseSqlServer(connectionString));
        services.AddIdentityCore<User>()
            .AddEntityFrameworkStores<DbDataAccess>();
    }

    /// <summary>
    /// Adds Student and Teacher repositories to the service collection.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="config"></param>
    /// <returns></returns>

    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IRepositoryStudents, StudentsRepository>();
        services.AddScoped<IRepositoryTeachers, TeachersRepository>();
        return services;
    }
}