using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/presidential-suite.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roomCategories",
                keyColumn: "RoomCategoryId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/presdidential-suite.jpg");
        }
    }
}
