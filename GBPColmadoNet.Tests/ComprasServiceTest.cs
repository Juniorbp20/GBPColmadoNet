using System;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.Tests
{
    public class ComprasServiceTest
    {
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
