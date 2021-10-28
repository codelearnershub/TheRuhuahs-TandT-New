using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRuhuahs_TandTNew.Migrations
{
    public partial class Madmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 16, 59, 19, 41, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 16, 59, 19, 41, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 16, 59, 19, 41, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 16, 59, 19, 42, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 16, 59, 19, 42, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 28, 16, 59, 19, 38, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 28, 16, 59, 19, 41, DateTimeKind.Local).AddTicks(7765));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 3, 27, 4, 610, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 3, 27, 4, 610, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 3, 27, 4, 610, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 3, 27, 4, 610, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 28, 3, 27, 4, 610, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 28, 3, 27, 4, 604, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 28, 3, 27, 4, 610, DateTimeKind.Local).AddTicks(452));
        }
    }
}
