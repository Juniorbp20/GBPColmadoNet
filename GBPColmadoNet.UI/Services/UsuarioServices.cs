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

        public async Task<bool> Modificar(Data.Models.Usuario entidad)
        {
            context.Usuarios.Update(entidad);
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

        public async Task<Usuario?> AutenticarAsync(string username, string password)
        {
            var usuario = await context.Usuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == username && u.Activo != false);

            if (usuario == null)
                return null;

            bool validPassword = false;
            try
            {
                validPassword = BCrypt.Net.BCrypt.Verify(password, usuario.PasswordHash);
            }
            catch (BCrypt.Net.SaltParseException)
            {
                // Fallback temporal por si hay contraseñas en texto plano en la base de datos
                if (password == usuario.PasswordHash)
                {
                    validPassword = true;
                }
            }

            if (validPassword)
                return usuario;

            return null;
        }
    }
}
