using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moazeb.DAL.Migrations
{
    public partial class AddForignKeyInPeriodEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyingPeriods_Classes_ClassName1",
                table: "StudyingPeriods");

            migrationBuilder.DropIndex(
                name: "IX_StudyingPeriods_ClassName1",
                table: "StudyingPeriods");

            migrationBuilder.DropColumn(
                name: "ClassName1",
                table: "StudyingPeriods");

            migrationBuilder.AlterColumn<string>(
                name: "ClassName",
                table: "StudyingPeriods",
                type: "nvarchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudyingPeriods_ClassName",
                table: "StudyingPeriods",
                column: "ClassName");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyingPeriods_Classes_ClassName",
                table: "StudyingPeriods",
                column: "ClassName",
                principalTable: "Classes",
                principalColumn: "ClassName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyingPeriods_Classes_ClassName",
                table: "StudyingPeriods");

            migrationBuilder.DropIndex(
                name: "IX_StudyingPeriods_ClassName",
                table: "StudyingPeriods");

            migrationBuilder.AlterColumn<string>(
                name: "ClassName",
                table: "StudyingPeriods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassName1",
                table: "StudyingPeriods",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudyingPeriods_ClassName1",
                table: "StudyingPeriods",
                column: "ClassName1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyingPeriods_Classes_ClassName1",
                table: "StudyingPeriods",
                column: "ClassName1",
                principalTable: "Classes",
                principalColumn: "ClassName");
        }
    }
}
