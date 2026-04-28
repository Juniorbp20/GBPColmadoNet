using System.Collections.Immutable;
using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class ProveedorService(ColmadoContext context
    ) : IService<Proveedore, int>
    {
        public async Task<bool> Guardar(Proveedore entidad)
        {
            if (!await Existe(entidad.ProveedorId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Proveedore entidad)
        {
            context.Proveedores.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Proveedores.AnyAsync(a => a.ProveedorId == id);
        }

        public async Task<bool> Modificar(Data.Models.Proveedore entiad)
        {
            context.Proveedores.Update(entiad);
            return await context.SaveChangesAsync() > 0;
        }

        public Task<Proveedore?> Buscar(int id)
        {
            return context.Proveedores
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.ProveedorId == id)
        }

        public async Task<bool> Eliminar(int id)
        {
            var proveedores = await context
                .Proveedores
                .FindAsync(id);

            if (proveedores == null)
                return false;

            context.Proveedores.Remove(proveedores);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Proveedore>> GetList(Expression<Func<Proveedore, bool>> criterio)
        {
            return await context.Proveedores
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
