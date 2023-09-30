using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_SneakrerMisuShop.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinimumAmount",
                table: "Sales");

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 9, 18, 10, 43, 23, 454, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 9, 18, 10, 43, 23, 454, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 9, 18, 10, 43, 23, 454, DateTimeKind.Local).AddTicks(7452));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "Sales",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "MinimumAmount",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 9, 11, 14, 32, 30, 768, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 9, 11, 14, 32, 30, 768, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 9, 11, 14, 32, 30, 768, DateTimeKind.Local).AddTicks(934));
        }
    }
}
