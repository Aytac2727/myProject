using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitabchi.Migrations
{
    public partial class sldpro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sliders_ProductID",
                table: "Sliders",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_Products_ProductID",
                table: "Sliders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_Products_ProductID",
                table: "Sliders");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_ProductID",
                table: "Sliders");
        }
    }
}
