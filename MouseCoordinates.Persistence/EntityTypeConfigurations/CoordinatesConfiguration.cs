using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MouseCoordinates.Domain;

namespace MouseCoordinates.Persistence.EntityTypeConfigurations
{
    internal class CoordinatesConfiguration : IEntityTypeConfiguration<Coordinates>
    {
        public void Configure(EntityTypeBuilder<Coordinates> builder)
        {
            builder.HasKey(coords => coords.Id);
        }
    }
}
