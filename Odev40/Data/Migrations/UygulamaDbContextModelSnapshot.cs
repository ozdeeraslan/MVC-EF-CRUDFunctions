﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Odev40.Data;

#nullable disable

namespace Odev40.Data.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    partial class UygulamaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Odev40.Data.Oyun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TekPlatform")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Oyunlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "The Witcher 3: Wild Hunt",
                            TekPlatform = true
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Red Dead Redemption 2",
                            TekPlatform = false
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Cyberpunk 2077",
                            TekPlatform = true
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Assassin's Creed Valhalla",
                            TekPlatform = false
                        },
                        new
                        {
                            Id = 5,
                            Ad = "FIFA 22",
                            TekPlatform = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}