﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task_Test.WebUI.Entity;

namespace Task_Test.WebUI.Migrations.MainDb
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20200205192219_Initi")]
    partial class Initi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Task_Test.WebUI.Entity.Arrival", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Arrivals");
                });

            modelBuilder.Entity("Task_Test.WebUI.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Task_Test.WebUI.Entity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Task_Test.WebUI.Entity.Departrue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Departrues");
                });

            modelBuilder.Entity("Task_Test.WebUI.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArrivalId");

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime?>("Datetime");

                    b.Property<int>("Departrueid");

                    b.Property<int?>("Kg");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<int?>("Stok");

                    b.HasKey("Id");

                    b.HasIndex("ArrivalId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Departrueid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Task_Test.WebUI.Entity.Product", b =>
                {
                    b.HasOne("Task_Test.WebUI.Entity.Arrival", "Arrival")
                        .WithMany("Products")
                        .HasForeignKey("ArrivalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Task_Test.WebUI.Entity.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Task_Test.WebUI.Entity.Departrue", "Departrue")
                        .WithMany("Products")
                        .HasForeignKey("Departrueid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
