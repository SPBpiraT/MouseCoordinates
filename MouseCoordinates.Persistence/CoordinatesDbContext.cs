using Microsoft.EntityFrameworkCore;
using MouseCoordinates.Application.Interfaces;
using MouseCoordinates.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseCoordinates.Persistence
{
    public class CoordinatesDbContext : DbContext, ICoordinatesDbContext
    {
        public DbSet<Coordinates> Coords { get; set; }
    }
}
