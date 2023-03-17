using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class testimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "ServiceInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "ServiceInfos",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
