using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.UI.Services
{
    public class BitacoraService(ColmadoContext context
        ) : IService<Bitacora, int>
    {
        public async Task<bool> Guardar(Bitacora entidad)
        {
            if (!await Existe(entidad.Id))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Bitacora entidad)
        {
            context.Bitacoras.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Bitacoras.AnyAsync(a => a.Id == id);
        }

        public async Task<bool> Modificar(Data.Models.Bitacora entidad)
        {
            context.Bitacoras.Update(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<Bitacora?> Buscar(int id)
        {
            return await context.Bitacoras
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var bitacora = await context
                .Bitacoras
                .FindAsync(id);

            if (bitacora == null)
                return false;

            context.Bitacoras.Remove(bitacora);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Bitacora>> GetList(Expression<Func<Bitacora, bool>> criterio)
        {
            return await context.Bitacoras
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
