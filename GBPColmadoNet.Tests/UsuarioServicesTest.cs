using System;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.Tests
{
    public class UsuarioServicesTest
    {
        [Fact]
        public async Task Guardar_CuandoUsuarioNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new UsuarioServices(context);
            var nuevoUsuario = CreateUsuario(id: 10, username: "admin_sys");

            // Act
            var result = await service.Guardar(nuevoUsuario);

            // Assert
            Assert.True(result);

            var saved = await context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == 10);
            Assert.NotNull(saved);
            Assert.Equal("admin_sys", saved!.Username);
        }

        [Fact]
        public async Task Guardar_CuandoUsuarioExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();

            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Usuarios.Add(CreateUsuario(id: 20, username: "caja_1"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new UsuarioServices(context);

            var updated = CreateUsuario(id: 20, username: "caja_principal");

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);

            var saved = await context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == 20);
            Assert.NotNull(saved);
            Assert.Equal("caja_principal", saved!.Username);
        }

        public async Task Buscar_CuandoExisteUsuario_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Usuarios.Add(CreateUsuario(id: 1, username: "bonifacio_dev"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new UsuarioServices(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.UsuarioId);
            Assert.Equal("bonifacio_dev", result.Username);
            // Verificamos que no se esté rastreando la entidad (AsNoTracking)
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteUsuario_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new UsuarioServices(context);

            // Act
            var result = await service.Buscar(99);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorRol_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Usuarios.AddRange(
                    CreateUsuario(id: 1, username: "admin", rol: "Admin"),
                    CreateUsuario(id: 2, username: "cajero1", rol: "Cajero"),
                    CreateUsuario(id: 3, username: "cajero2", rol: "Cajero")
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new UsuarioServices(context);

            // Act
            var result = await service.GetList(u => u.Rol == "Cajero");

            // Assert
            Assert.Equal(2, result.Count);
            Assert.All(result, u => Assert.Equal("Cajero", u.Rol));
        }

        [Fact]
        public async Task Eliminar_CuandoExisteUsuario_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Usuarios.Add(CreateUsuario(id: 1, username: "usuario_a_eliminar"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new UsuarioServices(context);

            // Act
            var result = await service.Eliminar(1);

            // Assert
            Assert.True(result);
            var eliminado = await context.Usuarios.FindAsync(1);
            Assert.Null(eliminado);
        }

        private static Usuario CreateUsuario(
            int id,
            string username,
            string rol = "Admin")
        {
            return new Usuario
            {
                UsuarioId = id,
                Username = username,
                PasswordHash = "12345",
                Rol = rol,
                FechaRegistro = DateTime.Now
            };
        }
    }
}
