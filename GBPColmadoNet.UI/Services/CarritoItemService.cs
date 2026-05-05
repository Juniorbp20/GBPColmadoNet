using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class CarritoItemService(ColmadoContext context)
    : IService<CarritoItem, int>
    {
        public async Task<bool> Guardar(CarritoItem entidad)
        {
            if (!await Existe(entidad.Id))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(CarritoItem entidad)
        {
            context.Set<CarritoItem>().Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public Task<CarritoItem?> Buscar(int id)
        {
            return context.Set<CarritoItem>()
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var item = await context.Set<CarritoItem>().FindAsync(id);

            if (item == null)
                return false;

            context.Set<CarritoItem>().Remove(item);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<CarritoItem>> GetList(Expression<Func<CarritoItem, bool>> criterio)
        {
            return await context.Set<CarritoItem>()
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Set<CarritoItem>().AnyAsync(a => a.Id == id);
        }

        public async Task<bool> Modificar(CarritoItem entidad)
        {
            var tracked = context.Set<CarritoItem>().Local.FirstOrDefault(e => e.Id == entidad.Id);
            if (tracked != null)
            {
                context.Entry(tracked).State = EntityState.Detached;
            }

            context.Set<CarritoItem>().Update(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> VaciarCarrito(int? usuarioId)
        {
            var items = await context.Set<CarritoItem>().Where(c => c.UsuarioId == usuarioId).ToListAsync();
            if (items.Any())
            {
                context.Set<CarritoItem>().RemoveRange(items);
                return await context.SaveChangesAsync() > 0;
            }
            return true;
        }
    }
}
