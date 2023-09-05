using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "discountCoupons",
                columns: new[] { "CouponId", "CouponName", "DiscountAmount" },
                values: new object[] { 1, "Summer Discount", 10 });

            migrationBuilder.InsertData(
                table: "discountCoupons",
                columns: new[] { "CouponId", "CouponName", "DiscountAmount" },
                values: new object[] { 2, "Monsoon Discount", 20 });

            migrationBuilder.InsertData(
                table: "discountCoupons",
                columns: new[] { "CouponId", "CouponName", "DiscountAmount" },
                values: new object[] { 3, "Winter Discount", 30 });

            migrationBuilder.InsertData(
                table: "bookings",
                columns: new[] { "BookingId", "CheckInDate", "CheckOutDate", "CouponId", "TotalCost", "UserEmail" },
                values: new object[] { 1, new DateTime(2023, 9, 15, 13, 45, 30, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 13, 45, 30, 0, DateTimeKind.Unspecified), 1, 0.0, "testuser123@gmail.com" });

            migrationBuilder.InsertData(
                table: "bookingRooms",
                columns: new[] { "BookingRoomId", "BookingId", "RoomId" },
                values: new object[] { 1, 1, "O-PS01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "bookingRooms",
                keyColumn: "BookingRoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "bookings",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "discountCoupons",
                keyColumn: "CouponId",
                keyValue: 1);
        }
    }
}
