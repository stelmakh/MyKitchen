﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyKitchen.Data;

namespace MyKitchen.Migrations
{
    [DbContext(typeof(MyKitchenContext))]
    [Migration("20200419143701_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MyKitchen.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Calories")
                        .HasColumnType("REAL");

                    b.Property<float>("Carbs")
                        .HasColumnType("REAL");

                    b.Property<float>("Fats")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(250);

                    b.Property<float>("Protein")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
