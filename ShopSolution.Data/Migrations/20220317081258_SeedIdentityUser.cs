using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("cccf417d-88af-4fae-9434-ed2464311aa4"), "1c14ba74-5441-4f1a-bdfb-f7772630ef5c", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("7d9b1fa1-56e8-4d15-817a-b1f540c77bc5"), new Guid("cccf417d-88af-4fae-9434-ed2464311aa4") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7d9b1fa1-56e8-4d15-817a-b1f540c77bc5"), 0, "91dce70b-5c45-4edd-bb08-460f6ee2fcdd", new DateTime(1998, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "hangtruong11398@gmail.com", true, "Hang", "Truong", false, null, "hangtruong11398@gmail.com", "admin", "AQAAAAEAACcQAAAAEBCX7zTHy++Jv20nKZFCpypK6PEpP0FmTwwoo7NO5dvJwsBMDoW5/Gklj/aho+MPNg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 17, 15, 12, 57, 412, DateTimeKind.Local).AddTicks(8741));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cccf417d-88af-4fae-9434-ed2464311aa4"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("7d9b1fa1-56e8-4d15-817a-b1f540c77bc5"), new Guid("cccf417d-88af-4fae-9434-ed2464311aa4") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d9b1fa1-56e8-4d15-817a-b1f540c77bc5"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 17, 14, 40, 38, 250, DateTimeKind.Local).AddTicks(7473));
        }
    }
}
