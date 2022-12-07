﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurenManage.Data;

#nullable disable

namespace RestaurenManage.Migrations
{
    [DbContext(typeof(RmanageContext))]
    [Migration("20221206070748_update")]
    partial class update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurenManage.Model.CartModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tablepos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("foodname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("foodprice")
                        .HasColumnType("int");

                    b.Property<int>("person")
                        .HasColumnType("int");

                    b.Property<int>("tableid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartModel");
                });

            modelBuilder.Entity("RestaurenManage.Model.FoodModel", b =>
                {
                    b.Property<int>("Foodid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Foodid"));

                    b.Property<string>("Couantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foodimg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<bool?>("avail")
                        .HasColumnType("bit");

                    b.HasKey("Foodid");

                    b.ToTable("FoodModel");
                });

            modelBuilder.Entity("RestaurenManage.Model.LoginModel", b =>
                {
                    b.Property<string>("LoginID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("RememberMe")
                        .HasColumnType("bit");

                    b.HasKey("LoginID");

                    b.ToTable("LoginModel");
                });

            modelBuilder.Entity("RestaurenManage.Model.TableModel", b =>
                {
                    b.Property<int>("TabId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TabId"));

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TabName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TabId");

                    b.ToTable("TableModel");
                });
#pragma warning restore 612, 618
        }
    }
}
