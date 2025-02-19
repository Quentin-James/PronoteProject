namespace DataAccess.Extensions;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// A hosted service that applies database migrations at startup if not in development environment.
/// </summary>
public class HostedService(IServiceProvider serviceProvider, IHostEnvironment env) : IHostedService
{
    /// <summary>
    /// Starts the hosted service and applies database migrations if not in development environment.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        if (env.IsDevelopment())
        {
            return;
        }
        using var scope = serviceProvider.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<DbDataAccess>();
        await db.Database.MigrateAsync(cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Stops the hosted service.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A completed task.</returns>
    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}