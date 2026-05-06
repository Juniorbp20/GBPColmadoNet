using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.UI.Services
{
    public class CierreCajaService(ColmadoContext context
    ) : IService<CierresCaja, int>
    {
        public async Task<bool> Guardar(CierresCaja entidad)
        {
            if (!await Existe(entidad.CierreId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(CierresCaja entidad)
        {
            context.CierresCajas.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.CierresCajas.AnyAsync(a => a.CierreId == id);
        }

        public async Task<bool> Modificar(Data.Models.CierresCaja entidad)
        {
            context.CierresCajas.Update(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<CierresCaja?> Buscar(int id)
        {
            return await context.CierresCajas
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CierreId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var cierreCaja = await context
                .CierresCajas
                .FindAsync(id);

            if (cierreCaja == null)
                return false;

            context.CierresCajas.Remove(cierreCaja);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<CierresCaja>> GetList(Expression<Func<CierresCaja, bool>> criterio)
        {
            return await context.CierresCajas
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<CierresCaja?> ObtenerCajaAbiertaAsync(int usuarioId)
        {
            return await context.CierresCajas
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.UsuarioId == usuarioId && c.Estado == "Abierta");
        }

        public async Task<bool> CerrarCajaAsync(CierresCaja cierre)
        {
            cierre.Estado = "Cerrada";
            cierre.FechaCierre = DateTime.Now;
            context.CierresCajas.Update(cierre);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
