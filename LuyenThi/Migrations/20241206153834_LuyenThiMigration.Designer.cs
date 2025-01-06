﻿// <auto-generated />
using System;
using LuyenThi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LuyenThi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241206153834_LuyenThiMigration")]
    partial class LuyenThiMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LuyenThi.Models.DonHang", b =>
                {
                    b.Property<string>("MaDonHang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("KhachHangsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayDatHang")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenDonHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDonHang");

                    b.HasIndex("KhachHangsId");

                    b.ToTable("DonHangs");
                });

            modelBuilder.Entity("LuyenThi.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("LuyenThi.Models.DonHang", b =>
                {
                    b.HasOne("LuyenThi.Models.KhachHang", "KhachHangs")
                        .WithMany("DonHangs")
                        .HasForeignKey("KhachHangsId");

                    b.Navigation("KhachHangs");
                });

            modelBuilder.Entity("LuyenThi.Models.KhachHang", b =>
                {
                    b.Navigation("DonHangs");
                });
#pragma warning restore 612, 618
        }
    }
}
