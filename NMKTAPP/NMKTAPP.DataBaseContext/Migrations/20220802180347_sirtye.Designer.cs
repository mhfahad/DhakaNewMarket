﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NMKTAPP.DatabaseContext.DatabaseContext;

namespace NMKTAPP.DataBaseContext.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20220802180347_sirtye")]
    partial class sirtye
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NMKTAPP.Models.Models.Service.ServiceInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("SellerInfoId")
                        .HasColumnType("int");

                    b.Property<string>("serArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("serDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("serDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ServiceInfos");
                });

            modelBuilder.Entity("NMKTAPP.Models.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("userEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
