using MouseCoordinates.Persistence;

var builder = WebApplication.CreateBuilder(args);
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
