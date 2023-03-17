using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class companyuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userUId",
                table: "companyInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userUId",
                table: "companyInfos");
        }
    }
}
