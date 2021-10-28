using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRuhuahs_TandTNew.Migrations
{
    public partial class Anothermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedingStandard",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "TransportationExpense",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "TransportationStandard",
                table: "Packages");

            migrationBuilder.AddColumn<string>(
                name: "PackageType",
                table: "Packages",
                nullable: true);

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
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 27, 16, 50, 17, 857, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2021, 10, 27, 16, 50, 17, 860, DateTimeKind.Local).AddTicks(9535));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PackageType",
                table: "Packages");

            migrationBuilder.AddColumn<string>(
                name: "FeedingStandard",
                table: "Packages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TransportationExpense",
                table: "Packages",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TransportationStandard",
                table: "Packages",
                type: "text",
                nullable: true);

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
    }
}
