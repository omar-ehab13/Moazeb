using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moazeb.DAL.Migrations
{
    public partial class SeedPeriodsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudyingPeriods",
                columns: new[] { "PeriodCode", "ClassName", "DayName", "PeriodNo", "SubjectCode" },
                values: new object[,]
                {
                    { "Monday1_4A", "4A", 1, 1, "COMPUTER_4A" },
                    { "Monday1_4B", "4B", 1, 1, "COMPUTER_4B" },
                    { "Monday1_5A", "5A", 1, 1, "COMPUTER_5A" },
                    { "Monday1_5B", "5B", 1, 1, "SPORTS_5B" },
                    { "Monday2_4A", "4A", 1, 2, "SCIENCE_4A" },
                    { "Monday2_4B", "4B", 1, 2, "SOCIAL_STUDIES_4B" },
                    { "Monday2_5A", "5A", 1, 2, "SOCIAL_STUDIES_5A" },
                    { "Monday2_5B", "5B", 1, 2, "ENGLISH_5B" },
                    { "Monday3_4A", "4A", 1, 3, "COMPUTER_4A" },
                    { "Monday3_4B", "4B", 1, 3, "ARABIC_4B" },
                    { "Monday3_5A", "5A", 1, 3, "SPORTS_5A" },
                    { "Monday3_5B", "5B", 1, 3, "MATH_5B" },
                    { "Monday4_4A", "4A", 1, 4, "ENGLISH_4A" },
                    { "Monday4_4B", "4B", 1, 4, "ARABIC_4B" },
                    { "Monday4_5A", "5A", 1, 4, "SOCIAL_STUDIES_5A" },
                    { "Monday4_5B", "5B", 1, 4, "ENGLISH_5B" },
                    { "Monday5_4A", "4A", 1, 5, "SOCIAL_STUDIES_4A" },
                    { "Monday5_4B", "4B", 1, 5, "SKILLS_4B" },
                    { "Monday5_5A", "5A", 1, 5, "ARABIC_5A" },
                    { "Monday5_5B", "5B", 1, 5, "SOCIAL_STUDIES_5B" },
                    { "Monday6_4A", "4A", 1, 6, "ENGLISH_4A" },
                    { "Monday6_4B", "4B", 1, 6, "ENGLISH_4B" },
                    { "Monday6_5A", "5A", 1, 6, "MATH_5A" },
                    { "Monday6_5B", "5B", 1, 6, "MATH_5B" },
                    { "Monday7_4A", "4A", 1, 7, "MATH_4A" },
                    { "Monday7_4B", "4B", 1, 7, "SPORTS_4B" },
                    { "Monday7_5A", "5A", 1, 7, "ARABIC_5A" },
                    { "Monday7_5B", "5B", 1, 7, "MATH_5B" },
                    { "Sunday1_4A", "4A", 0, 1, "ARABIC_4A" },
                    { "Sunday1_4B", "4B", 0, 1, "SPORTS_4B" },
                    { "Sunday1_5A", "5A", 0, 1, "SKILLS_5A" },
                    { "Sunday1_5B", "5B", 0, 1, "ENGLISH_5B" },
                    { "Sunday2_4A", "4A", 0, 2, "COMPUTER_4A" },
                    { "Sunday2_4B", "4B", 0, 2, "SOCIAL_STUDIES_4B" },
                    { "Sunday2_5A", "5A", 0, 2, "SPORTS_5A" },
                    { "Sunday2_5B", "5B", 0, 2, "SCIENCE_5B" },
                    { "Sunday3_4A", "4A", 0, 3, "SOCIAL_STUDIES_4A" },
                    { "Sunday3_4B", "4B", 0, 3, "SKILLS_4B" },
                    { "Sunday3_5A", "5A", 0, 3, "SCIENCE_5A" },
                    { "Sunday3_5B", "5B", 0, 3, "SCIENCE_5B" },
                    { "Sunday4_4A", "4A", 0, 4, "ENGLISH_4A" },
                    { "Sunday4_4B", "4B", 0, 4, "SCIENCE_4B" }
                });

            migrationBuilder.InsertData(
                table: "StudyingPeriods",
                columns: new[] { "PeriodCode", "ClassName", "DayName", "PeriodNo", "SubjectCode" },
                values: new object[,]
                {
                    { "Sunday4_5A", "5A", 0, 4, "SKILLS_5A" },
                    { "Sunday4_5B", "5B", 0, 4, "ENGLISH_5B" },
                    { "Sunday5_4A", "4A", 0, 5, "ENGLISH_4A" },
                    { "Sunday5_4B", "4B", 0, 5, "MATH_4B" },
                    { "Sunday5_5A", "5A", 0, 5, "MATH_5A" },
                    { "Sunday5_5B", "5B", 0, 5, "MATH_5B" },
                    { "Sunday6_4A", "4A", 0, 6, "ENGLISH_4A" },
                    { "Sunday6_4B", "4B", 0, 6, "SPORTS_4B" },
                    { "Sunday6_5A", "5A", 0, 6, "SPORTS_5A" },
                    { "Sunday6_5B", "5B", 0, 6, "MATH_5B" },
                    { "Sunday7_4A", "4A", 0, 7, "SOCIAL_STUDIES_4A" },
                    { "Sunday7_4B", "4B", 0, 7, "SOCIAL_STUDIES_4B" },
                    { "Sunday7_5A", "5A", 0, 7, "SOCIAL_STUDIES_5A" },
                    { "Sunday7_5B", "5B", 0, 7, "SOCIAL_STUDIES_5B" },
                    { "Thursday1_4A", "4A", 4, 1, "SOCIAL_STUDIES_4A" },
                    { "Thursday1_4B", "4B", 4, 1, "SCIENCE_4B" },
                    { "Thursday1_5A", "5A", 4, 1, "SKILLS_5A" },
                    { "Thursday1_5B", "5B", 4, 1, "SKILLS_5B" },
                    { "Thursday2_4A", "4A", 4, 2, "MATH_4A" },
                    { "Thursday2_4B", "4B", 4, 2, "SOCIAL_STUDIES_4B" },
                    { "Thursday2_5A", "5A", 4, 2, "SPORTS_5A" },
                    { "Thursday2_5B", "5B", 4, 2, "COMPUTER_5B" },
                    { "Thursday3_4A", "4A", 4, 3, "ENGLISH_4A" },
                    { "Thursday3_4B", "4B", 4, 3, "ARABIC_4B" },
                    { "Thursday3_5A", "5A", 4, 3, "SKILLS_5A" },
                    { "Thursday3_5B", "5B", 4, 3, "ARABIC_5B" },
                    { "Thursday4_4A", "4A", 4, 4, "ARABIC_4A" },
                    { "Thursday4_4B", "4B", 4, 4, "ARABIC_4B" },
                    { "Thursday4_5A", "5A", 4, 4, "COMPUTER_5A" },
                    { "Thursday4_5B", "5B", 4, 4, "SCIENCE_5B" },
                    { "Thursday5_4A", "4A", 4, 5, "SOCIAL_STUDIES_4A" },
                    { "Thursday5_4B", "4B", 4, 5, "MATH_4B" },
                    { "Thursday5_5A", "5A", 4, 5, "SKILLS_5A" },
                    { "Thursday5_5B", "5B", 4, 5, "SCIENCE_5B" },
                    { "Thursday6_4A", "4A", 4, 6, "ARABIC_4A" },
                    { "Thursday6_4B", "4B", 4, 6, "SOCIAL_STUDIES_4B" },
                    { "Thursday6_5A", "5A", 4, 6, "COMPUTER_5A" },
                    { "Thursday6_5B", "5B", 4, 6, "SKILLS_5B" },
                    { "Thursday7_4A", "4A", 4, 7, "MATH_4A" },
                    { "Thursday7_4B", "4B", 4, 7, "SKILLS_4B" },
                    { "Thursday7_5A", "5A", 4, 7, "SKILLS_5A" },
                    { "Thursday7_5B", "5B", 4, 7, "ARABIC_5B" }
                });

            migrationBuilder.InsertData(
                table: "StudyingPeriods",
                columns: new[] { "PeriodCode", "ClassName", "DayName", "PeriodNo", "SubjectCode" },
                values: new object[,]
                {
                    { "Tuesday1_4A", "4A", 2, 1, "SKILLS_4A" },
                    { "Tuesday1_4B", "4B", 2, 1, "ARABIC_4B" },
                    { "Tuesday1_5A", "5A", 2, 1, "SOCIAL_STUDIES_5A" },
                    { "Tuesday1_5B", "5B", 2, 1, "ENGLISH_5B" },
                    { "Tuesday2_4A", "4A", 2, 2, "MATH_4A" },
                    { "Tuesday2_4B", "4B", 2, 2, "ENGLISH_4B" },
                    { "Tuesday2_5A", "5A", 2, 2, "ENGLISH_5A" },
                    { "Tuesday2_5B", "5B", 2, 2, "SPORTS_5B" },
                    { "Tuesday3_4A", "4A", 2, 3, "SKILLS_4A" },
                    { "Tuesday3_4B", "4B", 2, 3, "COMPUTER_4B" },
                    { "Tuesday3_5A", "5A", 2, 3, "SKILLS_5A" },
                    { "Tuesday3_5B", "5B", 2, 3, "COMPUTER_5B" },
                    { "Tuesday4_4A", "4A", 2, 4, "ARABIC_4A" },
                    { "Tuesday4_4B", "4B", 2, 4, "SPORTS_4B" },
                    { "Tuesday4_5A", "5A", 2, 4, "SKILLS_5A" },
                    { "Tuesday4_5B", "5B", 2, 4, "SKILLS_5B" },
                    { "Tuesday5_4A", "4A", 2, 5, "SPORTS_4A" },
                    { "Tuesday5_4B", "4B", 2, 5, "ENGLISH_4B" },
                    { "Tuesday5_5A", "5A", 2, 5, "SCIENCE_5A" },
                    { "Tuesday5_5B", "5B", 2, 5, "SCIENCE_5B" },
                    { "Tuesday6_4A", "4A", 2, 6, "ARABIC_4A" },
                    { "Tuesday6_4B", "4B", 2, 6, "SKILLS_4B" },
                    { "Tuesday6_5A", "5A", 2, 6, "SPORTS_5A" },
                    { "Tuesday6_5B", "5B", 2, 6, "ARABIC_5B" },
                    { "Tuesday7_4A", "4A", 2, 7, "SOCIAL_STUDIES_4A" },
                    { "Tuesday7_4B", "4B", 2, 7, "MATH_4B" },
                    { "Tuesday7_5A", "5A", 2, 7, "COMPUTER_5A" },
                    { "Tuesday7_5B", "5B", 2, 7, "ENGLISH_5B" },
                    { "Wednesday1_4A", "4A", 3, 1, "MATH_4A" },
                    { "Wednesday1_4B", "4B", 3, 1, "SCIENCE_4B" },
                    { "Wednesday1_5A", "5A", 3, 1, "SKILLS_5A" },
                    { "Wednesday1_5B", "5B", 3, 1, "ENGLISH_5B" },
                    { "Wednesday2_4A", "4A", 3, 2, "ENGLISH_4A" },
                    { "Wednesday2_4B", "4B", 3, 2, "ENGLISH_4B" },
                    { "Wednesday2_5A", "5A", 3, 2, "ARABIC_5A" },
                    { "Wednesday2_5B", "5B", 3, 2, "MATH_5B" },
                    { "Wednesday3_4A", "4A", 3, 3, "ARABIC_4A" },
                    { "Wednesday3_4B", "4B", 3, 3, "ENGLISH_4B" },
                    { "Wednesday3_5A", "5A", 3, 3, "COMPUTER_5A" },
                    { "Wednesday3_5B", "5B", 3, 3, "MATH_5B" },
                    { "Wednesday4_4A", "4A", 3, 4, "MATH_4A" },
                    { "Wednesday4_4B", "4B", 3, 4, "MATH_4B" }
                });

            migrationBuilder.InsertData(
                table: "StudyingPeriods",
                columns: new[] { "PeriodCode", "ClassName", "DayName", "PeriodNo", "SubjectCode" },
                values: new object[,]
                {
                    { "Wednesday4_5A", "5A", 3, 4, "MATH_5A" },
                    { "Wednesday4_5B", "5B", 3, 4, "COMPUTER_5B" },
                    { "Wednesday5_4A", "4A", 3, 5, "SPORTS_4A" },
                    { "Wednesday5_4B", "4B", 3, 5, "ARABIC_4B" },
                    { "Wednesday5_5A", "5A", 3, 5, "COMPUTER_5A" },
                    { "Wednesday5_5B", "5B", 3, 5, "SOCIAL_STUDIES_5B" },
                    { "Wednesday6_4A", "4A", 3, 6, "ENGLISH_4A" },
                    { "Wednesday6_4B", "4B", 3, 6, "SKILLS_4B" },
                    { "Wednesday6_5A", "5A", 3, 6, "SOCIAL_STUDIES_5A" },
                    { "Wednesday6_5B", "5B", 3, 6, "ENGLISH_5B" },
                    { "Wednesday7_4A", "4A", 3, 7, "SKILLS_4A" },
                    { "Wednesday7_4B", "4B", 3, 7, "ARABIC_4B" },
                    { "Wednesday7_5A", "5A", 3, 7, "MATH_5A" },
                    { "Wednesday7_5B", "5B", 3, 7, "SCIENCE_5B" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday1_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday1_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday1_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday1_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday2_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday2_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday2_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday2_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday3_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday3_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday3_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday3_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday4_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday4_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday4_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday4_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday5_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday5_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday5_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday5_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday6_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday6_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday6_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday6_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday7_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday7_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday7_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Monday7_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday1_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday1_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday1_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday1_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday2_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday2_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday2_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday2_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday3_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday3_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday3_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday3_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday4_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday4_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday4_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday4_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday5_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday5_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday5_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday5_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday6_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday6_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday6_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday6_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday7_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday7_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday7_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Sunday7_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday1_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday1_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday1_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday1_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday2_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday2_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday2_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday2_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday3_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday3_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday3_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday3_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday4_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday4_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday4_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday4_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday5_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday5_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday5_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday5_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday6_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday6_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday6_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday6_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday7_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday7_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday7_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Thursday7_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday1_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday1_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday1_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday1_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday2_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday2_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday2_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday2_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday3_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday3_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday3_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday3_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday4_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday4_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday4_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday4_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday5_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday5_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday5_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday5_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday6_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday6_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday6_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday6_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday7_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday7_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday7_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Tuesday7_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday1_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday1_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday1_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday1_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday2_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday2_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday2_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday2_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday3_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday3_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday3_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday3_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday4_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday4_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday4_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday4_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday5_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday5_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday5_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday5_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday6_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday6_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday6_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday6_5B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday7_4A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday7_4B");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday7_5A");

            migrationBuilder.DeleteData(
                table: "StudyingPeriods",
                keyColumn: "PeriodCode",
                keyValue: "Wednesday7_5B");
        }
    }
}
