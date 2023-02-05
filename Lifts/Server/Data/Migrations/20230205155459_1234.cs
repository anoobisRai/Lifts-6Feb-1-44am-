using Microsoft.EntityFrameworkCore.Migrations;

namespace Lifts.Server.Data.Migrations
{
    public partial class _1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "84dfd954-b5ba-4ad8-aa67-6d697df13d9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "dfde15d0-c78a-4232-aa12-6ec893ccac73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "161ab423-40cd-4dab-816a-e737151a3857", "AQAAAAEAACcQAAAAEFnMGH3LJWVW9PyAxRaNxDw0I+pR8bwLtM5ucCF8erW8azugKWmuNKXkeO5OD/H1Kg==", "360a6e05-7a39-4555-a519-960a1394628d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
