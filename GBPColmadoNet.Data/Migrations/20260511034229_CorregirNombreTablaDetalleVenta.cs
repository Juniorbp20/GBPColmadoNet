using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBPColmadoNet.Data.Migrations
{
    /// <inheritdoc />
    public partial class CorregirNombreTablaDetalleVenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "VentasDetalle",
                newName: "DetalleVenta");

            migrationBuilder.RenameIndex(
                name: "IX_VentasDetalle_VentaId",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_VentaId");

            migrationBuilder.RenameIndex(
                name: "IX_VentasDetalle_ProductoId",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "DetalleVenta",
                newName: "VentasDetalle");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_VentaId",
                table: "VentasDetalle",
                newName: "IX_VentasDetalle_VentaId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_ProductoId",
                table: "VentasDetalle",
                newName: "IX_VentasDetalle_ProductoId");
        }
    }
}
