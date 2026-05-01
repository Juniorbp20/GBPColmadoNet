using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.Tests
{
    public class ComprasServiceTest
    {

        [Fact]
        public async Task Buscar_CuandoExisteCompra_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Compras.Add(CreateCompra(id: 1, totalNeto: 1500m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ComprasService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.CompraId);
            Assert.Equal(1500m, result.TotalNeto);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteCompra_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new ComprasService(context);

            // Act
            var result = await service.Buscar(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorTotal_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Compras.AddRange(
                    CreateCompra(id: 1, totalNeto: 500m),
                    CreateCompra(id: 2, totalNeto: 2500m),
                    CreateCompra(id: 3, totalNeto: 3000m)
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ComprasService(context);

            // Act
            var result = await service.GetList(c => c.TotalNeto >= 2000m);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, c => c.CompraId == 2);
            Assert.Contains(result, c => c.CompraId == 3);
        }

        [Fact]
        public async Task Guardar_CuandoCompraNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new ComprasService(context);
            var nuevaCompra = CreateCompra(id: 110, totalNeto: 5000m);

            // Act
            var result = await service.Guardar(nuevaCompra);

            // Assert
            Assert.True(result);
            var saved = await context.Compras.FirstOrDefaultAsync(c => c.CompraId == 110);
            Assert.NotNull(saved);
            Assert.Equal(5000m, saved!.TotalNeto);
        }

        [Fact]
        public async Task Guardar_CuandoCompraExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Compras.Add(CreateCompra(id: 200, totalNeto: 1000m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ComprasService(context);
            var updated = CreateCompra(id: 200, totalNeto: 1250.50m);

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);
            var saved = await context.Compras.FirstOrDefaultAsync(c => c.CompraId == 200);
            Assert.NotNull(saved);
            Assert.Equal(1250.50m, saved!.TotalNeto);
        }

        [Fact]
        public async Task Existe_CuandoCompraExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Compras.Add(CreateCompra(id: 50, totalNeto: 100m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ComprasService(context);

            // Act
            var exists = await service.Existe(50);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteCompra_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Compras.Add(CreateCompra(id: 300, totalNeto: 800m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ComprasService(context);

            // Act
            var result = await service.Eliminar(300);

            // Assert
            Assert.True(result);
            var eliminado = await context.Compras.FindAsync(300);
            Assert.Null(eliminado);
        }

        private static Compra CreateCompra(
            int id,
            decimal totalNeto)
        {
            return new Compra
            {
                CompraId = id,
                TotalNeto = totalNeto,
                FechaRegistro = DateTime.Now
            };
        }
    }
}