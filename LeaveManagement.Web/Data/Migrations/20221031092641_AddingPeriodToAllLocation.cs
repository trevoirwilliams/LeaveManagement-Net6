using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllLocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin12-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "97a6bf0d-a24b-4f2a-bfd7-18334bd07a74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user12-f7bb-4448-baaf-1acd431ddbbf",
                column: "ConcurrencyStamp",
                value: "459f3989-b97c-42af-940c-d28ffbff1689");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d77d78b9d7d-1c3e-449d-f66e1234",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a5a7f00-8367-4faf-ada0-415ee9ad3358", "AQAAAAEAACcQAAAAENI5Bt/grL8VIsPNdaaKpaqdHecoxSz0BiUOWbcpdjkpHcAI2sT+ZFWwPuwgae0bpw==", "746f7713-a0aa-48ad-a2d6-66548c21f617" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f66e1234-1c3e-449d-80c7-6d77d7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba7a21f0-44c6-4a07-aa2f-a8ff01b67627", "AQAAAAEAACcQAAAAEEQG0c7A/TkqL3XjWJbkj7jYs41atjb6rxULaMilYqgeR6VUBXh6CWmDWe20z2+YNA==", "cd6676ac-44b6-4572-ac3f-6a276612c4d7" });
        }
    }
}
