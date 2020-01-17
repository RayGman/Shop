﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Data;

namespace Shop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20200116144644_ShopCart")]
    partial class ShopCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Data.Models.Categor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.Property<string>("desc");

                    b.HasKey("id");

                    b.ToTable("Categor");
                });

            modelBuilder.Entity("Shop.Data.Models.Light", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Categorid");

                    b.Property<bool>("available");

                    b.Property<int>("categoryID");

                    b.Property<string>("img");

                    b.Property<bool>("isFavourite");

                    b.Property<string>("longDesc");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDesc");

                    b.HasKey("id");

                    b.HasIndex("Categorid");

                    b.ToTable("Light");
                });

            modelBuilder.Entity("Shop.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartId");

                    b.Property<int?>("lightid");

                    b.Property<int>("price");

                    b.HasKey("id");

                    b.HasIndex("lightid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("Shop.Data.Models.Light", b =>
                {
                    b.HasOne("Shop.Data.Models.Categor", "Categor")
                        .WithMany("light")
                        .HasForeignKey("Categorid");
                });

            modelBuilder.Entity("Shop.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("Shop.Data.Models.Light", "light")
                        .WithMany()
                        .HasForeignKey("lightid");
                });
#pragma warning restore 612, 618
        }
    }
}
