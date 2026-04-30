using System;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.Tests
{
    public class CategoriaServiceTest
    {
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

        private static Categoria CreateCategoria(
            int id,
            string nombre)
        {
            return new Categoria
            {
                CategoriaId = id,
                Nombre = nombre
            };
        }
    }
}
