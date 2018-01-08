using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetCore.Data.Migrations
{
    public partial class AddedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Secret",
                table: "Pets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Secret",
                table: "Pets");
        }
    }
}
