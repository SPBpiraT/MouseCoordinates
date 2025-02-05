using Microsoft.EntityFrameworkCore;
using MouseCoordinates.Domain;

namespace MouseCoordinates.Application.Interfaces
{
    public interface ICoordinatesDbContext
    {
        DbSet<Coordinates> Coords { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
