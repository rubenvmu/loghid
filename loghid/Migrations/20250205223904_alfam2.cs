using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Measurements",
                newName: "Value_Measurement");

            migrationBuilder.RenameColumn(
                name: "Probability",
                table: "Measurements",
                newName: "Probability_Measurement");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Measurements",
                newName: "Notes_Measurement");

            migrationBuilder.RenameColumn(
                name: "MeasurementMethod",
                table: "Measurements",
                newName: "MeasurementMethod_Measurement");

            migrationBuilder.RenameColumn(
                name: "MeasurementDate",
                table: "Measurements",
                newName: "MeasuredRange_Measurement");

            migrationBuilder.RenameColumn(
                name: "MeasuredRange",
                table: "Measurements",
                newName: "Location_Measurement");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Measurements",
                newName: "Date_Measurement");

            migrationBuilder.RenameColumn(
                name: "IsoThreshold",
                table: "Measurements",
                newName: "IsoThreshold_Measurement");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Measurements",
                newName: "Id_Measurement");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value_Measurement",
                table: "Measurements",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "Probability_Measurement",
                table: "Measurements",
                newName: "Probability");

            migrationBuilder.RenameColumn(
                name: "Notes_Measurement",
                table: "Measurements",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "MeasurementMethod_Measurement",
                table: "Measurements",
                newName: "MeasurementMethod");

            migrationBuilder.RenameColumn(
                name: "MeasuredRange_Measurement",
                table: "Measurements",
                newName: "MeasurementDate");

            migrationBuilder.RenameColumn(
                name: "Location_Measurement",
                table: "Measurements",
                newName: "MeasuredRange");

            migrationBuilder.RenameColumn(
                name: "IsoThreshold_Measurement",
                table: "Measurements",
                newName: "IsoThreshold");

            migrationBuilder.RenameColumn(
                name: "Date_Measurement",
                table: "Measurements",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "Id_Measurement",
                table: "Measurements",
                newName: "Id");
        }
    }
}
