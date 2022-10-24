using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedRolesAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "8661d268-87ef-4510-b217-410fe7695aff", "Administrator", "ADMINISTRATOR" },
                    { "cac51a7e-f7bb-4448-baaf-1acd431ddbbf", "4a79941e-225e-4d63-9fdb-be68c789eb79", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f39e6011-1c3e-449d-80c7-6d77d78b9d7d", 0, "14c3e80d-e455-4c11-8e0c-0dcea03f289f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emreersoylu@hotmail.com", true, "Emre", "Ersoylu", false, null, "EMREERSOYLU@HOTMAIL.COM", "EMREERSOYLU@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPRdm3XfKk5MIH/YSYqq/PdH/WuZdPEplLJVklmkNzzQg5oCvU7a8wNxaIBN9PuPHw==", null, false, "3ab26926-8159-42b6-ba1a-3b953e3eab4a", null, false, "emreersoylu@hotmail.com" },
                    { "f66e1234-1c3e-449d-80c7-6d77d78b9d7d", 0, "02a8327e-47aa-4526-be23-221918b93343", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "turkanersoylu@hotmail.com", true, "Turkan", "Ersoylu", false, null, "TURKANERSOYLU@HOTMAIL.COM", "TURKANERSOYLU@HOTMAIL.COM", "AQAAAAEAACcQAAAAELdlAXdjiRHS2W78R20omPM/i2YkpYgkzq8sOhp2xTS1o3KQoy1uWxFd7IFBafbWsg==", null, false, "e64f37cb-a82c-4ac5-9358-f4a1bc9cd4bb", null, false, "turkanersoylu@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-d8bb-4448-baaf-1add431ccbbf", "f39e6011-1c3e-449d-80c7-6d77d78b9d7d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac51a7e-f7bb-4448-baaf-1acd431ddbbf", "f66e1234-1c3e-449d-80c7-6d77d78b9d7d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-d8bb-4448-baaf-1add431ccbbf", "f39e6011-1c3e-449d-80c7-6d77d78b9d7d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac51a7e-f7bb-4448-baaf-1acd431ddbbf", "f66e1234-1c3e-449d-80c7-6d77d78b9d7d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac51a7e-f7bb-4448-baaf-1acd431ddbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f39e6011-1c3e-449d-80c7-6d77d78b9d7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f66e1234-1c3e-449d-80c7-6d77d78b9d7d");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Name");
        }
    }
}
