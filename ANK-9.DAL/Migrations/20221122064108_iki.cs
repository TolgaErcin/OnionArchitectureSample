using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK_9.DAL.Migrations
{
    public partial class iki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "ID", "CreateOn", "IsActive", "MealName", "UpdateOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(4197), true, "Kahvaltı", null },
                    { 2, new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(4199), true, "Öğle Yemeği", null },
                    { 3, new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(4199), true, "Akşam Yemeği", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(2074));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 870, DateTimeKind.Local).AddTicks(8495));
        }
    }
}
