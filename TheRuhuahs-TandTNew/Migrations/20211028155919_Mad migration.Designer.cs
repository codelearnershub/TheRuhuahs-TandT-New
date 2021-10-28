﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheRuhuahs_TandTNew.Context;

namespace TheRuhuahs_TandTNew.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211028155919_Mad migration")]
    partial class Madmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("NumberOfTouristToBoard")
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<string>("Reference")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<decimal>("FeedingExpense")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("HotelExpense")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("HotelStandard")
                        .HasColumnType("text");

                    b.Property<string>("PackageType")
                        .HasColumnType("text");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("RoleName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 10, 28, 16, 59, 19, 41, DateTimeKind.Local).AddTicks(9265),
                            RoleName = "SuperAdmin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 10, 28, 16, 59, 19, 41, DateTimeKind.Local).AddTicks(9895),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 10, 28, 16, 59, 19, 41, DateTimeKind.Local).AddTicks(9904),
                            RoleName = "Customer"
                        });
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.TouristCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TouristCenters");
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfTouristRequired")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("TouristCenterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TouristCenterId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("HashSalt")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Nigeria",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(2021, 10, 28, 16, 59, 19, 38, DateTimeKind.Local).AddTicks(580),
                            Email = "oyeleyeoyediran20@gmail.com",
                            FirstName = "Oyediran",
                            Gender = "Male",
                            HashSalt = "Rr+VsQuizJUuw6IIDqFEng==",
                            LastName = "Umar",
                            Mobile = "09026315926",
                            Password = "1234",
                            PasswordHash = "lnjgV8+UnY+JzL+MW8HB2DGTbR/lSmCaAXfW0/sUUX4=",
                            RoleId = 1,
                            State = "Abeokuta",
                            StreetAddress = "Asero"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Nigeria",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(2021, 10, 28, 16, 59, 19, 41, DateTimeKind.Local).AddTicks(7765),
                            Email = "umaroyediran20@gmail.com",
                            FirstName = "Ajibola",
                            Gender = "Male",
                            HashSalt = "HpW+UDBZdxj9aU/qKevVjQ==",
                            LastName = "Umar",
                            Mobile = "09026315926",
                            Password = "12345",
                            PasswordHash = "GW5/aRGQzvZKdWVGizIQb6ZzeiRBREcaT2Etlm3af+Y=",
                            RoleId = 2,
                            State = "Abeokuta",
                            StreetAddress = "Asero"
                        });
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 10, 28, 16, 59, 19, 42, DateTimeKind.Local).AddTicks(1731),
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 10, 28, 16, 59, 19, 42, DateTimeKind.Local).AddTicks(2009),
                            RoleId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.Booking", b =>
                {
                    b.HasOne("TheRuhuahs_TandTNew.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.Package", b =>
                {
                    b.HasOne("TheRuhuahs_TandTNew.Models.Trip", "Trip")
                        .WithMany("Package")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.Trip", b =>
                {
                    b.HasOne("TheRuhuahs_TandTNew.Models.TouristCenter", "TouristCenter")
                        .WithMany("Trip")
                        .HasForeignKey("TouristCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TheRuhuahs_TandTNew.Models.UserRole", b =>
                {
                    b.HasOne("TheRuhuahs_TandTNew.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheRuhuahs_TandTNew.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}