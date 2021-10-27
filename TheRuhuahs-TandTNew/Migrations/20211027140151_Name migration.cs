using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRuhuahs_TandTNew.Migrations
{
    public partial class Namemigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Package",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PackageId",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 15, 1, 51, 83, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 15, 1, 51, 83, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 15, 1, 51, 83, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 15, 1, 51, 83, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 15, 1, 51, 83, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 27, 15, 1, 51, 79, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 27, 15, 1, 51, 83, DateTimeKind.Local).AddTicks(2927));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "Package",
                table: "Bookings",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 25, 12, 25, 35, 941, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(4114));
        }
    }
}
