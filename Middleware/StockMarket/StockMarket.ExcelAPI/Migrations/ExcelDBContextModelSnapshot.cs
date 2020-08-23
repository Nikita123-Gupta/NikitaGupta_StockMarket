﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMarket.ExcelAPI.DBAcess;

namespace StockMarket.ExcelAPI.Migrations
{
    [DbContext(typeof(ExcelDBContext))]
    partial class ExcelDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockMarket.ExcelAPI.Models.Company", b =>
                {
                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("CEO")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("CompanyCode");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("StockMarket.ExcelAPI.Models.StockPrice", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<string>("StockExchange")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RowId");

                    b.HasIndex("CompanyCode");

                    b.ToTable("StockPrice");
                });

            modelBuilder.Entity("StockMarket.ExcelAPI.Models.StockPrice", b =>
                {
                    b.HasOne("StockMarket.ExcelAPI.Models.Company", "Company")
                        .WithMany("StockPrices")
                        .HasForeignKey("CompanyCode");
                });
#pragma warning restore 612, 618
        }
    }
}
