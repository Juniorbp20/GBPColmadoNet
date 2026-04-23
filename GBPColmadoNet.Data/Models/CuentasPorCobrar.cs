using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class CuentasPorCobrar
{
    public int Id { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int ClienteId { get; set; }

    public int? VentaId { get; set; }

    public decimal MontoDeuda { get; set; }

    public decimal? MontoAbonado { get; set; }

    public string? Estado { get; set; }

    public int? DiasCredito { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public decimal? BalancePendiente { get; set; }

    public virtual ICollection<Abono> Abonos { get; set; } = new List<Abono>();

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Venta? Venta { get; set; }
}
