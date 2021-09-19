using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbyRadarAPI.Migrations
{
    public partial class AddSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b1e5957-c8a2-4bb3-b9e4-49235dfbd3dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79012546-13c0-4fe7-9ad5-0a74a7945980");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f8d34ac-72d3-4e9c-b755-32e73d5e287f", "e8d2429c-2485-49fe-b066-228f9b4c084f", "Admin", "ADMIN" },
                    { "4a9fa479-df89-4f02-a97d-0f1259c0dca6", "b0e7746c-56a1-4018-a139-c11076e6a60e", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f22c979-726f-4962-b2b5-bf5e83cc13f1",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "d1f99889-2b15-489a-8d98-701513eb1413", "username10@website.com", "69a6a999-679a-46a0-8c93-8f550cbfec85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6fbbd3-5b86-4154-bd59-10901df0ad81",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "616ebbe7-76ba-4e91-a946-b6fa59aa0a38", "username20@website.com", "49a91243-f2c4-4298-ab49-2e48062e6e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3047431e-a67a-47b7-8ff6-d524c3583be0",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "eccda25d-5c99-49d6-926e-7d704879bdc7", "username40@website.com", "be77e07f-09c5-4214-acea-3d15ee29ce0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "00ce7690-8b18-432b-b3f8-842536c4a41e", "username28@website.com", "bb94c68c-30ef-4277-9ac2-919e35fc3a07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39dd92a6-b55d-4f0f-b614-76b15b550678",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "1046db20-8ba0-414c-992e-bc47027e6755", "username23@website.com", "27bdcaf0-034c-47cd-bf31-1c00026a1c96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6268e0-e090-4291-a610-8004347721dc",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "452c8015-24ea-408f-9761-9db7a5899a2c", "username08@website.com", "8cb40aa8-2652-4a4e-bed9-090dca6b8645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404e8d45-1b49-448a-be30-9ecc57b340af",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "ab2e94b1-9e11-41b3-93e7-00d4bf1e677f", "username22@website.com", "49b7bded-aec3-4b27-869d-32f21a9c1c4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406efbec-e351-4369-a812-d7a0df894b30",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "6476b6d9-4655-4e4b-b00e-fba529ac954e", "username16@website.com", "4c570fd3-e5be-47e8-8011-5ab285b161b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42d8c277-8adb-4479-9499-1f52b917b528",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "caa74544-f55d-44cc-a05c-62c7d7acbcd9", "username37@website.com", "914fb5c4-130d-4cff-94a1-5444f96b485f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ed259d-18c9-47fe-9e67-111dbc445fd4",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "365968ca-17f3-4c08-b380-0c4bd051c7e3", "username21@website.com", "bfe3f81e-4de5-4950-b009-8651cc13332f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968a764-9310-40b7-b114-08ad4a191db5",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "9ef27ae0-e5cf-4b90-ac1b-96862be2f4b1", "username17@website.com", "1af7e496-9f4c-4324-ab56-6fe063c840ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55367a6a-2505-4ce4-99cf-b77d55df3320",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "6b65f33c-6f26-48b8-995c-89f6ff7d1fd0", "username13@website.com", "cf80e974-6c54-4493-ad57-719d2e311658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558de276-cdd7-4f80-b7a7-9471e579788f",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "ada75de6-ab66-4434-b4e3-8515e5550cc8", "username06@website.com", "56dcdef6-e7ca-40e4-b2a5-140c46472e78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b050e9-93d3-4539-a13b-dfbcf27361b8",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "a2041f86-8a2c-4fad-a6ec-533b091ffc5c", "username09@website.com", "9d3c60f7-5216-4ba1-94bf-2608e2cea61f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f57cdbe-e41f-4d6b-8e11-ebe076723861",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "7aa3b7d7-4463-41d5-9755-16bb988ad6dd", "username31@website.com", "04a00ead-b23a-42d2-9a54-118bad5da5a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728d5de5-a876-4ec3-ae28-f9bd5d54e504",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "15e3a207-6d8d-46b7-9199-8345bbeca895", "username26@website.com", "94fedcea-0927-49a3-bb33-f6c65e467abf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737dd08e-80c1-45bd-a2b9-98a5d324cd1a",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "8b283780-5fe8-4062-a377-dbdf1bcb87dc", "username12@website.com", "02de33bb-3e59-41f3-a510-79d512c10de4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c5f76c-51ee-4c0a-bc26-f96cac06b92b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "49723f83-4f79-4523-8d84-d04f07849a53", "username36@website.com", "ae5d15cc-f1c0-41fb-a414-c1b3cc9c202d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baa663b-5422-4e0d-9d89-8d85eacb0e5c",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "cbce39f8-acb2-4f44-b839-3d4106b538a8", "username02@website.com", "86ebbe31-5155-47b2-8711-d471e3aa29c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0f6526-4964-4e75-82cc-dc7f5c662e5b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "6470ab64-b067-4323-99ae-eeecb88d9ed6", "username11@website.com", "54125c87-84fa-422f-bde1-3606f61b58cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e68dbf-d08e-4b3a-bb44-642f44826249",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "c5e18a3b-3c16-4faa-b2d4-a80a1b61bd39", "username24@website.com", "4c91cb41-ae17-4459-a223-f893331e8ec8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977a193e-b63c-4b74-8c2c-13fac432a3ff",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "9857221b-5857-4abf-ae83-a42525dfa107", "username34@website.com", "8451a369-7155-4ac3-8f21-a694548f6cb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfe112-4c41-4022-a5fe-62a83e8fc299",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "dab21e6a-c661-4bb2-a8d2-9e3346bf4398", "username15@website.com", "e1254491-7785-4c5f-81cd-e5ee2961cf12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1abf5b1-34bd-46cd-ace4-7623fe26813b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "16b71352-db10-467c-9534-171b1b20fdd2", "username30@website.com", "e5ad242c-77bd-40df-b769-af5473478223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "9aca6c2a-50ee-420f-ba8a-3b0ac16ccdc8", "username05@website.com", "7f947835-76c1-4bb4-9d23-65e3e000748a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b455a890-08c6-4e6f-bfe7-30cc99cf2f72",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "7654167f-dfd2-468b-a6bf-b5f743b9d9f2", "username19@website.com", "76e04e9d-f2f1-4ed9-8cce-87389ee5410e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4769c29-8598-480b-b5d3-698700864869",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "a314100b-4eed-4df1-9a05-7023ecdf52f3", "username14@website.com", "a6a17894-7b3f-459b-96bf-f6e65bbe6d14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7629af8-b837-4e6d-a0d5-156a88c2749d",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "8ab99d6e-b955-4591-8481-0f7e19b11f19", "username03@website.com", "cd6276fa-65e8-4d33-9b0d-4045260cd624" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caacdd8d-c803-4680-aa29-fe0d99f67abb",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "ed974457-390b-4356-a57d-aef892124a3f", "username32@website.com", "18e483fb-7a6f-48d5-a63b-05a3a53ef53b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd834580-5220-4fed-a923-fc03e1d3de14",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "ab702fb2-cbca-47e0-9d7f-37087558b225", "username04@website.com", "f07d9886-0057-4b71-b247-d5e131a49dcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "99d15479-ee47-4c65-a50a-59f54acca713", "username27@website.com", "d60a804e-cfa8-4895-9792-c71a023f60f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d957f266-695c-4e51-bb05-ddd4c78ab54b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "ef819755-3747-4ffb-b575-c49375f66ba6", "username33@website.com", "6bbff5bc-8a99-4683-acbd-444d752e92e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbbd1a5a-1161-483e-a705-5cb5b640f239",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "263aa80f-67e4-44b6-8a1b-8b147d5e3178", "username18@website.com", "a25a463a-4db3-4426-a008-1331e5a5c724" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e303170d-4192-4733-b5a2-7eafea38e142",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "88a037c9-47ca-421d-8bfe-a3434de405db", "username35@website.com", "8488fcc7-249a-4117-add6-8a9e5b00378a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47ff457-1df0-4275-9d6c-e76fe98fa961",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "deb2caa7-fff6-4635-b69e-307461d7d3c1", "username29@website.com", "b7e10ef0-0be7-43e8-97bf-99f2d91939b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5a62d42-8dde-4584-9107-19a825c9d241",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "63472930-14a2-491e-8e30-b1ad963c84cc", "username39@website.com", "196206f9-d591-441c-86ef-bce970ba6842" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70b4e31-573d-4132-9867-4c0a7f7302ec",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "c9e3bc3e-e070-4b64-979f-b2aad686ec45", "username38@website.com", "3778b04d-17d1-4010-920a-119ed613793e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e741c863-683d-4a5b-aad9-7bec025a352b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "02dba04d-3398-4de4-a8f3-58d710938ed5", "username25@website.com", "5cb696b9-d2b8-4f49-ae76-e7f201c28251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f079118a-23ea-4723-a979-27ae21dafbe1",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "fac74e57-22c1-4b8c-8776-b4dac7afffcd", "username07@website.com", "39963038-cba5-4f12-b6cf-aa71627b636d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "2369df7b-9fc5-43ad-b571-51b954b28573", "username01@website.com", "dd62c7b0-00cf-4a17-a9e6-57d61bd467a2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserCity", "UserName", "UserState", "UserZip" },
                values: new object[] { "548fdb44-0e52-436e-b63e-79880fe150c5", 0, "8b381342-b05f-4d4d-8da3-47f7132dede2", "ADMIN@website.com", false, "ADMIN", "ADMIN", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "fb3d7b60-7232-4854-9c51-3adf58d7ea3f", false, "Milwaukee", "ADMIN", "WI", "53172" });

            migrationBuilder.InsertData(
                table: "ConnectionInvites",
                columns: new[] { "ConnectionInviteId", "Accepted", "DateSent", "Dismissed", "FromUserId", "Message", "ToUserId" },
                values: new object[,]
                {
                    { 12, true, new DateTime(2021, 8, 7, 17, 43, 0, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "55367a6a-2505-4ce4-99cf-b77d55df3320", "Hello, please add me!", "67b050e9-93d3-4539-a13b-dfbcf27361b8" },
                    { 41, false, new DateTime(2021, 6, 22, 5, 41, 58, 638, DateTimeKind.Unspecified).AddTicks(3104), false, "caacdd8d-c803-4680-aa29-fe0d99f67abb", "Hello, please add me!", "d957f266-695c-4e51-bb05-ddd4c78ab54b" },
                    { 42, true, new DateTime(2021, 8, 5, 7, 43, 24, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "caacdd8d-c803-4680-aa29-fe0d99f67abb", "Hello, please add me!", "404e8d45-1b49-448a-be30-9ecc57b340af" },
                    { 43, true, new DateTime(2021, 8, 9, 16, 44, 27, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "d957f266-695c-4e51-bb05-ddd4c78ab54b", "Hello, please add me!", "404e8d45-1b49-448a-be30-9ecc57b340af" },
                    { 44, true, new DateTime(2021, 6, 23, 19, 31, 20, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "d957f266-695c-4e51-bb05-ddd4c78ab54b", "Hello, please add me!", "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { 45, false, new DateTime(2021, 7, 24, 16, 36, 52, 638, DateTimeKind.Unspecified).AddTicks(3104), false, "977a193e-b63c-4b74-8c2c-13fac432a3ff", "Hello, please add me!", "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" },
                    { 46, true, new DateTime(2021, 7, 4, 21, 48, 25, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "977a193e-b63c-4b74-8c2c-13fac432a3ff", "Hello, please add me!", "39dd92a6-b55d-4f0f-b614-76b15b550678" },
                    { 47, true, new DateTime(2021, 8, 1, 0, 54, 29, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "e303170d-4192-4733-b5a2-7eafea38e142", "Hello, please add me!", "728d5de5-a876-4ec3-ae28-f9bd5d54e504" },
                    { 48, false, new DateTime(2021, 7, 27, 12, 38, 39, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "e303170d-4192-4733-b5a2-7eafea38e142", "Hello, please add me!", "42d8c277-8adb-4479-9499-1f52b917b528" },
                    { 49, true, new DateTime(2021, 7, 27, 11, 42, 23, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "Hello, please add me!", "e70b4e31-573d-4132-9867-4c0a7f7302ec" },
                    { 50, true, new DateTime(2021, 6, 25, 1, 4, 17, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "Hello, please add me!", "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" },
                    { 51, true, new DateTime(2021, 8, 20, 7, 10, 17, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "Hello, please add me!", "90e68dbf-d08e-4b3a-bb44-642f44826249" },
                    { 40, false, new DateTime(2021, 7, 31, 11, 18, 46, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "a1abf5b1-34bd-46cd-ace4-7623fe26813b", "Hello, please add me!", "e70b4e31-573d-4132-9867-4c0a7f7302ec" },
                    { 52, true, new DateTime(2021, 9, 5, 7, 30, 42, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "42d8c277-8adb-4479-9499-1f52b917b528", "Hello, please add me!", "e303170d-4192-4733-b5a2-7eafea38e142" },
                    { 54, false, new DateTime(2021, 7, 14, 20, 49, 16, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "42d8c277-8adb-4479-9499-1f52b917b528", "Hello, please add me!", "3047431e-a67a-47b7-8ff6-d524c3583be0" },
                    { 55, true, new DateTime(2021, 7, 27, 17, 0, 22, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "e70b4e31-573d-4132-9867-4c0a7f7302ec", "Hello, please add me!", "a1abf5b1-34bd-46cd-ace4-7623fe26813b" },
                    { 9, true, new DateTime(2021, 7, 3, 4, 30, 5, 637, DateTimeKind.Unspecified).AddTicks(3248), true, "1f22c979-726f-4962-b2b5-bf5e83cc13f1", "Hello, please add me!", "3e6268e0-e090-4291-a610-8004347721dc" },
                    { 8, false, new DateTime(2021, 9, 8, 4, 35, 10, 637, DateTimeKind.Unspecified).AddTicks(3248), true, "67b050e9-93d3-4539-a13b-dfbcf27361b8", "Hello, please add me!", "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 7, false, new DateTime(2021, 7, 31, 6, 58, 25, 637, DateTimeKind.Unspecified).AddTicks(3248), false, "67b050e9-93d3-4539-a13b-dfbcf27361b8", "Hello, please add me!", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" },
                    { 6, true, new DateTime(2021, 9, 15, 1, 32, 0, 637, DateTimeKind.Unspecified).AddTicks(3248), true, "3e6268e0-e090-4291-a610-8004347721dc", "Hello, please add me!", "8baa663b-5422-4e0d-9d89-8d85eacb0e5c" },
                    { 5, false, new DateTime(2021, 8, 28, 9, 20, 28, 637, DateTimeKind.Unspecified).AddTicks(3248), true, "3e6268e0-e090-4291-a610-8004347721dc", "Hello, please add me!", "9adfe112-4c41-4022-a5fe-62a83e8fc299" },
                    { 4, false, new DateTime(2021, 8, 17, 10, 25, 39, 637, DateTimeKind.Unspecified).AddTicks(3248), false, "558de276-cdd7-4f80-b7a7-9471e579788f", "Hello, please add me!", "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 3, false, new DateTime(2021, 7, 13, 20, 24, 18, 637, DateTimeKind.Unspecified).AddTicks(3248), false, "558de276-cdd7-4f80-b7a7-9471e579788f", "Hello, please add me!", "cd834580-5220-4fed-a923-fc03e1d3de14" },
                    { 2, true, new DateTime(2021, 7, 24, 17, 21, 1, 637, DateTimeKind.Unspecified).AddTicks(3248), true, "8baa663b-5422-4e0d-9d89-8d85eacb0e5c", "Hello, please add me!", "cd834580-5220-4fed-a923-fc03e1d3de14" },
                    { 1, true, new DateTime(2021, 8, 30, 6, 44, 29, 637, DateTimeKind.Unspecified).AddTicks(3248), true, "8baa663b-5422-4e0d-9d89-8d85eacb0e5c", "Hello, please add me!", "737dd08e-80c1-45bd-a2b9-98a5d324cd1a" },
                    { 53, false, new DateTime(2021, 8, 30, 12, 15, 13, 638, DateTimeKind.Unspecified).AddTicks(3104), false, "42d8c277-8adb-4479-9499-1f52b917b528", "Hello, please add me!", "6f57cdbe-e41f-4d6b-8e11-ebe076723861" },
                    { 11, true, new DateTime(2021, 9, 14, 14, 52, 45, 637, DateTimeKind.Unspecified).AddTicks(3248), true, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", "Hello, please add me!", "406efbec-e351-4369-a812-d7a0df894b30" },
                    { 39, false, new DateTime(2021, 6, 22, 22, 42, 41, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "e47ff457-1df0-4275-9d6c-e76fe98fa961", "Hello, please add me!", "e741c863-683d-4a5b-aad9-7bec025a352b" },
                    { 37, true, new DateTime(2021, 7, 8, 13, 47, 52, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "Hello, please add me!", "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { 13, false, new DateTime(2021, 9, 5, 9, 9, 4, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "55367a6a-2505-4ce4-99cf-b77d55df3320", "Hello, please add me!", "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" },
                    { 14, true, new DateTime(2021, 8, 21, 16, 39, 14, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "55367a6a-2505-4ce4-99cf-b77d55df3320", "Hello, please add me!", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" },
                    { 15, false, new DateTime(2021, 7, 5, 10, 25, 44, 638, DateTimeKind.Unspecified).AddTicks(3104), false, "b4769c29-8598-480b-b5d3-698700864869", "Hello, please add me!", "9adfe112-4c41-4022-a5fe-62a83e8fc299" },
                    { 16, false, new DateTime(2021, 9, 15, 20, 37, 9, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "b4769c29-8598-480b-b5d3-698700864869", "Hello, please add me!", "558de276-cdd7-4f80-b7a7-9471e579788f" },
                    { 10, true, new DateTime(2021, 7, 25, 5, 0, 36, 637, DateTimeKind.Unspecified).AddTicks(3248), true, "1f22c979-726f-4962-b2b5-bf5e83cc13f1", "Hello, please add me!", "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" },
                    { 18, false, new DateTime(2021, 7, 10, 9, 23, 50, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "406efbec-e351-4369-a812-d7a0df894b30", "Hello, please add me!", "1f6fbbd3-5b86-4154-bd59-10901df0ad81" },
                    { 19, true, new DateTime(2021, 8, 9, 13, 32, 32, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "406efbec-e351-4369-a812-d7a0df894b30", "Hello, please add me!", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" },
                    { 20, true, new DateTime(2021, 8, 4, 8, 52, 31, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "406efbec-e351-4369-a812-d7a0df894b30", "Hello, please add me!", "3e6268e0-e090-4291-a610-8004347721dc" },
                    { 21, true, new DateTime(2021, 6, 29, 6, 58, 30, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "4968a764-9310-40b7-b114-08ad4a191db5", "Hello, please add me!", "f079118a-23ea-4723-a979-27ae21dafbe1" },
                    { 22, true, new DateTime(2021, 9, 19, 1, 25, 24, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "4968a764-9310-40b7-b114-08ad4a191db5", "Hello, please add me!", "1f22c979-726f-4962-b2b5-bf5e83cc13f1" },
                    { 23, false, new DateTime(2021, 7, 5, 5, 53, 29, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "4968a764-9310-40b7-b114-08ad4a191db5", "Hello, please add me!", "cd834580-5220-4fed-a923-fc03e1d3de14" },
                    { 38, true, new DateTime(2021, 7, 14, 19, 0, 27, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "Hello, please add me!", "e5a62d42-8dde-4584-9107-19a825c9d241" }
                });

            migrationBuilder.InsertData(
                table: "ConnectionInvites",
                columns: new[] { "ConnectionInviteId", "Accepted", "DateSent", "Dismissed", "FromUserId", "Message", "ToUserId" },
                values: new object[,]
                {
                    { 24, true, new DateTime(2021, 7, 13, 20, 35, 32, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72", "Hello, please add me!", "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 26, false, new DateTime(2021, 7, 15, 9, 46, 20, 638, DateTimeKind.Unspecified).AddTicks(3104), false, "1f6fbbd3-5b86-4154-bd59-10901df0ad81", "Hello, please add me!", "406efbec-e351-4369-a812-d7a0df894b30" },
                    { 27, true, new DateTime(2021, 9, 10, 18, 49, 30, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "48ed259d-18c9-47fe-9e67-111dbc445fd4", "Hello, please add me!", "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" },
                    { 28, true, new DateTime(2021, 8, 10, 0, 32, 27, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "48ed259d-18c9-47fe-9e67-111dbc445fd4", "Hello, please add me!", "e5a62d42-8dde-4584-9107-19a825c9d241" },
                    { 29, false, new DateTime(2021, 7, 7, 3, 36, 31, 638, DateTimeKind.Unspecified).AddTicks(3104), false, "48ed259d-18c9-47fe-9e67-111dbc445fd4", "Hello, please add me!", "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { 30, true, new DateTime(2021, 8, 23, 23, 57, 17, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "404e8d45-1b49-448a-be30-9ecc57b340af", "Hello, please add me!", "e70b4e31-573d-4132-9867-4c0a7f7302ec" },
                    { 31, true, new DateTime(2021, 7, 11, 0, 7, 5, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "404e8d45-1b49-448a-be30-9ecc57b340af", "Hello, please add me!", "d957f266-695c-4e51-bb05-ddd4c78ab54b" },
                    { 32, false, new DateTime(2021, 6, 24, 8, 27, 16, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "90e68dbf-d08e-4b3a-bb44-642f44826249", "Hello, please add me!", "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { 33, true, new DateTime(2021, 6, 29, 13, 37, 55, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "90e68dbf-d08e-4b3a-bb44-642f44826249", "Hello, please add me!", "6f57cdbe-e41f-4d6b-8e11-ebe076723861" },
                    { 34, false, new DateTime(2021, 8, 23, 17, 37, 20, 638, DateTimeKind.Unspecified).AddTicks(3104), false, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088", "Hello, please add me!", "caacdd8d-c803-4680-aa29-fe0d99f67abb" },
                    { 35, false, new DateTime(2021, 9, 11, 11, 54, 40, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088", "Hello, please add me!", "404e8d45-1b49-448a-be30-9ecc57b340af" },
                    { 36, true, new DateTime(2021, 8, 27, 18, 16, 37, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "Hello, please add me!", "a1abf5b1-34bd-46cd-ace4-7623fe26813b" },
                    { 25, true, new DateTime(2021, 6, 27, 6, 36, 16, 638, DateTimeKind.Unspecified).AddTicks(3104), true, "1f6fbbd3-5b86-4154-bd59-10901df0ad81", "Hello, please add me!", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" },
                    { 17, false, new DateTime(2021, 7, 8, 8, 50, 30, 638, DateTimeKind.Unspecified).AddTicks(3104), false, "b4769c29-8598-480b-b5d3-698700864869", "Hello, please add me!", "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" }
                });

            migrationBuilder.InsertData(
                table: "Connections",
                columns: new[] { "User1Id", "User2Id" },
                values: new object[,]
                {
                    { "8baa663b-5422-4e0d-9d89-8d85eacb0e5c", "737dd08e-80c1-45bd-a2b9-98a5d324cd1a" },
                    { "b455a890-08c6-4e6f-bfe7-30cc99cf2f72", "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { "e70b4e31-573d-4132-9867-4c0a7f7302ec", "a1abf5b1-34bd-46cd-ace4-7623fe26813b" },
                    { "42d8c277-8adb-4479-9499-1f52b917b528", "e303170d-4192-4733-b5a2-7eafea38e142" },
                    { "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "90e68dbf-d08e-4b3a-bb44-642f44826249" },
                    { "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" },
                    { "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "e70b4e31-573d-4132-9867-4c0a7f7302ec" },
                    { "e303170d-4192-4733-b5a2-7eafea38e142", "728d5de5-a876-4ec3-ae28-f9bd5d54e504" },
                    { "977a193e-b63c-4b74-8c2c-13fac432a3ff", "39dd92a6-b55d-4f0f-b614-76b15b550678" },
                    { "d957f266-695c-4e51-bb05-ddd4c78ab54b", "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { "d957f266-695c-4e51-bb05-ddd4c78ab54b", "404e8d45-1b49-448a-be30-9ecc57b340af" },
                    { "caacdd8d-c803-4680-aa29-fe0d99f67abb", "404e8d45-1b49-448a-be30-9ecc57b340af" },
                    { "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "a1abf5b1-34bd-46cd-ace4-7623fe26813b" },
                    { "90e68dbf-d08e-4b3a-bb44-642f44826249", "6f57cdbe-e41f-4d6b-8e11-ebe076723861" },
                    { "404e8d45-1b49-448a-be30-9ecc57b340af", "d957f266-695c-4e51-bb05-ddd4c78ab54b" },
                    { "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "e5a62d42-8dde-4584-9107-19a825c9d241" },
                    { "48ed259d-18c9-47fe-9e67-111dbc445fd4", "e5a62d42-8dde-4584-9107-19a825c9d241" },
                    { "4968a764-9310-40b7-b114-08ad4a191db5", "f079118a-23ea-4723-a979-27ae21dafbe1" },
                    { "406efbec-e351-4369-a812-d7a0df894b30", "3e6268e0-e090-4291-a610-8004347721dc" },
                    { "404e8d45-1b49-448a-be30-9ecc57b340af", "e70b4e31-573d-4132-9867-4c0a7f7302ec" },
                    { "55367a6a-2505-4ce4-99cf-b77d55df3320", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" },
                    { "55367a6a-2505-4ce4-99cf-b77d55df3320", "67b050e9-93d3-4539-a13b-dfbcf27361b8" },
                    { "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", "406efbec-e351-4369-a812-d7a0df894b30" },
                    { "1f22c979-726f-4962-b2b5-bf5e83cc13f1", "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" },
                    { "406efbec-e351-4369-a812-d7a0df894b30", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" },
                    { "3e6268e0-e090-4291-a610-8004347721dc", "8baa663b-5422-4e0d-9d89-8d85eacb0e5c" },
                    { "1f22c979-726f-4962-b2b5-bf5e83cc13f1", "3e6268e0-e090-4291-a610-8004347721dc" }
                });

            migrationBuilder.InsertData(
                table: "Connections",
                columns: new[] { "User1Id", "User2Id" },
                values: new object[,]
                {
                    { "48ed259d-18c9-47fe-9e67-111dbc445fd4", "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" },
                    { "1f6fbbd3-5b86-4154-bd59-10901df0ad81", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" },
                    { "4968a764-9310-40b7-b114-08ad4a191db5", "1f22c979-726f-4962-b2b5-bf5e83cc13f1" },
                    { "8baa663b-5422-4e0d-9d89-8d85eacb0e5c", "cd834580-5220-4fed-a923-fc03e1d3de14" }
                });

            migrationBuilder.InsertData(
                table: "EventAttendances",
                columns: new[] { "ScheduledEventId", "UserId" },
                values: new object[,]
                {
                    { 4, "f079118a-23ea-4723-a979-27ae21dafbe1" },
                    { 4, "9adfe112-4c41-4022-a5fe-62a83e8fc299" },
                    { 1, "f079118a-23ea-4723-a979-27ae21dafbe1" },
                    { 2, "1f22c979-726f-4962-b2b5-bf5e83cc13f1" },
                    { 2, "b4769c29-8598-480b-b5d3-698700864869" },
                    { 2, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" },
                    { 3, "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { 3, "6f57cdbe-e41f-4d6b-8e11-ebe076723861" },
                    { 3, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" },
                    { 3, "3047431e-a67a-47b7-8ff6-d524c3583be0" },
                    { 4, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" },
                    { 2, "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" },
                    { 4, "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 13, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" },
                    { 13, "d957f266-695c-4e51-bb05-ddd4c78ab54b" },
                    { 13, "e303170d-4192-4733-b5a2-7eafea38e142" },
                    { 11, "1f22c979-726f-4962-b2b5-bf5e83cc13f1" },
                    { 11, "3e6268e0-e090-4291-a610-8004347721dc" },
                    { 11, "558de276-cdd7-4f80-b7a7-9471e579788f" },
                    { 10, "e5a62d42-8dde-4584-9107-19a825c9d241" },
                    { 10, "42d8c277-8adb-4479-9499-1f52b917b528" },
                    { 10, "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { 9, "e5a62d42-8dde-4584-9107-19a825c9d241" },
                    { 9, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" },
                    { 9, "728d5de5-a876-4ec3-ae28-f9bd5d54e504" },
                    { 9, "404e8d45-1b49-448a-be30-9ecc57b340af" },
                    { 11, "55367a6a-2505-4ce4-99cf-b77d55df3320" },
                    { 8, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" },
                    { 7, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" },
                    { 7, "dbbd1a5a-1161-483e-a705-5cb5b640f239" },
                    { 7, "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 7, "55367a6a-2505-4ce4-99cf-b77d55df3320" },
                    { 7, "558de276-cdd7-4f80-b7a7-9471e579788f" },
                    { 6, "b4769c29-8598-480b-b5d3-698700864869" },
                    { 6, "737dd08e-80c1-45bd-a2b9-98a5d324cd1a" },
                    { 6, "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054" },
                    { 5, "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 5, "9adfe112-4c41-4022-a5fe-62a83e8fc299" }
                });

            migrationBuilder.InsertData(
                table: "EventAttendances",
                columns: new[] { "ScheduledEventId", "UserId" },
                values: new object[,]
                {
                    { 5, "cd834580-5220-4fed-a923-fc03e1d3de14" },
                    { 4, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" },
                    { 8, "caacdd8d-c803-4680-aa29-fe0d99f67abb" },
                    { 12, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "Name" },
                values: new object[,]
                {
                    { 15, "LEATHERCRAFTING" },
                    { 1, "3D PRINTING" },
                    { 16, "LEGO BUILDING" },
                    { 17, "LIVE STREAMING" },
                    { 18, "LISTENING TO MUSIC" },
                    { 19, "POETRY" },
                    { 13, "KNITTING" },
                    { 21, "QUILTING" },
                    { 22, "RC VEHICLES" },
                    { 23, "RAPPING" },
                    { 24, "READING" },
                    { 25, "FISHING" },
                    { 26, "HIKING" },
                    { 27, "GRILLING" },
                    { 12, "KNIFE MAKING" },
                    { 11, "MARTIAL ARTS" },
                    { 10, "KARAOKE" },
                    { 9, "COSPLAYING" },
                    { 8, "COOKING" },
                    { 7, "CARPENTRY" },
                    { 6, "CODING" },
                    { 5, "ANIMATION" },
                    { 4, "AMATEUR RADIO" },
                    { 3, "AIRBRUSHING" },
                    { 2, "ACTING" },
                    { 14, "BREWING KOMBUCHA" },
                    { 20, "POTTERY" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 11, "SPORT" },
                    { 29, "RELAXING" },
                    { 1, "INDOORS" },
                    { 2, "OUTDOORS" },
                    { 3, "SOLO" },
                    { 4, "COOPERATIVE" },
                    { 5, "COMPETITIVE" },
                    { 6, "CASUAL" },
                    { 7, "FREE" },
                    { 8, "LOW BARRIER TO ENTRY" },
                    { 9, "SELLABLE" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 10, "EXTREME" },
                    { 30, "EXCITING" },
                    { 13, "CRAFTING" },
                    { 14, "HIGH TECH" },
                    { 12, "ART" },
                    { 16, "NATURE" },
                    { 28, "EXERCISE" },
                    { 27, "LOW RISK" },
                    { 26, "WEATHER DEPENDENT" },
                    { 25, "WATER" },
                    { 15, "ANIMALS" },
                    { 23, "INTELLECTUAL" },
                    { 24, "CREATIVE" },
                    { 21, "FOOD & DRINK" },
                    { 20, "PHYSICAL" },
                    { 19, "PHILANTHROPY" },
                    { 18, "MUSIC" },
                    { 17, "URBAN" },
                    { 22, "COLLECTING" }
                });

            migrationBuilder.InsertData(
                table: "UserAlerts",
                columns: new[] { "UserAlertId", "Dismissed", "Message", "Method", "UserId" },
                values: new object[,]
                {
                    { 51, true, "You have a new invitation to connect!", "email", "42d8c277-8adb-4479-9499-1f52b917b528" },
                    { 55, false, "You have a new invitation to connect!", "email", "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" },
                    { 54, true, "You have a new invitation to connect!", "email", "e70b4e31-573d-4132-9867-4c0a7f7302ec" },
                    { 53, true, "You have a new invitation to connect!", "email", "42d8c277-8adb-4479-9499-1f52b917b528" },
                    { 52, false, "You have a new invitation to connect!", "email", "42d8c277-8adb-4479-9499-1f52b917b528" },
                    { 50, true, "You have a new invitation to connect!", "email", "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" },
                    { 21, true, "You have a new invitation to connect!", "email", "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 48, true, "You have a new invitation to connect!", "email", "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" },
                    { 20, true, "You have a new invitation to connect!", "email", "406efbec-e351-4369-a812-d7a0df894b30" },
                    { 22, true, "You have a new invitation to connect!", "email", "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 23, true, "You have a new invitation to connect!", "email", "4968a764-9310-40b7-b114-08ad4a191db5" },
                    { 24, true, "You have a new invitation to connect!", "email", "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" },
                    { 25, true, "You have a new invitation to connect!", "email", "1f6fbbd3-5b86-4154-bd59-10901df0ad81" },
                    { 26, false, "You have a new invitation to connect!", "email", "1f6fbbd3-5b86-4154-bd59-10901df0ad81" },
                    { 27, true, "You have a new invitation to connect!", "email", "48ed259d-18c9-47fe-9e67-111dbc445fd4" },
                    { 28, true, "You have a new invitation to connect!", "email", "48ed259d-18c9-47fe-9e67-111dbc445fd4" },
                    { 29, false, "You have a new invitation to connect!", "email", "48ed259d-18c9-47fe-9e67-111dbc445fd4" },
                    { 30, true, "You have a new invitation to connect!", "email", "404e8d45-1b49-448a-be30-9ecc57b340af" },
                    { 31, true, "You have a new invitation to connect!", "email", "404e8d45-1b49-448a-be30-9ecc57b340af" },
                    { 32, true, "You have a new invitation to connect!", "email", "90e68dbf-d08e-4b3a-bb44-642f44826249" },
                    { 33, true, "You have a new invitation to connect!", "email", "90e68dbf-d08e-4b3a-bb44-642f44826249" },
                    { 34, true, "You have a new invitation to connect!", "email", "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" },
                    { 35, true, "You have a new invitation to connect!", "email", "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" }
                });

            migrationBuilder.InsertData(
                table: "UserAlerts",
                columns: new[] { "UserAlertId", "Dismissed", "Message", "Method", "UserId" },
                values: new object[,]
                {
                    { 36, true, "You have a new invitation to connect!", "email", "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" },
                    { 37, true, "You have a new invitation to connect!", "email", "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" },
                    { 38, true, "You have a new invitation to connect!", "email", "e47ff457-1df0-4275-9d6c-e76fe98fa961" },
                    { 39, true, "You have a new invitation to connect!", "email", "a1abf5b1-34bd-46cd-ace4-7623fe26813b" },
                    { 40, false, "You have a new invitation to connect!", "email", "caacdd8d-c803-4680-aa29-fe0d99f67abb" },
                    { 49, true, "You have a new invitation to connect!", "email", "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" },
                    { 19, true, "You have a new invitation to connect!", "email", "406efbec-e351-4369-a812-d7a0df894b30" },
                    { 18, true, "You have a new invitation to connect!", "email", "406efbec-e351-4369-a812-d7a0df894b30" },
                    { 41, true, "You have a new invitation to connect!", "email", "caacdd8d-c803-4680-aa29-fe0d99f67abb" },
                    { 16, true, "You have a new invitation to connect!", "email", "b4769c29-8598-480b-b5d3-698700864869" },
                    { 47, true, "You have a new invitation to connect!", "email", "e303170d-4192-4733-b5a2-7eafea38e142" },
                    { 46, true, "You have a new invitation to connect!", "email", "e303170d-4192-4733-b5a2-7eafea38e142" },
                    { 45, true, "You have a new invitation to connect!", "email", "977a193e-b63c-4b74-8c2c-13fac432a3ff" },
                    { 44, false, "You have a new invitation to connect!", "email", "977a193e-b63c-4b74-8c2c-13fac432a3ff" },
                    { 43, true, "You have a new invitation to connect!", "email", "d957f266-695c-4e51-bb05-ddd4c78ab54b" },
                    { 1, true, "You have a new invitation to connect!", "email", "8baa663b-5422-4e0d-9d89-8d85eacb0e5c" },
                    { 17, false, "You have a new invitation to connect!", "email", "b4769c29-8598-480b-b5d3-698700864869" },
                    { 3, false, "You have a new invitation to connect!", "email", "558de276-cdd7-4f80-b7a7-9471e579788f" },
                    { 4, false, "You have a new invitation to connect!", "email", "558de276-cdd7-4f80-b7a7-9471e579788f" },
                    { 5, true, "You have a new invitation to connect!", "email", "3e6268e0-e090-4291-a610-8004347721dc" },
                    { 2, true, "You have a new invitation to connect!", "email", "8baa663b-5422-4e0d-9d89-8d85eacb0e5c" },
                    { 7, false, "You have a new invitation to connect!", "email", "67b050e9-93d3-4539-a13b-dfbcf27361b8" },
                    { 8, true, "You have a new invitation to connect!", "email", "67b050e9-93d3-4539-a13b-dfbcf27361b8" },
                    { 9, true, "You have a new invitation to connect!", "email", "1f22c979-726f-4962-b2b5-bf5e83cc13f1" },
                    { 10, true, "You have a new invitation to connect!", "email", "1f22c979-726f-4962-b2b5-bf5e83cc13f1" },
                    { 11, true, "You have a new invitation to connect!", "email", "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" },
                    { 12, true, "You have a new invitation to connect!", "email", "55367a6a-2505-4ce4-99cf-b77d55df3320" },
                    { 13, true, "You have a new invitation to connect!", "email", "55367a6a-2505-4ce4-99cf-b77d55df3320" },
                    { 14, true, "You have a new invitation to connect!", "email", "55367a6a-2505-4ce4-99cf-b77d55df3320" },
                    { 15, false, "You have a new invitation to connect!", "email", "b4769c29-8598-480b-b5d3-698700864869" },
                    { 6, true, "You have a new invitation to connect!", "email", "3e6268e0-e090-4291-a610-8004347721dc" },
                    { 42, true, "You have a new invitation to connect!", "email", "d957f266-695c-4e51-bb05-ddd4c78ab54b" }
                });

            migrationBuilder.InsertData(
                table: "UserHobbyRating",
                columns: new[] { "HobbyId", "UserId", "Rating" },
                values: new object[,]
                {
                    { 9, "6f57cdbe-e41f-4d6b-8e11-ebe076723861", 3 },
                    { 20, "6f57cdbe-e41f-4d6b-8e11-ebe076723861", 3 },
                    { 24, "6f57cdbe-e41f-4d6b-8e11-ebe076723861", 2 },
                    { 19, "caacdd8d-c803-4680-aa29-fe0d99f67abb", 3 },
                    { 12, "caacdd8d-c803-4680-aa29-fe0d99f67abb", 0 },
                    { 8, "caacdd8d-c803-4680-aa29-fe0d99f67abb", 3 },
                    { 6, "caacdd8d-c803-4680-aa29-fe0d99f67abb", 0 },
                    { 15, "caacdd8d-c803-4680-aa29-fe0d99f67abb", 3 },
                    { 17, "6f57cdbe-e41f-4d6b-8e11-ebe076723861", 0 },
                    { 17, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserHobbyRating",
                columns: new[] { "HobbyId", "UserId", "Rating" },
                values: new object[,]
                {
                    { 8, "e47ff457-1df0-4275-9d6c-e76fe98fa961", 4 },
                    { 24, "e47ff457-1df0-4275-9d6c-e76fe98fa961", 2 },
                    { 19, "e47ff457-1df0-4275-9d6c-e76fe98fa961", 3 },
                    { 25, "e47ff457-1df0-4275-9d6c-e76fe98fa961", 0 },
                    { 1, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", 1 },
                    { 2, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", 0 },
                    { 21, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", 0 },
                    { 10, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088", 0 },
                    { 4, "d957f266-695c-4e51-bb05-ddd4c78ab54b", 4 },
                    { 3, "a1abf5b1-34bd-46cd-ace4-7623fe26813b", 5 },
                    { 27, "d957f266-695c-4e51-bb05-ddd4c78ab54b", 2 },
                    { 24, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", 1 },
                    { 5, "d957f266-695c-4e51-bb05-ddd4c78ab54b", 3 },
                    { 20, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088", 5 },
                    { 13, "3047431e-a67a-47b7-8ff6-d524c3583be0", 3 },
                    { 24, "3047431e-a67a-47b7-8ff6-d524c3583be0", 0 },
                    { 11, "3047431e-a67a-47b7-8ff6-d524c3583be0", 1 },
                    { 26, "3047431e-a67a-47b7-8ff6-d524c3583be0", 5 },
                    { 25, "e5a62d42-8dde-4584-9107-19a825c9d241", 5 },
                    { 10, "e5a62d42-8dde-4584-9107-19a825c9d241", 1 },
                    { 13, "e70b4e31-573d-4132-9867-4c0a7f7302ec", 5 },
                    { 9, "e70b4e31-573d-4132-9867-4c0a7f7302ec", 2 },
                    { 2, "d957f266-695c-4e51-bb05-ddd4c78ab54b", 3 },
                    { 25, "42d8c277-8adb-4479-9499-1f52b917b528", 3 },
                    { 17, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", 2 },
                    { 23, "e303170d-4192-4733-b5a2-7eafea38e142", 2 },
                    { 26, "e303170d-4192-4733-b5a2-7eafea38e142", 2 },
                    { 17, "e303170d-4192-4733-b5a2-7eafea38e142", 0 },
                    { 21, "e303170d-4192-4733-b5a2-7eafea38e142", 5 },
                    { 2, "e303170d-4192-4733-b5a2-7eafea38e142", 4 },
                    { 26, "977a193e-b63c-4b74-8c2c-13fac432a3ff", 3 },
                    { 21, "977a193e-b63c-4b74-8c2c-13fac432a3ff", 4 },
                    { 14, "977a193e-b63c-4b74-8c2c-13fac432a3ff", 1 },
                    { 12, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", 0 },
                    { 22, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088", 0 },
                    { 13, "e741c863-683d-4a5b-aad9-7bec025a352b", 2 },
                    { 18, "728d5de5-a876-4ec3-ae28-f9bd5d54e504", 0 },
                    { 23, "67b050e9-93d3-4539-a13b-dfbcf27361b8", 0 },
                    { 1, "67b050e9-93d3-4539-a13b-dfbcf27361b8", 3 },
                    { 12, "1f22c979-726f-4962-b2b5-bf5e83cc13f1", 0 },
                    { 17, "1f22c979-726f-4962-b2b5-bf5e83cc13f1", 1 },
                    { 9, "1f22c979-726f-4962-b2b5-bf5e83cc13f1", 5 }
                });

            migrationBuilder.InsertData(
                table: "UserHobbyRating",
                columns: new[] { "HobbyId", "UserId", "Rating" },
                values: new object[,]
                {
                    { 26, "1f22c979-726f-4962-b2b5-bf5e83cc13f1", 4 },
                    { 8, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", 4 },
                    { 14, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", 5 },
                    { 24, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", 4 },
                    { 21, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", 0 },
                    { 27, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", 2 },
                    { 15, "737dd08e-80c1-45bd-a2b9-98a5d324cd1a", 3 },
                    { 5, "55367a6a-2505-4ce4-99cf-b77d55df3320", 5 },
                    { 26, "55367a6a-2505-4ce4-99cf-b77d55df3320", 1 },
                    { 19, "55367a6a-2505-4ce4-99cf-b77d55df3320", 1 },
                    { 6, "55367a6a-2505-4ce4-99cf-b77d55df3320", 4 },
                    { 8, "b4769c29-8598-480b-b5d3-698700864869", 2 },
                    { 7, "3e6268e0-e090-4291-a610-8004347721dc", 3 },
                    { 1, "3e6268e0-e090-4291-a610-8004347721dc", 5 },
                    { 26, "3e6268e0-e090-4291-a610-8004347721dc", 2 },
                    { 11, "f079118a-23ea-4723-a979-27ae21dafbe1", 2 },
                    { 15, "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054", 1 },
                    { 18, "8baa663b-5422-4e0d-9d89-8d85eacb0e5c", 1 },
                    { 5, "c7629af8-b837-4e6d-a0d5-156a88c2749d", 0 },
                    { 9, "c7629af8-b837-4e6d-a0d5-156a88c2749d", 5 },
                    { 24, "cd834580-5220-4fed-a923-fc03e1d3de14", 5 },
                    { 4, "cd834580-5220-4fed-a923-fc03e1d3de14", 2 },
                    { 17, "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb", 4 },
                    { 21, "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb", 2 },
                    { 15, "b4769c29-8598-480b-b5d3-698700864869", 1 },
                    { 13, "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb", 3 },
                    { 26, "558de276-cdd7-4f80-b7a7-9471e579788f", 0 },
                    { 25, "558de276-cdd7-4f80-b7a7-9471e579788f", 1 },
                    { 19, "558de276-cdd7-4f80-b7a7-9471e579788f", 2 },
                    { 6, "558de276-cdd7-4f80-b7a7-9471e579788f", 0 },
                    { 21, "558de276-cdd7-4f80-b7a7-9471e579788f", 4 },
                    { 14, "f079118a-23ea-4723-a979-27ae21dafbe1", 0 },
                    { 8, "f079118a-23ea-4723-a979-27ae21dafbe1", 1 },
                    { 3, "f079118a-23ea-4723-a979-27ae21dafbe1", 0 },
                    { 23, "558de276-cdd7-4f80-b7a7-9471e579788f", 4 },
                    { 17, "b4769c29-8598-480b-b5d3-698700864869", 1 },
                    { 14, "9adfe112-4c41-4022-a5fe-62a83e8fc299", 4 },
                    { 11, "9adfe112-4c41-4022-a5fe-62a83e8fc299", 0 },
                    { 13, "48ed259d-18c9-47fe-9e67-111dbc445fd4", 1 },
                    { 22, "48ed259d-18c9-47fe-9e67-111dbc445fd4", 2 },
                    { 8, "48ed259d-18c9-47fe-9e67-111dbc445fd4", 4 },
                    { 9, "404e8d45-1b49-448a-be30-9ecc57b340af", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserHobbyRating",
                columns: new[] { "HobbyId", "UserId", "Rating" },
                values: new object[,]
                {
                    { 22, "404e8d45-1b49-448a-be30-9ecc57b340af", 1 },
                    { 14, "404e8d45-1b49-448a-be30-9ecc57b340af", 3 },
                    { 26, "404e8d45-1b49-448a-be30-9ecc57b340af", 0 },
                    { 21, "404e8d45-1b49-448a-be30-9ecc57b340af", 3 },
                    { 4, "48ed259d-18c9-47fe-9e67-111dbc445fd4", 3 },
                    { 10, "404e8d45-1b49-448a-be30-9ecc57b340af", 3 },
                    { 6, "39dd92a6-b55d-4f0f-b614-76b15b550678", 0 },
                    { 21, "39dd92a6-b55d-4f0f-b614-76b15b550678", 2 },
                    { 20, "90e68dbf-d08e-4b3a-bb44-642f44826249", 1 },
                    { 8, "90e68dbf-d08e-4b3a-bb44-642f44826249", 4 },
                    { 21, "90e68dbf-d08e-4b3a-bb44-642f44826249", 3 },
                    { 16, "90e68dbf-d08e-4b3a-bb44-642f44826249", 4 },
                    { 21, "e741c863-683d-4a5b-aad9-7bec025a352b", 5 },
                    { 10, "728d5de5-a876-4ec3-ae28-f9bd5d54e504", 4 },
                    { 23, "39dd92a6-b55d-4f0f-b614-76b15b550678", 5 },
                    { 27, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088", 1 },
                    { 18, "1f6fbbd3-5b86-4154-bd59-10901df0ad81", 0 },
                    { 19, "1f6fbbd3-5b86-4154-bd59-10901df0ad81", 3 },
                    { 13, "9adfe112-4c41-4022-a5fe-62a83e8fc299", 3 },
                    { 2, "9adfe112-4c41-4022-a5fe-62a83e8fc299", 2 },
                    { 27, "9adfe112-4c41-4022-a5fe-62a83e8fc299", 5 },
                    { 4, "9adfe112-4c41-4022-a5fe-62a83e8fc299", 3 },
                    { 8, "406efbec-e351-4369-a812-d7a0df894b30", 2 },
                    { 6, "4968a764-9310-40b7-b114-08ad4a191db5", 2 },
                    { 4, "4968a764-9310-40b7-b114-08ad4a191db5", 3 },
                    { 19, "4968a764-9310-40b7-b114-08ad4a191db5", 1 },
                    { 16, "1f6fbbd3-5b86-4154-bd59-10901df0ad81", 0 },
                    { 14, "4968a764-9310-40b7-b114-08ad4a191db5", 5 },
                    { 22, "dbbd1a5a-1161-483e-a705-5cb5b640f239", 2 },
                    { 19, "dbbd1a5a-1161-483e-a705-5cb5b640f239", 1 },
                    { 17, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72", 1 },
                    { 25, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72", 0 },
                    { 14, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72", 2 },
                    { 18, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72", 1 },
                    { 24, "1f6fbbd3-5b86-4154-bd59-10901df0ad81", 4 },
                    { 10, "1f6fbbd3-5b86-4154-bd59-10901df0ad81", 5 },
                    { 8, "dbbd1a5a-1161-483e-a705-5cb5b640f239", 4 },
                    { 27, "f079118a-23ea-4723-a979-27ae21dafbe1", 4 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 19, 8 },
                    { 19, 7 },
                    { 19, 6 },
                    { 19, 5 },
                    { 19, 3 },
                    { 19, 2 },
                    { 19, 1 },
                    { 18, 30 },
                    { 18, 29 },
                    { 18, 27 },
                    { 18, 24 },
                    { 18, 18 },
                    { 18, 8 },
                    { 18, 7 },
                    { 18, 6 },
                    { 18, 3 },
                    { 18, 2 },
                    { 19, 9 },
                    { 19, 12 },
                    { 19, 23 },
                    { 19, 24 },
                    { 21, 6 },
                    { 21, 4 },
                    { 21, 3 },
                    { 21, 1 },
                    { 20, 28 },
                    { 20, 27 },
                    { 20, 20 },
                    { 20, 24 },
                    { 18, 1 },
                    { 20, 13 },
                    { 20, 9 },
                    { 20, 8 },
                    { 20, 6 },
                    { 20, 5 },
                    { 20, 3 },
                    { 20, 2 },
                    { 20, 1 },
                    { 19, 27 },
                    { 20, 12 },
                    { 17, 27 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 17, 14 },
                    { 17, 9 },
                    { 15, 13 },
                    { 15, 12 },
                    { 15, 9 },
                    { 15, 8 },
                    { 15, 6 },
                    { 15, 5 },
                    { 15, 3 },
                    { 15, 2 },
                    { 15, 20 },
                    { 15, 1 },
                    { 14, 21 },
                    { 14, 13 },
                    { 14, 9 },
                    { 14, 8 },
                    { 14, 6 },
                    { 27, 26 },
                    { 14, 4 },
                    { 14, 3 },
                    { 14, 27 },
                    { 21, 8 },
                    { 15, 24 },
                    { 16, 1 },
                    { 17, 8 },
                    { 17, 7 },
                    { 17, 6 },
                    { 17, 5 },
                    { 17, 4 },
                    { 17, 3 },
                    { 17, 2 },
                    { 17, 1 },
                    { 15, 27 },
                    { 16, 29 },
                    { 16, 24 },
                    { 16, 23 },
                    { 16, 22 },
                    { 16, 8 },
                    { 16, 6 },
                    { 16, 5 },
                    { 16, 4 },
                    { 16, 3 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 16, 27 },
                    { 21, 9 },
                    { 21, 12 },
                    { 21, 13 },
                    { 26, 6 },
                    { 26, 4 },
                    { 26, 3 },
                    { 26, 2 },
                    { 25, 29 },
                    { 25, 28 },
                    { 25, 27 },
                    { 25, 26 },
                    { 26, 7 },
                    { 25, 25 },
                    { 25, 20 },
                    { 25, 16 },
                    { 25, 15 },
                    { 25, 11 },
                    { 25, 9 },
                    { 25, 8 },
                    { 25, 7 },
                    { 25, 6 },
                    { 25, 22 },
                    { 25, 5 },
                    { 26, 8 },
                    { 26, 15 },
                    { 27, 24 },
                    { 27, 21 },
                    { 27, 17 },
                    { 27, 16 },
                    { 27, 13 },
                    { 27, 9 },
                    { 27, 8 },
                    { 27, 6 },
                    { 26, 11 },
                    { 27, 5 },
                    { 27, 3 },
                    { 27, 2 },
                    { 26, 29 },
                    { 26, 28 },
                    { 26, 27 },
                    { 26, 26 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 26, 20 },
                    { 26, 16 },
                    { 27, 4 },
                    { 14, 2 },
                    { 25, 3 },
                    { 24, 29 },
                    { 22, 30 },
                    { 22, 27 },
                    { 22, 26 },
                    { 22, 23 },
                    { 22, 22 },
                    { 22, 14 },
                    { 22, 13 },
                    { 22, 10 },
                    { 23, 1 },
                    { 22, 8 },
                    { 22, 5 },
                    { 22, 4 },
                    { 22, 3 },
                    { 22, 2 },
                    { 22, 1 },
                    { 21, 28 },
                    { 21, 27 },
                    { 21, 24 },
                    { 22, 6 },
                    { 25, 2 },
                    { 23, 2 },
                    { 23, 5 },
                    { 24, 27 },
                    { 24, 22 },
                    { 24, 23 },
                    { 24, 8 },
                    { 24, 7 },
                    { 24, 6 },
                    { 24, 3 },
                    { 24, 2 },
                    { 23, 3 },
                    { 24, 1 },
                    { 23, 23 },
                    { 23, 18 },
                    { 23, 24 },
                    { 23, 12 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 23, 9 },
                    { 23, 8 },
                    { 23, 7 },
                    { 23, 6 },
                    { 23, 27 },
                    { 14, 1 },
                    { 14, 5 },
                    { 13, 27 },
                    { 6, 4 },
                    { 6, 3 },
                    { 6, 1 },
                    { 5, 29 },
                    { 5, 27 },
                    { 5, 24 },
                    { 5, 23 },
                    { 5, 14 },
                    { 6, 5 },
                    { 5, 12 },
                    { 5, 8 },
                    { 5, 7 },
                    { 5, 6 },
                    { 5, 5 },
                    { 5, 4 },
                    { 5, 3 },
                    { 5, 1 },
                    { 4, 27 },
                    { 5, 9 },
                    { 4, 24 },
                    { 6, 6 },
                    { 6, 8 },
                    { 13, 29 },
                    { 7, 20 },
                    { 7, 16 },
                    { 7, 13 },
                    { 7, 12 },
                    { 7, 9 },
                    { 7, 5 },
                    { 7, 4 },
                    { 6, 7 },
                    { 7, 3 },
                    { 7, 1 },
                    { 6, 30 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 6, 27 },
                    { 6, 24 },
                    { 6, 23 },
                    { 6, 14 },
                    { 6, 13 },
                    { 6, 9 },
                    { 7, 2 },
                    { 7, 23 },
                    { 4, 23 },
                    { 4, 18 },
                    { 2, 12 },
                    { 2, 9 },
                    { 2, 8 },
                    { 2, 7 },
                    { 2, 6 },
                    { 2, 5 },
                    { 2, 4 },
                    { 2, 3 },
                    { 2, 18 },
                    { 2, 2 },
                    { 1, 24 },
                    { 1, 23 },
                    { 1, 14 },
                    { 1, 13 },
                    { 1, 12 },
                    { 1, 9 },
                    { 1, 3 },
                    { 1, 2 },
                    { 2, 1 },
                    { 4, 19 },
                    { 2, 20 },
                    { 2, 34 },
                    { 4, 14 },
                    { 4, 9 },
                    { 4, 6 },
                    { 4, 4 },
                    { 4, 3 },
                    { 4, 1 },
                    { 3, 27 },
                    { 3, 26 },
                    { 2, 23 },
                    { 3, 24 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 3, 12 },
                    { 3, 9 },
                    { 3, 8 },
                    { 3, 6 },
                    { 3, 3 },
                    { 3, 2 },
                    { 3, 1 },
                    { 2, 27 },
                    { 3, 13 },
                    { 7, 24 },
                    { 7, 22 },
                    { 8, 1 },
                    { 12, 3 },
                    { 12, 2 },
                    { 12, 1 },
                    { 11, 30 },
                    { 11, 28 },
                    { 11, 23 },
                    { 11, 20 },
                    { 11, 11 },
                    { 11, 10 },
                    { 11, 8 },
                    { 11, 5 },
                    { 11, 3 },
                    { 11, 2 },
                    { 11, 1 },
                    { 7, 28 },
                    { 10, 30 },
                    { 10, 27 },
                    { 12, 4 },
                    { 12, 5 },
                    { 12, 6 },
                    { 12, 8 },
                    { 13, 24 },
                    { 13, 22 },
                    { 13, 13 },
                    { 13, 12 },
                    { 13, 9 },
                    { 13, 8 },
                    { 13, 6 },
                    { 13, 3 },
                    { 10, 24 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 13, 2 },
                    { 12, 27 },
                    { 12, 24 },
                    { 12, 23 },
                    { 12, 22 },
                    { 12, 20 },
                    { 12, 13 },
                    { 12, 12 },
                    { 12, 9 },
                    { 13, 1 },
                    { 10, 18 },
                    { 27, 27 },
                    { 10, 8 },
                    { 9, 10 },
                    { 9, 9 },
                    { 8, 8 },
                    { 8, 9 },
                    { 9, 8 },
                    { 9, 6 },
                    { 9, 5 },
                    { 9, 4 },
                    { 9, 3 },
                    { 8, 13 },
                    { 9, 2 },
                    { 9, 1 },
                    { 8, 27 },
                    { 8, 25 },
                    { 8, 21 },
                    { 8, 6 },
                    { 9, 12 },
                    { 9, 13 },
                    { 10, 1 },
                    { 8, 2 },
                    { 10, 7 },
                    { 10, 6 },
                    { 8, 3 },
                    { 10, 5 },
                    { 10, 4 },
                    { 10, 3 },
                    { 10, 2 },
                    { 8, 24 },
                    { 8, 4 }
                });

            migrationBuilder.InsertData(
                table: "HobbyTags",
                columns: new[] { "HobbyId", "TagId" },
                values: new object[,]
                {
                    { 8, 5 },
                    { 9, 30 },
                    { 9, 27 },
                    { 9, 24 },
                    { 9, 22 },
                    { 9, 20 },
                    { 9, 17 },
                    { 9, 14 }
                });

            migrationBuilder.InsertData(
                table: "ScheduledEvents",
                columns: new[] { "ScheduledEventId", "Date", "Description", "HobbyId", "Location", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 10, 26, 4, 37, 30, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out BREWING KOMBUCHA with us!", 14, "Milwaukee, WI", "Try BREWING KOMBUCHA" },
                    { 6, new DateTime(2021, 11, 16, 2, 19, 6, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out LEATHERCRAFTING with us!", 15, "Milwaukee, WI", "Try LEATHERCRAFTING" },
                    { 11, new DateTime(2021, 9, 28, 20, 6, 30, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out HIKING with us!", 26, "Milwaukee, WI", "Try HIKING" },
                    { 7, new DateTime(2021, 10, 25, 2, 14, 4, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out POETRY with us!", 19, "Milwaukee, WI", "Try POETRY" },
                    { 5, new DateTime(2021, 12, 1, 11, 33, 29, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out AMATEUR RADIO with us!", 4, "Milwaukee, WI", "Try AMATEUR RADIO" },
                    { 13, new DateTime(2021, 11, 8, 10, 6, 58, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out ACTING with us!", 2, "Minneapolis, MN", "Try ACTING" },
                    { 10, new DateTime(2021, 11, 8, 11, 5, 38, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out FISHING with us!", 25, "Minneapolis, MN", "Try FISHING" },
                    { 1, new DateTime(2021, 10, 23, 10, 5, 41, 192, DateTimeKind.Unspecified).AddTicks(4480), "Come check out AIRBRUSHING with us!", 3, "Milwaukee, WI", "Try AIRBRUSHING" },
                    { 12, new DateTime(2021, 12, 17, 4, 5, 55, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out LEGO BUILDING with us!", 16, "Milwaukee, WI", "Try LEGO BUILDING" },
                    { 9, new DateTime(2021, 12, 2, 0, 38, 41, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out KARAOKE with us!", 10, "Minneapolis, MN", "Try KARAOKE" },
                    { 2, new DateTime(2021, 10, 10, 12, 10, 40, 192, DateTimeKind.Unspecified).AddTicks(4480), "Come check out LIVE STREAMING with us!", 17, "Milwaukee, WI", "Try LIVE STREAMING" },
                    { 8, new DateTime(2021, 11, 30, 4, 52, 1, 193, DateTimeKind.Unspecified).AddTicks(4464), "Come check out KNIFE MAKING with us!", 12, "Minneapolis, MN", "Try KNIFE MAKING" },
                    { 3, new DateTime(2021, 12, 7, 19, 58, 22, 192, DateTimeKind.Unspecified).AddTicks(4480), "Come check out READING with us!", 24, "Minneapolis, MN", "Try READING" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ConnectionInvites",
                keyColumn: "ConnectionInviteId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "1f22c979-726f-4962-b2b5-bf5e83cc13f1", "3e6268e0-e090-4291-a610-8004347721dc" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "1f22c979-726f-4962-b2b5-bf5e83cc13f1", "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "1f6fbbd3-5b86-4154-bd59-10901df0ad81", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "a1abf5b1-34bd-46cd-ace4-7623fe26813b" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "e47ff457-1df0-4275-9d6c-e76fe98fa961" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", "e5a62d42-8dde-4584-9107-19a825c9d241" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "3e6268e0-e090-4291-a610-8004347721dc", "8baa663b-5422-4e0d-9d89-8d85eacb0e5c" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "404e8d45-1b49-448a-be30-9ecc57b340af", "d957f266-695c-4e51-bb05-ddd4c78ab54b" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "404e8d45-1b49-448a-be30-9ecc57b340af", "e70b4e31-573d-4132-9867-4c0a7f7302ec" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "406efbec-e351-4369-a812-d7a0df894b30", "3e6268e0-e090-4291-a610-8004347721dc" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "406efbec-e351-4369-a812-d7a0df894b30", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "42d8c277-8adb-4479-9499-1f52b917b528", "e303170d-4192-4733-b5a2-7eafea38e142" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "48ed259d-18c9-47fe-9e67-111dbc445fd4", "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "48ed259d-18c9-47fe-9e67-111dbc445fd4", "e5a62d42-8dde-4584-9107-19a825c9d241" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "4968a764-9310-40b7-b114-08ad4a191db5", "1f22c979-726f-4962-b2b5-bf5e83cc13f1" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "4968a764-9310-40b7-b114-08ad4a191db5", "f079118a-23ea-4723-a979-27ae21dafbe1" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "55367a6a-2505-4ce4-99cf-b77d55df3320", "67b050e9-93d3-4539-a13b-dfbcf27361b8" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "55367a6a-2505-4ce4-99cf-b77d55df3320", "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "90e68dbf-d08e-4b3a-bb44-642f44826249" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", "e70b4e31-573d-4132-9867-4c0a7f7302ec" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "8baa663b-5422-4e0d-9d89-8d85eacb0e5c", "737dd08e-80c1-45bd-a2b9-98a5d324cd1a" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "8baa663b-5422-4e0d-9d89-8d85eacb0e5c", "cd834580-5220-4fed-a923-fc03e1d3de14" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", "406efbec-e351-4369-a812-d7a0df894b30" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "90e68dbf-d08e-4b3a-bb44-642f44826249", "6f57cdbe-e41f-4d6b-8e11-ebe076723861" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "977a193e-b63c-4b74-8c2c-13fac432a3ff", "39dd92a6-b55d-4f0f-b614-76b15b550678" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "b455a890-08c6-4e6f-bfe7-30cc99cf2f72", "4968a764-9310-40b7-b114-08ad4a191db5" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "caacdd8d-c803-4680-aa29-fe0d99f67abb", "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "d957f266-695c-4e51-bb05-ddd4c78ab54b", "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "d957f266-695c-4e51-bb05-ddd4c78ab54b", "e47ff457-1df0-4275-9d6c-e76fe98fa961" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "e303170d-4192-4733-b5a2-7eafea38e142", "728d5de5-a876-4ec3-ae28-f9bd5d54e504" });

            migrationBuilder.DeleteData(
                table: "Connections",
                keyColumns: new[] { "User1Id", "User2Id" },
                keyValues: new object[] { "e70b4e31-573d-4132-9867-4c0a7f7302ec", "a1abf5b1-34bd-46cd-ace4-7623fe26813b" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 1, "f079118a-23ea-4723-a979-27ae21dafbe1" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 2, "1f22c979-726f-4962-b2b5-bf5e83cc13f1" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 2, "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 2, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 2, "b4769c29-8598-480b-b5d3-698700864869" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 3, "3047431e-a67a-47b7-8ff6-d524c3583be0" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 3, "6f57cdbe-e41f-4d6b-8e11-ebe076723861" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 3, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 3, "e47ff457-1df0-4275-9d6c-e76fe98fa961" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 4, "4968a764-9310-40b7-b114-08ad4a191db5" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 4, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 4, "9adfe112-4c41-4022-a5fe-62a83e8fc299" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 4, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 4, "f079118a-23ea-4723-a979-27ae21dafbe1" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 5, "4968a764-9310-40b7-b114-08ad4a191db5" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 5, "9adfe112-4c41-4022-a5fe-62a83e8fc299" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 5, "cd834580-5220-4fed-a923-fc03e1d3de14" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 6, "737dd08e-80c1-45bd-a2b9-98a5d324cd1a" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 6, "b4769c29-8598-480b-b5d3-698700864869" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 6, "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 7, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 7, "4968a764-9310-40b7-b114-08ad4a191db5" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 7, "55367a6a-2505-4ce4-99cf-b77d55df3320" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 7, "558de276-cdd7-4f80-b7a7-9471e579788f" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 7, "dbbd1a5a-1161-483e-a705-5cb5b640f239" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 8, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 8, "caacdd8d-c803-4680-aa29-fe0d99f67abb" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 9, "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 9, "728d5de5-a876-4ec3-ae28-f9bd5d54e504" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 9, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 9, "e5a62d42-8dde-4584-9107-19a825c9d241" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 10, "42d8c277-8adb-4479-9499-1f52b917b528" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 10, "e47ff457-1df0-4275-9d6c-e76fe98fa961" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 10, "e5a62d42-8dde-4584-9107-19a825c9d241" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 11, "1f22c979-726f-4962-b2b5-bf5e83cc13f1" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 11, "3e6268e0-e090-4291-a610-8004347721dc" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 11, "55367a6a-2505-4ce4-99cf-b77d55df3320" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 11, "558de276-cdd7-4f80-b7a7-9471e579788f" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 12, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 13, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 13, "d957f266-695c-4e51-bb05-ddd4c78ab54b" });

            migrationBuilder.DeleteData(
                table: "EventAttendances",
                keyColumns: new[] { "ScheduledEventId", "UserId" },
                keyValues: new object[] { 13, "e303170d-4192-4733-b5a2-7eafea38e142" });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 26 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 6, 30 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 7, 28 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 21 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 25 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 8, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 22 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 9, 30 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 10, 30 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 28 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 11, 30 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 22 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 12, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 22 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 13, 29 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 21 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 14, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 15, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 22 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 16, 29 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 14 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 17, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 29 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 18, 30 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 19, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 20, 28 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 21, 28 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 14 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 22 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 26 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 22, 30 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 12 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 18 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 23, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 22 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 23 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 24, 29 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 11 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 15 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 16 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 22 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 25 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 26 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 28 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 25, 29 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 11 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 15 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 16 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 20 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 26 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 27 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 28 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 26, 29 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 6 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 8 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 13 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 16 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 17 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 21 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 24 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 26 });

            migrationBuilder.DeleteData(
                table: "HobbyTags",
                keyColumns: new[] { "HobbyId", "TagId" },
                keyValues: new object[] { 27, 27 });

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ScheduledEvents",
                keyColumn: "ScheduledEventId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UserAlerts",
                keyColumn: "UserAlertId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 9, "1f22c979-726f-4962-b2b5-bf5e83cc13f1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 12, "1f22c979-726f-4962-b2b5-bf5e83cc13f1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 17, "1f22c979-726f-4962-b2b5-bf5e83cc13f1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 26, "1f22c979-726f-4962-b2b5-bf5e83cc13f1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 10, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 16, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 18, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 19, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 24, "1f6fbbd3-5b86-4154-bd59-10901df0ad81" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 11, "3047431e-a67a-47b7-8ff6-d524c3583be0" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 13, "3047431e-a67a-47b7-8ff6-d524c3583be0" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 24, "3047431e-a67a-47b7-8ff6-d524c3583be0" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 26, "3047431e-a67a-47b7-8ff6-d524c3583be0" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 1, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 2, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 6, "39dd92a6-b55d-4f0f-b614-76b15b550678" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "39dd92a6-b55d-4f0f-b614-76b15b550678" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 23, "39dd92a6-b55d-4f0f-b614-76b15b550678" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 1, "3e6268e0-e090-4291-a610-8004347721dc" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 7, "3e6268e0-e090-4291-a610-8004347721dc" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 26, "3e6268e0-e090-4291-a610-8004347721dc" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 9, "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 10, "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 14, "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 22, "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 26, "404e8d45-1b49-448a-be30-9ecc57b340af" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "406efbec-e351-4369-a812-d7a0df894b30" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 25, "42d8c277-8adb-4479-9499-1f52b917b528" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 4, "48ed259d-18c9-47fe-9e67-111dbc445fd4" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "48ed259d-18c9-47fe-9e67-111dbc445fd4" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 13, "48ed259d-18c9-47fe-9e67-111dbc445fd4" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 22, "48ed259d-18c9-47fe-9e67-111dbc445fd4" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 4, "4968a764-9310-40b7-b114-08ad4a191db5" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 6, "4968a764-9310-40b7-b114-08ad4a191db5" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 14, "4968a764-9310-40b7-b114-08ad4a191db5" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 19, "4968a764-9310-40b7-b114-08ad4a191db5" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 5, "55367a6a-2505-4ce4-99cf-b77d55df3320" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 6, "55367a6a-2505-4ce4-99cf-b77d55df3320" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 19, "55367a6a-2505-4ce4-99cf-b77d55df3320" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 26, "55367a6a-2505-4ce4-99cf-b77d55df3320" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 6, "558de276-cdd7-4f80-b7a7-9471e579788f" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 19, "558de276-cdd7-4f80-b7a7-9471e579788f" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "558de276-cdd7-4f80-b7a7-9471e579788f" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 23, "558de276-cdd7-4f80-b7a7-9471e579788f" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 25, "558de276-cdd7-4f80-b7a7-9471e579788f" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 26, "558de276-cdd7-4f80-b7a7-9471e579788f" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 1, "67b050e9-93d3-4539-a13b-dfbcf27361b8" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 23, "67b050e9-93d3-4539-a13b-dfbcf27361b8" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 9, "6f57cdbe-e41f-4d6b-8e11-ebe076723861" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 17, "6f57cdbe-e41f-4d6b-8e11-ebe076723861" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 20, "6f57cdbe-e41f-4d6b-8e11-ebe076723861" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 24, "6f57cdbe-e41f-4d6b-8e11-ebe076723861" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 10, "728d5de5-a876-4ec3-ae28-f9bd5d54e504" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 18, "728d5de5-a876-4ec3-ae28-f9bd5d54e504" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 15, "737dd08e-80c1-45bd-a2b9-98a5d324cd1a" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 12, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 17, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 24, "82c5f76c-51ee-4c0a-bc26-f96cac06b92b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 18, "8baa663b-5422-4e0d-9d89-8d85eacb0e5c" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 14, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 24, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 27, "8c0f6526-4964-4e75-82cc-dc7f5c662e5b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "90e68dbf-d08e-4b3a-bb44-642f44826249" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 16, "90e68dbf-d08e-4b3a-bb44-642f44826249" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 20, "90e68dbf-d08e-4b3a-bb44-642f44826249" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "90e68dbf-d08e-4b3a-bb44-642f44826249" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 14, "977a193e-b63c-4b74-8c2c-13fac432a3ff" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "977a193e-b63c-4b74-8c2c-13fac432a3ff" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 26, "977a193e-b63c-4b74-8c2c-13fac432a3ff" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 2, "9adfe112-4c41-4022-a5fe-62a83e8fc299" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 4, "9adfe112-4c41-4022-a5fe-62a83e8fc299" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 11, "9adfe112-4c41-4022-a5fe-62a83e8fc299" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 13, "9adfe112-4c41-4022-a5fe-62a83e8fc299" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 14, "9adfe112-4c41-4022-a5fe-62a83e8fc299" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 27, "9adfe112-4c41-4022-a5fe-62a83e8fc299" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 3, "a1abf5b1-34bd-46cd-ace4-7623fe26813b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 13, "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 17, "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 14, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 17, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 18, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 25, "b455a890-08c6-4e6f-bfe7-30cc99cf2f72" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "b4769c29-8598-480b-b5d3-698700864869" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 15, "b4769c29-8598-480b-b5d3-698700864869" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 17, "b4769c29-8598-480b-b5d3-698700864869" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 5, "c7629af8-b837-4e6d-a0d5-156a88c2749d" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 9, "c7629af8-b837-4e6d-a0d5-156a88c2749d" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 6, "caacdd8d-c803-4680-aa29-fe0d99f67abb" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "caacdd8d-c803-4680-aa29-fe0d99f67abb" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 12, "caacdd8d-c803-4680-aa29-fe0d99f67abb" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 15, "caacdd8d-c803-4680-aa29-fe0d99f67abb" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 19, "caacdd8d-c803-4680-aa29-fe0d99f67abb" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 4, "cd834580-5220-4fed-a923-fc03e1d3de14" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 24, "cd834580-5220-4fed-a923-fc03e1d3de14" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 10, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 17, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 20, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 22, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 27, "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 2, "d957f266-695c-4e51-bb05-ddd4c78ab54b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 4, "d957f266-695c-4e51-bb05-ddd4c78ab54b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 5, "d957f266-695c-4e51-bb05-ddd4c78ab54b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 27, "d957f266-695c-4e51-bb05-ddd4c78ab54b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "dbbd1a5a-1161-483e-a705-5cb5b640f239" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 19, "dbbd1a5a-1161-483e-a705-5cb5b640f239" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 22, "dbbd1a5a-1161-483e-a705-5cb5b640f239" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 2, "e303170d-4192-4733-b5a2-7eafea38e142" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 17, "e303170d-4192-4733-b5a2-7eafea38e142" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "e303170d-4192-4733-b5a2-7eafea38e142" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 23, "e303170d-4192-4733-b5a2-7eafea38e142" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 26, "e303170d-4192-4733-b5a2-7eafea38e142" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "e47ff457-1df0-4275-9d6c-e76fe98fa961" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 19, "e47ff457-1df0-4275-9d6c-e76fe98fa961" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 24, "e47ff457-1df0-4275-9d6c-e76fe98fa961" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 25, "e47ff457-1df0-4275-9d6c-e76fe98fa961" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 10, "e5a62d42-8dde-4584-9107-19a825c9d241" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 25, "e5a62d42-8dde-4584-9107-19a825c9d241" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 9, "e70b4e31-573d-4132-9867-4c0a7f7302ec" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 13, "e70b4e31-573d-4132-9867-4c0a7f7302ec" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 13, "e741c863-683d-4a5b-aad9-7bec025a352b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 21, "e741c863-683d-4a5b-aad9-7bec025a352b" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 3, "f079118a-23ea-4723-a979-27ae21dafbe1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 8, "f079118a-23ea-4723-a979-27ae21dafbe1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 11, "f079118a-23ea-4723-a979-27ae21dafbe1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 14, "f079118a-23ea-4723-a979-27ae21dafbe1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 27, "f079118a-23ea-4723-a979-27ae21dafbe1" });

            migrationBuilder.DeleteData(
                table: "UserHobbyRating",
                keyColumns: new[] { "HobbyId", "UserId" },
                keyValues: new object[] { 15, "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054" });

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 27);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b1e5957-c8a2-4bb3-b9e4-49235dfbd3dc", "e242c7af-f217-4b9c-b06d-81658ed76e6a", "User", "USER" },
                    { "79012546-13c0-4fe7-9ad5-0a74a7945980", "ef747f7b-e12c-4b2b-b0f7-a12a834beeb1", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f22c979-726f-4962-b2b5-bf5e83cc13f1",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "33144246-7418-41d3-83bd-b91850754a1d", "username.10@website.com", "70d3cafc-fc2f-477c-bb6a-148ef325648e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6fbbd3-5b86-4154-bd59-10901df0ad81",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "525fed36-cbd2-4c30-ba7d-b1643291e1c1", "username.20@website.com", "00ae55df-09c1-4372-b557-7a1706a7904e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3047431e-a67a-47b7-8ff6-d524c3583be0",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "471680db-7a08-4b71-b14a-40a1a81703fb", "username.40@website.com", "82720385-aff4-44ba-a8b0-0d2a441d560e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "82f3cd6a-1f9b-457d-be6e-5ab65edecf26", "username.28@website.com", "e8b06299-3cc1-49c2-bd2b-974b36894180" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39dd92a6-b55d-4f0f-b614-76b15b550678",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "7de199bb-cb20-464d-b5c4-de381de321c0", "username.23@website.com", "74c31ce0-710d-4d1b-a8d2-1fcb6c89b1f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6268e0-e090-4291-a610-8004347721dc",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "66cfe664-392d-4147-a0ab-64ddba38221e", "username.08@website.com", "46a7d898-4869-49fc-8d89-0347b2eaba2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404e8d45-1b49-448a-be30-9ecc57b340af",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "6d220ff1-4f43-4f34-8ca1-2f3301ab2596", "username.22@website.com", "863171ce-bd82-4364-afd3-b6c75a6e2484" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406efbec-e351-4369-a812-d7a0df894b30",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "f342db1d-0dff-4446-8fd3-f27235ba7a1e", "username.16@website.com", "0094d1c9-6044-427a-90f7-66549a8dd2ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42d8c277-8adb-4479-9499-1f52b917b528",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "ab5428c1-e91a-48bf-92d1-22938d1cbe4f", "username.37@website.com", "09592ac3-1584-4ed8-91a4-e2e34fb1652c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ed259d-18c9-47fe-9e67-111dbc445fd4",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "65ae79cf-900d-4838-a531-b5b25572f28c", "username.21@website.com", "e81b009d-a438-449c-bf0f-c0fe798afe0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968a764-9310-40b7-b114-08ad4a191db5",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "6ce85098-c91a-47d8-b3ea-6aa35414b28f", "username.17@website.com", "c582d7e6-d5fa-4f27-8b94-bc937861d1c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55367a6a-2505-4ce4-99cf-b77d55df3320",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "ad396600-4bce-4694-b59d-e14e421e8e37", "username.13@website.com", "2559cbc9-dbf6-4bd5-883d-5de7e4ebadcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558de276-cdd7-4f80-b7a7-9471e579788f",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "cf9093a3-5416-4a9b-b004-ae4fa85cc924", "username.06@website.com", "c7b73062-0b08-438b-83b4-3dedc719ae88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b050e9-93d3-4539-a13b-dfbcf27361b8",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "0507341b-aeed-4c60-bd05-b17147141012", "username.09@website.com", "90fb4b5a-e930-4681-9e7f-a98b6125f13c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f57cdbe-e41f-4d6b-8e11-ebe076723861",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "46fdaad9-75b5-4677-90f1-21805c1fe1d5", "username.31@website.com", "31a7f6b5-a55e-4836-837e-2388ee07872b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728d5de5-a876-4ec3-ae28-f9bd5d54e504",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "3efbf91b-5045-4abc-b422-472602ca6c02", "username.26@website.com", "800fe41d-0292-4284-aa80-7b13746fbc51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737dd08e-80c1-45bd-a2b9-98a5d324cd1a",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "0bff9e36-6535-4a7d-afcd-e948cc28e7af", "username.12@website.com", "d4080658-d8de-45c6-ac31-3b35d565d23c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c5f76c-51ee-4c0a-bc26-f96cac06b92b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "e0df47a0-72b6-4442-a785-f287a4daeea9", "username.36@website.com", "f1ff325c-f7b8-4154-ad85-70a01c4a2cff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baa663b-5422-4e0d-9d89-8d85eacb0e5c",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "88cb3c8d-4ad4-422b-8c3d-f59dc2e4a167", "username.02@website.com", "7bb0549d-82ac-4627-b374-c8b85c825a01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0f6526-4964-4e75-82cc-dc7f5c662e5b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "e23dce04-9e37-4cb9-a253-3a4c2f98c411", "username.11@website.com", "e973e6c9-473b-49d3-a920-35a1863a6698" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e68dbf-d08e-4b3a-bb44-642f44826249",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "75143711-d03d-42be-823e-6012afdc9876", "username.24@website.com", "f96377b9-b8dd-4574-9f0d-57ff1d6b82e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977a193e-b63c-4b74-8c2c-13fac432a3ff",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "54a4ce2c-3e2f-41f6-96ea-2706f425ea49", "username.34@website.com", "33846984-727f-47ca-9992-53d5cebbb941" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfe112-4c41-4022-a5fe-62a83e8fc299",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "8b91c097-dbc5-46d8-9467-95a530751244", "username.15@website.com", "07c95b55-ec56-43e6-8239-0dd49db188d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1abf5b1-34bd-46cd-ace4-7623fe26813b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "efa42e8e-179a-430e-b879-59729643ffdb", "username.30@website.com", "5593f0a9-c2ec-4ba6-a895-39735ef7f003" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "2508f43e-8d7c-4344-9dbf-50a980857b29", "username.05@website.com", "10894e6c-73ac-46df-bd4b-35da3cf9b3b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b455a890-08c6-4e6f-bfe7-30cc99cf2f72",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "05bb05a7-7409-4df2-8f1f-882b4d82cc44", "username.19@website.com", "eb57f2e3-5eba-4466-81e0-0647030bb9b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4769c29-8598-480b-b5d3-698700864869",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "6a16884d-37c3-4fba-b6e5-546c6fdff086", "username.14@website.com", "4e8707fd-1d80-4f09-a9d8-4d5056e2c767" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7629af8-b837-4e6d-a0d5-156a88c2749d",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "9992278d-8326-4c00-b17b-17609735157c", "username.03@website.com", "92db1fd5-d1bf-49da-80b5-01554fd0ecde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caacdd8d-c803-4680-aa29-fe0d99f67abb",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "d369e591-80d1-4d72-abcf-f48ef65ac238", "username.32@website.com", "e4a7c992-f0e9-43f4-be0d-11a2a2348585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd834580-5220-4fed-a923-fc03e1d3de14",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "ccfb7469-13c4-4b74-ac19-17dd220e6d28", "username.04@website.com", "e25cddd7-4e70-4aa1-9476-03de0a10c997" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "c952830e-2bf8-418d-b05d-2a682d12e819", "username.27@website.com", "c003ee22-a171-478b-ba99-9ac4c66def73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d957f266-695c-4e51-bb05-ddd4c78ab54b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "bb9e5330-38d0-4f12-9f49-fb94d9a6fcca", "username.33@website.com", "3888b9b9-9261-4407-928c-551c98ff99d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbbd1a5a-1161-483e-a705-5cb5b640f239",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "da843782-a693-4636-8b83-8a2f04a38d5e", "username.18@website.com", "84735bad-46ed-485a-9e1f-7de529f99bf1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e303170d-4192-4733-b5a2-7eafea38e142",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "074025b6-008e-4484-bfc3-dcceaee44953", "username.35@website.com", "4dfa8518-24fa-4a85-8a6e-7494ad298f52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47ff457-1df0-4275-9d6c-e76fe98fa961",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "7a5ed749-508f-4154-818d-d2e1bcfbfecf", "username.29@website.com", "3e81b478-2b51-4d2b-bab0-ac5eea13f213" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5a62d42-8dde-4584-9107-19a825c9d241",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "06fc56e0-314a-4f55-ab56-46fb724dc804", "username.39@website.com", "cd76d1ac-ae58-400a-bcb0-f4c3cd6187a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70b4e31-573d-4132-9867-4c0a7f7302ec",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "82d40c49-7827-4ee7-bf39-376adb403dfa", "username.38@website.com", "304ad909-dc6a-49ce-ac8f-547b9dcf3f52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e741c863-683d-4a5b-aad9-7bec025a352b",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "7afae394-2792-403b-a2fe-53f9f62927de", "username.25@website.com", "917cbfd8-26f5-4a78-899a-e027356fbf4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f079118a-23ea-4723-a979-27ae21dafbe1",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "4565a8d5-fae1-40bf-bc57-cc736f08e0bf", "username.07@website.com", "3ecc6636-419c-4d82-a8e1-59a9e016ead7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "986e22d3-c985-4ddd-9dec-b28d6a0b6fc3", "username.01@website.com", "0ee3aae5-23c4-4884-ba89-de4dbacdef0d" });
        }
    }
}
