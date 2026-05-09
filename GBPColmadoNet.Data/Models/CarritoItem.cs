using System.ComponentModel.DataAnnotations.Schema;

namespace GBPColmadoNet.Data.Models
{
    public partial class CarritoItem
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public int ProductoId { get; set; }
        public required string Codigo { get; set; }
        public required string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TasaItbis { get; set; }
        
        [NotMapped]
        public decimal Itbis => PrecioUnitario * (TasaItbis / 100m) * Cantidad;
        
        [NotMapped]
        public decimal Subtotal => PrecioUnitario * Cantidad;
        
        [NotMapped]
        public decimal Total => Subtotal + Itbis;
    }
}
