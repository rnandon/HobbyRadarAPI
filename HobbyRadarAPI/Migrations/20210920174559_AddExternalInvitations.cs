using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbyRadarAPI.Migrations
{
    public partial class AddExternalInvitations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ExternalInvitation",
                columns: table => new
                {
                    ExternalInvitationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalInvitation", x => x.ExternalInvitationId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b10ea4af-7b96-435e-84f0-58d3a55d0571", "2b921d78-0a03-4fa2-8257-42936be36c99", "User", "USER" },
                    { "f08bdcc9-7dcc-4561-a0b8-50399c8a1009", "7e78ebbb-5713-4db9-b9c9-7ee5554daa91", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f22c979-726f-4962-b2b5-bf5e83cc13f1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ddc86d1-13a2-414c-93ff-39c4f2fb96c9", "89443903-7800-4bbf-bf77-4baa6fbfe0e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6fbbd3-5b86-4154-bd59-10901df0ad81",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecf027fb-02c2-4057-9721-2400f49648be", "28450d88-e0a0-4cc3-aaf6-fc419e72ecb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3047431e-a67a-47b7-8ff6-d524c3583be0",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1549be3-d4ca-4fc1-9ddd-3975b136cc05", "282c3b9e-0de2-43ed-a396-990d6c9db518" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b4d67b3-21a7-4deb-930c-0e23573e5181", "7df6bc19-3139-4f01-8ba3-8938472386c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39dd92a6-b55d-4f0f-b614-76b15b550678",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47234f55-7330-4e30-a7d0-8293ff2100de", "9c36854f-fe38-4e68-b17b-7d56e63a4b66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6268e0-e090-4291-a610-8004347721dc",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e18acea-47ea-4eed-a2cc-ae0bd77fe3cf", "350167ab-ffc0-4ae7-bc12-933f42b528ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404e8d45-1b49-448a-be30-9ecc57b340af",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2fc3cf57-e3d4-496c-96a1-136e7892e9d7", "bb644da6-509e-42be-b5c3-b40bb8432b59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406efbec-e351-4369-a812-d7a0df894b30",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d157d5d6-94ca-42e7-9406-ede35d159a55", "493fb7db-1b28-4c7d-9567-50c8ff86915c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42d8c277-8adb-4479-9499-1f52b917b528",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de17d38c-ecfe-4025-b758-ffc030d7035b", "9129c3d6-f46a-4954-91b3-ca96e2db6d32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ed259d-18c9-47fe-9e67-111dbc445fd4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c886b499-5437-4403-a767-d390b1709afb", "85313da3-3cd6-4079-9b89-79a79b9569e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968a764-9310-40b7-b114-08ad4a191db5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "874fc452-59fe-4221-b902-8edfd993d84e", "2b7aad6a-8ae4-44ac-8d68-d783365c5290" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55367a6a-2505-4ce4-99cf-b77d55df3320",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f71c42f7-2e3f-422e-9545-6ea9c09d13cf", "d1ad95ba-cd41-4a32-9ed3-858789e579eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558de276-cdd7-4f80-b7a7-9471e579788f",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c1fb7fa-aa2d-446f-b7ee-e5217353856a", "cee6d25a-3c65-4fab-bd37-0d787c3dd67c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b050e9-93d3-4539-a13b-dfbcf27361b8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54368362-1594-4e39-bddb-db0c8485e6d3", "d7c4dec3-af22-408f-a4f6-5476425c55ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f57cdbe-e41f-4d6b-8e11-ebe076723861",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec68ff68-cce9-4843-8dc0-7b4f9b151586", "d0479e95-6298-4f63-99f3-3856e9180036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728d5de5-a876-4ec3-ae28-f9bd5d54e504",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1b76af3-75f1-47db-afd4-0cb151bdf2e2", "cf2ade17-3c15-4c53-bed3-83ef32595320" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737dd08e-80c1-45bd-a2b9-98a5d324cd1a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b89d37f-b12e-4207-9781-bff8fc8010ce", "2e1e4fc0-dac1-4398-8408-d14ee78cae84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c5f76c-51ee-4c0a-bc26-f96cac06b92b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8185cfdb-9653-44fd-8b5e-d4a70442d7ac", "462bf2f5-3f69-46af-9039-4497b52b8b88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baa663b-5422-4e0d-9d89-8d85eacb0e5c",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c01a7f13-4d95-4659-a460-0f4d4ffd118d", "ab6ca5a9-7702-4a9a-b3e7-940b9936a9c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0f6526-4964-4e75-82cc-dc7f5c662e5b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b37eeeae-e2f9-4248-8092-aa5b594c32ee", "13e2396c-bb4b-43cb-8a7f-5d254d28a941" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e68dbf-d08e-4b3a-bb44-642f44826249",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "759995d3-42ee-467c-9171-a75ab3528134", "bfe3df89-210e-4e98-afb7-a826ddd3c955" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977a193e-b63c-4b74-8c2c-13fac432a3ff",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "19a9f1b9-7cc3-45ef-ba0c-2a5de24be77b", "1026641b-9034-4554-ba51-d36befa64d27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfe112-4c41-4022-a5fe-62a83e8fc299",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa147475-3719-4fed-90db-a26c8f692cc7", "85c20ba3-755c-4e88-b7a8-bf84e8f15ff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1abf5b1-34bd-46cd-ace4-7623fe26813b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc3fe598-2c0c-4971-8558-ea17d16ab1a4", "3484414c-17c4-4441-83d3-0826f1800c2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9641ee42-9142-4e13-baee-11c317f7a17d", "a16bde57-5740-48c5-a98b-af506ee0d000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b455a890-08c6-4e6f-bfe7-30cc99cf2f72",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "184c7b12-2056-4cff-9e38-6c22fba88c79", "5e3ca7bd-2b07-44e0-9036-09b3c13866a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4769c29-8598-480b-b5d3-698700864869",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01ee7c1f-ee91-416a-b033-01f85ebc1c9b", "b47ae60c-33eb-4967-829f-7bd3fabf5a49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7629af8-b837-4e6d-a0d5-156a88c2749d",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff601391-1e21-478f-b912-8709aeb0fdbd", "664c3597-0bbd-4a65-bae0-352558a47734" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caacdd8d-c803-4680-aa29-fe0d99f67abb",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0c009f9-2b92-4b3d-835f-48860a947f8b", "4f59b534-3760-4ce1-9bd6-f708525ef839" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd834580-5220-4fed-a923-fc03e1d3de14",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdd5a4c4-dbd4-4ef1-b436-e3877120d502", "944159c9-b7e3-4717-806b-6bbf592d72f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69590d6b-01a5-4280-bbb0-44548ef8c813", "0b06b644-24fd-4b13-b208-89729131cf92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d957f266-695c-4e51-bb05-ddd4c78ab54b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90de202f-7edd-41b8-ae9c-8ab5c113e050", "de85c5b4-c5bb-49f1-9730-d252214cea1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbbd1a5a-1161-483e-a705-5cb5b640f239",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24899a1d-03a5-42df-8a7d-48bb708d420e", "f44d0b0f-e728-4fa0-8efb-632ea1287384" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e303170d-4192-4733-b5a2-7eafea38e142",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d4b0aee-df0f-42e8-96da-6f559ee25dfc", "b6375e48-9fec-4fdd-a211-b779baf9cb61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47ff457-1df0-4275-9d6c-e76fe98fa961",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1f7bc6e-2141-424e-9b2d-19e24bbae60c", "87196977-ff69-4f38-a319-fa072dac3075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5a62d42-8dde-4584-9107-19a825c9d241",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "774131e7-5ec1-4890-85c5-1e84f07d1286", "60927f2b-0689-4f5a-8a0b-43d0de298e16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70b4e31-573d-4132-9867-4c0a7f7302ec",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d20b8c3f-365e-49b6-932f-9d6041a2bd41", "797369f4-c41a-40dd-a162-609cdc38cc6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e741c863-683d-4a5b-aad9-7bec025a352b",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b5265fe-de90-420f-88d6-d8f77fa88272", "e339eed4-4399-4729-bcba-6cb3893c8b07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f079118a-23ea-4723-a979-27ae21dafbe1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a9758ad-04aa-4de1-8820-f040c2cd18f5", "566d009b-4c80-4523-9e29-ab1e874b25f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f05a282-a8ae-4ec9-8164-8084846e6814", "c9e8f68e-fa8c-4b9a-a4cf-4b73d9f1a84b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactPreference", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserCity", "UserName", "UserState", "UserZip" },
                values: new object[] { "b5620253-6e0b-4e34-a274-e384431c9147", 0, "b57a5621-c04f-4290-b779-75b9962653af", null, "ADMIN@website.com", false, "ADMIN", "ADMIN", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "54ed6918-eaf5-43e7-ade0-9fd698872731", false, "Milwaukee", "ADMIN", "WI", "53172" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalInvitation");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b10ea4af-7b96-435e-84f0-58d3a55d0571");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f08bdcc9-7dcc-4561-a0b8-50399c8a1009");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5620253-6e0b-4e34-a274-e384431c9147");

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
    }
}
