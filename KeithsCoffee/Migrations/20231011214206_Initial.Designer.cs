﻿// <auto-generated />
using System;
using KeithsCoffee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KeithsCoffee.Migrations
{
    [DbContext(typeof(KeithsCoffeeContext))]
    [Migration("20231011214206_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KeithsCoffee.Models.CoffeeShop", b =>
                {
                    b.Property<int>("CoffeeShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("PriceRange")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("Unionized")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CoffeeShopId");

                    b.ToTable("CoffeeShops");
                });

            modelBuilder.Entity("KeithsCoffee.Models.CoffeeShopDrink", b =>
                {
                    b.Property<int>("CoffeeShopDrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CoffeeShopId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfReview")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DrinkId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("CoffeeShopDrinkId");

                    b.HasIndex("CoffeeShopId");

                    b.HasIndex("DrinkId");

                    b.ToTable("CoffeeShopDrinks");
                });

            modelBuilder.Entity("KeithsCoffee.Models.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("DrinkId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("KeithsCoffee.Models.CoffeeShopDrink", b =>
                {
                    b.HasOne("KeithsCoffee.Models.CoffeeShop", "CoffeeShop")
                        .WithMany("JoinEntities")
                        .HasForeignKey("CoffeeShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeithsCoffee.Models.Drink", "Drink")
                        .WithMany("JoinEntities")
                        .HasForeignKey("DrinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoffeeShop");

                    b.Navigation("Drink");
                });

            modelBuilder.Entity("KeithsCoffee.Models.CoffeeShop", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("KeithsCoffee.Models.Drink", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}