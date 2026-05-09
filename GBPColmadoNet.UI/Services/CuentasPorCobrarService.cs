using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class CuentasPorCobrarService(ColmadoContext context) : IService<CuentasPorCobrar, int>
    {
        public async Task<bool> Guardar(CuentasPorCobrar entidad)
        {
            if (!await Existe(entidad.Id))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(CuentasPorCobrar entidad)
        {
            context.CuentasPorCobrars.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.CuentasPorCobrars.AnyAsync(c => c.Id == id);
        }

        public async Task<bool> Modificar(CuentasPorCobrar entidad)
        {
            var local = context.CuentasPorCobrars.Local.FirstOrDefault(entry => entry.Id == entidad.Id);
            if (local != null)
                context.Entry(local).State = EntityState.Detached;

            context.Entry(entidad).State = EntityState.Modified;
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<CuentasPorCobrar?> Buscar(int id)
        {
            return await context.CuentasPorCobrars
                .Include(c => c.Cliente)
                .Include(c => c.Venta)
                .Include(c => c.Abonos)
                    .ThenInclude(a => a.Usuario)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var cuenta = await context.CuentasPorCobrars.FindAsync(id);
            if (cuenta == null)
                return false;

            context.CuentasPorCobrars.Remove(cuenta);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<List<CuentasPorCobrar>> GetList(Expression<Func<CuentasPorCobrar, bool>> criterio)
        {
            return await context.CuentasPorCobrars
                .Include(c => c.Cliente)
                .Include(c => c.Venta)
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            return await context.Clientes
                .Where(c => c.Activo == true)
                .OrderBy(c => c.Nombre)
                .ToListAsync();
        }

        public async Task<List<Venta>> GetVentasSinCuentaAsync()
        {
            var ventasConCuenta = await context.CuentasPorCobrars
                .Where(c => c.VentaId != null)
                .Select(c => c.VentaId)
                .ToListAsync();

            return await context.Ventas
                .Include(v => v.Cliente)
                .Where(v => !ventasConCuenta.Contains(v.VentaId))
                .OrderByDescending(v => v.Fecha)
                .ToListAsync();
        }

        public async Task<bool> RegistrarAbonoAsync(int cuentaId, decimal monto, int usuarioId)
        {
            var cuenta = await context.CuentasPorCobrars.FindAsync(cuentaId);
            if (cuenta == null)
                return false;

            var abono = new Abono
            {
                CuentaPorCobrarId = cuentaId,
                Monto = monto,
                Fecha = DateTime.Now,
                FechaRegistro = DateTime.Now,
                UsuarioId = usuarioId
            };

            context.Abonos.Add(abono);

            cuenta.MontoAbonado = (cuenta.MontoAbonado ?? 0) + monto;
            cuenta.BalancePendiente = cuenta.MontoDeuda - cuenta.MontoAbonado;

            if (cuenta.BalancePendiente <= 0)
            {
                cuenta.Estado = "Pagada";
                cuenta.BalancePendiente = 0;
            }

            return await context.SaveChangesAsync() > 0;
        }
    }
}