using MouseCoordinates.Application.Common.Mapping;
using MouseCoordinates.Application.Interfaces;
using MouseCoordinates.Persistence;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(ICoordinatesDbContext).Assembly));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<CoordinatesDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception exception)
    {
        //TODO: Add logging
    }
}

app.MapGet("/", () => "Hello World!");

app.Run();
