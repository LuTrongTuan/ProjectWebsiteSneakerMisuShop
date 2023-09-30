using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_SneakrerMisuShop.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "DetailSales");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 9, 18, 10, 45, 15, 135, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 9, 18, 10, 45, 15, 135, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 9, 18, 10, 45, 15, 135, DateTimeKind.Local).AddTicks(1306));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "DetailSales",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
    }
}
