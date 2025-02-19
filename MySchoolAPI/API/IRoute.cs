namespace Business;

using Microsoft.AspNetCore.Routing;

public interface IRoute
{
    void MapRoutes(IEndpointRouteBuilder app);
}