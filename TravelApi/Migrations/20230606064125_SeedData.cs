using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Reviews",
                newName: "Comment");

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Description", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Small town", "Eagleland", "Onett" },
                    { 2, "Big town", "Eagleland", "Twoson" },
                    { 3, "Quirky", "Dreamland", "Magicant" },
                    { 4, "Rural village", "Chommo", "Dalaam" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "Date", "DestinationId", "Rating" },
                values: new object[,]
                {
                    { 1, "Kind of boring", new DateTime(2023, 6, 5, 23, 41, 25, 230, DateTimeKind.Local).AddTicks(1748), 1, 8 },
                    { 2, "cool place", new DateTime(2023, 6, 5, 23, 41, 25, 230, DateTimeKind.Local).AddTicks(1780), 2, 5 },
                    { 3, "Weird", new DateTime(2023, 6, 5, 23, 41, 25, 230, DateTimeKind.Local).AddTicks(1782), 3, 6 },
                    { 4, "good vibes", new DateTime(2023, 6, 5, 23, 41, 25, 230, DateTimeKind.Local).AddTicks(1784), 4, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Reviews",
                newName: "Content");
        }
    }
}
