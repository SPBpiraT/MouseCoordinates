using MediatR;

namespace MouseCoordinates.Application.Coords.Commands.AddCoordinates
{
    public class AddCoordinatesCommand : IRequest<Guid>
    {
        public string Coords { get; set; }
    }
}
