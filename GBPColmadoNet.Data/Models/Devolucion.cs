using System;

namespace GBPColmadoNet.Data.Models
{
    public partial class Devolucion
    {
        public int DevolucionId { get; set; }

        public int VentaId { get; set; }

        public string? ProductoNombre { get; set; }

        public int Cantidad { get; set; }

        public decimal? MontoReembolsado { get; set; }

        public string? Motivo { get; set; }

        public string Estado { get; set; } = "Pendiente";

        public DateTime FechaRegistro { get; set; }

        public int? UsuarioId { get; set; }

        public virtual Usuario? Usuario { get; set; }

        public virtual Venta? Venta { get; set; }
    }
}