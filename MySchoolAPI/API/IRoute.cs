namespace Business;

using Microsoft.AspNetCore.Routing;

public interface IAddRoute
{
    void MapRoutes(IEndpointRouteBuilder app);
}