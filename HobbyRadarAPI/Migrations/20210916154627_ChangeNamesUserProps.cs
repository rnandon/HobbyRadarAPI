using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbyRadarAPI.Migrations
{
    public partial class ChangeNamesUserProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eed81cc-aae2-440a-8d34-7e91f28bb7b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8268a14c-c8ee-452e-acff-c8db6bc1c628");

            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "AspNetUsers",
                newName: "UserZip");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "AspNetUsers",
                newName: "UserState");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "AspNetUsers",
                newName: "UserCity");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "943ac117-3f5c-47fe-a39b-0b0f5d131691", "87b740f0-dfad-4e57-a9cb-e8f4d6c8ea1e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e33abd3-0735-4266-a81d-1788ead161fd", "ffc2803a-7ef4-4bbb-b0f7-75b3480ddde8", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e33abd3-0735-4266-a81d-1788ead161fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "943ac117-3f5c-47fe-a39b-0b0f5d131691");

            migrationBuilder.RenameColumn(
                name: "UserZip",
                table: "AspNetUsers",
                newName: "Zip");

            migrationBuilder.RenameColumn(
                name: "UserState",
                table: "AspNetUsers",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "UserCity",
                table: "AspNetUsers",
                newName: "City");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8268a14c-c8ee-452e-acff-c8db6bc1c628", "a0663700-0440-4402-90c8-62a8352799c4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1eed81cc-aae2-440a-8d34-7e91f28bb7b3", "71a2f28a-8218-4526-82dc-62669aa2a90d", "Admin", "ADMIN" });
        }
    }
}
