using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "discountCoupons",
                columns: new[] { "CouponId", "CouponName", "DiscountAmount" },
                values: new object[] { 2, "PROMOPLUS", 20 });

            migrationBuilder.InsertData(
                table: "discountCoupons",
                columns: new[] { "CouponId", "CouponName", "DiscountAmount" },
                values: new object[] { 3, "BARGAINBLISS", 30 });
        }
    }
}
