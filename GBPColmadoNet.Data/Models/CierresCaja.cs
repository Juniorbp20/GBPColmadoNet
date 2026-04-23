using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class CierresCaja
{
    public int CierreId { get; set; }

    public int UsuarioId { get; set; }

    public DateTime FechaApertura { get; set; }

    public DateTime? FechaCierre { get; set; }

    public decimal MontoInicial { get; set; }

    public decimal? VentasEfectivo { get; set; }

    public decimal? VentasCredito { get; set; }

    public decimal? AbonosRecibidos { get; set; }

    public decimal MontoFinalEsperado { get; set; }

    public decimal? MontoRealEntregado { get; set; }

    public decimal? Diferencia { get; set; }

    public string? Estado { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}
