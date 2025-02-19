using DataAccess;
using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Business;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Business.Extensions;

/// <summary>
/// Entry point for the application. Configures services and middleware.
/// </summary>
var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Adds authorization services to the container.
/// </summary>
builder.Services.AddAuthorization();

/// <summary>
/// Adds identity services to the container.
/// </summary>
var identityBuilder = builder.Services.AddIdentityApiEndpoints<User>();

/// <summary>
/// Configures the application's database context.
/// </summary>
builder.Services.AppDbContextMini(identityBuilder, builder.Configuration);

/// <summary>
/// Adds a hosted service to the container.
/// </summary>
builder.Services.AddHostedService();

/// <summary>
/// Adds CORS policy to allow requests from specified origins.
/// </summary>
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins",
        builder => builder.WithOrigins("http://localhost:4200")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

/// <summary>
/// Adds controllers with JSON options to the container.
/// </summary>
builder.Services.AddControllers()
   .AddJsonOptions(options =>
   {
       options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
       options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
   });

/// <summary>
/// Adds Swagger services to the container.
/// </summary>
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
    c.CustomSchemaIds(type => type.FullName);
});

/// <summary>
/// Builds the application.
/// </summary>
WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    /// <summary>
    /// Enables Swagger in development environment.
    /// </summary>
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    });
}

/// <summary>
/// Enables HTTPS redirection.
/// </summary>
app.UseHttpsRedirection();

/// <summary>
/// Enables CORS with the specified policy.
/// </summary>
app.UseCors("AllowAngularOrigins");

/// <summary>
/// Configures routing.
/// </summary>
app.UseRouting();

/// <summary>
/// Enables authorization.
/// </summary>
app.UseAuthorization();

/// <summary>
/// Maps routes for all types implementing IRoute interface.
/// </summary>
var interfaceType = typeof(IRoute);
var implementingTypes = Assembly.GetExecutingAssembly().GetTypes()
   .Where(t => interfaceType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

foreach (var type in implementingTypes)
{
    var route = Activator.CreateInstance(type) as IRoute;
    route?.MapRoutes(app);
}

/// <summary>
/// Maps identity API endpoints.
/// </summary>
app.MapIdentityApi<User>();

/// <summary>
/// Runs the application.
/// </summary>
app.Run();