using Microsoft.EntityFrameworkCore;
using MouseCoordinates.Application.Interfaces;
using MouseCoordinates.Domain;
using MouseCoordinates.Persistence.EntityTypeConfigurations;

namespace MouseCoordinates.Persistence
{
    public class CoordinatesDbContext : DbContext, ICoordinatesDbContext
    {
        public DbSet<Coordinates> Coords { get; set; }

        public CoordinatesDbContext(DbContextOptions<CoordinatesDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CoordinatesConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
