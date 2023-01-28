using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domio.Migrations
{
    /// <inheritdoc />
    public partial class initialmigrationwithtablemovimiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "config");

            migrationBuilder.CreateTable(
                name: "MovimientosAeropuerto",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoAvion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aerolinea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAterizaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraAterrizaje = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientosAeropuerto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovimientosAeropuerto",
                schema: "config");
        }
    }
}
