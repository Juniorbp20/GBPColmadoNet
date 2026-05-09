using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class ComprasService(ColmadoContext context
        ) : IService<Compra, int>
    {
        public async Task<bool> Guardar(Compra entidad)
        {
            if (!await Existe(entidad.CompraId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Compra entidad)
        {
            context.Compras.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Compras.AnyAsync(a => a.CompraId == id);
        }

        public async Task<bool> Modificar(Data.Models.Compra entiad)
        {
            context.Compras.Update(entiad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<Compra?> Buscar(int id)
        {
            return await context.Compras
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CompraId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var compra = await context
                .Compras
                .FindAsync(id);

            if (compra == null)
                return false;

            context.Compras.Remove(compra);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Compra>> GetList(Expression<Func<Compra, bool>> criterio)
        {
            return await context.Compras

                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<List<Compra>> GetListWithDetails(Expression<Func<Compra, bool>> criterio)
        {
            return await context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.ComprasDetalles)
                    .ThenInclude(cd => cd.Producto)
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
