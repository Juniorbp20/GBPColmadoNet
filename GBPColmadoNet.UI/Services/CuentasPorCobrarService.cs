using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class CuentasPorCobrarService(ColmadoContext context
    ) : IService<CuentasPorCobrar, int>
    {
        public async Task<bool> Guardar(CuentasPorCobrar entidad)
        {
            if (!await Existe((decimal)entidad.BalancePendiente!))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(CuentasPorCobrar entidad)
        {
            context.CuentasPorCobrars.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(Decimal id)
        {
            return await context.CuentasPorCobrars.AnyAsync(a => a.BalancePendiente == id);
        }

        public async Task<bool> Modificar(Data.Models.CuentasPorCobrar entidad)
        {
            context.CuentasPorCobrars.Update(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<CuentasPorCobrar?> Buscar(int id)
        {
            return await context.CuentasPorCobrars
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.BalancePendiente == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var cuentasPorCobrar = await context
                .CuentasPorCobrars
                .FindAsync(id);

            if (cuentasPorCobrar == null)
                return false;

            context.CuentasPorCobrars.Remove(cuentasPorCobrar);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0; ;
        }

        public async Task<List<CuentasPorCobrar>> GetList(Expression<Func<CuentasPorCobrar, bool>> criterio)
        {
            return await context.CuentasPorCobrars
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
