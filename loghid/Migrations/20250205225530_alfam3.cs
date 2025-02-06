using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Substance",
                table: "Substance");

            migrationBuilder.RenameTable(
                name: "Substance",
                newName: "Substances");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Substances",
                table: "Substances",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AmmoniaMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmmoniaMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_AmmoniaMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArgonMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArgonMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_ArgonMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarbonDioxideMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbonDioxideMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_CarbonDioxideMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarbonMonoxideMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbonMonoxideMeasurements", x => x.Id_Measurement);
                });

            migrationBuilder.CreateTable(
                name: "FormaldehydeMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaldehydeMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_FormaldehydeMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormicAcidMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormicAcidMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_FormicAcidMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HalogenatedCompoundsMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HalogenatedCompoundsMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_HalogenatedCompoundsMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeliumMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeliumMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_HeliumMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HydrocarbonsMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydrocarbonsMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_HydrocarbonsMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NitrogenMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NitrogenMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_NitrogenMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OxygenMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OxygenMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_OxygenMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SulphurCompoundsMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SulphurCompoundsMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_SulphurCompoundsMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterMeasurements", x => x.Id_Measurement);
                    table.ForeignKey(
                        name: "FK_WaterMeasurements_Measurements_Id_Measurement",
                        column: x => x.Id_Measurement,
                        principalTable: "Measurements",
                        principalColumn: "Id_Measurement",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmmoniaMeasurements");

            migrationBuilder.DropTable(
                name: "ArgonMeasurements");

            migrationBuilder.DropTable(
                name: "CarbonDioxideMeasurements");

            migrationBuilder.DropTable(
                name: "CarbonMonoxideMeasurements");

            migrationBuilder.DropTable(
                name: "FormaldehydeMeasurements");

            migrationBuilder.DropTable(
                name: "FormicAcidMeasurements");

            migrationBuilder.DropTable(
                name: "HalogenatedCompoundsMeasurements");

            migrationBuilder.DropTable(
                name: "HeliumMeasurements");

            migrationBuilder.DropTable(
                name: "HydrocarbonsMeasurements");

            migrationBuilder.DropTable(
                name: "NitrogenMeasurements");

            migrationBuilder.DropTable(
                name: "OxygenMeasurements");

            migrationBuilder.DropTable(
                name: "SulphurCompoundsMeasurements");

            migrationBuilder.DropTable(
                name: "WaterMeasurements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Substances",
                table: "Substances");

            migrationBuilder.RenameTable(
                name: "Substances",
                newName: "Substance");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Substance",
                table: "Substance",
                column: "Id");
        }
    }
}
