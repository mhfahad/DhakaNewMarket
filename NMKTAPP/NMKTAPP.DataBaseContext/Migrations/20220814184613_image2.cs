using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class image2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInfos_SellerInfo_SellerInfoId",
                table: "ServiceInfos");

            migrationBuilder.DropTable(
                name: "SellerInfo");

            migrationBuilder.RenameColumn(
                name: "SellerInfoId",
                table: "ServiceInfos",
                newName: "CompanyInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceInfos_SellerInfoId",
                table: "ServiceInfos",
                newName: "IX_ServiceInfos_CompanyInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInfos_companyInfos_CompanyInfoId",
                table: "ServiceInfos",
                column: "CompanyInfoId",
                principalTable: "companyInfos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInfos_companyInfos_CompanyInfoId",
                table: "ServiceInfos");

            migrationBuilder.RenameColumn(
                name: "CompanyInfoId",
                table: "ServiceInfos",
                newName: "SellerInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceInfos_CompanyInfoId",
                table: "ServiceInfos",
                newName: "IX_ServiceInfos_SellerInfoId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInfos_SellerInfo_SellerInfoId",
                table: "ServiceInfos",
                column: "SellerInfoId",
                principalTable: "SellerInfo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
