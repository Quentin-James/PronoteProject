using DataAccess;
using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Business;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Business.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthorization();
var identityBuilder = builder.Services.AddIdentityApiEndpoints<User>();
builder.Services.AppDbContextMini(identityBuilder, builder.Configuration);

// Add database developer page exception filter
builder.Services.AddHostedService();
// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins",
        builder => builder.WithOrigins("http://localhost:4200")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

// Add controllers with JSON options
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minimal API", Version = "v1" });
    c.CustomSchemaIds(type => type.FullName);
});

// Add application services and repositories

// Build the application
WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minimal API v1");
    });
}
app.UseHttpsRedirection();
app.UseCors("AllowAngularOrigins");

app.UseRouting();
app.UseAuthorization();
// Map routes
var interfaceType = typeof(IAddRoute);
var implementingTypes = Assembly.GetExecutingAssembly().GetTypes()
    .Where(t => interfaceType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

foreach (var type in implementingTypes)
{
    var route = Activator.CreateInstance(type) as IAddRoute;
    route?.MapRoutes(app);
}

// Use middleware
app.MapIdentityApi<User>();
// Run the application
app.Run();