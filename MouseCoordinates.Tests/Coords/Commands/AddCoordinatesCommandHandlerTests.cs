using Microsoft.EntityFrameworkCore;
using MouseCoordinates.Application.Coords.Commands.AddCoordinates;
using MouseCoordinates.Tests.Common;

namespace MouseCoordinates.Tests.Coords.Commands
{
    public class AddCoordinatesCommandHandlerTest : TestCommandBase
    {
        [Fact]
        public async Task AddCoordinatesCommandHandler_Success()
        {
            //Arrange

            var handler = new AddCoordinatesCommandHandler(Context);

            //Act

            var coordsId = await handler.Handle(
                new AddCoordinatesCommand()
                {
                    Coords = TestDataProvider.GenerateCoordinatesTestData(10)
                },
                CancellationToken.None);

            //Assert

            Assert.NotNull(
                await Context.Coords.SingleOrDefaultAsync(coords =>
                coords.Id == coordsId));
        }
    }
}
