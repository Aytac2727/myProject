using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitabchi.Migrations
{
    public partial class SliderImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "SliderToImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "Sliders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SliderToImages_ImageID",
                table: "SliderToImages",
                column: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_SliderToImages_Images_ImageID",
                table: "SliderToImages",
                column: "ImageID",
                principalTable: "Images",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SliderToImages_Images_ImageID",
                table: "SliderToImages");

            migrationBuilder.DropIndex(
                name: "IX_SliderToImages_ImageID",
                table: "SliderToImages");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "SliderToImages");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "Sliders");
        }
    }
}
