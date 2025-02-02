using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaminantParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MaxLimit = table.Column<string>(type: "TEXT", nullable: false),
                    Origin = table.Column<string>(type: "TEXT", nullable: false),
                    ContaminantParameterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaminantParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaminantParameters_ContaminantParameters_ContaminantParameterId",
                        column: x => x.ContaminantParameterId,
                        principalTable: "ContaminantParameters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IdealParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    Origin = table.Column<string>(type: "TEXT", nullable: false),
                    IdealParameterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdealParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdealParameters_IdealParameters_IdealParameterId",
                        column: x => x.IdealParameterId,
                        principalTable: "IdealParameters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaminantParameters_ContaminantParameterId",
                table: "ContaminantParameters",
                column: "ContaminantParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_IdealParameters_IdealParameterId",
                table: "IdealParameters",
                column: "IdealParameterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaminantParameters");

            migrationBuilder.DropTable(
                name: "IdealParameters");
        }
    }
}
