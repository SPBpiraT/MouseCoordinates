using MouseCoordinates.Persistence;

namespace MouseCoordinates.Tests.Common
{
    public abstract class TestCommandBase : IDisposable
    {
        protected readonly CoordinatesDbContext Context;

        public TestCommandBase()
        {
            Context = CoordinatesContextFactory.Create();
        }

        public void Dispose()
        {
            CoordinatesContextFactory.Destroy(Context);
        }
    }
}
