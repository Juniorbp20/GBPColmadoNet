using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;

namespace GBPColmadoNet.Tests
{
    public class CarritoItemServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExiste_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Set<CarritoItem>().Add(CreateCarritoItem(id: 1, nombre: "Item de prueba", cantidad: 2));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CarritoItemService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.Id);
            Assert.Equal("Item de prueba", result.Nombre);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExiste_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new CarritoItemService(context);

            // Act
            var result = await service.Buscar(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltra_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Set<CarritoItem>().AddRange(
                    CreateCarritoItem(id: 1, usuarioId: 1, nombre: "Producto A"),
                    CreateCarritoItem(id: 2, usuarioId: 1, nombre: "Producto B"),
                    CreateCarritoItem(id: 3, usuarioId: 2, nombre: "Producto C")
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CarritoItemService(context);

            // Act
            var result = await service.GetList(c => c.UsuarioId == 1);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, c => c.Id == 1);
            Assert.Contains(result, c => c.Id == 2);
        }

        [Fact]
        public async Task Guardar_CuandoNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new CarritoItemService(context);
            var nuevoItem = CreateCarritoItem(id: 30, nombre: "Item Nuevo", cantidad: 5);

            // Act
            var result = await service.Guardar(nuevoItem);

            // Assert
            Assert.True(result);

            var saved = await context.Set<CarritoItem>().FirstOrDefaultAsync(c => c.Id == 30);
            Assert.NotNull(saved);
            Assert.Equal("Item Nuevo", saved!.Nombre);
            Assert.Equal(5, saved.Cantidad);
        }

        [Fact]
        public async Task Guardar_CuandoExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Set<CarritoItem>().Add(CreateCarritoItem(id: 40, nombre: "Item Original", cantidad: 1));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CarritoItemService(context);

            var updated = CreateCarritoItem(id: 40, nombre: "Item Original", cantidad: 3);

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);

            var saved = await context.Set<CarritoItem>().FirstOrDefaultAsync(c => c.Id == 40);
            Assert.NotNull(saved);
            Assert.Equal(3, saved!.Cantidad);
        }

        [Fact]
        public async Task Existe_CuandoExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Set<CarritoItem>().Add(CreateCarritoItem(id: 50));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CarritoItemService(context);

            // Act
            var result = await service.Existe(50);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Eliminar_CuandoExiste_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Set<CarritoItem>().Add(CreateCarritoItem(id: 80));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CarritoItemService(context);

            // Act
            var result = await service.Eliminar(80);

            // Assert
            Assert.True(result);
            var eliminado = await context.Set<CarritoItem>().FindAsync(80);
            Assert.Null(eliminado);
        }

        [Fact]
        public async Task VaciarCarrito_CuandoLlamado_EliminaSoloLosDelUsuarioYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Set<CarritoItem>().AddRange(
                    CreateCarritoItem(id: 1, usuarioId: 10),
                    CreateCarritoItem(id: 2, usuarioId: 10),
                    CreateCarritoItem(id: 3, usuarioId: 20)
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CarritoItemService(context);

            // Act
            var result = await service.VaciarCarrito(10);

            // Assert
            Assert.True(result);
            var quedan = await context.Set<CarritoItem>().ToListAsync();
            Assert.Single(quedan);
            Assert.Equal(3, quedan.First().Id);
        }

        private static CarritoItem CreateCarritoItem(
            int id,
            int? usuarioId = null,
            int productoId = 1,
            string codigo = "123",
            string nombre = "Generico",
            decimal cantidad = 1m,
            decimal precioUnitario = 10m,
            decimal tasaItbis = 18m)
        {
            return new CarritoItem
            {
                Id = id,
                UsuarioId = usuarioId,
                ProductoId = productoId,
                Codigo = codigo,
                Nombre = nombre,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario,
                TasaItbis = tasaItbis
            };
        }
    }
}
