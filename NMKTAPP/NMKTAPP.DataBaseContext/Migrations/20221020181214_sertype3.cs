using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class sertype3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "serName",
                table: "serCategories",
                newName: "value");

            migrationBuilder.AddColumn<string>(
                name: "label",
                table: "serCategories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "label",
                table: "serCategories");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "serCategories",
                newName: "serName");
        }
    }
}
