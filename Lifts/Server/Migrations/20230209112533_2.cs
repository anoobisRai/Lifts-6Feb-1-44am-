using Microsoft.EntityFrameworkCore.Migrations;

namespace Lifts.Server.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "0a88829b-840a-4926-b3aa-76851f69d443");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "ea96caac-3c72-440e-918a-519931488401");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ce7cde8-bde0-437f-8ab8-28f96d64c046", "AQAAAAEAACcQAAAAECot9xWHFjhuEDhGJOlOOF58kfvqGF3ohGWBmBE0Kn4orYNpfY4XgGh8z/ZHg/I8ag==", "3b54b50e-a145-4ff6-9675-3701a8e0b646" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "StaffContactNumber", "StaffEmail", "StaffName", "StaffPassword", "StaffUsername" },
                values: new object[,]
                {
                    { 3, 82683263, "Ongyanyanz@gmail.com", "Ong Yan Lee", "2101115J", "Zalrenic Johnson" },
                    { 4, 81129750, "anoobiez@gmail.com", "Anoobie", "2101646D", "oowie jonny" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "0adb9c35-a5cf-46ea-ab85-68febcc15013");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "ab16ec28-219c-478b-a86e-838ce7d95175");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f19b117-5cfb-4157-a305-3954c60f5eeb", "AQAAAAEAACcQAAAAECT1O4BJ3tb4KxJ8eXzgF4aY58NEjGBjqmvMKVcyB8c1ooweK5Rc2f9apVs+Q9WnUg==", "1e90c0ae-6caa-4cf1-a840-7ffaf5e9c339" });
        }
    }
}
