using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbyRadarAPI.Migrations
{
    public partial class SimplifyControllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectionInvites_AspNetUsers_FromUserId",
                table: "ConnectionInvites");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectionInvites_AspNetUsers_ToUserId",
                table: "ConnectionInvites");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_AspNetUsers_User1Id",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_AspNetUsers_User2Id",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAttendances_AspNetUsers_UserId",
                table: "EventAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAttendances_ScheduledEvents_ScheduledEventId",
                table: "EventAttendances");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyTags_Tags_TagId",
                table: "HobbyTags");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHobbyRating_AspNetUsers_UserId",
                table: "UserHobbyRating");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHobbyRating_Hobbies_HobbyId",
                table: "UserHobbyRating");

            migrationBuilder.DropIndex(
                name: "IX_UserHobbyRating_HobbyId",
                table: "UserHobbyRating");

            migrationBuilder.DropIndex(
                name: "IX_HobbyTags_TagId",
                table: "HobbyTags");

            migrationBuilder.DropIndex(
                name: "IX_EventAttendances_UserId",
                table: "EventAttendances");

            migrationBuilder.DropIndex(
                name: "IX_Connections_User2Id",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_ConnectionInvites_FromUserId",
                table: "ConnectionInvites");

            migrationBuilder.DropIndex(
                name: "IX_ConnectionInvites_ToUserId",
                table: "ConnectionInvites");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67c88fe3-c214-4bad-a24e-15b7202748a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79e2651f-e063-48ed-9b8a-073e945e9436");

            migrationBuilder.AlterColumn<string>(
                name: "ToUserId",
                table: "ConnectionInvites",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FromUserId",
                table: "ConnectionInvites",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46c79e64-05ce-4b38-a46f-66f521c347dc", "6adf956c-dd46-4843-a457-ac4cb3efd0dd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c846149-4c0d-4756-ab99-a363c6e7ce98", "7c76bfa5-01ba-4d39-879f-d02806f10dd6", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c846149-4c0d-4756-ab99-a363c6e7ce98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c79e64-05ce-4b38-a46f-66f521c347dc");

            migrationBuilder.AlterColumn<string>(
                name: "ToUserId",
                table: "ConnectionInvites",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FromUserId",
                table: "ConnectionInvites",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "79e2651f-e063-48ed-9b8a-073e945e9436", "95386870-9dac-4f71-8be8-49fad58f09d8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67c88fe3-c214-4bad-a24e-15b7202748a0", "5f9b6ffd-89c5-4132-b8a4-9dd032c53b21", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_UserHobbyRating_HobbyId",
                table: "UserHobbyRating",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyTags_TagId",
                table: "HobbyTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendances_UserId",
                table: "EventAttendances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_User2Id",
                table: "Connections",
                column: "User2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectionInvites_FromUserId",
                table: "ConnectionInvites",
                column: "FromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectionInvites_ToUserId",
                table: "ConnectionInvites",
                column: "ToUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectionInvites_AspNetUsers_FromUserId",
                table: "ConnectionInvites",
                column: "FromUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectionInvites_AspNetUsers_ToUserId",
                table: "ConnectionInvites",
                column: "ToUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_AspNetUsers_User1Id",
                table: "Connections",
                column: "User1Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_AspNetUsers_User2Id",
                table: "Connections",
                column: "User2Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventAttendances_AspNetUsers_UserId",
                table: "EventAttendances",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventAttendances_ScheduledEvents_ScheduledEventId",
                table: "EventAttendances",
                column: "ScheduledEventId",
                principalTable: "ScheduledEvents",
                principalColumn: "ScheduledEventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyTags_Tags_TagId",
                table: "HobbyTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHobbyRating_AspNetUsers_UserId",
                table: "UserHobbyRating",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHobbyRating_Hobbies_HobbyId",
                table: "UserHobbyRating",
                column: "HobbyId",
                principalTable: "Hobbies",
                principalColumn: "HobbyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
