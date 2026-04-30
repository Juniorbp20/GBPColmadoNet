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

        private static Usuario CreateUsuario(
            int id,
            string username)
        {
            return new Usuario
            {
                UsuarioId = id,
                Username = username,
                PasswordHash = "12345",
                Rol = "Admin",
                FechaRegistro = DateTime.Now
            };
        }
    }
}
