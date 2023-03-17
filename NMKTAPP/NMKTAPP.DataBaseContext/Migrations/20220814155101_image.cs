using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "ServiceInfos");

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "ServiceInfos",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "ServiceInfos");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
