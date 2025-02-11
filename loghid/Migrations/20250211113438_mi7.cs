using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class mi7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ISO14040_14044",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LCAMethodology = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    EnvironmentalImpactMetrics = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    StandardCode = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    RenewalFrequency = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISO14040_14044", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISO14067",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LifeCycleAssessmentMethod = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    CarbonFootprint = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    StandardCode = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    RenewalFrequency = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISO14067", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISO19880_1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SafetyRequirements = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    PerformanceMetrics = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    StandardCode = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    RenewalFrequency = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISO19880_1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISO21087",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnalysisMethod = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    ImpurityDetectionLimit = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    StandardCode = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    RenewalFrequency = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISO21087", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISO23306",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CertificationMethodology = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    CarbonIntensityThreshold = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    StandardCode = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    RenewalFrequency = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISO23306", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISO26142",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SensorType = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DetectionRange = table.Column<string>(type: "TEXT", nullable: false),
                    ResponseTime = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    StandardCode = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    RenewalFrequency = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISO26142", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISOC23985",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SustainabilityCriteria = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ProductionProcessVerified = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    StandardCode = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    RenewalFrequency = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISOC23985", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISOTR15916",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RiskAssessmentMethod = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    SafetyMeasures = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    StandardCode = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Year = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cost = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    RenewalFrequency = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISOTR15916", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ISO14040_14044");

            migrationBuilder.DropTable(
                name: "ISO14067");

            migrationBuilder.DropTable(
                name: "ISO19880_1");

            migrationBuilder.DropTable(
                name: "ISO21087");

            migrationBuilder.DropTable(
                name: "ISO23306");

            migrationBuilder.DropTable(
                name: "ISO26142");

            migrationBuilder.DropTable(
                name: "ISOC23985");

            migrationBuilder.DropTable(
                name: "ISOTR15916");
        }
    }
}
