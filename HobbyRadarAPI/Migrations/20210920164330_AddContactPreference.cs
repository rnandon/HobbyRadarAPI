using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbyRadarAPI.Migrations
{
    public partial class AddContactPreference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f8d34ac-72d3-4e9c-b755-32e73d5e287f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a9fa479-df89-4f02-a97d-0f1259c0dca6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548fdb44-0e52-436e-b63e-79880fe150c5");

            migrationBuilder.AddColumn<string>(
                name: "ContactPreference",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cdceb03-0523-4aca-9a0a-84e938b23c0b", "4e06b4f6-9969-430c-ae01-6098203d18a1", "User", "USER" },
                    { "b4fd2960-9cac-4399-8977-2ab3d72aab47", "073125c3-2682-42dc-8efc-282ac7d3c9b1", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f22c979-726f-4962-b2b5-bf5e83cc13f1",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "47917331-e55f-4c21-84ef-511ec3efa8d0", "none", "15508967-921f-43e6-b805-d24ce558188f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6fbbd3-5b86-4154-bd59-10901df0ad81",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "96cae7d8-9f98-4fc3-8091-f755d8262c3f", "none", "324b220a-04f0-425e-86d9-b7f7544f94b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3047431e-a67a-47b7-8ff6-d524c3583be0",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "b1b6513c-5716-45db-bf01-3c0b2be92ef7", "none", "d038fe22-0dd6-4094-85c6-3150eefb23e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "0d1bd1ba-679a-4a3b-b565-74378f691012", "none", "3150d4a9-739e-48c0-aa8f-efe69ca448fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39dd92a6-b55d-4f0f-b614-76b15b550678",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "fb3cae3b-8fea-46e0-9efe-be3d4cb78495", "none", "67f863d0-fcac-4d93-969a-12d52ba7a9ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6268e0-e090-4291-a610-8004347721dc",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "9501b4e5-ad92-4e1e-ac1a-caf4a8f7b020", "none", "4c899bcf-8410-4d25-b443-01f23f26c833" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404e8d45-1b49-448a-be30-9ecc57b340af",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "00971e4b-c672-4cf6-b1a3-e1ee9a6a835e", "none", "234b0e8c-c0ac-40f3-b0fd-a51300d2b22c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406efbec-e351-4369-a812-d7a0df894b30",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "4107880e-26f5-4860-ad07-26ba8436f73d", "none", "2d67f7fa-a896-4238-abc3-2340fe5fa7ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42d8c277-8adb-4479-9499-1f52b917b528",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "9b62dd05-20df-44cb-832b-b4b7506e4928", "none", "7e0be25d-a8e0-41c5-8270-0b9d5935685f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ed259d-18c9-47fe-9e67-111dbc445fd4",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "910ed2d4-40c8-4b54-8b83-7691f96691b4", "none", "4e89df14-e8fa-450e-927e-d20abcc974f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968a764-9310-40b7-b114-08ad4a191db5",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "4745162a-1211-4116-95f4-74d24ab35497", "none", "ed3c7e63-ca7b-494f-ac15-369fe86a0c50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55367a6a-2505-4ce4-99cf-b77d55df3320",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "ccf785ec-46fb-431d-9ca4-a5460946824a", "none", "d50afa47-9333-48f0-baca-5c2c1a33bf06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558de276-cdd7-4f80-b7a7-9471e579788f",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "a4923a2a-88f5-40ad-b0fd-95da6f361abe", "none", "199a3b22-419b-4d04-b592-8daa863e0c1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b050e9-93d3-4539-a13b-dfbcf27361b8",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "13131e45-4c83-487b-b328-e2ee47eccef4", "none", "925e993d-f08d-450a-86f8-8443995cb195" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f57cdbe-e41f-4d6b-8e11-ebe076723861",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "e3dca680-377e-4340-a74c-9da71a1fe4bb", "none", "04121ea2-727a-423a-973a-d0707312ef0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728d5de5-a876-4ec3-ae28-f9bd5d54e504",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "a37f5960-82d8-4dbd-ae8c-17ede399eb74", "none", "6b8e72ef-fbb2-4fd5-8690-316380627e19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737dd08e-80c1-45bd-a2b9-98a5d324cd1a",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "222dbe15-928d-42d5-ae5d-2c762a24d89d", "none", "29bca6e7-9302-4ba7-8552-9516348d6026" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c5f76c-51ee-4c0a-bc26-f96cac06b92b",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "01c2c6c9-5c6f-43b2-9001-35fd202c732d", "none", "06bb9111-e826-4488-a68f-aacccea906f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baa663b-5422-4e0d-9d89-8d85eacb0e5c",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "60dd62f6-4755-476b-9133-685116e26258", "none", "bd1dd266-c241-4c5c-9e71-b5322f3dadb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0f6526-4964-4e75-82cc-dc7f5c662e5b",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "a691b3a5-0d2d-4b74-9ea8-845038cb9cdb", "none", "13cc2113-2f67-4703-8f67-74e018179a86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e68dbf-d08e-4b3a-bb44-642f44826249",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "e01e21ca-83af-4008-867c-71531f1b187b", "none", "50c3cbbb-00b4-473d-91b4-50f12a550b99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977a193e-b63c-4b74-8c2c-13fac432a3ff",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "76de6877-90a2-4ef3-88dd-f686499338b0", "none", "a82286c9-31aa-4add-92cc-9334da8d3fb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfe112-4c41-4022-a5fe-62a83e8fc299",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "820ad31a-487d-4618-86bc-53656bad45e6", "none", "aaf43636-aac7-43f5-88f6-30403f412f6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1abf5b1-34bd-46cd-ace4-7623fe26813b",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "5de4e4af-4774-418a-b4f7-39b1b43bd24c", "none", "ce7c7c9f-1ab2-42d3-a661-ec53bdd195b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "8ea662fd-82be-4d22-a600-8035b2c76ab3", "none", "bf5e49b8-a580-4fa6-bbf0-870af277a7ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b455a890-08c6-4e6f-bfe7-30cc99cf2f72",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "6cd665af-1e3b-4b06-8a81-5d00d5b6749e", "none", "84468388-4bc6-4fb0-9be2-7c94759387c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4769c29-8598-480b-b5d3-698700864869",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "a33a1465-6911-409b-827c-caefc4783ec8", "none", "71c7c9ec-9234-4ce4-8c80-2a04fd2206e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7629af8-b837-4e6d-a0d5-156a88c2749d",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "3ecb1563-e4f9-41af-a2b4-577d1a47096b", "none", "fc2af253-027c-491e-a94b-cbd69d8029c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caacdd8d-c803-4680-aa29-fe0d99f67abb",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "f1531a27-b2e9-4afc-9cfe-97f13fee1ff0", "none", "a332d53d-6943-48a2-9448-baea665976b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd834580-5220-4fed-a923-fc03e1d3de14",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "746f7516-4373-409e-9c05-113cdd0237cb", "none", "bd55eca6-a2ba-44a2-9583-eb8296f57546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "ae396545-1377-486e-8cf2-cc8a11c66136", "none", "8bf3c1ed-8fcc-4f66-8a4c-232121fe7393" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d957f266-695c-4e51-bb05-ddd4c78ab54b",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "e85bcd6f-f8f7-40c3-b11e-aef76d14cdf7", "none", "d5561e16-7a82-4386-a6d3-d7312e26e58a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbbd1a5a-1161-483e-a705-5cb5b640f239",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "3668ee9c-565c-488c-9c00-92addb9f190a", "none", "e24a0a82-3569-49cb-9cfd-bac2cfec33f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e303170d-4192-4733-b5a2-7eafea38e142",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "e0512f0d-8f43-4540-95a8-dc6b9145f42b", "none", "41c9cd5f-84b9-4479-957b-5dd592e9e394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47ff457-1df0-4275-9d6c-e76fe98fa961",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "e00653e8-0bf5-4f28-979a-0ee16fed25c9", "none", "f21fdc0a-8284-4e84-af7c-4b572a15e9b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5a62d42-8dde-4584-9107-19a825c9d241",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "80bde4da-acdf-4cfb-9412-fa1fb8c5435b", "none", "ad4acb8a-b0e0-4dca-863c-968b24865374" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70b4e31-573d-4132-9867-4c0a7f7302ec",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "674de07c-04d7-45d9-8f4f-9500972793b2", "none", "1efb898b-0417-4dc5-aafa-a4b371baccb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e741c863-683d-4a5b-aad9-7bec025a352b",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "4a835bdc-8769-4beb-868d-09508738e111", "none", "ec281eae-1a46-4d82-bd74-43485e3e112f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f079118a-23ea-4723-a979-27ae21dafbe1",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "43bd6fde-a244-4154-a96a-ba516910a981", "none", "85250226-b32c-4388-859d-0421c23d220b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054",
                columns: new[] { "ConcurrencyStamp", "ContactPreference", "SecurityStamp" },
                values: new object[] { "da59c837-1bb3-4e93-b6ca-868f9174c3ab", "none", "4339cd75-7cb7-4f08-9015-37c3ab490a28" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactPreference", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserCity", "UserName", "UserState", "UserZip" },
                values: new object[] { "4300842f-5029-446a-b43e-0775403037b6", 0, "bcc8b588-eefe-494c-900f-276d4c946fe7", null, "ADMIN@website.com", false, "ADMIN", "ADMIN", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "e58c5031-cca4-4550-957d-ed0390e8facd", false, "Milwaukee", "ADMIN", "WI", "53172" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cdceb03-0523-4aca-9a0a-84e938b23c0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4fd2960-9cac-4399-8977-2ab3d72aab47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4300842f-5029-446a-b43e-0775403037b6");

            migrationBuilder.DropColumn(
                name: "ContactPreference",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a9fa479-df89-4f02-a97d-0f1259c0dca6", "b0e7746c-56a1-4018-a139-c11076e6a60e", "User", "USER" },
                    { "1f8d34ac-72d3-4e9c-b755-32e73d5e287f", "e8d2429c-2485-49fe-b066-228f9b4c084f", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f22c979-726f-4962-b2b5-bf5e83cc13f1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1f99889-2b15-489a-8d98-701513eb1413", "69a6a999-679a-46a0-8c93-8f550cbfec85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6fbbd3-5b86-4154-bd59-10901df0ad81",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "616ebbe7-76ba-4e91-a946-b6fa59aa0a38", "49a91243-f2c4-4298-ab49-2e48062e6e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3047431e-a67a-47b7-8ff6-d524c3583be0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eccda25d-5c99-49d6-926e-7d704879bdc7", "be77e07f-09c5-4214-acea-3d15ee29ce0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00ce7690-8b18-432b-b3f8-842536c4a41e", "bb94c68c-30ef-4277-9ac2-919e35fc3a07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39dd92a6-b55d-4f0f-b614-76b15b550678",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1046db20-8ba0-414c-992e-bc47027e6755", "27bdcaf0-034c-47cd-bf31-1c00026a1c96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6268e0-e090-4291-a610-8004347721dc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "452c8015-24ea-408f-9761-9db7a5899a2c", "8cb40aa8-2652-4a4e-bed9-090dca6b8645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404e8d45-1b49-448a-be30-9ecc57b340af",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab2e94b1-9e11-41b3-93e7-00d4bf1e677f", "49b7bded-aec3-4b27-869d-32f21a9c1c4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406efbec-e351-4369-a812-d7a0df894b30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6476b6d9-4655-4e4b-b00e-fba529ac954e", "4c570fd3-e5be-47e8-8011-5ab285b161b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42d8c277-8adb-4479-9499-1f52b917b528",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "caa74544-f55d-44cc-a05c-62c7d7acbcd9", "914fb5c4-130d-4cff-94a1-5444f96b485f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ed259d-18c9-47fe-9e67-111dbc445fd4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "365968ca-17f3-4c08-b380-0c4bd051c7e3", "bfe3f81e-4de5-4950-b009-8651cc13332f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968a764-9310-40b7-b114-08ad4a191db5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ef27ae0-e5cf-4b90-ac1b-96862be2f4b1", "1af7e496-9f4c-4324-ab56-6fe063c840ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55367a6a-2505-4ce4-99cf-b77d55df3320",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6b65f33c-6f26-48b8-995c-89f6ff7d1fd0", "cf80e974-6c54-4493-ad57-719d2e311658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558de276-cdd7-4f80-b7a7-9471e579788f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ada75de6-ab66-4434-b4e3-8515e5550cc8", "56dcdef6-e7ca-40e4-b2a5-140c46472e78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b050e9-93d3-4539-a13b-dfbcf27361b8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2041f86-8a2c-4fad-a6ec-533b091ffc5c", "9d3c60f7-5216-4ba1-94bf-2608e2cea61f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f57cdbe-e41f-4d6b-8e11-ebe076723861",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7aa3b7d7-4463-41d5-9755-16bb988ad6dd", "04a00ead-b23a-42d2-9a54-118bad5da5a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728d5de5-a876-4ec3-ae28-f9bd5d54e504",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15e3a207-6d8d-46b7-9199-8345bbeca895", "94fedcea-0927-49a3-bb33-f6c65e467abf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737dd08e-80c1-45bd-a2b9-98a5d324cd1a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b283780-5fe8-4062-a377-dbdf1bcb87dc", "02de33bb-3e59-41f3-a510-79d512c10de4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c5f76c-51ee-4c0a-bc26-f96cac06b92b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49723f83-4f79-4523-8d84-d04f07849a53", "ae5d15cc-f1c0-41fb-a414-c1b3cc9c202d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baa663b-5422-4e0d-9d89-8d85eacb0e5c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbce39f8-acb2-4f44-b839-3d4106b538a8", "86ebbe31-5155-47b2-8711-d471e3aa29c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0f6526-4964-4e75-82cc-dc7f5c662e5b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6470ab64-b067-4323-99ae-eeecb88d9ed6", "54125c87-84fa-422f-bde1-3606f61b58cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e68dbf-d08e-4b3a-bb44-642f44826249",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5e18a3b-3c16-4faa-b2d4-a80a1b61bd39", "4c91cb41-ae17-4459-a223-f893331e8ec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977a193e-b63c-4b74-8c2c-13fac432a3ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9857221b-5857-4abf-ae83-a42525dfa107", "8451a369-7155-4ac3-8f21-a694548f6cb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfe112-4c41-4022-a5fe-62a83e8fc299",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dab21e6a-c661-4bb2-a8d2-9e3346bf4398", "e1254491-7785-4c5f-81cd-e5ee2961cf12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1abf5b1-34bd-46cd-ace4-7623fe26813b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16b71352-db10-467c-9534-171b1b20fdd2", "e5ad242c-77bd-40df-b769-af5473478223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9aca6c2a-50ee-420f-ba8a-3b0ac16ccdc8", "7f947835-76c1-4bb4-9d23-65e3e000748a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b455a890-08c6-4e6f-bfe7-30cc99cf2f72",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7654167f-dfd2-468b-a6bf-b5f743b9d9f2", "76e04e9d-f2f1-4ed9-8cce-87389ee5410e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4769c29-8598-480b-b5d3-698700864869",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a314100b-4eed-4df1-9a05-7023ecdf52f3", "a6a17894-7b3f-459b-96bf-f6e65bbe6d14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7629af8-b837-4e6d-a0d5-156a88c2749d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ab99d6e-b955-4591-8481-0f7e19b11f19", "cd6276fa-65e8-4d33-9b0d-4045260cd624" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caacdd8d-c803-4680-aa29-fe0d99f67abb",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed974457-390b-4356-a57d-aef892124a3f", "18e483fb-7a6f-48d5-a63b-05a3a53ef53b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd834580-5220-4fed-a923-fc03e1d3de14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab702fb2-cbca-47e0-9d7f-37087558b225", "f07d9886-0057-4b71-b247-d5e131a49dcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99d15479-ee47-4c65-a50a-59f54acca713", "d60a804e-cfa8-4895-9792-c71a023f60f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d957f266-695c-4e51-bb05-ddd4c78ab54b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef819755-3747-4ffb-b575-c49375f66ba6", "6bbff5bc-8a99-4683-acbd-444d752e92e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbbd1a5a-1161-483e-a705-5cb5b640f239",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "263aa80f-67e4-44b6-8a1b-8b147d5e3178", "a25a463a-4db3-4426-a008-1331e5a5c724" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e303170d-4192-4733-b5a2-7eafea38e142",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88a037c9-47ca-421d-8bfe-a3434de405db", "8488fcc7-249a-4117-add6-8a9e5b00378a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47ff457-1df0-4275-9d6c-e76fe98fa961",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "deb2caa7-fff6-4635-b69e-307461d7d3c1", "b7e10ef0-0be7-43e8-97bf-99f2d91939b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5a62d42-8dde-4584-9107-19a825c9d241",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63472930-14a2-491e-8e30-b1ad963c84cc", "196206f9-d591-441c-86ef-bce970ba6842" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70b4e31-573d-4132-9867-4c0a7f7302ec",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9e3bc3e-e070-4b64-979f-b2aad686ec45", "3778b04d-17d1-4010-920a-119ed613793e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e741c863-683d-4a5b-aad9-7bec025a352b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02dba04d-3398-4de4-a8f3-58d710938ed5", "5cb696b9-d2b8-4f49-ae76-e7f201c28251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f079118a-23ea-4723-a979-27ae21dafbe1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fac74e57-22c1-4b8c-8776-b4dac7afffcd", "39963038-cba5-4f12-b6cf-aa71627b636d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2369df7b-9fc5-43ad-b571-51b954b28573", "dd62c7b0-00cf-4a17-a9e6-57d61bd467a2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserCity", "UserName", "UserState", "UserZip" },
                values: new object[] { "548fdb44-0e52-436e-b63e-79880fe150c5", 0, "8b381342-b05f-4d4d-8da3-47f7132dede2", "ADMIN@website.com", false, "ADMIN", "ADMIN", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "fb3d7b60-7232-4854-9c51-3adf58d7ea3f", false, "Milwaukee", "ADMIN", "WI", "53172" });
        }
    }
}
