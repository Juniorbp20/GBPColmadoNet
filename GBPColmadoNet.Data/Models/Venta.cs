using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class Venta
{
    public int VentaId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? UsuarioId { get; set; }

    public int? ClienteId { get; set; }

    public decimal TotalNeto { get; set; }

    public decimal TotalItbis { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<CuentasPorCobrar> CuentasPorCobrars { get; set; } = new List<CuentasPorCobrar>();

    public virtual Usuario? Usuario { get; set; }

    public virtual ICollection<VentasDetalle> VentasDetalles { get; set; } = new List<VentasDetalle>();
}
