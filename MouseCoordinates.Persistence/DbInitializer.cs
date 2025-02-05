namespace MouseCoordinates.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(CoordinatesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
