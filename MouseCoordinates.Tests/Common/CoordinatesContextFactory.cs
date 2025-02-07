using Microsoft.EntityFrameworkCore;
using MouseCoordinates.Persistence;
using MouseCoordinates.Domain;
using Newtonsoft.Json;

namespace MouseCoordinates.Tests.Common
{
    public static class CoordinatesContextFactory
    {
        public static CoordinatesDbContext Create()
        {
            var options = new DbContextOptionsBuilder<CoordinatesDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new CoordinatesDbContext(options);

            context.Database.EnsureCreated();

            context.Coords.AddRange(
                new Coordinates
                {
                    Id = Guid.NewGuid(),
                    CoordsJson = JsonConvert.SerializeObject(TestDataProvider.GenerateCoordinatesTestData(10))
                },
                new Coordinates
                {
                    Id = Guid.NewGuid(),
                    CoordsJson = JsonConvert.SerializeObject(TestDataProvider.GenerateCoordinatesTestData(10))
                }
            );

            context.SaveChanges();
            return context;
        }

        public static void Destroy(CoordinatesDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
