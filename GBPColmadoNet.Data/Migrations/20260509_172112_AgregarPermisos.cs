using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBPColmadoNet.Data.Migrations
{
    public partial class AgregarPermisos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modulo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Accion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Permite = table.Column<bool>(type: "bit", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Permisos__A16D1EC041379BA5", x => x.PermisoId);
                    table.ForeignKey(
                        name: "FK__Permisos__RolId__12",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_rol_modulo_accion",
                table: "Permisos",
                columns: new[] { "RolId", "Modulo", "Accion" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permisos");
        }
    }
}