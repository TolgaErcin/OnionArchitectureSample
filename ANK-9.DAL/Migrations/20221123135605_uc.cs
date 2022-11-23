using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK_9.DAL.Migrations
{
    public partial class uc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateOn",
                table: "Foods",
                type: "datetime2(7)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FoodName",
                table: "Foods",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Foods",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateOn",
                table: "Foods",
                type: "datetime2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<double>(
                name: "Calorie",
                table: "Foods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "MealsFoods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealsFoods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MealsFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealsFoods_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealsFoods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "Calorie", "CategoryId", "CreateOn", "Description", "FoodName", "IsActive", "UpdateOn" },
                values: new object[,]
                {
                    { 1, 11400.0, 1, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5108), "Bir su bardağı,200 ml", "Süt", true, null },
                    { 2, 69000.0, 2, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5111), "1 köfte, 30gr", "Kıyma", true, null },
                    { 3, 80000.0, 3, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5112), "4 yemek kaşığı, 25gr", "Mercimek", true, null },
                    { 4, 68000.0, 4, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5113), "3 yemek kaşığı, 50gr", "Makarna", true, null },
                    { 5, 25000.0, 5, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5114), "4 yemek kaşığı, 200gr", "Brokoli(Pişmiş)", true, null },
                    { 6, 60000.0, 6, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5115), "1 küçük boy, 120gr", "Elma", true, null },
                    { 7, 45000.0, 7, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5115), "1 tatlı kaşığı, 5gr", "Tereyağ", true, null },
                    { 8, 68000.0, 8, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5116), "1 yemek kaşığı, 30gr", "Bal", true, null },
                    { 9, 45000.0, 9, new DateTime(2022, 11, 23, 16, 56, 5, 312, DateTimeKind.Local).AddTicks(5117), "2 adet, 8gr", "Ceviz içi", true, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MealsFoods_FoodId",
                table: "MealsFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MealsFoods_MealId",
                table: "MealsFoods",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_MealsFoods_UserId",
                table: "MealsFoods",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "MealsFoods");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Calorie",
                table: "Foods");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateOn",
                table: "Foods",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FoodName",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateOn",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2(7)");

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

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 22, 9, 41, 7, 768, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
