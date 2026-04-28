using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class ProductoService(ColmadoContext context)
    : IService<Producto, int>
    {
        public async Task<bool> Guardar(Producto entidad)
        {
            if (!await Existe(entidad.ProductoId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Producto entidad)
        {
            context.Productos.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public Task<Producto?> Buscar(int id)
        {
            return context.Productos
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.ProductoId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var producto = await context
                .Productos
                .FindAsync(id);

            if (producto == null)
                return false;

            context.Productos.Remove(producto);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Producto>> GetList(Expression<Func<Producto, bool>> criterio)
        {
            return await context.Productos
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Productos.AnyAsync(a => a.ProductoId == id);
        }

        public async Task<bool> Modificar(Data.Models.Producto entiad)
        {
            context.Productos.Update(entiad);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
