namespace DataAccess.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Models;

    public static class ExtensionsDb
    {
        public static IServiceCollection AddDbContextMini(this IServiceCollection services, IdentityBuilder builder)
        {
            services.AddScoped<IDbDataAccess>(service => service.GetRequiredService<DbDataAccess>());
            builder.AddEntityFrameworkStores<DbDataAccess>();
            return services;
        }

        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<DbDataAccess>
           (opt => opt.UseSqlServer(connectionString));
            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<DbDataAccess>();
        }
    }
}