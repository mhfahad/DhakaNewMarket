using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class sernamedelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "ServiceInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
