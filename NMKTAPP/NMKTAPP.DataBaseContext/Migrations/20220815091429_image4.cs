using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class image4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "ServiceInfos",
                newName: "CompanyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInfos_CompanyInfoId",
                table: "ServiceInfos",
                column: "CompanyInfoId");

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

            migrationBuilder.DropIndex(
                name: "IX_ServiceInfos_CompanyInfoId",
                table: "ServiceInfos");

            migrationBuilder.RenameColumn(
                name: "CompanyInfoId",
                table: "ServiceInfos",
                newName: "CompanyId");
        }
    }
}
