﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Data;

namespace StoreApp.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoreApp.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("OrderTime");

                    b.Property<double>("Total");

                    b.Property<int>("UserID");

                    b.HasKey("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("StoreApp.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<int?>("OrderDetailsOrderID");

                    b.Property<double>("Price");

                    b.Property<string>("ProductName");

                    b.Property<string>("ProductType");

                    b.Property<int>("SupplierID");

                    b.HasKey("ID");

                    b.HasIndex("OrderDetailsOrderID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StoreApp.Models.StorageProducts", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<DateTime>("LastOrder");

                    b.Property<string>("ProductName");

                    b.Property<int?>("SupplierID");

                    b.HasKey("ProductID");

                    b.HasIndex("SupplierID");

                    b.ToTable("StorageProducts");
                });

            modelBuilder.Entity("StoreApp.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CompanyName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("StoreApp.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LastName");

                    b.Property<string>("Mail");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StoreApp.Models.Product", b =>
                {
                    b.HasOne("StoreApp.Models.OrderDetails")
                        .WithMany("Cart")
                        .HasForeignKey("OrderDetailsOrderID");

                    b.HasOne("StoreApp.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StoreApp.Models.StorageProducts", b =>
                {
                    b.HasOne("StoreApp.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID");
                });
#pragma warning restore 612, 618
        }
    }
}
