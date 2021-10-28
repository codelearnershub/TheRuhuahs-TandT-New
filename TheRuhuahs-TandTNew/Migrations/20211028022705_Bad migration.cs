using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRuhuahs_TandTNew.Migrations
{
    public partial class Badmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateOfBirth", "RoleId" },
                values: new object[] { new DateTime(2021, 10, 28, 3, 27, 4, 604, DateTimeKind.Local).AddTicks(9625), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "RoleId" },
                values: new object[] { new DateTime(2021, 10, 28, 3, 27, 4, 610, DateTimeKind.Local).AddTicks(452), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 16, 50, 17, 861, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 16, 50, 17, 861, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 16, 50, 17, 861, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 16, 50, 17, 861, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 27, 16, 50, 17, 861, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "RoleId" },
                values: new object[] { new DateTime(2021, 10, 27, 16, 50, 17, 857, DateTimeKind.Local).AddTicks(3066), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "RoleId" },
                values: new object[] { new DateTime(2021, 10, 27, 16, 50, 17, 860, DateTimeKind.Local).AddTicks(9535), 0 });
        }
    }
}
