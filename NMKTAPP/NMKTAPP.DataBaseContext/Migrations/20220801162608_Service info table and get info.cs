using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class Serviceinfotableandgetinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SellerInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sellName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerInfo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceInfos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    serTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerInfoIdid = table.Column<int>(type: "int", nullable: true),
                    serDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_ServiceInfos_SellerInfo_SellerInfoIdid",
                        column: x => x.SellerInfoIdid,
                        principalTable: "SellerInfo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInfos_SellerInfoIdid",
                table: "ServiceInfos",
                column: "SellerInfoIdid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceInfos");

            migrationBuilder.DropTable(
                name: "SellerInfo");
        }
    }
}
