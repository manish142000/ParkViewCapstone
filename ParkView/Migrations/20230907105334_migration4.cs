using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_discountCoupons_CouponId",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_CouponId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "CheckInDate",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "CheckOutDate",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "bookings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "C-SD20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "D-SD20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "M-SD20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "O-SD20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX20");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX21");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX22");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX23");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX24");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-DX25");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-EX10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-PS05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD01");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD02");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD03");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD04");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD05");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD06");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD07");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD08");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD09");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD10");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD11");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD12");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD13");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD14");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD15");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD16");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD17");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD18");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD19");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "RoomId",
                keyValue: "S-SD20");

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckInDate",
                table: "rooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOutDate",
                table: "rooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "bookings",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "CouponId",
                value: 1);

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "Discriminator", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "C-DX01", "Room", 5, 4, true, 2 },
                    { "C-DX02", "Room", 5, 4, true, 2 },
                    { "C-DX03", "Room", 5, 4, true, 2 },
                    { "C-DX04", "Room", 5, 4, true, 2 },
                    { "C-DX05", "Room", 5, 4, true, 2 },
                    { "C-DX06", "Room", 5, 4, true, 2 },
                    { "C-DX07", "Room", 5, 4, true, 2 },
                    { "C-DX08", "Room", 5, 4, true, 2 },
                    { "C-DX09", "Room", 5, 4, true, 2 },
                    { "C-DX10", "Room", 5, 4, true, 2 },
                    { "C-DX11", "Room", 5, 4, true, 2 },
                    { "C-DX12", "Room", 5, 4, true, 2 },
                    { "C-DX13", "Room", 5, 4, true, 2 },
                    { "C-DX14", "Room", 5, 4, true, 2 },
                    { "C-DX15", "Room", 5, 4, true, 2 },
                    { "C-DX16", "Room", 5, 4, true, 2 },
                    { "C-DX17", "Room", 5, 4, true, 2 },
                    { "C-DX18", "Room", 5, 4, true, 2 },
                    { "C-DX19", "Room", 5, 4, true, 2 },
                    { "C-DX20", "Room", 5, 4, true, 2 },
                    { "C-DX21", "Room", 5, 4, true, 2 },
                    { "C-DX22", "Room", 5, 4, true, 2 },
                    { "C-DX23", "Room", 5, 4, true, 2 },
                    { "C-DX24", "Room", 5, 4, true, 2 },
                    { "C-DX25", "Room", 5, 4, true, 2 },
                    { "C-EX01", "Room", 5, 2, true, 3 },
                    { "C-EX02", "Room", 5, 2, true, 3 },
                    { "C-EX03", "Room", 5, 2, true, 3 },
                    { "C-EX04", "Room", 5, 2, true, 3 },
                    { "C-EX05", "Room", 5, 2, true, 3 },
                    { "C-EX06", "Room", 5, 2, true, 3 },
                    { "C-EX07", "Room", 5, 2, true, 3 },
                    { "C-EX08", "Room", 5, 2, true, 3 },
                    { "C-EX09", "Room", 5, 2, true, 3 },
                    { "C-EX10", "Room", 5, 2, true, 3 },
                    { "C-PS01", "Room", 5, 1, true, 4 },
                    { "C-PS02", "Room", 5, 1, true, 4 },
                    { "C-PS03", "Room", 5, 1, true, 4 },
                    { "C-PS04", "Room", 5, 1, true, 4 },
                    { "C-PS05", "Room", 5, 1, true, 4 },
                    { "C-SD01", "Room", 5, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "Discriminator", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "C-SD02", "Room", 5, 3, true, 2 },
                    { "C-SD03", "Room", 5, 3, true, 2 },
                    { "C-SD04", "Room", 5, 3, true, 2 },
                    { "C-SD05", "Room", 5, 3, true, 2 },
                    { "C-SD06", "Room", 5, 3, true, 2 },
                    { "C-SD07", "Room", 5, 3, true, 2 },
                    { "C-SD08", "Room", 5, 3, true, 2 },
                    { "C-SD09", "Room", 5, 3, true, 2 },
                    { "C-SD10", "Room", 5, 3, true, 2 },
                    { "C-SD11", "Room", 5, 3, true, 2 },
                    { "C-SD12", "Room", 5, 3, true, 2 },
                    { "C-SD13", "Room", 5, 3, true, 2 },
                    { "C-SD14", "Room", 5, 3, true, 2 },
                    { "C-SD15", "Room", 5, 3, true, 2 },
                    { "C-SD16", "Room", 5, 3, true, 2 },
                    { "C-SD17", "Room", 5, 3, true, 2 },
                    { "C-SD18", "Room", 5, 3, true, 2 },
                    { "C-SD19", "Room", 5, 3, true, 2 },
                    { "C-SD20", "Room", 5, 3, true, 2 },
                    { "D-DX01", "Room", 2, 4, true, 2 },
                    { "D-DX02", "Room", 2, 4, true, 2 },
                    { "D-DX03", "Room", 2, 4, true, 2 },
                    { "D-DX04", "Room", 2, 4, true, 2 },
                    { "D-DX05", "Room", 2, 4, true, 2 },
                    { "D-DX06", "Room", 2, 4, true, 2 },
                    { "D-DX07", "Room", 2, 4, true, 2 },
                    { "D-DX08", "Room", 2, 4, true, 2 },
                    { "D-DX09", "Room", 2, 4, true, 2 },
                    { "D-DX10", "Room", 2, 4, true, 2 },
                    { "D-DX11", "Room", 2, 4, true, 2 },
                    { "D-DX12", "Room", 2, 4, true, 2 },
                    { "D-DX13", "Room", 2, 4, true, 2 },
                    { "D-DX14", "Room", 2, 4, true, 2 },
                    { "D-DX15", "Room", 2, 4, true, 2 },
                    { "D-DX16", "Room", 2, 4, true, 2 },
                    { "D-DX17", "Room", 2, 4, true, 2 },
                    { "D-DX18", "Room", 2, 4, true, 2 },
                    { "D-DX19", "Room", 2, 4, true, 2 },
                    { "D-DX20", "Room", 2, 4, true, 2 },
                    { "D-DX21", "Room", 2, 4, true, 2 },
                    { "D-DX22", "Room", 2, 4, true, 2 },
                    { "D-DX23", "Room", 2, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "Discriminator", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "D-DX24", "Room", 2, 4, true, 2 },
                    { "D-DX25", "Room", 2, 4, true, 2 },
                    { "D-EX01", "Room", 2, 2, true, 3 },
                    { "D-EX02", "Room", 2, 2, true, 3 },
                    { "D-EX03", "Room", 2, 2, true, 3 },
                    { "D-EX04", "Room", 2, 2, true, 3 },
                    { "D-EX05", "Room", 2, 2, true, 3 },
                    { "D-EX06", "Room", 2, 2, true, 3 },
                    { "D-EX07", "Room", 2, 2, true, 3 },
                    { "D-EX08", "Room", 2, 2, true, 3 },
                    { "D-EX09", "Room", 2, 2, true, 3 },
                    { "D-EX10", "Room", 2, 2, true, 3 },
                    { "D-PS01", "Room", 2, 1, true, 4 },
                    { "D-PS02", "Room", 2, 1, true, 4 },
                    { "D-PS03", "Room", 2, 1, true, 4 },
                    { "D-PS04", "Room", 2, 1, true, 4 },
                    { "D-PS05", "Room", 2, 1, true, 4 },
                    { "D-SD01", "Room", 2, 3, true, 2 },
                    { "D-SD02", "Room", 2, 3, true, 2 },
                    { "D-SD03", "Room", 2, 3, true, 2 },
                    { "D-SD04", "Room", 2, 3, true, 2 },
                    { "D-SD05", "Room", 2, 3, true, 2 },
                    { "D-SD06", "Room", 2, 3, true, 2 },
                    { "D-SD07", "Room", 2, 3, true, 2 },
                    { "D-SD08", "Room", 2, 3, true, 2 },
                    { "D-SD09", "Room", 2, 3, true, 2 },
                    { "D-SD10", "Room", 2, 3, true, 2 },
                    { "D-SD11", "Room", 2, 3, true, 2 },
                    { "D-SD12", "Room", 2, 3, true, 2 },
                    { "D-SD13", "Room", 2, 3, true, 2 },
                    { "D-SD14", "Room", 2, 3, true, 2 },
                    { "D-SD15", "Room", 2, 3, true, 2 },
                    { "D-SD16", "Room", 2, 3, true, 2 },
                    { "D-SD17", "Room", 2, 3, true, 2 },
                    { "D-SD18", "Room", 2, 3, true, 2 },
                    { "D-SD19", "Room", 2, 3, true, 2 },
                    { "D-SD20", "Room", 2, 3, true, 2 },
                    { "M-DX01", "Room", 4, 4, true, 2 },
                    { "M-DX02", "Room", 4, 4, true, 2 },
                    { "M-DX03", "Room", 4, 4, true, 2 },
                    { "M-DX04", "Room", 4, 4, true, 2 },
                    { "M-DX05", "Room", 4, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "Discriminator", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "M-DX06", "Room", 4, 4, true, 2 },
                    { "M-DX07", "Room", 4, 4, true, 2 },
                    { "M-DX08", "Room", 4, 4, true, 2 },
                    { "M-DX09", "Room", 4, 4, true, 2 },
                    { "M-DX10", "Room", 4, 4, true, 2 },
                    { "M-DX11", "Room", 4, 4, true, 2 },
                    { "M-DX12", "Room", 4, 4, true, 2 },
                    { "M-DX13", "Room", 4, 4, true, 2 },
                    { "M-DX14", "Room", 4, 4, true, 2 },
                    { "M-DX15", "Room", 4, 4, true, 2 },
                    { "M-DX16", "Room", 4, 4, true, 2 },
                    { "M-DX17", "Room", 4, 4, true, 2 },
                    { "M-DX18", "Room", 4, 4, true, 2 },
                    { "M-DX19", "Room", 4, 4, true, 2 },
                    { "M-DX20", "Room", 4, 4, true, 2 },
                    { "M-DX21", "Room", 4, 4, true, 2 },
                    { "M-DX22", "Room", 4, 4, true, 2 },
                    { "M-DX23", "Room", 4, 4, true, 2 },
                    { "M-DX24", "Room", 4, 4, true, 2 },
                    { "M-DX25", "Room", 4, 4, true, 2 },
                    { "M-EX01", "Room", 4, 2, true, 3 },
                    { "M-EX02", "Room", 4, 2, true, 3 },
                    { "M-EX03", "Room", 4, 2, true, 3 },
                    { "M-EX04", "Room", 4, 2, true, 3 },
                    { "M-EX05", "Room", 4, 2, true, 3 },
                    { "M-EX06", "Room", 4, 2, true, 3 },
                    { "M-EX07", "Room", 4, 2, true, 3 },
                    { "M-EX08", "Room", 4, 2, true, 3 },
                    { "M-EX09", "Room", 4, 2, true, 3 },
                    { "M-EX10", "Room", 4, 2, true, 3 },
                    { "M-PS01", "Room", 4, 1, true, 4 },
                    { "M-PS02", "Room", 4, 1, true, 4 },
                    { "M-PS03", "Room", 4, 1, true, 4 },
                    { "M-PS04", "Room", 4, 1, true, 4 },
                    { "M-PS05", "Room", 4, 1, true, 4 },
                    { "M-SD01", "Room", 4, 3, true, 2 },
                    { "M-SD02", "Room", 4, 3, true, 2 },
                    { "M-SD03", "Room", 4, 3, true, 2 },
                    { "M-SD04", "Room", 4, 3, true, 2 },
                    { "M-SD05", "Room", 4, 3, true, 2 },
                    { "M-SD06", "Room", 4, 3, true, 2 },
                    { "M-SD07", "Room", 4, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "Discriminator", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "M-SD08", "Room", 4, 3, true, 2 },
                    { "M-SD09", "Room", 4, 3, true, 2 },
                    { "M-SD10", "Room", 4, 3, true, 2 },
                    { "M-SD11", "Room", 4, 3, true, 2 },
                    { "M-SD12", "Room", 4, 3, true, 2 },
                    { "M-SD13", "Room", 4, 3, true, 2 },
                    { "M-SD14", "Room", 4, 3, true, 2 },
                    { "M-SD15", "Room", 4, 3, true, 2 },
                    { "M-SD16", "Room", 4, 3, true, 2 },
                    { "M-SD17", "Room", 4, 3, true, 2 },
                    { "M-SD18", "Room", 4, 3, true, 2 },
                    { "M-SD19", "Room", 4, 3, true, 2 },
                    { "M-SD20", "Room", 4, 3, true, 2 },
                    { "O-DX01", "Room", 1, 4, true, 2 },
                    { "O-DX02", "Room", 1, 4, true, 2 },
                    { "O-DX03", "Room", 1, 4, true, 2 },
                    { "O-DX04", "Room", 1, 4, true, 2 },
                    { "O-DX05", "Room", 1, 4, true, 2 },
                    { "O-DX06", "Room", 1, 4, true, 2 },
                    { "O-DX07", "Room", 1, 4, true, 2 },
                    { "O-DX08", "Room", 1, 4, true, 2 },
                    { "O-DX09", "Room", 1, 4, true, 2 },
                    { "O-DX10", "Room", 1, 4, true, 2 },
                    { "O-DX11", "Room", 1, 4, true, 2 },
                    { "O-DX12", "Room", 1, 4, true, 2 },
                    { "O-DX13", "Room", 1, 4, true, 2 },
                    { "O-DX14", "Room", 1, 4, true, 2 },
                    { "O-DX15", "Room", 1, 4, true, 2 },
                    { "O-DX16", "Room", 1, 4, true, 2 },
                    { "O-DX17", "Room", 1, 4, true, 2 },
                    { "O-DX18", "Room", 1, 4, true, 2 },
                    { "O-DX19", "Room", 1, 4, true, 2 },
                    { "O-DX20", "Room", 1, 4, true, 2 },
                    { "O-DX21", "Room", 1, 4, true, 2 },
                    { "O-DX22", "Room", 1, 4, true, 2 },
                    { "O-DX23", "Room", 1, 4, true, 2 },
                    { "O-DX24", "Room", 1, 4, true, 2 },
                    { "O-DX25", "Room", 1, 4, true, 2 },
                    { "O-EX01", "Room", 1, 2, true, 3 },
                    { "O-EX02", "Room", 1, 2, true, 3 },
                    { "O-EX03", "Room", 1, 2, true, 3 },
                    { "O-EX04", "Room", 1, 2, true, 3 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "Discriminator", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "O-EX05", "Room", 1, 2, true, 3 },
                    { "O-EX06", "Room", 1, 2, true, 3 },
                    { "O-EX07", "Room", 1, 2, true, 3 },
                    { "O-EX08", "Room", 1, 2, true, 3 },
                    { "O-EX09", "Room", 1, 2, true, 3 },
                    { "O-EX10", "Room", 1, 2, true, 3 },
                    { "O-PS01", "Room", 1, 1, true, 4 },
                    { "O-PS02", "Room", 1, 1, true, 4 },
                    { "O-PS03", "Room", 1, 1, true, 4 },
                    { "O-PS04", "Room", 1, 1, true, 4 },
                    { "O-PS05", "Room", 1, 1, true, 4 },
                    { "O-SD01", "Room", 1, 3, true, 2 },
                    { "O-SD02", "Room", 1, 3, true, 2 },
                    { "O-SD03", "Room", 1, 3, true, 2 },
                    { "O-SD04", "Room", 1, 3, true, 2 },
                    { "O-SD05", "Room", 1, 3, true, 2 },
                    { "O-SD06", "Room", 1, 3, true, 2 },
                    { "O-SD07", "Room", 1, 3, true, 2 },
                    { "O-SD08", "Room", 1, 3, true, 2 },
                    { "O-SD09", "Room", 1, 3, true, 2 },
                    { "O-SD10", "Room", 1, 3, true, 2 },
                    { "O-SD11", "Room", 1, 3, true, 2 },
                    { "O-SD12", "Room", 1, 3, true, 2 },
                    { "O-SD13", "Room", 1, 3, true, 2 },
                    { "O-SD14", "Room", 1, 3, true, 2 },
                    { "O-SD15", "Room", 1, 3, true, 2 },
                    { "O-SD16", "Room", 1, 3, true, 2 },
                    { "O-SD17", "Room", 1, 3, true, 2 },
                    { "O-SD18", "Room", 1, 3, true, 2 },
                    { "O-SD19", "Room", 1, 3, true, 2 },
                    { "O-SD20", "Room", 1, 3, true, 2 },
                    { "S-DX01", "Room", 3, 4, true, 2 },
                    { "S-DX02", "Room", 3, 4, true, 2 },
                    { "S-DX03", "Room", 3, 4, true, 2 },
                    { "S-DX04", "Room", 3, 4, true, 2 },
                    { "S-DX05", "Room", 3, 4, true, 2 },
                    { "S-DX06", "Room", 3, 4, true, 2 },
                    { "S-DX07", "Room", 3, 4, true, 2 },
                    { "S-DX08", "Room", 3, 4, true, 2 },
                    { "S-DX09", "Room", 3, 4, true, 2 },
                    { "S-DX10", "Room", 3, 4, true, 2 },
                    { "S-DX11", "Room", 3, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "Discriminator", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "S-DX12", "Room", 3, 4, true, 2 },
                    { "S-DX13", "Room", 3, 4, true, 2 },
                    { "S-DX14", "Room", 3, 4, true, 2 },
                    { "S-DX15", "Room", 3, 4, true, 2 },
                    { "S-DX16", "Room", 3, 4, true, 2 },
                    { "S-DX17", "Room", 3, 4, true, 2 },
                    { "S-DX18", "Room", 3, 4, true, 2 },
                    { "S-DX19", "Room", 3, 4, true, 2 },
                    { "S-DX20", "Room", 3, 4, true, 2 },
                    { "S-DX21", "Room", 3, 4, true, 2 },
                    { "S-DX22", "Room", 3, 4, true, 2 },
                    { "S-DX23", "Room", 3, 4, true, 2 },
                    { "S-DX24", "Room", 3, 4, true, 2 },
                    { "S-DX25", "Room", 3, 4, true, 2 },
                    { "S-EX01", "Room", 3, 2, true, 3 },
                    { "S-EX02", "Room", 3, 2, true, 3 },
                    { "S-EX03", "Room", 3, 2, true, 3 },
                    { "S-EX04", "Room", 3, 2, true, 3 },
                    { "S-EX05", "Room", 3, 2, true, 3 },
                    { "S-EX06", "Room", 3, 2, true, 3 },
                    { "S-EX07", "Room", 3, 2, true, 3 },
                    { "S-EX08", "Room", 3, 2, true, 3 },
                    { "S-EX09", "Room", 3, 2, true, 3 },
                    { "S-EX10", "Room", 3, 2, true, 3 },
                    { "S-PS01", "Room", 3, 1, true, 4 },
                    { "S-PS02", "Room", 3, 1, true, 4 },
                    { "S-PS03", "Room", 3, 1, true, 4 },
                    { "S-PS04", "Room", 3, 1, true, 4 },
                    { "S-PS05", "Room", 3, 1, true, 4 },
                    { "S-SD01", "Room", 3, 3, true, 2 },
                    { "S-SD02", "Room", 3, 3, true, 2 },
                    { "S-SD03", "Room", 3, 3, true, 2 },
                    { "S-SD04", "Room", 3, 3, true, 2 },
                    { "S-SD05", "Room", 3, 3, true, 2 },
                    { "S-SD06", "Room", 3, 3, true, 2 },
                    { "S-SD07", "Room", 3, 3, true, 2 },
                    { "S-SD08", "Room", 3, 3, true, 2 },
                    { "S-SD09", "Room", 3, 3, true, 2 },
                    { "S-SD10", "Room", 3, 3, true, 2 },
                    { "S-SD11", "Room", 3, 3, true, 2 },
                    { "S-SD12", "Room", 3, 3, true, 2 },
                    { "S-SD13", "Room", 3, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "Discriminator", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "S-SD14", "Room", 3, 3, true, 2 },
                    { "S-SD15", "Room", 3, 3, true, 2 },
                    { "S-SD16", "Room", 3, 3, true, 2 },
                    { "S-SD17", "Room", 3, 3, true, 2 },
                    { "S-SD18", "Room", 3, 3, true, 2 },
                    { "S-SD19", "Room", 3, 3, true, 2 },
                    { "S-SD20", "Room", 3, 3, true, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_CouponId",
                table: "bookings",
                column: "CouponId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_discountCoupons_CouponId",
                table: "bookings",
                column: "CouponId",
                principalTable: "discountCoupons",
                principalColumn: "CouponId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
