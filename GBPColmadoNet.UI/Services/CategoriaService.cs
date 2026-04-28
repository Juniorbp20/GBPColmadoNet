using Aplicada1.Core;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GBPColmadoNet.UI.Services
{
    public class CategoriaService(ColmadoContext context
    ) : IService<Categoria, int>
    {
        public async Task<Categoria?> Buscar(int id)
        {
            return await context.Categorias
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CategoriaId == id);
        }

        public async Task<bool> Eliminar(int id)
        {
            var categoria = await context
                .Categorias
                .FindAsync(id);

            if (categoria == null)
                return false;

            context.Categorias.Remove(categoria);
            var cantidad = await context.SaveChangesAsync();

            return cantidad > 0;
        }

        public async Task<List<Categoria>> GetList(Expression<Func<Categoria, bool>> criterio)
        {
            return await context.Categorias
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<bool> Guardar(Categoria entidad)
        {
            if (!await Existe(entidad.CategoriaId))
                return await Insertar(entidad);
            else
                return await Modificar(entidad);
        }

        private async Task<bool> Insertar(Categoria entidad)
        {
            context.Categorias.Add(entidad);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Productos.AnyAsync(a => a.ProductoId == id);
        }

        public async Task<bool> Modificar(Data.Models.Categoria entiad)
        {
            context.Categorias.Update(entiad);
            return await context.SaveChangesAsync() > 0;
        }

    }
}
