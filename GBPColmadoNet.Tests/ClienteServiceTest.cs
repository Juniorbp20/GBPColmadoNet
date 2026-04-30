using System;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.Tests
{
    public class ClienteServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoClienteNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new ClienteService(context);
            var nuevoCliente = CreateCliente(id: 100, nombre: "Juan", apellido: "Perez");

            // Act
            var result = await service.Guardar(nuevoCliente);

            // Assert
            Assert.True(result);

            var saved = await context.Clientes.FirstOrDefaultAsync(c => c.ClienteId == 100);
            Assert.NotNull(saved);
            Assert.Equal("Juan", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoClienteExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Clientes.Add(CreateCliente(id: 200, nombre: "Maria", apellido: "Gomez"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ClienteService(context);

            var updated = CreateCliente(id: 200, nombre: "Maria Alejandra", apellido: "Gomez");

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);

            var saved = await context.Clientes.FirstOrDefaultAsync(c => c.ClienteId == 200);
            Assert.NotNull(saved);
            Assert.Equal("Maria Alejandra", saved!.Nombre);
        }

        private static Cliente CreateCliente(
            int id,
            string nombre,
            string apellido)
        {
            return new Cliente
            {
                ClienteId = id,
                Nombre = nombre,
                FechaRegistro = DateTime.Now
            };
        }
    }
}
