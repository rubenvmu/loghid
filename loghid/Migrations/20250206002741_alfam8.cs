using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class alfam8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Method_Measurement",
                table: "Measurements");

            migrationBuilder.DropColumn(
                name: "Range_Measurement",
                table: "Measurements");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_PublicID_Measurement",
                table: "Measurements",
                column: "PublicID_Measurement",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Measurements_PublicID_Measurement",
                table: "Measurements");

            migrationBuilder.AddColumn<string>(
                name: "Method_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Range_Measurement",
                table: "Measurements",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
