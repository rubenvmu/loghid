using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "Amonia_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Amonia_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Amonia_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Amonia_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Amonia_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Argon_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Argon_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Argon_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Argon_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Argon_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "CarbonDioxide_Argon_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CarbonDioxide_Argon_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarbonDioxide_Argon_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarbonDioxide_Argon_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarbonDioxide_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "CarbonMonoxid_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CarbonMonoxid_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarbonMonoxid_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarbonMonoxid_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarbonMonoxid_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Formaldehyde_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Formaldehyde_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Formaldehyde_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Formaldehyde_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Formaldehyde_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "FormicAcid_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "FormicAcid_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormicAcid_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormicAcid_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FormicAcid_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "HalogenatedCompounds_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "HalogenatedCompounds_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HalogenatedCompounds_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HalogenatedCompounds_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HalogenatedCompounds_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Helium_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Helium_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Helium_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Helium_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Helium_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Hydrocarbons_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Hydrocarbons_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hydrocarbons_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hydrocarbons_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hydrocarbons_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Methane_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Methane_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Methane_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Methane_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Methane_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Nitrogen_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Nitrogen_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nitrogen_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nitrogen_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nitrogen_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "NonCH4Hydrocarbons_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "NonCH4Hydrocarbons_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NonCH4Hydrocarbons_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NonCH4Hydrocarbons_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NonCH4Hydrocarbons_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Oxygen_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Oxygen_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Oxygen_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Oxygen_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Oxygen_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "SulphurCompounds_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SulphurCompounds_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SulphurCompounds_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SulphurCompounds_Probability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SulphurCompounds_SubstanceName_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Water_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Water_MeasuredRange_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Water_MeasurementMethod_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Water_Name_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Water_robability_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amonia_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Amonia_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Amonia_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Amonia_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Amonia_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Argon_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Argon_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Argon_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Argon_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Argon_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonDioxide_Argon_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonDioxide_Argon_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonDioxide_Argon_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonDioxide_Argon_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonDioxide_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonMonoxid_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonMonoxid_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonMonoxid_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonMonoxid_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "CarbonMonoxid_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Formaldehyde_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Formaldehyde_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Formaldehyde_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Formaldehyde_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Formaldehyde_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "FormicAcid_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "FormicAcid_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "FormicAcid_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "FormicAcid_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "FormicAcid_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "HalogenatedCompounds_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "HalogenatedCompounds_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "HalogenatedCompounds_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "HalogenatedCompounds_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "HalogenatedCompounds_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Helium_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Helium_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Helium_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Helium_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Helium_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Hydrocarbons_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Hydrocarbons_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Hydrocarbons_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Hydrocarbons_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Hydrocarbons_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Methane_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Methane_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Methane_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Methane_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Methane_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Nitrogen_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Nitrogen_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Nitrogen_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Nitrogen_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Nitrogen_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "NonCH4Hydrocarbons_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "NonCH4Hydrocarbons_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "NonCH4Hydrocarbons_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "NonCH4Hydrocarbons_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "NonCH4Hydrocarbons_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Oxygen_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Oxygen_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Oxygen_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Oxygen_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Oxygen_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "SulphurCompounds_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "SulphurCompounds_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "SulphurCompounds_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "SulphurCompounds_Probability_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "SulphurCompounds_SubstanceName_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Water_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Water_MeasuredRange_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Water_MeasurementMethod_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Water_Name_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Water_robability_Measurement",
                table: "Measurements");

            migrationBuilder.CreateTable(
                name: "AmmoniaMeasurements",
                columns: table => new
                {
                    Id_Measurement = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
                    IsoThreshold_Measurement = table.Column<double>(type: "REAL", nullable: false),
                    MeasuredRange_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    MeasurementMethod_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    Probability_Measurement = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName_Measurement = table.Column<string>(type: "TEXT", nullable: false)
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
    }
}
