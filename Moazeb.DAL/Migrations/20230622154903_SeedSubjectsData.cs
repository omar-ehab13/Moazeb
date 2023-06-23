using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moazeb.DAL.Migrations
{
    public partial class SeedSubjectsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectCode", "ClassName", "SubjcetName", "TeacherId" },
                values: new object[,]
                {
                    { "ARABIC_1A", "1A", 0, null },
                    { "ARABIC_1B", "1B", 0, null },
                    { "ARABIC_2A", "2A", 0, null },
                    { "ARABIC_2B", "2B", 0, null },
                    { "ARABIC_4A", "4A", 0, null },
                    { "ARABIC_4B", "4B", 0, null },
                    { "ARABIC_5A", "5A", 0, null },
                    { "ARABIC_5B", "5B", 0, null },
                    { "COMPUTER_4A", "4A", 5, null },
                    { "COMPUTER_4B", "4B", 5, null },
                    { "COMPUTER_5A", "5A", 5, null },
                    { "COMPUTER_5B", "5B", 5, null },
                    { "ENGLISH_1A", "1A", 2, null },
                    { "ENGLISH_1B", "1B", 2, null },
                    { "ENGLISH_2A", "2A", 2, null },
                    { "ENGLISH_2B", "2B", 2, null },
                    { "ENGLISH_4A", "4A", 2, null },
                    { "ENGLISH_4B", "4B", 2, null },
                    { "ENGLISH_5A", "5A", 2, null },
                    { "ENGLISH_5B", "5B", 2, null },
                    { "MATH_1A", "1A", 1, null },
                    { "MATH_1B", "1B", 1, null },
                    { "MATH_2A", "2A", 1, null },
                    { "MATH_2B", "2B", 1, null },
                    { "MATH_4A", "4A", 1, null },
                    { "MATH_4B", "4B", 1, null },
                    { "MATH_5A", "5A", 1, null },
                    { "MATH_5B", "5B", 1, null },
                    { "SCIENCE_4A", "4A", 3, null },
                    { "SCIENCE_4B", "4B", 3, null },
                    { "SCIENCE_5A", "5A", 3, null },
                    { "SCIENCE_5B", "5B", 3, null },
                    { "SKILLS_1A", "1A", 6, null },
                    { "SKILLS_1B", "1B", 6, null },
                    { "SKILLS_2A", "2A", 6, null },
                    { "SKILLS_2B", "2B", 6, null },
                    { "SKILLS_4A", "4A", 6, null },
                    { "SKILLS_4B", "4B", 6, null },
                    { "SKILLS_5A", "5A", 6, null },
                    { "SKILLS_5B", "5B", 6, null },
                    { "SOCIAL_STUDIES_4A", "4A", 4, null },
                    { "SOCIAL_STUDIES_4B", "4B", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectCode", "ClassName", "SubjcetName", "TeacherId" },
                values: new object[,]
                {
                    { "SOCIAL_STUDIES_5A", "5A", 4, null },
                    { "SOCIAL_STUDIES_5B", "5B", 4, null },
                    { "SPORTS_1A", "1A", 7, null },
                    { "SPORTS_1B", "1B", 7, null },
                    { "SPORTS_2A", "2A", 7, null },
                    { "SPORTS_2B", "2B", 7, null },
                    { "SPORTS_4A", "4A", 7, null },
                    { "SPORTS_4B", "4B", 7, null },
                    { "SPORTS_5A", "5A", 7, null },
                    { "SPORTS_5B", "5B", 7, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ARABIC_1A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ARABIC_1B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ARABIC_2A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ARABIC_2B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ARABIC_4A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ARABIC_4B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ARABIC_5A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ARABIC_5B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "COMPUTER_4A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "COMPUTER_4B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "COMPUTER_5A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "COMPUTER_5B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ENGLISH_1A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ENGLISH_1B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ENGLISH_2A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ENGLISH_2B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ENGLISH_4A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ENGLISH_4B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ENGLISH_5A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "ENGLISH_5B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "MATH_1A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "MATH_1B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "MATH_2A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "MATH_2B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "MATH_4A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "MATH_4B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "MATH_5A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "MATH_5B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SCIENCE_4A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SCIENCE_4B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SCIENCE_5A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SCIENCE_5B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SKILLS_1A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SKILLS_1B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SKILLS_2A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SKILLS_2B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SKILLS_4A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SKILLS_4B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SKILLS_5A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SKILLS_5B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SOCIAL_STUDIES_4A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SOCIAL_STUDIES_4B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SOCIAL_STUDIES_5A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SOCIAL_STUDIES_5B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SPORTS_1A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SPORTS_1B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SPORTS_2A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SPORTS_2B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SPORTS_4A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SPORTS_4B");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SPORTS_5A");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectCode",
                keyValue: "SPORTS_5B");
        }
    }
}
