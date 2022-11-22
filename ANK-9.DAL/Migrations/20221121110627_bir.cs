using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK_9.DAL.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime2(7)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreateOn", "IsActive", "UpdateOn" },
                values: new object[,]
                {
                    { 1, "Süt Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(163), true, null },
                    { 2, "Et Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(168), true, null },
                    { 3, "KuruBaklagil Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(169), true, null },
                    { 4, "Ekmek Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(170), true, null },
                    { 5, "Sebze Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(171), true, null },
                    { 6, "Meyve Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(172), true, null },
                    { 7, "Yağ Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(172), true, null },
                    { 8, "Tatlı Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(173), true, null },
                    { 9, "Kuruyemiş Grubu", new DateTime(2022, 11, 21, 14, 6, 26, 871, DateTimeKind.Local).AddTicks(174), true, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 21, 14, 6, 26, 870, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateOn",
                value: new DateTime(2022, 11, 20, 18, 48, 27, 356, DateTimeKind.Local).AddTicks(3521));
        }
    }
}
