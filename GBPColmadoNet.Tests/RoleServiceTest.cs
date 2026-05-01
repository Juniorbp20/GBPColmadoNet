using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.Tests
{
    public class RoleServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExisteRole_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Roles.Add(CreateRole(id: 1, nombre: "Administrador"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RoleService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.RolId);
            Assert.Equal("Administrador", result.Nombre);
            // Verificamos que se use AsNoTracking para optimizar el rendimiento
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteRole_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new RoleService(context);

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
                seedContext.Roles.AddRange(
                    CreateRole(id: 1, nombre: "Admin"),
                    CreateRole(id: 2, nombre: "Cajero"),
                    CreateRole(id: 3, nombre: "Supervisor")
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RoleService(context);

            // Act
            var result = await service.GetList(r => r.Nombre.ToLower().Contains("a"));

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, r => r.RolId == 1);
            Assert.Contains(result, r => r.RolId == 2);
        }

        [Fact]
        public async Task Guardar_CuandoRoleNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new RoleService(context);
            var nuevoRole = CreateRole(id: 10, nombre: "Cajero de Noche");

            // Act
            var result = await service.Guardar(nuevoRole);

            // Assert
            Assert.True(result);
            var saved = await context.Roles.FirstOrDefaultAsync(r => r.RolId == 10);
            Assert.NotNull(saved);
            Assert.Equal("Cajero de Noche", saved!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoRoleExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Roles.Add(CreateRole(id: 20, nombre: "Vendedor"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RoleService(context);
            var updated = CreateRole(id: 20, nombre: "Vendedor Senior");

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);
            var saved = await context.Roles.FirstOrDefaultAsync(r => r.RolId == 20);
            Assert.NotNull(saved);
            Assert.Equal("Vendedor Senior", saved!.Nombre);
        }

        [Fact]
        public async Task Existe_CuandoRoleExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Roles.Add(CreateRole(id: 5, nombre: "Invitado"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RoleService(context);

            // Act
            var exists = await service.Existe(5);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteRole_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Roles.Add(CreateRole(id: 30, nombre: "Rol Temporal"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new RoleService(context);

            // Act
            var result = await service.Eliminar(30);

            // Assert
            Assert.True(result);
            var eliminado = await context.Roles.FindAsync(30);
            Assert.Null(eliminado);
        }

        private static Role CreateRole(int id, string nombre)
        {
            return new Role
            {
                RolId = id,
                Nombre = nombre,
            };
        }
    }
}