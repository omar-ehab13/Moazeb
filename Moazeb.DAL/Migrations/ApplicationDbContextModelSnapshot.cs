﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moazeb.DAL.DataContext;

#nullable disable

namespace Moazeb.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", "security");

                    b.HasData(
                        new
                        {
                            Id = "bbe78769-5bd1-4c21-915e-790f874e39fe",
                            ConcurrencyStamp = "4d6fa03b-248e-4b8f-ba9d-3ccd989aac73",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "a6136e7b-1099-4157-bde7-27ada0df7f01",
                            ConcurrencyStamp = "14b14c96-afa1-4eeb-9a62-457bd8d20022",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "93d1dfd8-c421-4063-871e-5eae84095fe4",
                            ConcurrencyStamp = "3da525ca-7dad-41ab-9d38-db692951c9a0",
                            Name = "Parent",
                            NormalizedName = "PARENT"
                        },
                        new
                        {
                            Id = "c9066e37-b2b8-4af2-9c1f-dd3c86c73d74",
                            ConcurrencyStamp = "58a81259-2cf3-4823-b189-36e3c3820615",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "security");

                    b.HasData(
                        new
                        {
                            UserId = "f23bec6d-1f5e-41d4-a062-d2b351b46244",
                            RoleId = "bbe78769-5bd1-4c21-915e-790f874e39fe"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "security");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ExternalEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Governorate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "security");

                    b.HasData(
                        new
                        {
                            Id = "f23bec6d-1f5e-41d4-a062-d2b351b46244",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5f20e4e5-2402-4239-ad4d-e1d2c7962af1",
                            Email = "superadmin@superadmin.moazeb",
                            EmailConfirmed = true,
                            FullName = "superadmin@superadmin.moazeb",
                            LockoutEnabled = true,
                            NormalizedEmail = "SUPERADMIN@SUPERADMIN.MOAZEB",
                            NormalizedUserName = "SUPERADMIN@SUPERADMIN.MOAZEB",
                            PasswordHash = "AQAAAAEAACcQAAAAEB0jJEJlYQkd6nMvYlyOIOFrw0kO+lam5tr1fePZSRPUjapF7NCyMTzDr4e5kgt7vw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5cbaf3c5-a8a1-4b9f-ad7b-bd1884163d78",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@superadmin.moazeb"
                        });
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.AttendanceState", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("AttendanceStates");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Class", b =>
                {
                    b.Property<string>("ClassName")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<byte>("Grade")
                        .HasColumnType("tinyint");

                    b.Property<string>("ReaderId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ClassName");

                    b.HasIndex("ReaderId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Log", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Action")
                        .HasColumnType("int");

                    b.Property<string>("AttendanceStateId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("LogTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceStateId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Parent", b =>
                {
                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Job")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nid")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ParentId");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Reader", b =>
                {
                    b.Property<string>("ReaderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AddedDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClassId")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReaderId");

                    b.HasIndex("ClassId");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClassCode")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassCode");

                    b.HasIndex("ParentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.StudyingPeriod", b =>
                {
                    b.Property<string>("PeriodId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("DayName")
                        .HasColumnType("int");

                    b.Property<int>("PeriodNo")
                        .HasColumnType("int");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PeriodId");

                    b.HasIndex("ClassName");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudyingPeriods");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Subject", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("SubjcetName")
                        .HasColumnType("int");

                    b.Property<string>("SubjectCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ClassName");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Teacher", b =>
                {
                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Specialize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moazeb.DAL.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.AttendanceState", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.Student", "Student")
                        .WithMany("AttendanceStates")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Class", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.Reader", "Reader")
                        .WithMany()
                        .HasForeignKey("ReaderId");

                    b.Navigation("Reader");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Log", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.AttendanceState", "AttendanceState")
                        .WithMany("Logs")
                        .HasForeignKey("AttendanceStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AttendanceState");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Parent", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Reader", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Student", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassCode");

                    b.HasOne("Moazeb.DAL.Entities.Parent", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.StudyingPeriod", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.Class", null)
                        .WithMany("StudyingPeriods")
                        .HasForeignKey("ClassName");

                    b.HasOne("Moazeb.DAL.Entities.Subject", "Subject")
                        .WithMany("Periods")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Subject", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassName");

                    b.HasOne("Moazeb.DAL.Entities.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Class");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Teacher", b =>
                {
                    b.HasOne("Moazeb.DAL.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.AttendanceState", b =>
                {
                    b.Navigation("Logs");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Class", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("StudyingPeriods");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Parent", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Student", b =>
                {
                    b.Navigation("AttendanceStates");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Subject", b =>
                {
                    b.Navigation("Periods");
                });

            modelBuilder.Entity("Moazeb.DAL.Entities.Teacher", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
