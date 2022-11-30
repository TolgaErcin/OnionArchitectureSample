using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK_9.DAL.Migrations
{
    public partial class dort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealsFoods_Foods_FoodId",
                table: "MealsFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MealsFoods_Meals_MealId",
                table: "MealsFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MealsFoods_Users_UserId",
                table: "MealsFoods");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateOn",
                table: "MealsFoods",
                type: "datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateOn",
                table: "MealsFoods",
                type: "datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Portion",
                table: "MealsFoods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 514, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 24, 9, 56, 43, 513, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.AddForeignKey(
                name: "FK_MealsFoods_Foods_FoodId",
                table: "MealsFoods",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MealsFoods_Meals_MealId",
                table: "MealsFoods",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MealsFoods_Users_UserId",
                table: "MealsFoods",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealsFoods_Foods_FoodId",
                table: "MealsFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MealsFoods_Meals_MealId",
                table: "MealsFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_MealsFoods_Users_UserId",
                table: "MealsFoods");

            migrationBuilder.DropColumn(
                name: "Portion",
                table: "MealsFoods");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateOn",
                table: "MealsFoods",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateOn",
                table: "MealsFoods",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(7)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.AddForeignKey(
                name: "FK_MealsFoods_Foods_FoodId",
                table: "MealsFoods",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealsFoods_Meals_MealId",
                table: "MealsFoods",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealsFoods_Users_UserId",
                table: "MealsFoods",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
