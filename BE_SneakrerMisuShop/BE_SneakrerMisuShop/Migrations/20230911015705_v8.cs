using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_SneakrerMisuShop.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PercentPrice",
                table: "Vouchers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 9, 11, 8, 57, 4, 717, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 9, 11, 8, 57, 4, 717, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 9, 11, 8, 57, 4, 717, DateTimeKind.Local).AddTicks(8566));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentPrice",
                table: "Vouchers");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 9, 8, 15, 49, 56, 860, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 9, 8, 15, 49, 56, 860, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 9, 8, 15, 49, 56, 860, DateTimeKind.Local).AddTicks(5628));
        }
    }
}
