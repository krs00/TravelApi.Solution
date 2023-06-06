using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class RevertToInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 6, 6, 12, 55, 41, 710, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 6, 6, 12, 55, 41, 710, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 6, 6, 12, 55, 41, 710, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 6, 6, 12, 55, 41, 710, DateTimeKind.Local).AddTicks(630));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
