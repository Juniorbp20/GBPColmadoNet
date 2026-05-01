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
    public class CuentasPorCobrarServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExisteCuenta_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CuentasPorCobrars.Add(CreateCuenta(id: 1, balance: 500.25m, montoDeuda: 1000m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CuentasPorCobrarService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.Id);
            Assert.Equal(500.25m, result.BalancePendiente);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteCuenta_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new CuentasPorCobrarService(context);

            // Act
            var result = await service.Buscar(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorBalancePendiente_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CuentasPorCobrars.AddRange(
                    CreateCuenta(id: 1, balance: 0m),
                    CreateCuenta(id: 2, balance: 1500m),
                    CreateCuenta(id: 3, balance: 200m)
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CuentasPorCobrarService(context);

            // Act
            var result = await service.GetList(c => c.BalancePendiente > 0);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, c => c.Id == 2);
            Assert.Contains(result, c => c.Id == 3);
        }

        [Fact]
        public async Task Guardar_CuandoCuentaNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new CuentasPorCobrarService(context);
            var nuevaCuenta = CreateCuenta(id: 10, balance: 2500m);

            // Act
            var result = await service.Guardar(nuevaCuenta);

            // Assert
            Assert.True(result);
            var saved = await context.CuentasPorCobrars.FirstOrDefaultAsync(c => c.Id == 10);
            Assert.NotNull(saved);
            Assert.Equal(2500m, saved!.BalancePendiente);
        }

        [Fact]
        public async Task Guardar_CuandoCuentaExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CuentasPorCobrars.Add(CreateCuenta(id: 20, balance: 1000m, montoDeuda: 1000m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CuentasPorCobrarService(context);
            var updated = CreateCuenta(id: 20, balance: 800m, montoDeuda: 1000m);

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);
            var saved = await context.CuentasPorCobrars.FirstOrDefaultAsync(
                c => c.Id == 20);
            Assert.NotNull(saved);
            Assert.Equal(800m, saved!.BalancePendiente);
            Assert.Equal(200m, saved.MontoAbonado);
        }

        [Fact]
        public async Task Existe_CuandoCuentaExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CuentasPorCobrars.Add(CreateCuenta(id: 5, balance: 100m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CuentasPorCobrarService(context);

            // Act
            var exists = await service.Existe(5);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteCuenta_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CuentasPorCobrars.Add(CreateCuenta(id: 30, balance: 0m, montoDeuda: 500m));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CuentasPorCobrarService(context);

            // Act
            var result = await service.Eliminar(30);

            // Assert
            Assert.True(result);
            var eliminado = await context.CuentasPorCobrars.FindAsync(30);
            Assert.Null(eliminado);
        }

        private static CuentasPorCobrar CreateCuenta(int id, decimal balance, decimal montoDeuda = 1000m)
        {
            return new CuentasPorCobrar()
            {
                Id = id,
                ClienteId = 1,
                BalancePendiente = balance,
                MontoDeuda = montoDeuda,
                MontoAbonado = montoDeuda - balance,
                FechaRegistro = DateTime.Now,
                Estado = balance > 0 ? "Pendiente" : "Saldado"
            };
        }
    }
}