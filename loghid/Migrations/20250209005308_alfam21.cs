using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SprinterLab",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vehicle = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    VehiclePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ConversionType = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    ConversionTypePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    LoadCapacity = table.Column<double>(type: "REAL", nullable: false),
                    LoadCapacityPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    InteriorSpace = table.Column<double>(type: "REAL", nullable: false),
                    InteriorSpacePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    EquipmentModel = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    EquipmentModelPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    HydrogenStandard = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HydrogenStandardPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    PurityStandard = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PurityStandardPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    MinimumPurity = table.Column<double>(type: "REAL", nullable: false),
                    MinimumPurityPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    OptimalPurity = table.Column<double>(type: "REAL", nullable: false),
                    OptimalPurityPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    HydrogenDetector = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    HydrogenDetectorPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    HydrocarbonDetector = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    HydrocarbonDetectorPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    OxygenOthersDetector = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    OxygenOthersDetectorPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    SulfurDetector = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SulfurDetectorPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    MinimumMicronFilter = table.Column<int>(type: "INTEGER", nullable: false),
                    MinimumMicronFilterPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    MaximumMicronFilter = table.Column<int>(type: "INTEGER", nullable: false),
                    MaximumMicronFilterPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    SampleCollectionMethod = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SampleCollectionMethodPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    MolarFractionUnit = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MolarFractionUnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    WaterContentUnit = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    WaterContentUnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImpuritiesUnit = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ImpuritiesUnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CalibrationMethod = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    CalibrationMethodPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CalibrationStandard = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CalibrationStandardPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    PressureTest = table.Column<bool>(type: "INTEGER", nullable: false),
                    PressureTestPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    LeakTest = table.Column<bool>(type: "INTEGER", nullable: false),
                    LeakTestPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    HydrogenQualityTest = table.Column<bool>(type: "INTEGER", nullable: false),
                    HydrogenQualityTestPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CarrierGas = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CarrierGasPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    AlternativeCarrier = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AlternativeCarrierPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    MinimumSensitivity = table.Column<double>(type: "REAL", nullable: false),
                    MinimumSensitivityPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    VibrationIsolationSystem = table.Column<bool>(type: "INTEGER", nullable: false),
                    VibrationIsolationSystemPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ControlledClimateSystem = table.Column<bool>(type: "INTEGER", nullable: false),
                    ControlledClimateSystemPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    IndependentPowerSystem = table.Column<bool>(type: "INTEGER", nullable: false),
                    IndependentPowerSystemPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SprinterLab", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SprinterLab");
        }
    }
}
