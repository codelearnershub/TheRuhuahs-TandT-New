using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheRuhuahs_TandTNew.Migrations
{
    public partial class Nextmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(5483), "SuperAdmin" },
                    { 2, new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(6034), "Admin" },
                    { 3, new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(6043), "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConfirmPassword", "Country", "CreatedAt", "DateOfBirth", "Email", "FirstName", "Gender", "HashSalt", "LastName", "Mobile", "Password", "PasswordHash", "RoleId", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, null, "Nigeria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 25, 12, 25, 35, 941, DateTimeKind.Local).AddTicks(1846), "oyeleyeoyediran20@gmail.com", "Oyediran", "Male", "Rr+VsQuizJUuw6IIDqFEng==", "Umar", "09026315926", "1234", "lnjgV8+UnY+JzL+MW8HB2DGTbR/lSmCaAXfW0/sUUX4=", 0, "Abeokuta", "Asero" },
                    { 2, null, "Nigeria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(4114), "umaroyediran20@gmail.com", "Ajibola", "Male", "HpW+UDBZdxj9aU/qKevVjQ==", "Umar", "09026315926", "12345", "GW5/aRGQzvZKdWVGizIQb6ZzeiRBREcaT2Etlm3af+Y=", 0, "Abeokuta", "Asero" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "RoleId", "UserId" },
                values: new object[] { 1, new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(7839), 1, 1 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "RoleId", "UserId" },
                values: new object[] { 2, new DateTime(2021, 10, 25, 12, 25, 35, 944, DateTimeKind.Local).AddTicks(8107), 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_TouristCenterId",
                table: "Trips",
                column: "TouristCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Id",
                table: "Roles",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_TripId",
                table: "Packages",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Trips_TripId",
                table: "Packages",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_TouristCenters_TouristCenterId",
                table: "Trips",
                column: "TouristCenterId",
                principalTable: "TouristCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Trips_TripId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_TouristCenters_TouristCenterId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Trips_TouristCenterId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Id",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Packages_TripId",
                table: "Packages");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
