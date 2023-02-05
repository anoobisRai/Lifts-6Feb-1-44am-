using Microsoft.EntityFrameworkCore.Migrations;

namespace Lifts.Server.Data.Migrations
{
    public partial class nigga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "65945cfe-71a8-47a4-9138-e00811b7e89c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "3019048c-016d-4d3e-836e-f771d8299eaa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2d62d5d-d628-44e6-a0d2-89f22a62e0a2", "AQAAAAEAACcQAAAAEDL53LN8yAUYFaqA+cAYsIymy08S1S//y3AzelUqK9Ipk2i1RVJjXUKeuFQYop6o2Q==", "2d9ecefd-5bba-4faa-9338-73a0a4d60f1f" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CustomerContactNumber", "CustomerEmail", "CustomerLicense", "CustomerName", "CustomerPassword", "CustomerUsername" },
                values: new object[,]
                {
                    { 1, 91290002, "JohnLee@gmail.com", "123A", "John Lee", "91290002U", "Rock Johnson" },
                    { 2, 91010100, "MaryJane@gmail.com", "234A", "Mary Jane", "1111111A", "Spidey lover" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "StaffContactNumber", "StaffEmail", "StaffName", "StaffPassword", "StaffUsername" },
                values: new object[,]
                {
                    { 1, 91290002, "ProvinLee@gmail.com", "Provin Lee", "91290002U", "Rock Johnson" },
                    { 2, 91010100, "GwenStacy@gmail.com", "Gwen Stacy", "1111111A", "Spiderman2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "71f59d13-9cf3-4a03-965f-aedbd0792d21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "9596b9be-8a58-49c9-8222-5e573155e72c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7103032-ead8-4984-ac87-1abc9dd10abd", "AQAAAAEAACcQAAAAEMZs5P9UwqPreV6NDHH6ZPtNqFxn9vp8Cq1OXN0rbwFXdCvQ0ZcXbCeY1G20uZjloA==", "557cfa95-2bce-42c8-b073-c697322eb94d" });
        }
    }
}
