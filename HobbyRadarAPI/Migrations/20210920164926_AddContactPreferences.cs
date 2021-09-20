using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbyRadarAPI.Migrations
{
    public partial class AddContactPreferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0801f287-ba7c-4cb3-bf18-376d498d9bcf", "1ba162bc-257d-4466-bd36-7e644333bea7", "User", "USER" },
                    { "bc259985-5c1f-4b9d-86f1-7af547fa5e37", "76aba886-1583-47f8-9fc4-b976129900c2", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f22c979-726f-4962-b2b5-bf5e83cc13f1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5268a8d7-0328-4ecd-a52d-4d2f85b58b27", "c817e92f-348f-4c04-bab6-c9f3ca611c9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6fbbd3-5b86-4154-bd59-10901df0ad81",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10f7e699-9d9f-4f25-bbdd-d6e130bc61a0", "cf409c81-aebb-43d1-b21b-a77991fedc31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3047431e-a67a-47b7-8ff6-d524c3583be0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "19a65a0a-54bb-483c-8f28-ee9875024d36", "ccc521b2-a7c1-4a47-b4df-c0aed0471154" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "848dedd9-5a08-413b-a62b-3d212e11ada9", "af5a4cdd-e657-4f54-9bfc-9c7c160cb310" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39dd92a6-b55d-4f0f-b614-76b15b550678",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a173bc9b-faf3-42ea-9729-decd13d2ed67", "199e2b18-71af-4e43-a3d1-bdce4543531d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6268e0-e090-4291-a610-8004347721dc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "305ad79d-72f0-48ba-9453-f54513c612e6", "8ccc2d5a-f892-4129-8127-3dfdd29c0ff3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404e8d45-1b49-448a-be30-9ecc57b340af",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02847fa4-acc1-4124-8308-624f229e0c23", "c8e01f21-0372-4129-860a-d9bcf272dcdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406efbec-e351-4369-a812-d7a0df894b30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "281f3b97-8d2e-43b6-a3af-fe358c885b04", "a4730da4-577f-409d-8832-00ee3c337991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42d8c277-8adb-4479-9499-1f52b917b528",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "388921cc-0068-4cb8-905e-7f74a69ecdde", "de364ed9-0390-4829-9849-89420e159f03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ed259d-18c9-47fe-9e67-111dbc445fd4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70699453-3010-4fb8-994c-fd68dda34924", "f34aa9ee-583c-4009-95ef-e33b44b22a69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968a764-9310-40b7-b114-08ad4a191db5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca8a8f5e-0593-446a-8f13-263008c9615b", "0379aaba-666c-445a-810b-1261382962c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55367a6a-2505-4ce4-99cf-b77d55df3320",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8790ba7-6c03-4b4b-9a47-ad9323f9b783", "eb719226-02e7-489e-92af-0ca885ad0a7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558de276-cdd7-4f80-b7a7-9471e579788f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "202cd714-e0c6-4ee6-8ad0-a95002416949", "1498f1eb-c33a-46d1-bbcc-6f85aca0dadc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b050e9-93d3-4539-a13b-dfbcf27361b8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e1bb7c7-fbea-4f7a-aab6-24d57ac29ebe", "f01557a0-e4c2-4dd2-a530-a75b9748efe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f57cdbe-e41f-4d6b-8e11-ebe076723861",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8976a17-def9-4775-b769-b577b87b603d", "a53192d5-e7e4-4bb3-9b92-749011574092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728d5de5-a876-4ec3-ae28-f9bd5d54e504",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e2c2888-915e-4c34-865c-21d44311b0cb", "151b060e-39ce-4c26-adf1-51f3d0509a95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737dd08e-80c1-45bd-a2b9-98a5d324cd1a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc0b9cb7-cbf8-457c-92dc-ddfa4118625d", "0b052abd-79ab-46d0-9820-40c957f8b8b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c5f76c-51ee-4c0a-bc26-f96cac06b92b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cb1b1c1-847d-45b7-9f99-4479db1fdaac", "d059d710-e2be-49b8-a8b1-3e6ec3ce5341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baa663b-5422-4e0d-9d89-8d85eacb0e5c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba729232-4e6d-4f2d-a1cb-4c4f740f7f1e", "582f860e-66a8-449c-92cc-acbe8364870d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0f6526-4964-4e75-82cc-dc7f5c662e5b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76fc66e1-ac28-4e19-9e23-ffbbd8779615", "58df6238-03fb-4037-b374-e08f6f7419e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e68dbf-d08e-4b3a-bb44-642f44826249",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6987a21a-5529-4c85-9ebf-96bc3c912a07", "dd7f6cd8-8251-4f05-96f8-1d8637f06b38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977a193e-b63c-4b74-8c2c-13fac432a3ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d02a674b-7417-41b6-afdd-41495397b10b", "51330863-208b-4bb9-9990-61a7e696c503" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfe112-4c41-4022-a5fe-62a83e8fc299",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b45932b-a5be-45ad-8f1e-880a2e153d32", "6000a827-110b-4eec-afb2-276561da83de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1abf5b1-34bd-46cd-ace4-7623fe26813b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "075cfbe0-356e-4243-9cbc-7f45a0b362ea", "18da7d32-40ba-4ca1-b6f0-1c2f40f64ff6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92c90ec0-5e29-4f99-915e-81a609c81f12", "a2d3a24f-5c5f-4ffb-9797-2c97df87a12d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b455a890-08c6-4e6f-bfe7-30cc99cf2f72",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3cd260f4-e318-4d89-b290-e72b4d852c3c", "e59dd7fd-8fc5-40e6-b389-6d9a0052643c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4769c29-8598-480b-b5d3-698700864869",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8c9baf8-7fee-41d0-83ab-ae4bef928546", "b86aa871-4de7-4830-90de-c86f0db0e8bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7629af8-b837-4e6d-a0d5-156a88c2749d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bc48ff8-81a7-4088-a56f-cc6afa95e0ed", "e365557a-9fee-4d89-9fbb-29a63abb7a49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caacdd8d-c803-4680-aa29-fe0d99f67abb",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02241263-0fc5-49d6-a966-08eeb1dc3a26", "72f8687c-6fa8-4f32-9a14-824796d4becb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd834580-5220-4fed-a923-fc03e1d3de14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "271dc6af-03b6-4a3b-87b6-fce72797f5cd", "4db02018-2b71-4b3a-883a-2ff3d96def34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41c3c85a-4306-4985-9469-526d40c0dd57", "c8c6ba12-2f2f-4f56-98e8-31f16736957c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d957f266-695c-4e51-bb05-ddd4c78ab54b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc34fc8b-8577-493c-a45a-0393e8a29d13", "a08119c0-644a-4b72-8b99-22c065945513" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbbd1a5a-1161-483e-a705-5cb5b640f239",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b373a5b6-9b34-41e7-93f0-420ca07a526a", "9e5e0183-57ca-4dec-bdce-596f47962237" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e303170d-4192-4733-b5a2-7eafea38e142",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5af0e2a9-4290-45c3-9398-b3d07bdb6b5a", "698afaea-8e15-4847-9a5d-4634d9946fd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47ff457-1df0-4275-9d6c-e76fe98fa961",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d926b58a-960c-4ea1-9d15-51badd58e3a2", "fc10e678-735f-4dcf-a575-5061f308adfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5a62d42-8dde-4584-9107-19a825c9d241",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02cfa4de-66ea-40c4-8ba8-af4258a0d334", "b14e3d78-fa89-48b1-98f4-39a6a7d07df3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70b4e31-573d-4132-9867-4c0a7f7302ec",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11a95c03-3fac-4eb3-b801-bb8952e9b336", "5554ef63-5741-4e8f-95b3-3710862c91c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e741c863-683d-4a5b-aad9-7bec025a352b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fdce7bc-c616-4090-bccb-6d66f44fc367", "b713716e-0bf1-4798-8181-2c914751e405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f079118a-23ea-4723-a979-27ae21dafbe1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0269ff0-b696-48ea-b6ce-4f619b8b7011", "95a16663-caeb-446e-83f3-731a624e4f1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ade356a-15b2-4fe3-b0b4-48fb26d208b7", "060cc7ee-d648-4b63-be62-eeca7fb8a363" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactPreference", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserCity", "UserName", "UserState", "UserZip" },
                values: new object[] { "8856f0dc-4d2b-441b-8759-600a0e579216", 0, "090b45c9-a196-46ca-8010-66fdbf3abe75", null, "ADMIN@website.com", false, "ADMIN", "ADMIN", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "f5678a66-187d-48fe-9dc9-eb21546730df", false, "Milwaukee", "ADMIN", "WI", "53172" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0801f287-ba7c-4cb3-bf18-376d498d9bcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc259985-5c1f-4b9d-86f1-7af547fa5e37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8856f0dc-4d2b-441b-8759-600a0e579216");

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47917331-e55f-4c21-84ef-511ec3efa8d0", "15508967-921f-43e6-b805-d24ce558188f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6fbbd3-5b86-4154-bd59-10901df0ad81",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "96cae7d8-9f98-4fc3-8091-f755d8262c3f", "324b220a-04f0-425e-86d9-b7f7544f94b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3047431e-a67a-47b7-8ff6-d524c3583be0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1b6513c-5716-45db-bf01-3c0b2be92ef7", "d038fe22-0dd6-4094-85c6-3150eefb23e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d1bd1ba-679a-4a3b-b565-74378f691012", "3150d4a9-739e-48c0-aa8f-efe69ca448fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39dd92a6-b55d-4f0f-b614-76b15b550678",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb3cae3b-8fea-46e0-9efe-be3d4cb78495", "67f863d0-fcac-4d93-969a-12d52ba7a9ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6268e0-e090-4291-a610-8004347721dc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9501b4e5-ad92-4e1e-ac1a-caf4a8f7b020", "4c899bcf-8410-4d25-b443-01f23f26c833" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404e8d45-1b49-448a-be30-9ecc57b340af",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00971e4b-c672-4cf6-b1a3-e1ee9a6a835e", "234b0e8c-c0ac-40f3-b0fd-a51300d2b22c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406efbec-e351-4369-a812-d7a0df894b30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4107880e-26f5-4860-ad07-26ba8436f73d", "2d67f7fa-a896-4238-abc3-2340fe5fa7ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42d8c277-8adb-4479-9499-1f52b917b528",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b62dd05-20df-44cb-832b-b4b7506e4928", "7e0be25d-a8e0-41c5-8270-0b9d5935685f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ed259d-18c9-47fe-9e67-111dbc445fd4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "910ed2d4-40c8-4b54-8b83-7691f96691b4", "4e89df14-e8fa-450e-927e-d20abcc974f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968a764-9310-40b7-b114-08ad4a191db5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4745162a-1211-4116-95f4-74d24ab35497", "ed3c7e63-ca7b-494f-ac15-369fe86a0c50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55367a6a-2505-4ce4-99cf-b77d55df3320",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccf785ec-46fb-431d-9ca4-a5460946824a", "d50afa47-9333-48f0-baca-5c2c1a33bf06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558de276-cdd7-4f80-b7a7-9471e579788f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4923a2a-88f5-40ad-b0fd-95da6f361abe", "199a3b22-419b-4d04-b592-8daa863e0c1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b050e9-93d3-4539-a13b-dfbcf27361b8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13131e45-4c83-487b-b328-e2ee47eccef4", "925e993d-f08d-450a-86f8-8443995cb195" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f57cdbe-e41f-4d6b-8e11-ebe076723861",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3dca680-377e-4340-a74c-9da71a1fe4bb", "04121ea2-727a-423a-973a-d0707312ef0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728d5de5-a876-4ec3-ae28-f9bd5d54e504",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a37f5960-82d8-4dbd-ae8c-17ede399eb74", "6b8e72ef-fbb2-4fd5-8690-316380627e19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737dd08e-80c1-45bd-a2b9-98a5d324cd1a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "222dbe15-928d-42d5-ae5d-2c762a24d89d", "29bca6e7-9302-4ba7-8552-9516348d6026" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c5f76c-51ee-4c0a-bc26-f96cac06b92b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01c2c6c9-5c6f-43b2-9001-35fd202c732d", "06bb9111-e826-4488-a68f-aacccea906f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baa663b-5422-4e0d-9d89-8d85eacb0e5c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60dd62f6-4755-476b-9133-685116e26258", "bd1dd266-c241-4c5c-9e71-b5322f3dadb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0f6526-4964-4e75-82cc-dc7f5c662e5b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a691b3a5-0d2d-4b74-9ea8-845038cb9cdb", "13cc2113-2f67-4703-8f67-74e018179a86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e68dbf-d08e-4b3a-bb44-642f44826249",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e01e21ca-83af-4008-867c-71531f1b187b", "50c3cbbb-00b4-473d-91b4-50f12a550b99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977a193e-b63c-4b74-8c2c-13fac432a3ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76de6877-90a2-4ef3-88dd-f686499338b0", "a82286c9-31aa-4add-92cc-9334da8d3fb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfe112-4c41-4022-a5fe-62a83e8fc299",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "820ad31a-487d-4618-86bc-53656bad45e6", "aaf43636-aac7-43f5-88f6-30403f412f6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1abf5b1-34bd-46cd-ace4-7623fe26813b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5de4e4af-4774-418a-b4f7-39b1b43bd24c", "ce7c7c9f-1ab2-42d3-a661-ec53bdd195b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ea662fd-82be-4d22-a600-8035b2c76ab3", "bf5e49b8-a580-4fa6-bbf0-870af277a7ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b455a890-08c6-4e6f-bfe7-30cc99cf2f72",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6cd665af-1e3b-4b06-8a81-5d00d5b6749e", "84468388-4bc6-4fb0-9be2-7c94759387c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4769c29-8598-480b-b5d3-698700864869",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a33a1465-6911-409b-827c-caefc4783ec8", "71c7c9ec-9234-4ce4-8c80-2a04fd2206e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7629af8-b837-4e6d-a0d5-156a88c2749d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ecb1563-e4f9-41af-a2b4-577d1a47096b", "fc2af253-027c-491e-a94b-cbd69d8029c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caacdd8d-c803-4680-aa29-fe0d99f67abb",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1531a27-b2e9-4afc-9cfe-97f13fee1ff0", "a332d53d-6943-48a2-9448-baea665976b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd834580-5220-4fed-a923-fc03e1d3de14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "746f7516-4373-409e-9c05-113cdd0237cb", "bd55eca6-a2ba-44a2-9583-eb8296f57546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae396545-1377-486e-8cf2-cc8a11c66136", "8bf3c1ed-8fcc-4f66-8a4c-232121fe7393" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d957f266-695c-4e51-bb05-ddd4c78ab54b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e85bcd6f-f8f7-40c3-b11e-aef76d14cdf7", "d5561e16-7a82-4386-a6d3-d7312e26e58a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbbd1a5a-1161-483e-a705-5cb5b640f239",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3668ee9c-565c-488c-9c00-92addb9f190a", "e24a0a82-3569-49cb-9cfd-bac2cfec33f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e303170d-4192-4733-b5a2-7eafea38e142",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0512f0d-8f43-4540-95a8-dc6b9145f42b", "41c9cd5f-84b9-4479-957b-5dd592e9e394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47ff457-1df0-4275-9d6c-e76fe98fa961",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e00653e8-0bf5-4f28-979a-0ee16fed25c9", "f21fdc0a-8284-4e84-af7c-4b572a15e9b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5a62d42-8dde-4584-9107-19a825c9d241",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80bde4da-acdf-4cfb-9412-fa1fb8c5435b", "ad4acb8a-b0e0-4dca-863c-968b24865374" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70b4e31-573d-4132-9867-4c0a7f7302ec",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "674de07c-04d7-45d9-8f4f-9500972793b2", "1efb898b-0417-4dc5-aafa-a4b371baccb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e741c863-683d-4a5b-aad9-7bec025a352b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4a835bdc-8769-4beb-868d-09508738e111", "ec281eae-1a46-4d82-bd74-43485e3e112f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f079118a-23ea-4723-a979-27ae21dafbe1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43bd6fde-a244-4154-a96a-ba516910a981", "85250226-b32c-4388-859d-0421c23d220b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da59c837-1bb3-4e93-b6ca-868f9174c3ab", "4339cd75-7cb7-4f08-9015-37c3ab490a28" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactPreference", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserCity", "UserName", "UserState", "UserZip" },
                values: new object[] { "4300842f-5029-446a-b43e-0775403037b6", 0, "bcc8b588-eefe-494c-900f-276d4c946fe7", null, "ADMIN@website.com", false, "ADMIN", "ADMIN", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "e58c5031-cca4-4550-957d-ed0390e8facd", false, "Milwaukee", "ADMIN", "WI", "53172" });
        }
    }
}
