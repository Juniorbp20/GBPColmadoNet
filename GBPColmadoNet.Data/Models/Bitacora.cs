using System;
using System.Collections.Generic;

namespace GBPColmadoNet.Data.Models;

public partial class Bitacora
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int UsuarioId { get; set; }

    public string Accion { get; set; } = null!;

    public string Modulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
