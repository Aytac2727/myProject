using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitabchi.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_Category1ID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Category1ID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Category1ID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Category1_ID",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category1ID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category1_ID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Category1ID",
                table: "Categories",
                column: "Category1ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_Category1ID",
                table: "Categories",
                column: "Category1ID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
