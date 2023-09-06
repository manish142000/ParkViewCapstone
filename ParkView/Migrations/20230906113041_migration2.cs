using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "CouponName",
                value: "DEALSFORU");

            migrationBuilder.UpdateData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "CouponName",
                value: "PROMOPLUS");

            migrationBuilder.UpdateData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 3,
                column: "CouponName",
                value: "BARGAINBLISS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "CouponName",
                value: "Summer Discount");

            migrationBuilder.UpdateData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "CouponName",
                value: "Monsoon Discount");

            migrationBuilder.UpdateData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 3,
                column: "CouponName",
                value: "Winter Discount");
        }
    }
}
