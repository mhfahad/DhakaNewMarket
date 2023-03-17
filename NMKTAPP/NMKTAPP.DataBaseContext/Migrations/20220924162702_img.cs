using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class img : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "active",
                table: "ServiceInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "serImg1",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "serImg2",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "serImg3",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "serImg4",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "ServiceInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "active",
                table: "ServiceInfos");

            migrationBuilder.DropColumn(
                name: "serImg1",
                table: "ServiceInfos");

            migrationBuilder.DropColumn(
                name: "serImg2",
                table: "ServiceInfos");

            migrationBuilder.DropColumn(
                name: "serImg3",
                table: "ServiceInfos");

            migrationBuilder.DropColumn(
                name: "serImg4",
                table: "ServiceInfos");

            migrationBuilder.DropColumn(
                name: "status",
                table: "ServiceInfos");
        }
    }
}
