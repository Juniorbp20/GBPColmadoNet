using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class Compra
{
    public int CompraId { get; set; }

    public DateTime? Fecha { get; set; }

    public int ProveedorId { get; set; }

    public int UsuarioId { get; set; }

    public decimal TotalNeto { get; set; }

    public decimal TotalItbis { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<ComprasDetalle> ComprasDetalles { get; set; } = new List<ComprasDetalle>();

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
