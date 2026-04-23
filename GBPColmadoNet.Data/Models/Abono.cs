using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class Abono
{
    public int AbonoId { get; set; }

    public int CuentaPorCobrarId { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal Monto { get; set; }

    public int UsuarioId { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual CuentasPorCobrar CuentaPorCobrar { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
