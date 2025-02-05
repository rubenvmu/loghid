using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class LoghidMeasurementDbContext36345 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Substance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubstanceName = table.Column<string>(type: "TEXT", nullable: false),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange = table.Column<string>(type: "TEXT", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substance", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Substance");
        }
    }
}
