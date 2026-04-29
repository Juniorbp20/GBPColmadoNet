using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class AbonoService(ColmadoContext context
    ) : IService<Abono, int>
    {
        public async Task<Abono?> Buscar(int id)
        {
            return await context.Abonos
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.AbonoId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var abono = await context
                .Abonos
                .FindAsync(id);

            if (abono == null)
                return false;

            context.Abonos.Remove(abono);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Abono>> GetList(Expression<Func<Abono, bool>> criterio)
        {
            return await context.Abonos
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<bool> Guardar(Abono entidad)
        {
            if (!await Existe(entidad.AbonoId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Abono entidad)
        {
            context.Abonos.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Abonos.AnyAsync(a => a.AbonoId == id);
        }

        public async Task<bool> Modificar(Data.Models.Abono entidad)
        {
            context.Abonos.Update(entidad);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
