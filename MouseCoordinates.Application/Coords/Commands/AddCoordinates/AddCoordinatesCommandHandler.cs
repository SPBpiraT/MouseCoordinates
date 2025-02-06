using MediatR;
using MouseCoordinates.Application.Interfaces;
using MouseCoordinates.Domain;

namespace MouseCoordinates.Application.Coords.Commands.AddCoordinates
{
    public class AddCoordinatesCommandHandler
        : IRequestHandler<AddCoordinatesCommand, Guid>
    {
        private readonly ICoordinatesDbContext _dbContext;
        public AddCoordinatesCommandHandler(ICoordinatesDbContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Guid> Handle(AddCoordinatesCommand request,
            CancellationToken cancellationToken)
        {
            var coordinates = new Coordinates
            {
                Id = Guid.NewGuid(),
                Coords = request.Coords
            };

            await _dbContext.Coords.AddAsync(coordinates, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return coordinates.Id;
        }
    }
}
