using Microsoft.EntityFrameworkCore;
using GBPColmadoNet.Data.Context;
namespace GBPColmadoNet.Tests.Infraestructura
{
    public class TestDbContextFactory
    {
        public static string NewDataBaseName() => $"GBPColmadoNet_{Guid.NewGuid()}";

        public static ColmadoContext CreateContext(string DatabaseName)
        {
            var options = new DbContextOptionsBuilder<ColmadoContext>()
                .UseInMemoryDatabase(DatabaseName)
                .Options;

            return new InMemoryClmadoContext(options);
        }

        private sealed class InMemoryClmadoContext(DbContextOptions<ColmadoContext> options)
            : ColmadoContext(options)
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // Intentionally empty: tests provide InMemory provider through options.
            }
        }
    }
}
