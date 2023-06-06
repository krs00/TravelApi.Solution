﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class AddInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                })
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

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Portland", "USA", "A programming school", "Epicodus" },
                    { 2, "Portland", "USA", "City center", "Pioneer Square" },
                    { 3, "Portland", "USA", "City Park", "Council Crest" },
                    { 4, "Tokyo", "Japan", "Pedestrian Scramble", "Shibuya Crossing" },
                    { 5, "Tokyo", "Japan", "Lookout Point", "Tokyo Tower" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name" },
                values: new object[,]
                {
                    { 1, "Kymani" },
                    { 2, "Qayden" },
                    { 3, "Renee" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Date", "DestinationId", "Message", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 6, 14, 4, 45, 581, DateTimeKind.Local).AddTicks(9110), 1, "Cool spot!", 5, 2 },
                    { 2, new DateTime(2023, 6, 6, 14, 4, 45, 581, DateTimeKind.Local).AddTicks(9150), 4, "Very Busy Place!", 7, 3 },
                    { 3, new DateTime(2023, 6, 6, 14, 4, 45, 581, DateTimeKind.Local).AddTicks(9150), 3, "Woah nice views!", 10, 2 },
                    { 4, new DateTime(2023, 6, 6, 14, 4, 45, 581, DateTimeKind.Local).AddTicks(9150), 1, "A good place to learn how to program", 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_DestinationId",
                table: "Reviews",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}