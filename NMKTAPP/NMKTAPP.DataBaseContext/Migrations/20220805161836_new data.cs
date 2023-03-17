using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "serDate",
                table: "ServiceInfos");

            migrationBuilder.RenameColumn(
                name: "serType",
                table: "ServiceInfos",
                newName: "whyUs");

            migrationBuilder.RenameColumn(
                name: "serTime",
                table: "ServiceInfos",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "serPhone",
                table: "ServiceInfos",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "serNo",
                table: "ServiceInfos",
                newName: "serviceOpen");

            migrationBuilder.RenameColumn(
                name: "serName",
                table: "ServiceInfos",
                newName: "serviceDetails");

            migrationBuilder.RenameColumn(
                name: "serEmail",
                table: "ServiceInfos",
                newName: "serviceClose");

            migrationBuilder.RenameColumn(
                name: "serDetails",
                table: "ServiceInfos",
                newName: "offeredServices");

            migrationBuilder.RenameColumn(
                name: "serArea",
                table: "ServiceInfos",
                newName: "name");

            migrationBuilder.AddColumn<string>(
                name: "extraServices",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "extraServices",
                table: "ServiceInfos");

            migrationBuilder.DropColumn(
                name: "image",
                table: "ServiceInfos");

            migrationBuilder.DropColumn(
                name: "location",
                table: "ServiceInfos");

            migrationBuilder.RenameColumn(
                name: "whyUs",
                table: "ServiceInfos",
                newName: "serType");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "ServiceInfos",
                newName: "serTime");

            migrationBuilder.RenameColumn(
                name: "time",
                table: "ServiceInfos",
                newName: "serPhone");

            migrationBuilder.RenameColumn(
                name: "serviceOpen",
                table: "ServiceInfos",
                newName: "serNo");

            migrationBuilder.RenameColumn(
                name: "serviceDetails",
                table: "ServiceInfos",
                newName: "serName");

            migrationBuilder.RenameColumn(
                name: "serviceClose",
                table: "ServiceInfos",
                newName: "serEmail");

            migrationBuilder.RenameColumn(
                name: "offeredServices",
                table: "ServiceInfos",
                newName: "serDetails");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ServiceInfos",
                newName: "serArea");

            migrationBuilder.AddColumn<DateTime>(
                name: "serDate",
                table: "ServiceInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
