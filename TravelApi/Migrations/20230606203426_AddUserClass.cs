using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class AddUserClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Destinations",
                newName: "Country");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Destinations",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Destinations");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Reviews",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Destinations",
                newName: "Location");

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
                    { 1, "Kind of boring", new DateTime(2023, 6, 6, 12, 55, 41, 710, DateTimeKind.Local).AddTicks(580), 1, 8 },
                    { 2, "cool place", new DateTime(2023, 6, 6, 12, 55, 41, 710, DateTimeKind.Local).AddTicks(620), 2, 5 },
                    { 3, "Weird", new DateTime(2023, 6, 6, 12, 55, 41, 710, DateTimeKind.Local).AddTicks(630), 3, 6 },
                    { 4, "good vibes", new DateTime(2023, 6, 6, 12, 55, 41, 710, DateTimeKind.Local).AddTicks(630), 4, 5 }
                });
        }
    }
}
