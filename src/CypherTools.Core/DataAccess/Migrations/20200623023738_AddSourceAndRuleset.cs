using Microsoft.EntityFrameworkCore.Migrations;

namespace CypherTools.Core.DataAccess.Migrations
{
    public partial class AddSourceAndRuleset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ruleset",
                table: "UnidentifiedCyphers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruleset",
                table: "UnidentifiedArtifacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Oddities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruleset",
                table: "Cyphers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruleset",
                table: "Artifacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruleset",
                table: "ArtifactQuirks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "ArtifactQuirks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ruleset",
                table: "UnidentifiedCyphers");

            migrationBuilder.DropColumn(
                name: "Ruleset",
                table: "UnidentifiedArtifacts");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Oddities");

            migrationBuilder.DropColumn(
                name: "Ruleset",
                table: "Cyphers");

            migrationBuilder.DropColumn(
                name: "Ruleset",
                table: "Artifacts");

            migrationBuilder.DropColumn(
                name: "Ruleset",
                table: "ArtifactQuirks");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "ArtifactQuirks");
        }
    }
}
