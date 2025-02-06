using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Water_IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "Water_robability_Measurement",
                table: "Measurements",
                newName: "Water_Probability_Measurement");

            migrationBuilder.RenameColumn(
                name: "Water_MeasurementMethod_Measurement",
                table: "Measurements",
                newName: "Water_Measurement_Method_Measurement");

            migrationBuilder.AddColumn<string>(
                name: "Water_ISO_Threshold_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Water_ISO_Threshold_Measurement",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "Water_Probability_Measurement",
                table: "Measurements",
                newName: "Water_robability_Measurement");

            migrationBuilder.RenameColumn(
                name: "Water_Measurement_Method_Measurement",
                table: "Measurements",
                newName: "Water_MeasurementMethod_Measurement");

            migrationBuilder.AddColumn<double>(
                name: "Water_IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
