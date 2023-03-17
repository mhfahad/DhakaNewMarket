using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class sir : Migration
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

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInfos_SellerInfoId",
                table: "ServiceInfos",
                column: "SellerInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInfos_SellerInfo_SellerInfoId",
                table: "ServiceInfos",
                column: "SellerInfoId",
                principalTable: "SellerInfo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInfos_SellerInfo_SellerInfoId",
                table: "ServiceInfos");

            migrationBuilder.DropTable(
                name: "SellerInfo");

            migrationBuilder.DropIndex(
                name: "IX_ServiceInfos_SellerInfoId",
                table: "ServiceInfos");
        }
    }
}
