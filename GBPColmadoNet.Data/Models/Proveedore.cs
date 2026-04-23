using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class Proveedore
{
    public int ProveedorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Rnc { get; set; }

    public string? Telefono { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
