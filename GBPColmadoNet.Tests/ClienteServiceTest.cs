using System;
using System.Linq;
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
        public async Task Buscar_CuandoExisteCliente_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Clientes.Add(CreateCliente(id: 1, nombre: "Gustavo"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ClienteService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.ClienteId);
            Assert.Equal("Gustavo", result.Nombre);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteCliente_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new ClienteService(context);

            // Act
            var result = await service.Buscar(999);

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
                seedContext.Clientes.AddRange(
                    CreateCliente(id: 1, nombre: "Juan"),
                    CreateCliente(id: 2, nombre: "Juana"),
                    CreateCliente(id: 3, nombre: "Pedro")
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ClienteService(context);

            // Act
            var result = await service.GetList(c => c.Nombre.Contains("Juan"));

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, c => c.ClienteId == 1);
            Assert.Contains(result, c => c.ClienteId == 2);
        }

        [Fact]
        public async Task Guardar_CuandoClienteNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new ClienteService(context);
            var nuevoCliente = CreateCliente(id: 100, nombre: "Juan");

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
                seedContext.Clientes.Add(CreateCliente(id: 200, nombre: "Maria"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ClienteService(context);

            var updated = CreateCliente(id: 200, nombre: "Maria Alejandra");

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);

            var saved = await context.Clientes.FirstOrDefaultAsync(c => c.ClienteId == 200);
            Assert.NotNull(saved);
            Assert.Equal("Maria Alejandra", saved!.Nombre);
        }

        [Fact]
        public async Task Existe_CuandoClienteExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Clientes.Add(CreateCliente(id: 50, nombre: "Carlos"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ClienteService(context);

            // Act
            var result = await service.Existe(50);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteCliente_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Clientes.Add(CreateCliente(id: 80, nombre: "Ana"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new ClienteService(context);

            // Act
            var result = await service.Eliminar(80);

            // Assert
            Assert.True(result);
            var eliminado = await context.Clientes.FindAsync(80);
            Assert.Null(eliminado);
        }

        private static Cliente CreateCliente(int id, string nombre)
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