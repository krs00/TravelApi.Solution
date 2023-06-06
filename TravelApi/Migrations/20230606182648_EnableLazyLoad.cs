using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class EnableLazyLoad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 6, 6, 11, 26, 48, 89, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 6, 6, 11, 26, 48, 89, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 6, 6, 11, 26, 48, 89, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 6, 11, 26, 48, 89, DateTimeKind.Local).AddTicks(6050));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 6, 5, 23, 41, 25, 230, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 6, 5, 23, 41, 25, 230, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 6, 5, 23, 41, 25, 230, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 5, 23, 41, 25, 230, DateTimeKind.Local).AddTicks(1784));
        }
    }
}
