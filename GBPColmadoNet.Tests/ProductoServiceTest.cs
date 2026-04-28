using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.Tests
{
    public class ProductoServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoProductoNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new ProductoService(context);
            var nuevoProducto = CreateProducto(id: 30, nombre: "Arroz Premium", precioCompra: 20m, precioVenta: 30m, codigoBarras: "12345");

            // Act
            var result = await service.Guardar(nuevoProducto);

            // Assert
            Assert.True(result);

            var saved = await context.Productos.FirstOrDefaultAsync(p => p.ProductoId == 30);
            Assert.NotNull(saved);
            Assert.Equal("Arroz Premium", saved!.Nombre);
            Assert.Equal("12345", saved.CodigoBarras);
        }

        [Fact]
        public async Task Guardar_CuandoProductoExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Productos.Add(CreateProducto(id: 40, nombre: "Habichuela", precioCompra: 30m, precioVenta: 40m, codigoBarras: "67890"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ProductoService(context);

            var updated = CreateProducto(id: 40, nombre: "Habichuela Negra", precioCompra: 35m, precioVenta: 45m, codigoBarras: "67890");

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);

            var saved = await context.Productos.FirstOrDefaultAsync(p => p.ProductoId == 40);
            Assert.NotNull(saved);
            Assert.Equal("Habichuela Negra", saved!.Nombre);
            Assert.Equal(35m, saved.PrecioCompra);
        }

        private static Producto CreateProducto(
            int id,
            string nombre,
            decimal precioCompra = 10m,
            decimal precioVenta = 15m,
            string? codigoBarras = null,
            decimal stock = 50m,
            decimal tasaItbis = 18m,
            bool activo = true)
        {
            return new Producto
            {
                ProductoId = id,
                Nombre = nombre,
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                CodigoBarras = codigoBarras ?? Guid.NewGuid().ToString().Substring(0, 8),
                Stock = stock,
                TasaItbis = tasaItbis,
                Activo = activo,
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now
            };
        }
    }
}
