﻿// <auto-generated />
using InternetShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IntertShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250326143117_AddProduct")]
    partial class AddProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InternetShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderDisplay")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action",
                            OrderDisplay = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sci-Fi",
                            OrderDisplay = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "History",
                            OrderDisplay = 3
                        });
                });

            modelBuilder.Entity("InternetShop.Models.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Jon Skeet",
                            Description = "Guide to C#",
                            Price = 5999.0,
                            Title = "C# in Depth"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Robert Martin",
                            Description = "Best practies for writing code",
                            Price = 9999.0,
                            Title = "Clean Code"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
