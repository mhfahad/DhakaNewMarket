using Microsoft.EntityFrameworkCore.Migrations;

namespace NMKTAPP.DataBaseContext.Migrations
{
    public partial class sercat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "serType",
                table: "ServiceInfos");

            migrationBuilder.AddColumn<int>(
                name: "serCategoryId",
                table: "ServiceInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "serCategories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serCategories", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInfos_serCategoryId",
                table: "ServiceInfos",
                column: "serCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInfos_serCategories_serCategoryId",
                table: "ServiceInfos",
                column: "serCategoryId",
                principalTable: "serCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInfos_serCategories_serCategoryId",
                table: "ServiceInfos");

            migrationBuilder.DropTable(
                name: "serCategories");

            migrationBuilder.DropIndex(
                name: "IX_ServiceInfos_serCategoryId",
                table: "ServiceInfos");

            migrationBuilder.DropColumn(
                name: "serCategoryId",
                table: "ServiceInfos");

            migrationBuilder.AddColumn<string>(
                name: "serType",
                table: "ServiceInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
