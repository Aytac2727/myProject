using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitabchi.Migrations
{
    public partial class offer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferToImage_Images_ImageID",
                table: "OfferToImage");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferToImage_Offers_OfferID",
                table: "OfferToImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferToImage",
                table: "OfferToImage");

            migrationBuilder.RenameTable(
                name: "OfferToImage",
                newName: "OfferToImages");

            migrationBuilder.RenameIndex(
                name: "IX_OfferToImage_OfferID",
                table: "OfferToImages",
                newName: "IX_OfferToImages_OfferID");

            migrationBuilder.RenameIndex(
                name: "IX_OfferToImage_ImageID",
                table: "OfferToImages",
                newName: "IX_OfferToImages_ImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferToImages",
                table: "OfferToImages",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferToImages_Images_ImageID",
                table: "OfferToImages",
                column: "ImageID",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferToImages_Offers_OfferID",
                table: "OfferToImages",
                column: "OfferID",
                principalTable: "Offers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferToImages_Images_ImageID",
                table: "OfferToImages");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferToImages_Offers_OfferID",
                table: "OfferToImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferToImages",
                table: "OfferToImages");

            migrationBuilder.RenameTable(
                name: "OfferToImages",
                newName: "OfferToImage");

            migrationBuilder.RenameIndex(
                name: "IX_OfferToImages_OfferID",
                table: "OfferToImage",
                newName: "IX_OfferToImage_OfferID");

            migrationBuilder.RenameIndex(
                name: "IX_OfferToImages_ImageID",
                table: "OfferToImage",
                newName: "IX_OfferToImage_ImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferToImage",
                table: "OfferToImage",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferToImage_Images_ImageID",
                table: "OfferToImage",
                column: "ImageID",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferToImage_Offers_OfferID",
                table: "OfferToImage",
                column: "OfferID",
                principalTable: "Offers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
