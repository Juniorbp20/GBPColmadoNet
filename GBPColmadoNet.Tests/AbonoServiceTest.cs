using GBPColmadoNet.Data.Models;
using GBPColmadoNet.Tests.Infraestructura;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.Tests
{
    public class AbonoServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExisteAbono_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Abonos.Add(CreateAbono(id: 1, monto: 500m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new AbonoService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.AbonoId);
            Assert.Equal(500m, result.Monto);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteAbono_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new AbonoService(context);

            // Act
            var result = await service.Buscar(99);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorMonto_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Abonos.AddRange(
                    CreateAbono(id: 1, monto: 100m),
                    CreateAbono(id: 2, monto: 1000m),
                    CreateAbono(id: 3, monto: 2500m)
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new AbonoService(context);

            // Act
            var result = await service.GetList(a => a.Monto >= 1000m);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, a => a.AbonoId == 2);
            Assert.Contains(result, a => a.AbonoId == 3);
        }

        [Fact]
        public async Task Guardar_CuandoAbonoNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory
                .NewDataBaseName());
            var service = new AbonoService(context);
            var nuevoAbono = CreateAbono(id: 10, monto: 1500.50m);

            // Act
            var result = await service.Guardar(nuevoAbono);

            // Assert
            Assert.True(result);
            var saved = await context.Abonos.FirstOrDefaultAsync(a => a.AbonoId == 10);
            Assert.NotNull(saved);
            Assert.Equal(1500.50m, saved!.Monto);
        }

        [Fact]
        public async Task Guardar_CuandoAbonoExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Abonos.Add(CreateAbono(id: 20, monto: 200m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new AbonoService(context);
            var updated = CreateAbono(id: 20, monto: 250m);

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);
            var saved = await context.Abonos.FirstOrDefaultAsync(a => a.AbonoId == 20);
            Assert.NotNull(saved);
            Assert.Equal(250m, saved!.Monto);
        }

        [Fact]
        public async Task Existe_CuandoAbonoExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Abonos.Add(CreateAbono(id: 5, monto: 100m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new AbonoService(context);

            // Act
            var result = await service.Existe(5);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteAbono_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Abonos.Add(CreateAbono(id: 30, monto: 50m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new AbonoService(context);

            // Act
            var result = await service.Eliminar(30);

            // Assert
            Assert.True(result);
            var eliminado = await context.Abonos.FindAsync(30);
            Assert.Null(eliminado);
        }

        private static Abono CreateAbono(int id, decimal monto)
        {
            return new Abono
            {
                AbonoId = id,
                Monto = monto,
                CuentaPorCobrarId = 1,
                UsuarioId = 1,
                Fecha = DateTime.Now,
                FechaRegistro = DateTime.Now
            };
        }
    }
}