using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class VentasService(ColmadoContext context
    ) : IService<Venta, int>
    {
        public async Task<bool> Guardar(Venta entidad)
        {
            if (!await Existe(entidad.VentaId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Venta entidad)
        {
            context.Ventas.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Ventas.AnyAsync(a => a.VentaId == id);
        }

        public async Task<bool> Modificar(Data.Models.Venta entiad)
        {
            context.Ventas.Update(entiad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<Venta?> Buscar(int id)
        {
            return await context.Ventas
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.VentaId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var venta = await context
                .Ventas
                .FindAsync(id);

            if (venta == null)
                return false;

            context.Ventas.Remove(venta);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Venta>> GetList(Expression<Func<Venta, bool>> criterio)
        {
            return await context.Ventas
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<List<Venta>> GetListWithDetails(Expression<Func<Venta, bool>> criterio)
        {
            return await context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.VentasDetalles)
                    .ThenInclude(vd => vd.Producto)
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
