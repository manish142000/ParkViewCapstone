using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class withCoupons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "roomCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/presdidential-suite.jpg");

            migrationBuilder.UpdateData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/images/executive.jpg");

            migrationBuilder.UpdateData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/images/super-deluxe.jpg");

            migrationBuilder.UpdateData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/images/deluxe.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "roomCategories");
        }
    }
}
