using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class LoghidMeasurementDbContex32t : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Substances",
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
                    table.PrimaryKey("PK_Substances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeasurementDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    MeasurementMethod = table.Column<string>(type: "TEXT", nullable: false),
                    MeasuredRange = table.Column<string>(type: "TEXT", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false),
                    SubstanceName = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    SubstanceId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measurements_Substances_SubstanceId",
                        column: x => x.SubstanceId,
                        principalTable: "Substances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Measurements_Substances_SubstanceId1",
                        column: x => x.SubstanceId1,
                        principalTable: "Substances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_SubstanceId",
                table: "Measurements",
                column: "SubstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_SubstanceId1",
                table: "Measurements",
                column: "SubstanceId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "Substances");
        }
    }
}
