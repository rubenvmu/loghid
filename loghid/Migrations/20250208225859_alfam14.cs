using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SprinterLabs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vehiculo = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Mercedes-Benz Sprinter"),
                    TipoConversion = table.Column<string>(type: "TEXT", nullable: false),
                    CapacidadCarga = table.Column<double>(type: "REAL", nullable: false),
                    EspacioInterior = table.Column<double>(type: "REAL", nullable: false),
                    ModeloEquipo = table.Column<string>(type: "TEXT", nullable: false),
                    NormaHidrogeno = table.Column<string>(type: "TEXT", nullable: false),
                    NormaPureza = table.Column<string>(type: "TEXT", nullable: false),
                    PurezaMinima = table.Column<double>(type: "REAL", nullable: false),
                    PurezaOptima = table.Column<double>(type: "REAL", nullable: false),
                    DetectorHidrogeno = table.Column<string>(type: "TEXT", nullable: false),
                    DetectorHidrocarburos = table.Column<string>(type: "TEXT", nullable: false),
                    DetectorOxigenoOtros = table.Column<string>(type: "TEXT", nullable: false),
                    DetectorAzufre = table.Column<string>(type: "TEXT", nullable: false),
                    FiltroMinimoMicrones = table.Column<int>(type: "INTEGER", nullable: false),
                    FiltroMaximoMicrones = table.Column<int>(type: "INTEGER", nullable: false),
                    MetodoTomaMuestra = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadFraccionMolar = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadContenidoAgua = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadImpurezas = table.Column<string>(type: "TEXT", nullable: false),
                    MetodoCalibracion = table.Column<string>(type: "TEXT", nullable: false),
                    NormaCalibracion = table.Column<string>(type: "TEXT", nullable: false),
                    EnsayoPresion = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    EnsayoFugas = table.Column<bool>(type: "INTEGER", nullable: false),
                    EnsayoCalidadHidrogeno = table.Column<bool>(type: "INTEGER", nullable: false),
                    CarrierGas = table.Column<string>(type: "TEXT", nullable: false),
                    CarrierAlternativo = table.Column<string>(type: "TEXT", nullable: false),
                    SensibilidadMinima = table.Column<double>(type: "REAL", nullable: false, defaultValue: 0.10000000000000001),
                    SistemaAislamientoVibraciones = table.Column<bool>(type: "INTEGER", nullable: false),
                    SistemaClimatizacionControlada = table.Column<bool>(type: "INTEGER", nullable: false),
                    SistemaEnergiaIndependiente = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SprinterLabs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_ModeloEquipo",
                table: "SprinterLabs",
                column: "ModeloEquipo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_NormaHidrogeno",
                table: "SprinterLabs",
                column: "NormaHidrogeno");

            migrationBuilder.CreateIndex(
                name: "IX_SprinterLabs_PurezaOptima",
                table: "SprinterLabs",
                column: "PurezaOptima");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SprinterLabs");
        }
    }
}
