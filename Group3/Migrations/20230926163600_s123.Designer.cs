﻿// <auto-generated />
using System;
using Group3.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Group3.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230926163600_s123")]
    partial class s123
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lib.Blogs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDay")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Lib.BrandMst", b =>
                {
                    b.Property<string>("Brand_ID")
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Brand_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Brand_ID");

                    b.ToTable("BrandMst");
                });

            modelBuilder.Entity("Lib.CatMst", b =>
                {
                    b.Property<string>("Cat_ID")
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Cat_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Cat_ID");

                    b.ToTable("CatMst");
                });

            modelBuilder.Entity("Lib.CertifyMst", b =>
                {
                    b.Property<string>("Certify_ID")
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Certify_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Certify_ID");

                    b.ToTable("CertifyMst");
                });

            modelBuilder.Entity("Lib.DimInfoMst", b =>
                {
                    b.Property<string>("DimID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimCrt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimImg")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimPrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimSubType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimID");

                    b.ToTable("DimInfoMst");
                });

            modelBuilder.Entity("Lib.DimMst", b =>
                {
                    b.Property<int>("DimMst_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DimMst_ID"));

                    b.Property<string>("DimQlty_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimSubType_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Dim_Amt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Crt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Gm")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Pcs")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Rate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Size")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Style_Code")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("DimMst_ID");

                    b.HasIndex("DimQlty_ID");

                    b.HasIndex("DimSubType_ID");

                    b.HasIndex("Style_Code");

                    b.ToTable("DimMst");
                });

            modelBuilder.Entity("Lib.DimQltyMst", b =>
                {
                    b.Property<string>("DimQlty_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimQlty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimQlty_ID");

                    b.ToTable("DimQltyMst");
                });

            modelBuilder.Entity("Lib.DimQltySubMst", b =>
                {
                    b.Property<string>("DimSubType_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimQlty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimSubType_ID");

                    b.ToTable("DimQltySubMst");
                });

            modelBuilder.Entity("Lib.GoldKrtMst", b =>
                {
                    b.Property<string>("GoldType_ID")
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Gold_Crt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GoldType_ID");

                    b.ToTable("GoldKrtMst");
                });

            modelBuilder.Entity("Lib.ItemMst", b =>
                {
                    b.Property<string>("Style_Code")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Brand_ID")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Cat_ID")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Certify_ID")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("GoldType_ID")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<decimal>("Gold_Amt")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Gold_Making")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Gold_Rate")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Gold_Wt")
                        .HasColumnType("numeric(10,3)");

                    b.Property<decimal>("MRP")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Net_Gold")
                        .HasColumnType("numeric(10,3)");

                    b.Property<decimal>("Other_Making")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Pairs")
                        .HasColumnType("numeric(3,0)");

                    b.Property<string>("Prod_ID")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Prod_Quality")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric(18,0)");

                    b.Property<decimal>("Stone_Making")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Stone_Wt")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Tot_Gross_Wt")
                        .HasColumnType("numeric(10,3)");

                    b.Property<decimal>("Tot_Making")
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Wstg")
                        .HasColumnType("numeric(10,3)");

                    b.Property<decimal>("Wstg_Per")
                        .HasColumnType("numeric(10,3)");

                    b.HasKey("Style_Code");

                    b.HasIndex("Brand_ID");

                    b.HasIndex("Cat_ID");

                    b.HasIndex("Certify_ID");

                    b.HasIndex("GoldType_ID");

                    b.HasIndex("Prod_ID");

                    b.ToTable("ItemMst");
                });

            modelBuilder.Entity("Lib.JewelTypeMst", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Jewellery_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("JewelTypeMst");
                });

            modelBuilder.Entity("Lib.ProdMst", b =>
                {
                    b.Property<string>("Prod_ID")
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Prod_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Prod_ID");

                    b.ToTable("ProdMst");
                });

            modelBuilder.Entity("Lib.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand_ID")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Cat_ID")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Size_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Brand_ID");

                    b.HasIndex("Cat_ID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Lib.StoneMst", b =>
                {
                    b.Property<int>("StoneMst_ID")
                        .HasColumnType("int");

                    b.Property<string>("StoneQlty_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Stone_Amt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Crt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Gm")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Pcs")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Rate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Style_Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("StoneMst_ID");

                    b.HasIndex("StoneQlty_ID");

                    b.HasIndex("Style_Code");

                    b.ToTable("StoneMst");
                });

            modelBuilder.Entity("Lib.StoneQltyMst", b =>
                {
                    b.Property<string>("StoneQlty_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StoneQlty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StoneQlty_ID");

                    b.ToTable("StoneQltyMst");
                });

            modelBuilder.Entity("Lib.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Role")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "",
                            Email = "superadmin@gmail.com",
                            Password = "123",
                            PhoneNumber = "",
                            Role = true,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Address = "",
                            Email = "supertest@gmail.com",
                            Password = "123",
                            PhoneNumber = "",
                            Role = false,
                            Username = "test"
                        });
                });

            modelBuilder.Entity("Lib.DimMst", b =>
                {
                    b.HasOne("Lib.DimQltyMst", "DiamondQuality")
                        .WithMany()
                        .HasForeignKey("DimQlty_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.DimQltySubMst", "DimQualitySubType")
                        .WithMany()
                        .HasForeignKey("DimSubType_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.ItemMst", "Item")
                        .WithMany("Dimensions")
                        .HasForeignKey("Style_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiamondQuality");

                    b.Navigation("DimQualitySubType");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Lib.ItemMst", b =>
                {
                    b.HasOne("Lib.BrandMst", "Brand")
                        .WithMany()
                        .HasForeignKey("Brand_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.CatMst", "Category")
                        .WithMany()
                        .HasForeignKey("Cat_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.CertifyMst", "Certify")
                        .WithMany()
                        .HasForeignKey("Certify_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.GoldKrtMst", "GoldCarat")
                        .WithMany()
                        .HasForeignKey("GoldType_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.ProdMst", "Product")
                        .WithMany()
                        .HasForeignKey("Prod_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Certify");

                    b.Navigation("GoldCarat");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lib.Product", b =>
                {
                    b.HasOne("Lib.BrandMst", "brandMst")
                        .WithMany("products")
                        .HasForeignKey("Brand_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.CatMst", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Cat_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("brandMst");
                });

            modelBuilder.Entity("Lib.StoneMst", b =>
                {
                    b.HasOne("Lib.StoneQltyMst", "StoneQuality")
                        .WithMany()
                        .HasForeignKey("StoneQlty_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lib.ItemMst", "Item")
                        .WithMany()
                        .HasForeignKey("Style_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("StoneQuality");
                });

            modelBuilder.Entity("Lib.BrandMst", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Lib.CatMst", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Lib.ItemMst", b =>
                {
                    b.Navigation("Dimensions");
                });
#pragma warning restore 612, 618
        }
    }
}