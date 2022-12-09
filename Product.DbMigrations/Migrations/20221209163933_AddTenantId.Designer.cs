﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Product.DbMigrations;

#nullable disable

namespace Product.DbMigrations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221209163933_AddTenantId")]
    partial class AddTenantId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Product.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<long>("LotNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<string>("UniqueId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitOfMeasure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Product.Models.ItemObjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentItemId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ItemObjects");
                });

            modelBuilder.Entity("Product.Models.ItemObjects", b =>
                {
                    b.HasOne("Product.Models.Item", "ParentItem")
                        .WithMany()
                        .HasForeignKey("ParentProductId");

                    b.HasOne("Product.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Item");

                    b.Navigation("ParentItem");
                });
#pragma warning restore 612, 618
        }
    }
}
