using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class _ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin12-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4258307b-49b1-486a-80b9-be948a9885e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user12-f7bb-4448-baaf-1acd431ddbbf",
                column: "ConcurrencyStamp",
                value: "8fc5fff3-49d1-4dfd-ba37-8cdb2306c7ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d77d78b9d7d-1c3e-449d-f66e1234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05fe6240-2f61-4578-a610-83c860975ce2", "AQAAAAEAACcQAAAAEOodFBbnH0+Tq3/a8YF3e64x6kR7vzpntAs3O8u5gSSs62wOFXO+FRDiIfKB6dcdrA==", "9e1c4966-c61e-4f7d-9551-ad64a17bc5d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f66e1234-1c3e-449d-80c7-6d77d7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ad11ca6-b1be-4979-a514-2ed3a83f91fc", "AQAAAAEAACcQAAAAEETQR82Lw5qZwIxkyq42w+pUliWeroBFWeG8xhlUlLJkaGA1QBWUL5L9OlIjjlvstg==", "2acabe16-84e4-4e13-aa25-cd3621e4cf49" });
        }
    }
}
