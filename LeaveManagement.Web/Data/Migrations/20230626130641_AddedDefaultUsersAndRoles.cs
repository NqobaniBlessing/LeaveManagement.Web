using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ec693b3-e694-8dd4-8ac9-e71f8d635a59", "ae8d9e79-fae5-49cd-a3ac-f535d5f519ce", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ee693b3-e594-4f4-8ab9-e71f8d655d47", "92f26231-56ff-4548-a353-ed15138156d2", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5ab992b3-e594-4cd4-8ca9-e61f8d655d47", 0, "308ac2e4-3b73-48b0-8ac1-c6befd052347", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bnyoni@imgsol.co.zw", true, "System", "Admin", false, null, "BNYONI@IMGSOL.CO.ZW", "BNYONI@IMGSOL.CO.ZW", "AQAAAAEAACcQAAAAEOBfBzGzjR4PHDGsLwTxILDi7WXYsDPCgvMeByphhlz1c2taegygALAJBNIfvssKFg==", null, false, "1e46c210-25e0-41fb-9c8b-761b3cf99fc2", null, false, "bnyoni@imgsol.co.zw" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ee693b3-e594-4f4-8ab9-e71f8d655d47", "5ab992b3-e594-4cd4-8ca9-e61f8d655d47" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ec693b3-e694-8dd4-8ac9-e71f8d635a59");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ee693b3-e594-4f4-8ab9-e71f8d655d47", "5ab992b3-e594-4cd4-8ca9-e61f8d655d47" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee693b3-e594-4f4-8ab9-e71f8d655d47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ab992b3-e594-4cd4-8ca9-e61f8d655d47");
        }
    }
}
