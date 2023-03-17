using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userName",
                table: "users",
                newName: "usrPass");

            migrationBuilder.RenameColumn(
                name: "userEmail",
                table: "users",
                newName: "usrName");

            migrationBuilder.AddColumn<string>(
                name: "usrEmail",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "usrEmail",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "usrPass",
                table: "users",
                newName: "userName");

            migrationBuilder.RenameColumn(
                name: "usrName",
                table: "users",
                newName: "userEmail");
        }
    }
}
