using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkView.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "temporaryData",
                columns: table => new
                {
                    TemporaryDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    checkin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    checkout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hotel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_temporaryData", x => x.TemporaryDataId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "temporaryData");
        }
    }
}
