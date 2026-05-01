using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.Tests
{
    public class VentasServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExisteVenta_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ventas.Add(CreateVenta(id: 1, totalNeto: 1200.50m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new VentasService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.VentaId);
            Assert.Equal(1200.50m, result.TotalNeto);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteVenta_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new VentasService(context);

            // Act
            var result = await service.Buscar(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorMonto_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ventas.AddRange(
                    CreateVenta(id: 1, totalNeto: 100m),
                    CreateVenta(id: 2, totalNeto: 500m),
                    CreateVenta(id: 3, totalNeto: 1000m)
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new VentasService(context);

            // Act
            var result = await service.GetList(v => v.TotalNeto >= 400m);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, v => v.VentaId == 2);
            Assert.Contains(result, v => v.VentaId == 3);
        }

        [Fact]
        public async Task Guardar_CuandoVentaNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new VentasService(context);
            var nuevaVenta = CreateVenta(id: 50, totalNeto: 1500m);

            // Act
            var result = await service.Guardar(nuevaVenta);

            // Assert
            Assert.True(result);

            var saved = await context.Ventas.FirstOrDefaultAsync(v => v.VentaId == 50);
            Assert.NotNull(saved);
            Assert.Equal(1500m, saved!.TotalNeto);
        }

        [Fact]
        public async Task Guardar_CuandoVentaExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ventas.Add(CreateVenta(id: 60, totalNeto: 300m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new VentasService(context);
            var updated = CreateVenta(id: 60, totalNeto: 450.75m);

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);
            var saved = await context.Ventas.FirstOrDefaultAsync(v => v.VentaId == 60);
            Assert.NotNull(saved);
            Assert.Equal(450.75m, saved!.TotalNeto);
        }

        [Fact]
        public async Task Existe_CuandoVentaExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ventas.Add(CreateVenta(id: 70, totalNeto: 100m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new VentasService(context);

            // Act
            var result = await service.Existe(70);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteVenta_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Ventas.Add(CreateVenta(id: 80, totalNeto: 200m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new VentasService(context);

            // Act
            var result = await service.Eliminar(80);

            // Assert
            Assert.True(result);
            var eliminado = await context.Ventas.FindAsync(80);
            Assert.Null(eliminado);
        }

        private static Venta CreateVenta(
            int id,
            decimal totalNeto)
        {
            return new Venta
            {
                VentaId = id,
                TotalNeto = totalNeto,
                Fecha = DateTime.Now
            };
        }
    }
}