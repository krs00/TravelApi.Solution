﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20230606220925_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Portland",
                            Country = "USA",
                            Description = "A programming school",
                            Name = "Epicodus"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "Portland",
                            Country = "USA",
                            Description = "City center",
                            Name = "Pioneer Square"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Portland",
                            Country = "USA",
                            Description = "City Park",
                            Name = "Council Crest"
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "Tokyo",
                            Country = "Japan",
                            Description = "Pedestrian Scramble",
                            Name = "Shibuya Crossing"
                        },
                        new
                        {
                            DestinationId = 5,
                            City = "Tokyo",
                            Country = "Japan",
                            Description = "Lookout Point",
                            Name = "Tokyo Tower"
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            DestinationId = 3,
                            Message = "Cool spot!",
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 2,
                            DestinationId = 3,
                            Message = "Rad CounCil!!",
                            Rating = 8
                        },
                        new
                        {
                            ReviewId = 3,
                            DestinationId = 1,
                            Message = "Cool spot Epicodus!",
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 4,
                            DestinationId = 1,
                            Message = "Cool Code!!",
                            Rating = 5
                        });
                });

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.HasOne("TravelApi.Models.Destination", null)
                        .WithMany("Reviews")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}