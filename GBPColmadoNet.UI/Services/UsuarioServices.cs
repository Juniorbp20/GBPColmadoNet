using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class UsuarioServices(ColmadoContext context
    ) : IService<Usuario, int>
    {
        public async Task<bool> Guardar(Usuario entidad)
        {
            if (!await Existe(entidad.UsuarioId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Usuario entidad)
        {
            context.Usuarios.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Usuarios.AnyAsync(a => a.UsuarioId == id);
        }

        public async Task<bool> Modificar(Data.Models.Usuario entiad)
        {
            context.Usuarios.Update(entiad);
            return await context.SaveChangesAsync() > 0;
        }
        
        public async Task<Usuario?> Buscar(int id)
        {
            return await context.Usuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.UsuarioId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var usuario = await context
                .Usuarios
                .FindAsync(id);

            if (usuario == null)
                return false;

            context.Usuarios.Remove(usuario);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Usuario>> GetList(Expression<Func<Usuario, bool>> criterio)
        {
            return await context.Usuarios
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
