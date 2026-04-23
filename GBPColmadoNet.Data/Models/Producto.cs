using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string? CodigoBarras { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal PrecioCompra { get; set; }

    public decimal PrecioVenta { get; set; }

    public decimal? Stock { get; set; }

    public decimal? TasaItbis { get; set; }

    public int? CategoriaId { get; set; }

    public int? ProveedorId { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<ComprasDetalle> ComprasDetalles { get; set; } = new List<ComprasDetalle>();

    public virtual Proveedore? Proveedor { get; set; }

    public virtual ICollection<VentasDetalle> VentasDetalles { get; set; } = new List<VentasDetalle>();
}
