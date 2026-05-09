using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class DevolucionService(ColmadoContext context) : IService<Devolucion, int>
    {
        public async Task<bool> Guardar(Devolucion entidad)
        {
            if (entidad.DevolucionId == 0)
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Devolucion entidad)
        {
            context.Devoluciones.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Devoluciones.AnyAsync(d => d.DevolucionId == id);
        }

        public async Task<bool> Modificar(Devolucion entidad)
        {
            context.Devoluciones.Update(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<Devolucion?> Buscar(int id)
        {
            return await context.Devoluciones
                .Include(d => d.Venta)
                    .ThenInclude(v => v!.VentasDetalles)
                        .ThenInclude(vd => vd.Producto)
                .Include(d => d.Usuario)
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.DevolucionId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var devolucion = await context.Devoluciones.FindAsync(id);
            if (devolucion == null)
                return false;

            context.Devoluciones.Remove(devolucion);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<List<Devolucion>> GetList(Expression<Func<Devolucion, bool>> criterio)
        {
            return await context.Devoluciones
                .Include(d => d.Venta)
                    .ThenInclude(v => v!.Cliente)
                .Include(d => d.Usuario)
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<List<Venta>> GetVentasDisponiblesAsync()
        {
            return await context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.VentasDetalles)
                    .ThenInclude(vd => vd.Producto)
                .OrderByDescending(v => v.Fecha)
                .Take(50)
                .ToListAsync();
        }

        public async Task<bool> ActualizarEstadoAsync(int id, string nuevoEstado)
        {
            var devolucion = await context.Devoluciones.FindAsync(id);
            if (devolucion == null)
                return false;

            devolucion.Estado = nuevoEstado;
            return await context.SaveChangesAsync() > 0;
        }
    }
}