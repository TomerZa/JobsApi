using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsApi.Migrations
{
    public partial class InitialMigrationWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobInfo",
                columns: table => new
                {
                    JobDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ActiveJobs = table.Column<int>(type: "int", nullable: false),
                    JobViews = table.Column<int>(type: "int", nullable: false),
                    PredictedJobViews = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInfo", x => x.JobDate);
                });

            migrationBuilder.InsertData(
                table: "JobInfo",
                columns: new[] { "JobDate", "ActiveJobs", "JobViews", "PredictedJobViews" },
                values: new object[,]
                {
                    { new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 150, 90, 60 },
                    { new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), 145, 87, 58 },
                    { new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), 140, 84, 56 },
                    { new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 135, 81, 54 },
                    { new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 130, 78, 52 },
                    { new DateTime(2022, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 125, 75, 50 },
                    { new DateTime(2022, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 120, 72, 48 },
                    { new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 115, 69, 46 },
                    { new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 110, 66, 44 },
                    { new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 105, 63, 42 },
                    { new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 100, 60, 40 },
                    { new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 95, 57, 38 },
                    { new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 90, 54, 36 },
                    { new DateTime(2022, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 85, 51, 34 },
                    { new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 80, 48, 32 },
                    { new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 75, 45, 30 },
                    { new DateTime(2022, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), 70, 42, 28 },
                    { new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 65, 39, 26 },
                    { new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 60, 36, 24 },
                    { new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 55, 33, 22 },
                    { new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), 50, 30, 20 },
                    { new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 45, 27, 18 },
                    { new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 40, 24, 16 },
                    { new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 35, 21, 14 },
                    { new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), 30, 18, 12 },
                    { new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 25, 15, 10 },
                    { new DateTime(2022, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 20, 12, 8 },
                    { new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 15, 9, 6 },
                    { new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), 10, 6, 4 },
                    { new DateTime(2022, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 5, 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobInfo");
        }
    }
}
