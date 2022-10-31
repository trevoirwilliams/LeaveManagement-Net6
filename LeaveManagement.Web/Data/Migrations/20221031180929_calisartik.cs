using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class calisartik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin12-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "45241037-2792-4087-9f1a-96a53989335a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user12-f7bb-4448-baaf-1acd431ddbbf",
                column: "ConcurrencyStamp",
                value: "63ee4a48-5ba4-4a0e-aec7-f6693c74b326");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d77d78b9d7d-1c3e-449d-f66e1234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bde053a-3499-490a-a297-e6d883185a54", "AQAAAAEAACcQAAAAED1gf3FoaLuOpdOQuummoutNhEWrXRBXHdN+Zrs3Ndn60Sazyci6ilNJq+5GbEnZiw==", "2e840a93-1b89-4201-ac91-93caec208fd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f66e1234-1c3e-449d-80c7-6d77d7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ed526a-5530-4250-8b08-5b1ff445fc07", "AQAAAAEAACcQAAAAEDkjQKx5EkhT0ehh84x7SQOUXZcjZRUIBFHTPfAYoiR/AAVt/OJjHFdYwzfLCwoQKA==", "b28c30b1-fdfd-466f-b66a-3297c0c722a9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin12-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c515827a-0b11-4c07-9e91-f47eb827a4c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user12-f7bb-4448-baaf-1acd431ddbbf",
                column: "ConcurrencyStamp",
                value: "db79c430-57ca-41d6-87f4-56d74e9be703");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d77d78b9d7d-1c3e-449d-f66e1234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88268504-9993-40d2-be23-603bffec6757", "AQAAAAEAACcQAAAAEF/HUZDhXVzC8AWM+3B93va03MP9lM8HyNYsduIZUraHTkOkkU++bf8tdBNocwg7dw==", "45e1bfe3-766a-42cb-a14e-6d37d9778180" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f66e1234-1c3e-449d-80c7-6d77d7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cf334c9-f9ce-46f4-b33d-778385b47e59", "AQAAAAEAACcQAAAAEPcNpe3LAXQ489+q19hpHVtf3KnVyKkEnCqVo+1HUW6t44Emzr0vw/9D5OKm3V94Dw==", "25253108-1931-46cd-9e46-8d498127e332" });
        }
    }
}
