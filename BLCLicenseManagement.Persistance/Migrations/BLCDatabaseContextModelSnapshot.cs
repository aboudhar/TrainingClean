﻿// <auto-generated />
using System;
using BLCLicenseManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BLCLicenseManagement.Persistence.Migrations
{
    [DbContext(typeof(BLCDatabaseContext))]
    partial class BLCDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BLCApplicationLicense", b =>
                {
                    b.Property<int>("BLCApplicationsId")
                        .HasColumnType("int");

                    b.Property<int>("LicensesId")
                        .HasColumnType("int");

                    b.HasKey("BLCApplicationsId", "LicensesId");

                    b.HasIndex("LicensesId");

                    b.ToTable("BLCApplicationLicense");
                });

            modelBuilder.Entity("BLCLicenseManagement.Domain.BLCApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BLCApplications");
                });

            modelBuilder.Entity("BLCLicenseManagement.Domain.InstanceOfLicense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LicenseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LicenseId");

                    b.ToTable("InstanceOfLicenses");
                });

            modelBuilder.Entity("BLCLicenseManagement.Domain.License", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LicenseTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LicenseTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("BLCLicenseManagement.Domain.LicenseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LicenseTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 6, 15, 18, 59, 54, 507, DateTimeKind.Local).AddTicks(7820),
                            DateModified = new DateTime(2023, 6, 15, 18, 59, 54, 507, DateTimeKind.Local).AddTicks(7821),
                            Name = "Trial"
                        });
                });

            modelBuilder.Entity("BLCLicenseManagement.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 6, 15, 18, 59, 54, 507, DateTimeKind.Local).AddTicks(8021),
                            DateModified = new DateTime(2023, 6, 15, 18, 59, 54, 507, DateTimeKind.Local).AddTicks(8022),
                            Email = "",
                            Name = "Admin",
                            Role = ""
                        });
                });

            modelBuilder.Entity("BLCApplicationLicense", b =>
                {
                    b.HasOne("BLCLicenseManagement.Domain.BLCApplication", null)
                        .WithMany()
                        .HasForeignKey("BLCApplicationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BLCLicenseManagement.Domain.License", null)
                        .WithMany()
                        .HasForeignKey("LicensesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BLCLicenseManagement.Domain.InstanceOfLicense", b =>
                {
                    b.HasOne("BLCLicenseManagement.Domain.License", "License")
                        .WithMany("InstanceOfLicenses")
                        .HasForeignKey("LicenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("License");
                });

            modelBuilder.Entity("BLCLicenseManagement.Domain.License", b =>
                {
                    b.HasOne("BLCLicenseManagement.Domain.LicenseType", "LicenseType")
                        .WithMany()
                        .HasForeignKey("LicenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BLCLicenseManagement.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LicenseType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BLCLicenseManagement.Domain.License", b =>
                {
                    b.Navigation("InstanceOfLicenses");
                });
#pragma warning restore 612, 618
        }
    }
}
