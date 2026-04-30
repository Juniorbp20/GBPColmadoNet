using System;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.Tests
{
    public class VentasServiceTest
    {
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
             // In EF InMemory, it translates correctly.
            Assert.Equal(1500m, saved!.TotalNeto);
        }

        [Fact]
        public async Task Existe_CuandoVentaExiste_RetornaTrue()
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

            // Act
            var result = await service.Existe(60);

            // Assert
            Assert.True(result);
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
