using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate45 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ammonia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ammonia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Argon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Argon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarbonDioxide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbonDioxide", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarbonMonoxide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbonMonoxide", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formaldehyde",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formaldehyde", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormicAcid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormicAcid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HalogenatedCompounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HalogenatedCompounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Helium",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helium", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hydrocarbons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hydrocarbons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Methane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methane", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nitrogen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nitrogen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonCH4Hydrocarbons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonCH4Hydrocarbons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oxygen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oxygen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SulphurCompounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SulphurCompounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Water",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsoThreshold = table.Column<double>(type: "REAL", nullable: false),
                    Probability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Water", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ammonia");

            migrationBuilder.DropTable(
                name: "Argon");

            migrationBuilder.DropTable(
                name: "CarbonDioxide");

            migrationBuilder.DropTable(
                name: "CarbonMonoxide");

            migrationBuilder.DropTable(
                name: "Formaldehyde");

            migrationBuilder.DropTable(
                name: "FormicAcid");

            migrationBuilder.DropTable(
                name: "HalogenatedCompounds");

            migrationBuilder.DropTable(
                name: "Helium");

            migrationBuilder.DropTable(
                name: "Hydrocarbons");

            migrationBuilder.DropTable(
                name: "Methane");

            migrationBuilder.DropTable(
                name: "Nitrogen");

            migrationBuilder.DropTable(
                name: "NonCH4Hydrocarbons");

            migrationBuilder.DropTable(
                name: "Oxygen");

            migrationBuilder.DropTable(
                name: "SulphurCompounds");

            migrationBuilder.DropTable(
                name: "Water");
        }
    }
}
