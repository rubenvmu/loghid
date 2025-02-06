using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsoThreshold_Measurement",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "Value_Measurement",
                table: "Measurements",
                newName: "Supplier_Measurement");

            migrationBuilder.RenameColumn(
                name: "Probability_Measurement",
                table: "Measurements",
                newName: "Range_Measurement");

            migrationBuilder.RenameColumn(
                name: "MeasurementMethod_Measurement",
                table: "Measurements",
                newName: "Method_Measurement");

            migrationBuilder.RenameColumn(
                name: "MeasuredRange_Measurement",
                table: "Measurements",
                newName: "Customer_Measurement");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID_Measurement",
                table: "Measurements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PublicID_Measurement",
                table: "Measurements",
                type: "TEXT",
                maxLength: 19,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SupplierID_Measurement",
                table: "Measurements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerID_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "PublicID_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "SupplierID_Measurement",
                table: "Measurements");

            migrationBuilder.RenameColumn(
                name: "Supplier_Measurement",
                table: "Measurements",
                newName: "Value_Measurement");

            migrationBuilder.RenameColumn(
                name: "Range_Measurement",
                table: "Measurements",
                newName: "Probability_Measurement");

            migrationBuilder.RenameColumn(
                name: "Method_Measurement",
                table: "Measurements",
                newName: "MeasurementMethod_Measurement");

            migrationBuilder.RenameColumn(
                name: "Customer_Measurement",
                table: "Measurements",
                newName: "MeasuredRange_Measurement");

            migrationBuilder.AddColumn<double>(
                name: "IsoThreshold_Measurement",
                table: "Measurements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
