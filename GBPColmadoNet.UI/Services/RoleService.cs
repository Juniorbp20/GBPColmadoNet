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
    public class RoleService(ColmadoContext context
        ) : IService<Role, int>
    {
        public async Task<bool> Guardar(Role entidad)
        {
            if (!await Existe(entidad.RolId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Role entidad)
        {
            context.Roles.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Roles.AnyAsync(a => a.RolId == id);
        }

        public async Task<bool> Modificar(Data.Models.Role entidad)
        {
            context.Roles.Update(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<Role?> Buscar(int id)
        {
            return await context.Roles
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.RolId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var role = await context
                .Roles
                .FindAsync(id);

            if (role == null)
                return false;

            context.Roles.Remove(role);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Role>> GetList(Expression<Func<Role, bool>> criterio)
        {
            return await context.Roles
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
