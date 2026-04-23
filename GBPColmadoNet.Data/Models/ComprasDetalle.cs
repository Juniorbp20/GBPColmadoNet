using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class ComprasDetalle
{
    public int DetalleId { get; set; }

    public int CompraId { get; set; }

    public int ProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioCompra { get; set; }

    public virtual Compra Compra { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
