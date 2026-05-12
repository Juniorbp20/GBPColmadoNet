using System;

namespace GBPColmadoNet.Data.Models;

public class Permiso
{
    public int PermisoId { get; set; }

    public string Modulo { get; set; } = null!;

    public string Accion { get; set; } = null!;

    public bool Permite { get; set; }

    public int? RolId { get; set; }

    public virtual Role? Rol { get; set; }
}

public static class Modulos
{
    public const string Inventario = "Inventario";
    public const string Ventas = "Ventas";
    public const string Clientes = "Clientes";
    public const string Historial = "Historial";
    public const string Proveedores = "Proveedores";
    public const string Configuracion = "Configuracion";
    public const string Devoluciones = "Devoluciones";
    public const string Caja = "Caja";
}

public static class Acciones
{
    public const string Alta = "Alta";
    public const string Baja = "Baja";
    public const string Modificacion = "Modificacion";
    public const string Consulta = "Consulta";
    public const string Anulacion = "Anulacion";
}