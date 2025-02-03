using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loghid.Migrations
{
    /// <inheritdoc />
    public partial class AddSubstancesTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Water",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Water",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Water",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "SulphurCompounds",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "SulphurCompounds",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "SulphurCompounds",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Substances",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Substances",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Substances",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Oxygen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Oxygen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Oxygen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "NonCH4Hydrocarbons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "NonCH4Hydrocarbons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "NonCH4Hydrocarbons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Nitrogen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Nitrogen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Nitrogen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Methane",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Methane",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Methane",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Hydrocarbons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Hydrocarbons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Hydrocarbons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Helium",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Helium",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Helium",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "HalogenatedCompounds",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "HalogenatedCompounds",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "HalogenatedCompounds",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "FormicAcid",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "FormicAcid",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "FormicAcid",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Formaldehyde",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Formaldehyde",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Formaldehyde",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "CarbonMonoxide",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "CarbonMonoxide",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "CarbonMonoxide",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "CarbonDioxide",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "CarbonDioxide",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "CarbonDioxide",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Argon",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Argon",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Argon",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasuredRange",
                table: "Ammonia",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeasurementMethod",
                table: "Ammonia",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubstanceName",
                table: "Ammonia",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Water");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Water");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Water");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "SulphurCompounds");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "SulphurCompounds");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "SulphurCompounds");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Substances");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Oxygen");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Oxygen");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Oxygen");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "NonCH4Hydrocarbons");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "NonCH4Hydrocarbons");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "NonCH4Hydrocarbons");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Nitrogen");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Nitrogen");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Nitrogen");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Methane");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Methane");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Methane");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Hydrocarbons");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Hydrocarbons");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Hydrocarbons");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Helium");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Helium");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Helium");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "HalogenatedCompounds");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "HalogenatedCompounds");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "HalogenatedCompounds");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "FormicAcid");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "FormicAcid");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "FormicAcid");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Formaldehyde");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Formaldehyde");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Formaldehyde");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "CarbonMonoxide");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "CarbonMonoxide");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "CarbonMonoxide");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "CarbonDioxide");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "CarbonDioxide");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "CarbonDioxide");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Argon");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Argon");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Argon");

            migrationBuilder.DropColumn(
                name: "MeasuredRange",
                table: "Ammonia");

            migrationBuilder.DropColumn(
                name: "MeasurementMethod",
                table: "Ammonia");

            migrationBuilder.DropColumn(
                name: "SubstanceName",
                table: "Ammonia");
        }
    }
}
