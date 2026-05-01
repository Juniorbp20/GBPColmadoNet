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
    public class CierreCajaServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExisteCierre_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CierresCajas.Add(CreateCierre(id: 1, montoInicial: 2000m, estado: "Abierto"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CierreCajaService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.CierreId);
            Assert.Equal(2000m, result.MontoInicial);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteCierre_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new CierreCajaService(context);

            // Act
            var result = await service.Buscar(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorEstado_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CierresCajas.AddRange(
                    CreateCierre(id: 1, estado: "Cerrado"),
                    CreateCierre(id: 2, estado: "Abierto"),
                    CreateCierre(id: 3, estado: "Cerrado")
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CierreCajaService(context);

            // Act
            var result = await service.GetList(c => c.Estado == "Cerrado"); // Variable real: Estado

            // Assert
            Assert.Equal(2, result.Count);
            Assert.All(result, c => Assert.Equal("Cerrado", c.Estado));
        }

        [Fact]
        public async Task Guardar_CuandoCierreNoExiste_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new CierreCajaService(context);
            var nuevoCierre = CreateCierre(id: 10, montoInicial: 5000m, esperado: 15000m);

            // Act
            var result = await service.Guardar(nuevoCierre);

            // Assert
            Assert.True(result);
            var saved = await context.CierresCajas.FirstOrDefaultAsync(c => c.CierreId == 10);
            Assert.NotNull(saved);
            Assert.Equal(5000m, saved!.MontoInicial);
            Assert.Equal(15000m, saved.MontoFinalEsperado);
        }

        [Fact]
        public async Task Guardar_CuandoCierreExiste_ModificaYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CierresCajas.Add(CreateCierre(id: 20, estado: "Abierto"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CierreCajaService(context);

            var updated = CreateCierre(id: 20, estado: "Cerrado");
            updated.FechaCierre = DateTime.Now;

            // Act
            var result = await service.Guardar(updated);

            // Assert
            Assert.True(result);
            var saved = await context.CierresCajas.FirstOrDefaultAsync(c => c.CierreId == 20);
            Assert.NotNull(saved);
            Assert.Equal("Cerrado", saved!.Estado);
            Assert.NotNull(saved.FechaCierre);
        }

        [Fact]
        public async Task Existe_CuandoCierreExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CierresCajas.Add(CreateCierre(id: 5, estado: "Abierto"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CierreCajaService(context);

            // Act
            var exists = await service.Existe(5);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteCierre_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.CierresCajas.Add(CreateCierre(id: 50, estado: "Abierto"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new CierreCajaService(context);

            // Act
            var result = await service.Eliminar(50);

            // Assert
            Assert.True(result);
            var eliminado = await context.CierresCajas.FindAsync(50);
            Assert.Null(eliminado);
        }

        private static CierresCaja CreateCierre(int id, string estado = "Abierto", decimal montoInicial = 1000m, decimal esperado = 1000m)
        {
            return new CierresCaja
            {
                CierreId = id,
                UsuarioId = 1,
                FechaApertura = DateTime.Now,
                MontoInicial = montoInicial,
                MontoFinalEsperado = esperado,
                Estado = estado
            };
        }
    }
}