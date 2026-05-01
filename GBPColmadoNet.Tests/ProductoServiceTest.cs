using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.Tests
{
    public class ProductoServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExisteProducto_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Productos.Add(CreateProducto(id: 1, nombre: "Aceite Vegetal", precioCompra: 150m, precioVenta: 180m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ProductoService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.ProductoId);
            Assert.Equal("Aceite Vegetal", result.Nombre);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteProducto_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new ProductoService(context);

            // Act
            var result = await service.Buscar(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorStock_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Productos.AddRange(
                    CreateProducto(id: 1, nombre: "Sal Refinada", stock: 10m),
                    CreateProducto(id: 2, nombre: "Azúcar Crema", stock: 5m),
                    CreateProducto(id: 3, nombre: "Harina de Trigo", stock: 2m)
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ProductoService(context);

            // Act
            var result = await service.GetList(p => p.Stock <= 5m);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, p => p.ProductoId == 2);
            Assert.Contains(result, p => p.ProductoId == 3);
        }

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

        [Fact]
        public async Task Existe_CuandoProductoExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Productos.Add(CreateProducto(id: 50, nombre: "Café Santo Domingo"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ProductoService(context);

            // Act
            var result = await service.Existe(50);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteProducto_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Productos.Add(CreateProducto(id: 80, nombre: "Salami Especial"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ProductoService(context);

            // Act
            var result = await service.Eliminar(80);

            // Assert
            Assert.True(result);
            var eliminado = await context.Productos.FindAsync(80);
            Assert.Null(eliminado);
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