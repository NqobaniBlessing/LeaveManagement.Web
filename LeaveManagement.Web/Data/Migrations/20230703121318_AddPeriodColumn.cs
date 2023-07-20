using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ec693b3-e694-8dd4-8ac9-e71f8d635a59",
                column: "ConcurrencyStamp",
                value: "7d36ab22-a593-4c4e-9e71-1645f3daf19f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee693b3-e594-4f4-8ab9-e71f8d655d47",
                column: "ConcurrencyStamp",
                value: "e9f04cf8-d7c9-451d-86b1-a96f8b7e1a61");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ab992b3-e594-4cd4-8ca9-e61f8d655d47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf4e28e5-8a42-47ea-9372-e95097823546", "AQAAAAEAACcQAAAAEKMExivGFHuxmmL6hmWf+bZJDxogpUusj6v4nUbrbWEeyVyK6QGKQaiDeB/S+IsU1Q==", "70f4b30c-8333-4803-b99c-8872e0f25198" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ec693b3-e694-8dd4-8ac9-e71f8d635a59",
                column: "ConcurrencyStamp",
                value: "ae8d9e79-fae5-49cd-a3ac-f535d5f519ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee693b3-e594-4f4-8ab9-e71f8d655d47",
                column: "ConcurrencyStamp",
                value: "92f26231-56ff-4548-a353-ed15138156d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ab992b3-e594-4cd4-8ca9-e61f8d655d47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "308ac2e4-3b73-48b0-8ac1-c6befd052347", "AQAAAAEAACcQAAAAEOBfBzGzjR4PHDGsLwTxILDi7WXYsDPCgvMeByphhlz1c2taegygALAJBNIfvssKFg==", "1e46c210-25e0-41fb-9c8b-761b3cf99fc2" });
        }
    }
}
