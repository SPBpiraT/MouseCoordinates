using MediatR;

namespace MouseCoordinates.Application.Coords.Commands.AddCoordinates
{
    public class AddCoordinatesCommand : IRequest<Guid>
    {
        public List<CoordinateData> Coords { get; set; }
    }

    public record CoordinateData(int x, int y, string datetime) { }
}
