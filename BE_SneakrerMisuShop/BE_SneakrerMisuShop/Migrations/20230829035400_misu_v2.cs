using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_SneakrerMisuShop.Migrations
{
    public partial class misu_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Vouchers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Sizes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "ProductImages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "ProductDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "DetailSales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Colors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Brands",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isDeleted",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 8, 29, 10, 54, 0, 76, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 8, 29, 10, 54, 0, 76, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 8, 29, 10, 54, 0, 76, DateTimeKind.Local).AddTicks(6182));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "DetailSales");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Accounts");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2023, 8, 29, 10, 33, 18, 110, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2023, 8, 29, 10, 33, 18, 110, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2023, 8, 29, 10, 33, 18, 110, DateTimeKind.Local).AddTicks(5293));
        }
    }
}
