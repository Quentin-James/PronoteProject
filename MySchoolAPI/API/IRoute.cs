namespace Business;

using Microsoft.AspNetCore.Routing;

/// <summary>
/// Interface for defining route mapping in the application.
/// </summary>
public interface IRoute
{
    /// <summary>
    /// Maps the routes for the application.
    /// </summary>
    /// <param name="app">The endpoint route builder used to configure routes.</param>
    void MapRoutes(IEndpointRouteBuilder app);
}