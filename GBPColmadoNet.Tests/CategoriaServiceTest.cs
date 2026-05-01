using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.Tests
{
    public class CategoriaServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExisteCategoria_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Categorias.Add(CreateCategoria(id: 1, nombre: "Provisiones"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CategoriaService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.CategoriaId);
            Assert.Equal("Provisiones", result.Nombre);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteCategoria_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new CategoriaService(context);

            // Act
            var result = await service.Buscar(99);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorNombre_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Categorias.AddRange(
                    CreateCategoria(id: 1, nombre: "Refrescos"),
                    CreateCategoria(id: 2, nombre: "Jugos Naturales"),
                    CreateCategoria(id: 3, nombre: "Embutidos")
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CategoriaService(context);

            // Act
            var result = await service.GetList(c => c.Nombre.Contains("Refrescos"));

            // Assert
            Assert.Single(result);
            Assert.Equal("Refrescos", result[0].Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoCategoriaNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new CategoriaService(context);
            var nuevaCategoria = CreateCategoria(id: 10, nombre: "Bebidas");

            // Act
            var result = await service.Guardar(nuevaCategoria);

            // Assert
            Assert.True(result);

            var saved = await context.Categorias.FirstOrDefaultAsync(c => c.CategoriaId == 10);
            Assert.NotNull(saved);
            Assert.Equal("Bebidas", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoCategoriaExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Categorias.Add(CreateCategoria(id: 30, nombre: "Lácteos"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CategoriaService(context);

            var updated = CreateCategoria(id: 30, nombre: "Lácteos y Derivados");

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);

            var saved = await context.Categorias.FirstOrDefaultAsync(c => c.CategoriaId == 30);
            Assert.NotNull(saved);
            Assert.Equal("Lácteos y Derivados", saved!.Nombre);
        }

        [Fact]
        public async Task Existe_CuandoCategoriaExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Categorias.Add(CreateCategoria(id: 5, nombre: "Golosinas"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CategoriaService(context);

            // Act
            var exists = await service.Existe(5);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteCategoria_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Categorias.Add(CreateCategoria(id: 15, nombre: "Categoría Temporal"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CategoriaService(context);

            // Act
            var result = await service.Eliminar(15);

            // Assert
            Assert.True(result);
            var eliminado = await context.Categorias.FindAsync(15);
            Assert.Null(eliminado);
        }

        private static Categoria CreateCategoria(int id, string nombre)
        {
            return new Categoria
            {
                CategoriaId = id,
                Nombre = nombre
            };
        }
    }
}