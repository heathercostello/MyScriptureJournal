using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Journal");

            migrationBuilder.AddColumn<string>(
                name: "Scripture",
                table: "Journal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scripture",
                table: "Journal");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Journal",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
