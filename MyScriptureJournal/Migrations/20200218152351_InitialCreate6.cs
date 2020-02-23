using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scripture",
                table: "Journal");

            migrationBuilder.AddColumn<string>(
                name: "Book",
                table: "Journal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Chapter",
                table: "Journal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Verse",
                table: "Journal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "Chapter",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "Verse",
                table: "Journal");

            migrationBuilder.AddColumn<string>(
                name: "Scripture",
                table: "Journal",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
