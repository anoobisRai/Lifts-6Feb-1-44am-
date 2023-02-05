using Microsoft.EntityFrameworkCore.Migrations;

namespace Lifts.Server.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "ca741a8c-1098-4414-a6d2-64a304087d0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "0ba481f8-7fba-4ccc-b06a-5c56310e6506");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00715135-1845-44cf-9da9-18ed67f96fb0", "AQAAAAEAACcQAAAAEER2AC22m5nzHcW0sA2zgJsj5Ms5Y9AhN9GxrQ1lzV09OJC4O2cXOFgANHX6azuh3g==", "55421cad-83a6-4c00-b7c1-f603ddc09916" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
