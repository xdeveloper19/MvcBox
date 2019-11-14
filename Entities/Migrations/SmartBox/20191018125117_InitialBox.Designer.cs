﻿// <auto-generated />
using System;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations.SmartBox
{
    [DbContext(typeof(SmartBoxContext))]
    [Migration("20191018125117_InitialBox")]
    partial class InitialBox
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("Altitude")
                        .HasColumnType("float");

                    b.Property<Guid>("BoxId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SignalLevel")
                        .HasColumnType("float");

                    b.Property<Guid?>("SmartBoxId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SmartBoxId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Entities.Models.SmartBox", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("BatteryPower")
                        .HasColumnType("float");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOpenedBox")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOpenedDoor")
                        .HasColumnType("bit");

                    b.Property<int>("Light")
                        .HasColumnType("int");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<double>("Wetness")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SmartBoxes");
                });

            modelBuilder.Entity("Entities.Models.Location", b =>
                {
                    b.HasOne("Entities.Models.SmartBox", null)
                        .WithMany("Locations")
                        .HasForeignKey("SmartBoxId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
