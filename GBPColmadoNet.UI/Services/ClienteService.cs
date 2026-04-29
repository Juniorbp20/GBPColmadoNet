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
    public class ClienteService(ColmadoContext context
    ) : IService<Cliente, int>
    {
        public async Task<bool> Guardar(Cliente entidad)
        {
            if (!await Existe(entidad.ClienteId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Cliente entidad)
        {
            context.Clientes.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Clientes.AnyAsync(a => a.ClienteId == id);
        }

        public async Task<bool> Modificar(Data.Models.Cliente entiad)
        {
            context.Clientes.Update(entiad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<Cliente?> Buscar(int id)
        {
            return await context.Clientes
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.ClienteId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var cliente = await context
                .Clientes
                .FindAsync(id);

            if (cliente == null)
                return false;

            context.Clientes.Remove(cliente);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Cliente>> GetList(Expression<Func<Cliente, bool>> criterio)
        {
            return await context.Clientes
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
