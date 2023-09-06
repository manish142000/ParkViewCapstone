using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "discountCoupons",
                columns: table => new
                {
                    CouponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discountCoupons", x => x.CouponId);
                });

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "roomCategories",
                columns: table => new
                {
                    RoomCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyRate = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomCategories", x => x.RoomCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_bookings_discountCoupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "discountCoupons",
                        principalColumn: "CouponId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookingCartItems",
                columns: table => new
                {
                    BookingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingCartId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomCategoryId = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingCartItems", x => x.BookingCartItemId);
                    table.ForeignKey(
                        name: "FK_bookingCartItems_roomCategories_RoomCategoryId",
                        column: x => x.RoomCategoryId,
                        principalTable: "roomCategories",
                        principalColumn: "RoomCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomCategoryId = table.Column<int>(type: "int", nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_rooms_hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "hotels",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rooms_roomCategories_RoomCategoryId",
                        column: x => x.RoomCategoryId,
                        principalTable: "roomCategories",
                        principalColumn: "RoomCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookingRooms",
                columns: table => new
                {
                    BookingRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingRooms", x => x.BookingRoomId);
                    table.ForeignKey(
                        name: "FK_bookingRooms_bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingRooms_rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "discountCoupons",
                columns: new[] { "CouponId", "CouponName", "DiscountAmount" },
                values: new object[] { 1, "DEALSFORU", 10 });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "HotelId", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Ooty", "ParkView Ooty" },
                    { 2, "Darjeeling", "ParkView Darjeeling" },
                    { 3, "Shimla", "ParkView Shimla" },
                    { 4, "Manali", "ParkView Manali" },
                    { 5, "Coorg", "ParkView Coorg" }
                });

            migrationBuilder.InsertData(
                table: "roomCategories",
                columns: new[] { "RoomCategoryId", "CategoryName", "DailyRate", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "Presidential Suite", 28000, "~/images/presidential-suite.jpg" },
                    { 2, "Executive", 20000, "~/images/executive.jpg" },
                    { 3, "Super Deluxe", 14000, "~/images/super-deluxe.jpg" },
                    { 4, "Deluxe", 8000, "~/images/deluxe.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "bookings",
                columns: new[] { "BookingId", "CheckInDate", "CheckOutDate", "CouponId", "TotalCost", "UserEmail" },
                values: new object[] { 1, new DateTime(2023, 9, 15, 13, 45, 30, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 13, 45, 30, 0, DateTimeKind.Unspecified), 1, 0.0, "testuser123@gmail.com" });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "C-DX01", 5, 4, true, 2 },
                    { "C-DX02", 5, 4, true, 2 },
                    { "C-DX03", 5, 4, true, 2 },
                    { "C-DX04", 5, 4, true, 2 },
                    { "C-DX05", 5, 4, true, 2 },
                    { "C-DX06", 5, 4, true, 2 },
                    { "C-DX07", 5, 4, true, 2 },
                    { "C-DX08", 5, 4, true, 2 },
                    { "C-DX09", 5, 4, true, 2 },
                    { "C-DX10", 5, 4, true, 2 },
                    { "C-DX11", 5, 4, true, 2 },
                    { "C-DX12", 5, 4, true, 2 },
                    { "C-DX13", 5, 4, true, 2 },
                    { "C-DX14", 5, 4, true, 2 },
                    { "C-DX15", 5, 4, true, 2 },
                    { "C-DX16", 5, 4, true, 2 },
                    { "C-DX17", 5, 4, true, 2 },
                    { "C-DX18", 5, 4, true, 2 },
                    { "C-DX19", 5, 4, true, 2 },
                    { "C-DX20", 5, 4, true, 2 },
                    { "C-DX21", 5, 4, true, 2 },
                    { "C-DX22", 5, 4, true, 2 },
                    { "C-DX23", 5, 4, true, 2 },
                    { "C-DX24", 5, 4, true, 2 },
                    { "C-DX25", 5, 4, true, 2 },
                    { "C-EX01", 5, 2, true, 3 },
                    { "C-EX02", 5, 2, true, 3 },
                    { "C-EX03", 5, 2, true, 3 },
                    { "C-EX04", 5, 2, true, 3 },
                    { "C-EX05", 5, 2, true, 3 },
                    { "C-EX06", 5, 2, true, 3 },
                    { "C-EX07", 5, 2, true, 3 },
                    { "C-EX08", 5, 2, true, 3 },
                    { "C-EX09", 5, 2, true, 3 },
                    { "C-EX10", 5, 2, true, 3 },
                    { "C-PS01", 5, 1, true, 4 },
                    { "C-PS02", 5, 1, true, 4 },
                    { "C-PS03", 5, 1, true, 4 },
                    { "C-PS04", 5, 1, true, 4 },
                    { "C-PS05", 5, 1, true, 4 },
                    { "C-SD01", 5, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "C-SD02", 5, 3, true, 2 },
                    { "C-SD03", 5, 3, true, 2 },
                    { "C-SD04", 5, 3, true, 2 },
                    { "C-SD05", 5, 3, true, 2 },
                    { "C-SD06", 5, 3, true, 2 },
                    { "C-SD07", 5, 3, true, 2 },
                    { "C-SD08", 5, 3, true, 2 },
                    { "C-SD09", 5, 3, true, 2 },
                    { "C-SD10", 5, 3, true, 2 },
                    { "C-SD11", 5, 3, true, 2 },
                    { "C-SD12", 5, 3, true, 2 },
                    { "C-SD13", 5, 3, true, 2 },
                    { "C-SD14", 5, 3, true, 2 },
                    { "C-SD15", 5, 3, true, 2 },
                    { "C-SD16", 5, 3, true, 2 },
                    { "C-SD17", 5, 3, true, 2 },
                    { "C-SD18", 5, 3, true, 2 },
                    { "C-SD19", 5, 3, true, 2 },
                    { "C-SD20", 5, 3, true, 2 },
                    { "D-DX01", 2, 4, true, 2 },
                    { "D-DX02", 2, 4, true, 2 },
                    { "D-DX03", 2, 4, true, 2 },
                    { "D-DX04", 2, 4, true, 2 },
                    { "D-DX05", 2, 4, true, 2 },
                    { "D-DX06", 2, 4, true, 2 },
                    { "D-DX07", 2, 4, true, 2 },
                    { "D-DX08", 2, 4, true, 2 },
                    { "D-DX09", 2, 4, true, 2 },
                    { "D-DX10", 2, 4, true, 2 },
                    { "D-DX11", 2, 4, true, 2 },
                    { "D-DX12", 2, 4, true, 2 },
                    { "D-DX13", 2, 4, true, 2 },
                    { "D-DX14", 2, 4, true, 2 },
                    { "D-DX15", 2, 4, true, 2 },
                    { "D-DX16", 2, 4, true, 2 },
                    { "D-DX17", 2, 4, true, 2 },
                    { "D-DX18", 2, 4, true, 2 },
                    { "D-DX19", 2, 4, true, 2 },
                    { "D-DX20", 2, 4, true, 2 },
                    { "D-DX21", 2, 4, true, 2 },
                    { "D-DX22", 2, 4, true, 2 },
                    { "D-DX23", 2, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "D-DX24", 2, 4, true, 2 },
                    { "D-DX25", 2, 4, true, 2 },
                    { "D-EX01", 2, 2, true, 3 },
                    { "D-EX02", 2, 2, true, 3 },
                    { "D-EX03", 2, 2, true, 3 },
                    { "D-EX04", 2, 2, true, 3 },
                    { "D-EX05", 2, 2, true, 3 },
                    { "D-EX06", 2, 2, true, 3 },
                    { "D-EX07", 2, 2, true, 3 },
                    { "D-EX08", 2, 2, true, 3 },
                    { "D-EX09", 2, 2, true, 3 },
                    { "D-EX10", 2, 2, true, 3 },
                    { "D-PS01", 2, 1, true, 4 },
                    { "D-PS02", 2, 1, true, 4 },
                    { "D-PS03", 2, 1, true, 4 },
                    { "D-PS04", 2, 1, true, 4 },
                    { "D-PS05", 2, 1, true, 4 },
                    { "D-SD01", 2, 3, true, 2 },
                    { "D-SD02", 2, 3, true, 2 },
                    { "D-SD03", 2, 3, true, 2 },
                    { "D-SD04", 2, 3, true, 2 },
                    { "D-SD05", 2, 3, true, 2 },
                    { "D-SD06", 2, 3, true, 2 },
                    { "D-SD07", 2, 3, true, 2 },
                    { "D-SD08", 2, 3, true, 2 },
                    { "D-SD09", 2, 3, true, 2 },
                    { "D-SD10", 2, 3, true, 2 },
                    { "D-SD11", 2, 3, true, 2 },
                    { "D-SD12", 2, 3, true, 2 },
                    { "D-SD13", 2, 3, true, 2 },
                    { "D-SD14", 2, 3, true, 2 },
                    { "D-SD15", 2, 3, true, 2 },
                    { "D-SD16", 2, 3, true, 2 },
                    { "D-SD17", 2, 3, true, 2 },
                    { "D-SD18", 2, 3, true, 2 },
                    { "D-SD19", 2, 3, true, 2 },
                    { "D-SD20", 2, 3, true, 2 },
                    { "M-DX01", 4, 4, true, 2 },
                    { "M-DX02", 4, 4, true, 2 },
                    { "M-DX03", 4, 4, true, 2 },
                    { "M-DX04", 4, 4, true, 2 },
                    { "M-DX05", 4, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "M-DX06", 4, 4, true, 2 },
                    { "M-DX07", 4, 4, true, 2 },
                    { "M-DX08", 4, 4, true, 2 },
                    { "M-DX09", 4, 4, true, 2 },
                    { "M-DX10", 4, 4, true, 2 },
                    { "M-DX11", 4, 4, true, 2 },
                    { "M-DX12", 4, 4, true, 2 },
                    { "M-DX13", 4, 4, true, 2 },
                    { "M-DX14", 4, 4, true, 2 },
                    { "M-DX15", 4, 4, true, 2 },
                    { "M-DX16", 4, 4, true, 2 },
                    { "M-DX17", 4, 4, true, 2 },
                    { "M-DX18", 4, 4, true, 2 },
                    { "M-DX19", 4, 4, true, 2 },
                    { "M-DX20", 4, 4, true, 2 },
                    { "M-DX21", 4, 4, true, 2 },
                    { "M-DX22", 4, 4, true, 2 },
                    { "M-DX23", 4, 4, true, 2 },
                    { "M-DX24", 4, 4, true, 2 },
                    { "M-DX25", 4, 4, true, 2 },
                    { "M-EX01", 4, 2, true, 3 },
                    { "M-EX02", 4, 2, true, 3 },
                    { "M-EX03", 4, 2, true, 3 },
                    { "M-EX04", 4, 2, true, 3 },
                    { "M-EX05", 4, 2, true, 3 },
                    { "M-EX06", 4, 2, true, 3 },
                    { "M-EX07", 4, 2, true, 3 },
                    { "M-EX08", 4, 2, true, 3 },
                    { "M-EX09", 4, 2, true, 3 },
                    { "M-EX10", 4, 2, true, 3 },
                    { "M-PS01", 4, 1, true, 4 },
                    { "M-PS02", 4, 1, true, 4 },
                    { "M-PS03", 4, 1, true, 4 },
                    { "M-PS04", 4, 1, true, 4 },
                    { "M-PS05", 4, 1, true, 4 },
                    { "M-SD01", 4, 3, true, 2 },
                    { "M-SD02", 4, 3, true, 2 },
                    { "M-SD03", 4, 3, true, 2 },
                    { "M-SD04", 4, 3, true, 2 },
                    { "M-SD05", 4, 3, true, 2 },
                    { "M-SD06", 4, 3, true, 2 },
                    { "M-SD07", 4, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "M-SD08", 4, 3, true, 2 },
                    { "M-SD09", 4, 3, true, 2 },
                    { "M-SD10", 4, 3, true, 2 },
                    { "M-SD11", 4, 3, true, 2 },
                    { "M-SD12", 4, 3, true, 2 },
                    { "M-SD13", 4, 3, true, 2 },
                    { "M-SD14", 4, 3, true, 2 },
                    { "M-SD15", 4, 3, true, 2 },
                    { "M-SD16", 4, 3, true, 2 },
                    { "M-SD17", 4, 3, true, 2 },
                    { "M-SD18", 4, 3, true, 2 },
                    { "M-SD19", 4, 3, true, 2 },
                    { "M-SD20", 4, 3, true, 2 },
                    { "O-DX01", 1, 4, true, 2 },
                    { "O-DX02", 1, 4, true, 2 },
                    { "O-DX03", 1, 4, true, 2 },
                    { "O-DX04", 1, 4, true, 2 },
                    { "O-DX05", 1, 4, true, 2 },
                    { "O-DX06", 1, 4, true, 2 },
                    { "O-DX07", 1, 4, true, 2 },
                    { "O-DX08", 1, 4, true, 2 },
                    { "O-DX09", 1, 4, true, 2 },
                    { "O-DX10", 1, 4, true, 2 },
                    { "O-DX11", 1, 4, true, 2 },
                    { "O-DX12", 1, 4, true, 2 },
                    { "O-DX13", 1, 4, true, 2 },
                    { "O-DX14", 1, 4, true, 2 },
                    { "O-DX15", 1, 4, true, 2 },
                    { "O-DX16", 1, 4, true, 2 },
                    { "O-DX17", 1, 4, true, 2 },
                    { "O-DX18", 1, 4, true, 2 },
                    { "O-DX19", 1, 4, true, 2 },
                    { "O-DX20", 1, 4, true, 2 },
                    { "O-DX21", 1, 4, true, 2 },
                    { "O-DX22", 1, 4, true, 2 },
                    { "O-DX23", 1, 4, true, 2 },
                    { "O-DX24", 1, 4, true, 2 },
                    { "O-DX25", 1, 4, true, 2 },
                    { "O-EX01", 1, 2, true, 3 },
                    { "O-EX02", 1, 2, true, 3 },
                    { "O-EX03", 1, 2, true, 3 },
                    { "O-EX04", 1, 2, true, 3 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "O-EX05", 1, 2, true, 3 },
                    { "O-EX06", 1, 2, true, 3 },
                    { "O-EX07", 1, 2, true, 3 },
                    { "O-EX08", 1, 2, true, 3 },
                    { "O-EX09", 1, 2, true, 3 },
                    { "O-EX10", 1, 2, true, 3 },
                    { "O-PS01", 1, 1, true, 4 },
                    { "O-PS02", 1, 1, true, 4 },
                    { "O-PS03", 1, 1, true, 4 },
                    { "O-PS04", 1, 1, true, 4 },
                    { "O-PS05", 1, 1, true, 4 },
                    { "O-SD01", 1, 3, true, 2 },
                    { "O-SD02", 1, 3, true, 2 },
                    { "O-SD03", 1, 3, true, 2 },
                    { "O-SD04", 1, 3, true, 2 },
                    { "O-SD05", 1, 3, true, 2 },
                    { "O-SD06", 1, 3, true, 2 },
                    { "O-SD07", 1, 3, true, 2 },
                    { "O-SD08", 1, 3, true, 2 },
                    { "O-SD09", 1, 3, true, 2 },
                    { "O-SD10", 1, 3, true, 2 },
                    { "O-SD11", 1, 3, true, 2 },
                    { "O-SD12", 1, 3, true, 2 },
                    { "O-SD13", 1, 3, true, 2 },
                    { "O-SD14", 1, 3, true, 2 },
                    { "O-SD15", 1, 3, true, 2 },
                    { "O-SD16", 1, 3, true, 2 },
                    { "O-SD17", 1, 3, true, 2 },
                    { "O-SD18", 1, 3, true, 2 },
                    { "O-SD19", 1, 3, true, 2 },
                    { "O-SD20", 1, 3, true, 2 },
                    { "S-DX01", 3, 4, true, 2 },
                    { "S-DX02", 3, 4, true, 2 },
                    { "S-DX03", 3, 4, true, 2 },
                    { "S-DX04", 3, 4, true, 2 },
                    { "S-DX05", 3, 4, true, 2 },
                    { "S-DX06", 3, 4, true, 2 },
                    { "S-DX07", 3, 4, true, 2 },
                    { "S-DX08", 3, 4, true, 2 },
                    { "S-DX09", 3, 4, true, 2 },
                    { "S-DX10", 3, 4, true, 2 },
                    { "S-DX11", 3, 4, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "S-DX12", 3, 4, true, 2 },
                    { "S-DX13", 3, 4, true, 2 },
                    { "S-DX14", 3, 4, true, 2 },
                    { "S-DX15", 3, 4, true, 2 },
                    { "S-DX16", 3, 4, true, 2 },
                    { "S-DX17", 3, 4, true, 2 },
                    { "S-DX18", 3, 4, true, 2 },
                    { "S-DX19", 3, 4, true, 2 },
                    { "S-DX20", 3, 4, true, 2 },
                    { "S-DX21", 3, 4, true, 2 },
                    { "S-DX22", 3, 4, true, 2 },
                    { "S-DX23", 3, 4, true, 2 },
                    { "S-DX24", 3, 4, true, 2 },
                    { "S-DX25", 3, 4, true, 2 },
                    { "S-EX01", 3, 2, true, 3 },
                    { "S-EX02", 3, 2, true, 3 },
                    { "S-EX03", 3, 2, true, 3 },
                    { "S-EX04", 3, 2, true, 3 },
                    { "S-EX05", 3, 2, true, 3 },
                    { "S-EX06", 3, 2, true, 3 },
                    { "S-EX07", 3, 2, true, 3 },
                    { "S-EX08", 3, 2, true, 3 },
                    { "S-EX09", 3, 2, true, 3 },
                    { "S-EX10", 3, 2, true, 3 },
                    { "S-PS01", 3, 1, true, 4 },
                    { "S-PS02", 3, 1, true, 4 },
                    { "S-PS03", 3, 1, true, 4 },
                    { "S-PS04", 3, 1, true, 4 },
                    { "S-PS05", 3, 1, true, 4 },
                    { "S-SD01", 3, 3, true, 2 },
                    { "S-SD02", 3, 3, true, 2 },
                    { "S-SD03", 3, 3, true, 2 },
                    { "S-SD04", 3, 3, true, 2 },
                    { "S-SD05", 3, 3, true, 2 },
                    { "S-SD06", 3, 3, true, 2 },
                    { "S-SD07", 3, 3, true, 2 },
                    { "S-SD08", 3, 3, true, 2 },
                    { "S-SD09", 3, 3, true, 2 },
                    { "S-SD10", 3, 3, true, 2 },
                    { "S-SD11", 3, 3, true, 2 },
                    { "S-SD12", 3, 3, true, 2 },
                    { "S-SD13", 3, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "RoomId", "HotelId", "RoomCategoryId", "Status", "capacity" },
                values: new object[,]
                {
                    { "S-SD14", 3, 3, true, 2 },
                    { "S-SD15", 3, 3, true, 2 },
                    { "S-SD16", 3, 3, true, 2 },
                    { "S-SD17", 3, 3, true, 2 },
                    { "S-SD18", 3, 3, true, 2 },
                    { "S-SD19", 3, 3, true, 2 },
                    { "S-SD20", 3, 3, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "bookingRooms",
                columns: new[] { "BookingRoomId", "BookingId", "RoomId" },
                values: new object[] { 1, 1, "O-PS01" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_bookingCartItems_RoomCategoryId",
                table: "bookingCartItems",
                column: "RoomCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_bookingRooms_BookingId",
                table: "bookingRooms",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_bookingRooms_RoomId",
                table: "bookingRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_CouponId",
                table: "bookings",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_HotelId",
                table: "rooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_RoomCategoryId",
                table: "rooms",
                column: "RoomCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "bookingCartItems");

            migrationBuilder.DropTable(
                name: "bookingRooms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "discountCoupons");

            migrationBuilder.DropTable(
                name: "hotels");

            migrationBuilder.DropTable(
                name: "roomCategories");
        }
    }
}
