using MediatR;

namespace MouseCoordinates.Application.Coords.Commands.AddCoordinates
{
    public class AddCoordinatesCommand : IRequest<Guid>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
