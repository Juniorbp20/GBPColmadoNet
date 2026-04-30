using System;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.Tests
{
    public class ProveedorServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoProveedorNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new ProveedorService(context);
            var nuevoProveedor = CreateProveedor(id: 15, nombre: "Embutidos Sosua");

            // Act
            var result = await service.Guardar(nuevoProveedor);

            // Assert
            Assert.True(result);

            var saved = await context.Proveedores.FirstOrDefaultAsync(p => p.ProveedorId == 15);
            Assert.NotNull(saved);
            Assert.Equal("Embutidos Sosua", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoProveedorExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Proveedores.Add(CreateProveedor(id: 25, nombre: "Coca Cola Co."));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ProveedorService(context);

            var updated = CreateProveedor(id: 25, nombre: "Bepensa Dominicana");

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);

            var saved = await context.Proveedores.FirstOrDefaultAsync(p => p.ProveedorId == 25);
            Assert.NotNull(saved);
            Assert.Equal("Bepensa Dominicana", saved!.Nombre);
        }

        private static Proveedore CreateProveedor(
            int id,
            string nombre)
        {
            return new Proveedore
            {
                ProveedorId = id,
                Nombre = nombre,
                FechaRegistro = DateTime.Now
            };
        }
    }
}
