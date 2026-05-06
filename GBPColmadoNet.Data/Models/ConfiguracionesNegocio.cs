using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class ConfiguracionesNegocio
{
    public int Id { get; set; }

    public string NombreComercial { get; set; } = null!;

    public string? Rnc { get; set; }

    public string? Direccion { get; set; }

    public string? CiudadProvincia { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Descripcion { get; set; }

    public decimal MargenGananciaDefecto { get; set; }

    public decimal ItbisDefecto { get; set; }

    public string? MensajeTicket { get; set; }

    public string? ImpresoraPredeterminada { get; set; }
}
