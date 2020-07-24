﻿// <auto-generated />
using System;
using ArApiProvider.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArApiProvider.Migrations
{
    [DbContext(typeof(RoomsDbContext))]
    partial class RoomsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArApiProvider.Models.RoomPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RoomPlans");
                });

            modelBuilder.Entity("ArApiProvider.Models.WallBlock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("PositionX")
                        .HasColumnType("float");

                    b.Property<double>("PositionY")
                        .HasColumnType("float");

                    b.Property<int?>("RoomPlanId")
                        .HasColumnType("int");

                    b.Property<int>("Rotation")
                        .HasColumnType("int");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("RoomPlanId");

                    b.ToTable("WallBlocks");
                });

            modelBuilder.Entity("ArApiProvider.Models.WallBlock", b =>
                {
                    b.HasOne("ArApiProvider.Models.RoomPlan", null)
                        .WithMany("WallBlocks")
                        .HasForeignKey("RoomPlanId");
                });
#pragma warning restore 612, 618
        }
    }
}
