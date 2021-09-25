using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitabchi.Migrations
{
    public partial class ProImgUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "ProductToImages",
                newName: "ImgUrl");

            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "ProductToImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductToImages_ImageID",
                table: "ProductToImages",
                column: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductToImages_Images_ImageID",
                table: "ProductToImages",
                column: "ImageID",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductToImages_Images_ImageID",
                table: "ProductToImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductToImages_ImageID",
                table: "ProductToImages");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "ProductToImages");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ImgUrl",
                table: "ProductToImages",
                newName: "Url");
        }
    }
}
