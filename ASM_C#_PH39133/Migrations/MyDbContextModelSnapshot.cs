﻿// <auto-generated />
using System;
using ASM_C__PH39133.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASM_C__PH39133.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASM_C__PH39133.Models.Cart_detail", b =>
                {
                    b.Property<Guid>("IdGioHangCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdGioHang")
                        .HasMaxLength(100)
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdGioHangCT");

                    b.HasIndex("IdGioHang");

                    b.HasIndex("MaSP");

                    b.ToTable("GioHangCT");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Carts", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKH")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdGioHang");

                    b.HasIndex("IDKH")
                        .IsUnique();

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Categories", b =>
                {
                    b.Property<Guid>("IdDanhMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDanhMuc");

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Customers", b =>
                {
                    b.Property<Guid>("IdKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdKH");

                    b.HasIndex("DienThoai")
                        .IsUnique();

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Products", b =>
                {
                    b.Property<Guid>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMEI")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("IdDanhMuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaSP");

                    b.HasIndex("IMEI")
                        .IsUnique();

                    b.HasIndex("IdDanhMuc");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Cart_detail", b =>
                {
                    b.HasOne("ASM_C__PH39133.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("IdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM_C__PH39133.Models.Carts", "Carts")
                        .WithMany("Cart_Details")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carts");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Carts", b =>
                {
                    b.HasOne("ASM_C__PH39133.Models.Customers", "Customers")
                        .WithOne("Carts")
                        .HasForeignKey("ASM_C__PH39133.Models.Carts", "IDKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Products", b =>
                {
                    b.HasOne("ASM_C__PH39133.Models.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("IdDanhMuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Carts", b =>
                {
                    b.Navigation("Cart_Details");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ASM_C__PH39133.Models.Customers", b =>
                {
                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
