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
    public class BitacoraServiceTest
    {
        [Fact]
        public async Task Buscar_CuandoExisteEntrada_RetornaEntidad()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Bitacoras.Add(CreateBitacora(id: 1, accion: "Login", modulo: "Seguridad"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new BitacoraService(context);

            // Act
            var result = await service.Buscar(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.Id);
            Assert.Equal("Login", result.Accion);
            Assert.Empty(context.ChangeTracker.Entries());
        }

        [Fact]
        public async Task Buscar_CuandoNoExisteEntrada_RetornaNull()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new BitacoraService(context);

            // Act
            var result = await service.Buscar(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetList_CuandoSeFiltraPorModulo_RetornaCoincidencias()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Bitacoras.AddRange(
                    CreateBitacora(id: 1, accion: "Venta Realizada", modulo: "Ventas"),
                    CreateBitacora(id: 2, accion: "Producto Agregado", modulo: "Inventario"),
                    CreateBitacora(id: 3, accion: "Reporte Generado", modulo: "Ventas")
                );
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new BitacoraService(context);

            // Act
            var result = await service.GetList(b => b.Modulo == "Ventas"); // Variable real: Modulo

            // Assert
            Assert.Equal(2, result.Count);
            Assert.All(result, b => Assert.Equal("Ventas", b.Modulo));
        }

        [Fact]
        public async Task Guardar_CuandoEntradaEsNueva_InsertaYRetornaTrue()
        {
            // Arrange
            await using var context = TestDbContextFactory.CreateContext(TestDbContextFactory.NewDataBaseName());
            var service = new BitacoraService(context);
            var nuevaEntrada = CreateBitacora(id: 10, accion: "Eliminación", modulo: "Clientes", descripcion: "Se eliminó el cliente ID 5");

            // Act
            var result = await service.Guardar(nuevaEntrada);

            // Assert
            Assert.True(result);
            var saved = await context.Bitacoras.FirstOrDefaultAsync(b => b.Id == 10);
            Assert.NotNull(saved);
            Assert.Equal("Eliminación", saved!.Accion);
        }

        [Fact]
        public async Task Existe_CuandoEntradaExiste_RetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Bitacoras.Add(CreateBitacora(id: 5, accion: "Consulta", modulo: "Reportes"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new BitacoraService(context);

            // Act
            var exists = await service.Existe(5);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteEntrada_LoBorraYRetornaTrue()
        {
            // Arrange
            var dbName = TestDbContextFactory.NewDataBaseName();
            await using (var seedContext = TestDbContextFactory.CreateContext(dbName))
            {
                seedContext.Bitacoras.Add(CreateBitacora(id: 100, accion: "Temporal", modulo: "Test"));
                await seedContext.SaveChangesAsync();
            }

            await using var context = TestDbContextFactory.CreateContext(dbName);
            var service = new BitacoraService(context);

            // Act
            var result = await service.Eliminar(100);

            // Assert
            Assert.True(result);
            var eliminado = await context.Bitacoras.FindAsync(100);
            Assert.Null(eliminado);
        }

        private static Bitacora CreateBitacora(int id, string accion, string modulo, string descripcion = "Descripción de prueba")
        {
            return new Bitacora
            {
                Id = id,
                Accion = accion,
                Modulo = modulo,
                Descripcion = descripcion,
                UsuarioId = 1,
                Fecha = DateTime.Now,
            };
        }
    }
}