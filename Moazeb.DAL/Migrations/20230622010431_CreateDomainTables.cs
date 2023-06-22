using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moazeb.DAL.Migrations
{
    public partial class CreateDomainTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "91d40bd3-4132-472a-ad82-53de5bb0d8fd");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "affacbf4-8cd5-4849-b7b7-68fcfece7890");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bb765e3c-47d1-4441-8231-c95c5b8c6f57");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "944f6b89-8ff1-4138-8642-081bc71b6c02", "3545a66b-afd0-4e80-a9cf-50377ad810c3" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "944f6b89-8ff1-4138-8642-081bc71b6c02");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "3545a66b-afd0-4e80-a9cf-50377ad810c3");

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nid = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Job = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentId);
                    table.ForeignKey(
                        name: "FK_Parents_Users_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "security",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Specialize = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_Users_TeacherId",
                        column: x => x.TeacherId,
                        principalSchema: "security",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceStates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Action = table.Column<int>(type: "int", nullable: false),
                    AttendanceStateId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_AttendanceStates_AttendanceStateId",
                        column: x => x.AttendanceStateId,
                        principalTable: "AttendanceStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassName = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Grade = table.Column<byte>(type: "tinyint", nullable: false),
                    ReaderId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassName);
                });

            migrationBuilder.CreateTable(
                name: "Readers",
                columns: table => new
                {
                    ReaderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddedDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readers", x => x.ReaderId);
                    table.ForeignKey(
                        name: "FK_Readers_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassName");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassCode = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassCode",
                        column: x => x.ClassCode,
                        principalTable: "Classes",
                        principalColumn: "ClassName");
                    table.ForeignKey(
                        name: "FK_Students_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "ParentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjcetName = table.Column<int>(type: "int", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Classes_ClassName",
                        column: x => x.ClassName,
                        principalTable: "Classes",
                        principalColumn: "ClassName");
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId");
                });

            migrationBuilder.CreateTable(
                name: "StudyingPeriods",
                columns: table => new
                {
                    PeriodId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeriodNo = table.Column<int>(type: "int", nullable: false),
                    DayName = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClassName = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyingPeriods", x => x.PeriodId);
                    table.ForeignKey(
                        name: "FK_StudyingPeriods_Classes_ClassName",
                        column: x => x.ClassName,
                        principalTable: "Classes",
                        principalColumn: "ClassName");
                    table.ForeignKey(
                        name: "FK_StudyingPeriods_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "93d1dfd8-c421-4063-871e-5eae84095fe4", "3da525ca-7dad-41ab-9d38-db692951c9a0", "Parent", "PARENT" },
                    { "a6136e7b-1099-4157-bde7-27ada0df7f01", "14b14c96-afa1-4eeb-9a62-457bd8d20022", "Admin", "ADMIN" },
                    { "bbe78769-5bd1-4c21-915e-790f874e39fe", "4d6fa03b-248e-4b8f-ba9d-3ccd989aac73", "SuperAdmin", "SUPERADMIN" },
                    { "c9066e37-b2b8-4af2-9c1f-dd3c86c73d74", "58a81259-2cf3-4823-b189-36e3c3820615", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "ExternalEmail", "FullName", "Governorate", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f23bec6d-1f5e-41d4-a062-d2b351b46244", 0, null, null, "5f20e4e5-2402-4239-ad4d-e1d2c7962af1", "superadmin@superadmin.moazeb", true, null, "superadmin@superadmin.moazeb", null, null, true, null, "SUPERADMIN@SUPERADMIN.MOAZEB", "SUPERADMIN@SUPERADMIN.MOAZEB", "AQAAAAEAACcQAAAAEB0jJEJlYQkd6nMvYlyOIOFrw0kO+lam5tr1fePZSRPUjapF7NCyMTzDr4e5kgt7vw==", null, false, "5cbaf3c5-a8a1-4b9f-ad7b-bd1884163d78", false, "superadmin@superadmin.moazeb" });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bbe78769-5bd1-4c21-915e-790f874e39fe", "f23bec6d-1f5e-41d4-a062-d2b351b46244" });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceStates_StudentId",
                table: "AttendanceStates",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ReaderId",
                table: "Classes",
                column: "ReaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_AttendanceStateId",
                table: "Logs",
                column: "AttendanceStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Readers_ClassId",
                table: "Readers",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassCode",
                table: "Students",
                column: "ClassCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingPeriods_ClassName",
                table: "StudyingPeriods",
                column: "ClassName");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingPeriods_SubjectId",
                table: "StudyingPeriods",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ClassName",
                table: "Subjects",
                column: "ClassName");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceStates_Students_StudentId",
                table: "AttendanceStates",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Readers_ReaderId",
                table: "Classes",
                column: "ReaderId",
                principalTable: "Readers",
                principalColumn: "ReaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Readers_ReaderId",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "StudyingPeriods");

            migrationBuilder.DropTable(
                name: "AttendanceStates");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Readers");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "93d1dfd8-c421-4063-871e-5eae84095fe4");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a6136e7b-1099-4157-bde7-27ada0df7f01");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c9066e37-b2b8-4af2-9c1f-dd3c86c73d74");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbe78769-5bd1-4c21-915e-790f874e39fe", "f23bec6d-1f5e-41d4-a062-d2b351b46244" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bbe78769-5bd1-4c21-915e-790f874e39fe");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Users",
                keyColumn: "Id",
                keyValue: "f23bec6d-1f5e-41d4-a062-d2b351b46244");

            migrationBuilder.InsertData(
                schema: "security",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91d40bd3-4132-472a-ad82-53de5bb0d8fd", "299f361e-af26-4273-b6ed-13f6c6993f33", "Admin", "ADMIN" },
                    { "944f6b89-8ff1-4138-8642-081bc71b6c02", "4d1d62be-faa1-4f45-a76c-fe88be988bcd", "SuperAdmin", "SUPERADMIN" },
                    { "affacbf4-8cd5-4849-b7b7-68fcfece7890", "fa3d6ca6-c4e3-4031-9614-becafaac13a5", "Teacher", "TEACHER" },
                    { "bb765e3c-47d1-4441-8231-c95c5b8c6f57", "a0709f04-f8d6-408a-aee4-542f110c3551", "Parent", "PARENT" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "ExternalEmail", "FullName", "Governorate", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3545a66b-afd0-4e80-a9cf-50377ad810c3", 0, null, null, "13950a09-c372-4907-9eb1-75f8e0c81417", "superadmin@superadmin.moazeb", true, null, "superadmin@superadmin.moazeb", null, null, true, null, "SUPERADMIN@SUPERADMIN.MOAZEB", "SUPERADMIN@SUPERADMIN.MOAZEB", "AQAAAAEAACcQAAAAEBcuJtkCF7xWqi144UJGAsMIwXK7Q0tPvQ/DiuyrRqpcrAebCFXax1F/b/CzgeVCQA==", null, false, "b889be4a-d0ad-463f-bdcf-07284c2d273c", false, "superadmin@superadmin.moazeb" });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "944f6b89-8ff1-4138-8642-081bc71b6c02", "3545a66b-afd0-4e80-a9cf-50377ad810c3" });
        }
    }
}
