using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.UI.Services;

public interface IService<T, TKey> where T : class
{
    Task<bool> Guardar(T entidad);
    Task<T?> Buscar(TKey id);
    Task<List<T>> GetList(Expression<Func<T, bool>> criterio);
    Task<bool> Eliminar(TKey id);
}

public class PermisoService
{
    private readonly ColmadoContext _context;

    public PermisoService(ColmadoContext context)
    {
        _context = context;
    }

    public async Task<bool> TienePermiso(string rolNombre, string modulo, string accion)
    {
        var rol = await _context.Roles
            .Include(r => r.Permisos)
            .FirstOrDefaultAsync(r => r.Nombre == rolNombre);

        if (rol == null) return false;

        var permiso = rol.Permisos.FirstOrDefault(p => p.Modulo == modulo && p.Accion == accion);
        return permiso?.Permite ?? false;
    }

    public async Task<List<Permiso>> GetPermisosPorRol(string rolNombre)
    {
        var rol = await _context.Roles
            .Include(r => r.Permisos)
            .FirstOrDefaultAsync(r => r.Nombre == rolNombre);

        return rol?.Permisos.ToList() ?? new List<Permiso>();
    }

    public async Task<bool> AsignarPermisos(int rolId, List<Permiso> permisos)
    {
        var existentes = await _context.Permisos.Where(p => p.RolId == rolId).ToListAsync();
        _context.Permisos.RemoveRange(existentes);

        foreach (var permiso in permisos)
        {
            permiso.PermisoId = 0;
            permiso.RolId = rolId;
            _context.Permisos.Add(permiso);
        }

        return await _context.SaveChangesAsync() > 0;
    }

    public async Task InicializarPermisos()
    {
        var tieneAdmin = await _context.Roles.AnyAsync(r => r.Nombre == "Admin");
        if (!tieneAdmin)
        {
            _context.Roles.Add(new Role { Nombre = "Admin" });
        }

        var tieneAlmacen = await _context.Roles.AnyAsync(r => r.Nombre == "Almacen");
        if (!tieneAlmacen)
        {
            _context.Roles.Add(new Role { Nombre = "Almacen" });
        }

        var tieneCajero = await _context.Roles.AnyAsync(r => r.Nombre == "Cajero");
        if (!tieneCajero)
        {
            _context.Roles.Add(new Role { Nombre = "Cajero" });
        }

        await _context.SaveChangesAsync();

        var roles = await _context.Roles.Include(r => r.Permisos).ToListAsync();

        foreach (var rol in roles)
        {
            if (rol.Permisos.Any()) continue;

            var permisos = GenerarPermisosPorRol(rol.Nombre);
            foreach (var p in permisos)
            {
                p.RolId = rol.RolId;
                _context.Permisos.Add(p);
            }
        }

        await _context.SaveChangesAsync();
    }

    private List<Permiso> GenerarPermisosPorRol(string rolNombre)
    {
        var permisos = new List<Permiso>();

        switch (rolNombre)
        {
            case "Admin":
                permisos.AddRange(new[]
                {
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Baja, Permite = true },
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Modificacion, Permite = true },
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Ventas, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Ventas, Accion = Acciones.Anulacion, Permite = true },
                    new Permiso { Modulo = Modulos.Ventas, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Clientes, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Clientes, Accion = Acciones.Modificacion, Permite = true },
                    new Permiso { Modulo = Modulos.Clientes, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Historial, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Proveedores, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Proveedores, Accion = Acciones.Modificacion, Permite = true },
                    new Permiso { Modulo = Modulos.Proveedores, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Configuracion, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Configuracion, Accion = Acciones.Modificacion, Permite = true },
                    new Permiso { Modulo = Modulos.Configuracion, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Devoluciones, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Devoluciones, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Caja, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Caja, Accion = Acciones.Modificacion, Permite = true },
                    new Permiso { Modulo = Modulos.Caja, Accion = Acciones.Consulta, Permite = true },
                });
                break;

            case "Almacen":
                permisos.AddRange(new[]
                {
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Baja, Permite = true },
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Modificacion, Permite = true },
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Ventas, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Clientes, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Historial, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Proveedores, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Proveedores, Accion = Acciones.Modificacion, Permite = true },
                    new Permiso { Modulo = Modulos.Proveedores, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Devoluciones, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Devoluciones, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Caja, Accion = Acciones.Consulta, Permite = true },
                });
                break;

            case "Cajero":
                permisos.AddRange(new[]
                {
                    new Permiso { Modulo = Modulos.Inventario, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Ventas, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Ventas, Accion = Acciones.Anulacion, Permite = true },
                    new Permiso { Modulo = Modulos.Ventas, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Clientes, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Clientes, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Historial, Accion = Acciones.Consulta, Permite = true },
                    new Permiso { Modulo = Modulos.Caja, Accion = Acciones.Alta, Permite = true },
                    new Permiso { Modulo = Modulos.Caja, Accion = Acciones.Modificacion, Permite = true },
                    new Permiso { Modulo = Modulos.Caja, Accion = Acciones.Consulta, Permite = true },
                });
                break;
        }

        return permisos;
    }
}