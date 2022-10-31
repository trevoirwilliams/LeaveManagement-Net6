using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class MigrationForAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin12-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f72dc71e-5614-48da-ab93-5791df5dba17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user12-f7bb-4448-baaf-1acd431ddbbf",
                column: "ConcurrencyStamp",
                value: "d5a9e784-4e9d-4382-9e92-b2e18005411e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d77d78b9d7d-1c3e-449d-f66e1234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e064eefb-408b-49c8-a8bf-71565ae5712b", "AQAAAAEAACcQAAAAEEzauSOaqBjxJO8PAvtV7dx+Y5YVqiKMB3QwvntNorQcE/LlX+zeHULk3bK1NLNr/w==", "f083093c-1a0a-418d-958a-f64d7344f0c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f66e1234-1c3e-449d-80c7-6d77d7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06327ee0-d6bb-4eef-be29-775f544f774c", "AQAAAAEAACcQAAAAEBdlaYhXCIdicydDuoK5wEdn1pdkjcP/Og31eVMIUsV31Z9ufLwsRvBLmyIpaxI0/Q==", "d0ebdf70-f904-4031-acfb-97384faafd54" });
        }
    }
}
