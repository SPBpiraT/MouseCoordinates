using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MouseCoordinates.Application.Interfaces;

namespace MouseCoordinates.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<CoordinatesDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<ICoordinatesDbContext>(provider =>
                provider.GetService<CoordinatesDbContext>());
            return services;
        }
    }
}
