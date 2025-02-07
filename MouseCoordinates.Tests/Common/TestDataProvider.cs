using MouseCoordinates.Application.Coords.Commands.AddCoordinates;

namespace MouseCoordinates.Tests.Common
{
    public static class TestDataProvider
    {
        public static List<CoordinateData> GenerateCoordinatesTestData(int numCoords)
        {
            var coords = new List<CoordinateData>();

            var random = new Random();

            for (int i = 0; i < numCoords; i++)
            {
                int x = random.Next(0, 999);
                int y = random.Next(0, 999);
                string time = DateTime.Now.ToString("HH:mm:ss");

                coords.Add(new CoordinateData(x, y, time));
            }

            return coords;
        }
    }
}
