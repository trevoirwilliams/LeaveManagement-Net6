using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedUsersAndRoles : Migration
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
                    { "admin12-f7bb-4448-baaf-1add431ccbbf", "97a6bf0d-a24b-4f2a-bfd7-18334bd07a74", "Administrator", "ADMINISTRATOR" },
                    { "user12-f7bb-4448-baaf-1acd431ddbbf", "459f3989-b97c-42af-940c-d28ffbff1689", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d77d78b9d7d-1c3e-449d-f66e1234", 0, "7a5a7f00-8367-4faf-ada0-415ee9ad3358", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminsson@hotmail.com", true, "Admin", "Adminsson", false, null, "ADMINSSON@HOTMAIL.COM", "ADMINSSON@HOTMAIL.COM", "AQAAAAEAACcQAAAAENI5Bt/grL8VIsPNdaaKpaqdHecoxSz0BiUOWbcpdjkpHcAI2sT+ZFWwPuwgae0bpw==", null, false, "746f7713-a0aa-48ad-a2d6-66548c21f617", null, false, "adminsson@hotmail.com" },
                    { "f66e1234-1c3e-449d-80c7-6d77d7", 0, "ba7a21f0-44c6-4a07-aa2f-a8ff01b67627", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "usersson@hotmail.com", true, "User", "Usersson", false, null, "USERSSON@HOTMAIL.COM", "USERSSON@HOTMAIL.COM", "AQAAAAEAACcQAAAAEEQG0c7A/TkqL3XjWJbkj7jYs41atjb6rxULaMilYqgeR6VUBXh6CWmDWe20z2+YNA==", null, false, "cd6676ac-44b6-4572-ac3f-6a276612c4d7", null, false, "usersson@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "admin12-f7bb-4448-baaf-1add431ccbbf", "6d77d78b9d7d-1c3e-449d-f66e1234" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "user12-f7bb-4448-baaf-1acd431ddbbf", "f66e1234-1c3e-449d-80c7-6d77d7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "admin12-f7bb-4448-baaf-1add431ccbbf", "6d77d78b9d7d-1c3e-449d-f66e1234" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user12-f7bb-4448-baaf-1acd431ddbbf", "f66e1234-1c3e-449d-80c7-6d77d7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin12-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user12-f7bb-4448-baaf-1acd431ddbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d77d78b9d7d-1c3e-449d-f66e1234");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f66e1234-1c3e-449d-80c7-6d77d7");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Name");
        }
    }
}
