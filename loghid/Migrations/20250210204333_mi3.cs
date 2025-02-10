using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class mi3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eSprinterLab",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vehicle = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    VehiclePrice = table.Column<double>(type: "REAL", nullable: false),
                    CargoCapacity = table.Column<double>(type: "REAL", nullable: false),
                    InteriorSpace = table.Column<double>(type: "REAL", nullable: false),
                    AutonomyCapacity = table.Column<double>(type: "REAL", nullable: false),
                    PricePer100km = table.Column<double>(type: "REAL", nullable: false),
                    Chromatograph = table.Column<double>(type: "REAL", nullable: false),
                    TCD = table.Column<double>(type: "REAL", nullable: false),
                    FID = table.Column<double>(type: "REAL", nullable: false),
                    Hygrometer = table.Column<double>(type: "REAL", nullable: false),
                    FPD = table.Column<double>(type: "REAL", nullable: false),
                    PressureRegulators = table.Column<double>(type: "REAL", nullable: false),
                    StandardGasBottles = table.Column<double>(type: "REAL", nullable: false),
                    GasColumns = table.Column<double>(type: "REAL", nullable: false),
                    HeliumCarrierGas = table.Column<double>(type: "REAL", nullable: false),
                    AirFuelGas = table.Column<double>(type: "REAL", nullable: false),
                    ChromatographCertification = table.Column<double>(type: "REAL", nullable: false),
                    RegulatoryConsultations = table.Column<double>(type: "REAL", nullable: false),
                    AnalysisService = table.Column<double>(type: "REAL", nullable: false),
                    Calibration = table.Column<double>(type: "REAL", nullable: false),
                    VehicleMaintenance = table.Column<double>(type: "REAL", nullable: false),
                    TotalPrice = table.Column<double>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[VehiclePrice] + [Chromatograph] + [TCD] + [FID] + [Hygrometer] + [FPD] + [PressureRegulators] + [StandardGasBottles] + [GasColumns] + [HeliumCarrierGas] + [AirFuelGas] + [ChromatographCertification] + [RegulatoryConsultations] + [AnalysisService] + [Calibration] + [VehicleMaintenance]", stored: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eSprinterLab", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eSprinterLab");
        }
    }
}
