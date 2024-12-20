﻿// <auto-generated />
using System;
using GoCycleAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace GoCycleAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GoCycleAPI.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("AdditionalInfo")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<int>("Number")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ProfileCPF")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("AddressId");

                    b.HasIndex("ProfileCPF");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<float>("Amount")
                        .HasColumnType("BINARY_FLOAT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.Property<int>("UsageId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("PaymentId");

                    b.HasIndex("UsageId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Profile", b =>
                {
                    b.Property<string>("CPF")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<int>("Score")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)");

                    b.HasKey("CPF");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Telephone", b =>
                {
                    b.Property<int>("TelephoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TelephoneId"));

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("NVARCHAR2(10)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)");

                    b.Property<string>("ProfileCPF")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.HasKey("TelephoneId");

                    b.HasIndex("ProfileCPF");

                    b.ToTable("Telephones");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Usage", b =>
                {
                    b.Property<int>("UsageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsageId"));

                    b.Property<float>("Duration")
                        .HasColumnType("BINARY_FLOAT");

                    b.Property<DateTime>("PickupDatetime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("ProfileCPF")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<DateTime>("ReturnDatetime")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Score")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("UsageId");

                    b.HasIndex("ProfileCPF");

                    b.ToTable("Usages");
                });

            modelBuilder.Entity("GoCycleAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Address", b =>
                {
                    b.HasOne("GoCycleAPI.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileCPF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Payment", b =>
                {
                    b.HasOne("GoCycleAPI.Models.Usage", "Usage")
                        .WithMany()
                        .HasForeignKey("UsageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usage");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Profile", b =>
                {
                    b.HasOne("GoCycleAPI.Models.User", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Telephone", b =>
                {
                    b.HasOne("GoCycleAPI.Models.Profile", "Profile")
                        .WithMany("Telephones")
                        .HasForeignKey("ProfileCPF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Usage", b =>
                {
                    b.HasOne("GoCycleAPI.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileCPF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("GoCycleAPI.Models.Profile", b =>
                {
                    b.Navigation("Telephones");
                });

            modelBuilder.Entity("GoCycleAPI.Models.User", b =>
                {
                    b.Navigation("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}
