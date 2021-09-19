using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbyRadarAPI.Migrations
{
    public partial class CreateSampleUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e33abd3-0735-4266-a81d-1788ead161fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "943ac117-3f5c-47fe-a39b-0b0f5d131691");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79012546-13c0-4fe7-9ad5-0a74a7945980", "ef747f7b-e12c-4b2b-b0f7-a12a834beeb1", "Admin", "ADMIN" },
                    { "1b1e5957-c8a2-4bb3-b9e4-49235dfbd3dc", "e242c7af-f217-4b9c-b06d-81658ed76e6a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserCity", "UserName", "UserState", "UserZip" },
                values: new object[,]
                {
                    { "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054", 0, "986e22d3-c985-4ddd-9dec-b28d6a0b6fc3", "username.01@website.com", false, "Virgil", "Nichols", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "0ee3aae5-23c4-4884-ba89-de4dbacdef0d", false, "Milwaukee", "username01", "WI", "53172" },
                    { "8baa663b-5422-4e0d-9d89-8d85eacb0e5c", 0, "88cb3c8d-4ad4-422b-8c3d-f59dc2e4a167", "username.02@website.com", false, "Donald", "Williams", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "7bb0549d-82ac-4627-b374-c8b85c825a01", false, "Milwaukee", "username02", "WI", "53172" },
                    { "c7629af8-b837-4e6d-a0d5-156a88c2749d", 0, "9992278d-8326-4c00-b17b-17609735157c", "username.03@website.com", false, "Victor", "English", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "92db1fd5-d1bf-49da-80b5-01554fd0ecde", false, "Milwaukee", "username03", "WI", "53172" },
                    { "cd834580-5220-4fed-a923-fc03e1d3de14", 0, "ccfb7469-13c4-4b74-ac19-17dd220e6d28", "username.04@website.com", false, "Marilyn", "Jensen", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "e25cddd7-4e70-4aa1-9476-03de0a10c997", false, "Milwaukee", "username04", "WI", "53172" },
                    { "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb", 0, "2508f43e-8d7c-4344-9dbf-50a980857b29", "username.05@website.com", false, "Joseph", "Hensley", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "10894e6c-73ac-46df-bd4b-35da3cf9b3b6", false, "Milwaukee", "username05", "WI", "53172" },
                    { "558de276-cdd7-4f80-b7a7-9471e579788f", 0, "cf9093a3-5416-4a9b-b004-ae4fa85cc924", "username.06@website.com", false, "Joan", "Nicholson", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "c7b73062-0b08-438b-83b4-3dedc719ae88", false, "Milwaukee", "username06", "WI", "53172" },
                    { "f079118a-23ea-4723-a979-27ae21dafbe1", 0, "4565a8d5-fae1-40bf-bc57-cc736f08e0bf", "username.07@website.com", false, "Jen", "Hinton", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "3ecc6636-419c-4d82-a8e1-59a9e016ead7", false, "Milwaukee", "username07", "WI", "53172" },
                    { "3e6268e0-e090-4291-a610-8004347721dc", 0, "66cfe664-392d-4147-a0ab-64ddba38221e", "username.08@website.com", false, "Janet", "Holloway", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "46a7d898-4869-49fc-8d89-0347b2eaba2f", false, "Milwaukee", "username08", "WI", "53172" },
                    { "67b050e9-93d3-4539-a13b-dfbcf27361b8", 0, "0507341b-aeed-4c60-bd05-b17147141012", "username.09@website.com", false, "Vince", "McClain", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "90fb4b5a-e930-4681-9e7f-a98b6125f13c", false, "Milwaukee", "username09", "WI", "53172" },
                    { "1f22c979-726f-4962-b2b5-bf5e83cc13f1", 0, "33144246-7418-41d3-83bd-b91850754a1d", "username.10@website.com", false, "Rebbecca", "Patton", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "70d3cafc-fc2f-477c-bb6a-148ef325648e", false, "Milwaukee", "username10", "WI", "53172" },
                    { "8c0f6526-4964-4e75-82cc-dc7f5c662e5b", 0, "e23dce04-9e37-4cb9-a253-3a4c2f98c411", "username.11@website.com", false, "Ann", "McConnell", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "e973e6c9-473b-49d3-a920-35a1863a6698", false, "Milwaukee", "username11", "WI", "53172" },
                    { "737dd08e-80c1-45bd-a2b9-98a5d324cd1a", 0, "0bff9e36-6535-4a7d-afcd-e948cc28e7af", "username.12@website.com", false, "Brandy", "Booth", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "d4080658-d8de-45c6-ac31-3b35d565d23c", false, "Milwaukee", "username12", "WI", "53172" },
                    { "55367a6a-2505-4ce4-99cf-b77d55df3320", 0, "ad396600-4bce-4694-b59d-e14e421e8e37", "username.13@website.com", false, "Curtis", "Allison", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "2559cbc9-dbf6-4bd5-883d-5de7e4ebadcf", false, "Milwaukee", "username13", "WI", "53172" },
                    { "b4769c29-8598-480b-b5d3-698700864869", 0, "6a16884d-37c3-4fba-b6e5-546c6fdff086", "username.14@website.com", false, "Stan", "Carr", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "4e8707fd-1d80-4f09-a9d8-4d5056e2c767", false, "Milwaukee", "username14", "WI", "53172" },
                    { "9adfe112-4c41-4022-a5fe-62a83e8fc299", 0, "8b91c097-dbc5-46d8-9467-95a530751244", "username.15@website.com", false, "Joe", "Cowan", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "07c95b55-ec56-43e6-8239-0dd49db188d5", false, "Milwaukee", "username15", "WI", "53172" },
                    { "406efbec-e351-4369-a812-d7a0df894b30", 0, "f342db1d-0dff-4446-8fd3-f27235ba7a1e", "username.16@website.com", false, "Jenna", "Farmer", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "0094d1c9-6044-427a-90f7-66549a8dd2ae", false, "Milwaukee", "username16", "WI", "53172" },
                    { "4968a764-9310-40b7-b114-08ad4a191db5", 0, "6ce85098-c91a-47d8-b3ea-6aa35414b28f", "username.17@website.com", false, "Cecelia", "Rider", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "c582d7e6-d5fa-4f27-8b94-bc937861d1c3", false, "Milwaukee", "username17", "WI", "53172" },
                    { "dbbd1a5a-1161-483e-a705-5cb5b640f239", 0, "da843782-a693-4636-8b83-8a2f04a38d5e", "username.18@website.com", false, "Thelma", "Daily", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "84735bad-46ed-485a-9e1f-7de529f99bf1", false, "Milwaukee", "username18", "WI", "53172" },
                    { "b455a890-08c6-4e6f-bfe7-30cc99cf2f72", 0, "05bb05a7-7409-4df2-8f1f-882b4d82cc44", "username.19@website.com", false, "Rudy", "Sears", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "eb57f2e3-5eba-4466-81e0-0647030bb9b1", false, "Milwaukee", "username19", "WI", "53172" },
                    { "1f6fbbd3-5b86-4154-bd59-10901df0ad81", 0, "525fed36-cbd2-4c30-ba7d-b1643291e1c1", "username.20@website.com", false, "Kristen", "Booker", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "00ae55df-09c1-4372-b557-7a1706a7904e", false, "Milwaukee", "username20", "WI", "53172" },
                    { "48ed259d-18c9-47fe-9e67-111dbc445fd4", 0, "65ae79cf-900d-4838-a531-b5b25572f28c", "username.21@website.com", false, "Greg", "Haines", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "e81b009d-a438-449c-bf0f-c0fe798afe0f", false, "Minneapolis", "username21", "MN", "55403" },
                    { "404e8d45-1b49-448a-be30-9ecc57b340af", 0, "6d220ff1-4f43-4f34-8ca1-2f3301ab2596", "username.22@website.com", false, "Roy", "Shields", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "863171ce-bd82-4364-afd3-b6c75a6e2484", false, "Minneapolis", "username22", "MN", "55403" },
                    { "39dd92a6-b55d-4f0f-b614-76b15b550678", 0, "7de199bb-cb20-464d-b5c4-de381de321c0", "username.23@website.com", false, "Pablo", "Sanders", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "74c31ce0-710d-4d1b-a8d2-1fcb6c89b1f4", false, "Minneapolis", "username23", "MN", "55403" },
                    { "90e68dbf-d08e-4b3a-bb44-642f44826249", 0, "75143711-d03d-42be-823e-6012afdc9876", "username.24@website.com", false, "Bonita", "Reese", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "f96377b9-b8dd-4574-9f0d-57ff1d6b82e1", false, "Minneapolis", "username24", "MN", "55403" },
                    { "e741c863-683d-4a5b-aad9-7bec025a352b", 0, "7afae394-2792-403b-a2fe-53f9f62927de", "username.25@website.com", false, "Dolores", "Wolfe", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "917cbfd8-26f5-4a78-899a-e027356fbf4a", false, "Minneapolis", "username25", "MN", "55403" },
                    { "728d5de5-a876-4ec3-ae28-f9bd5d54e504", 0, "3efbf91b-5045-4abc-b422-472602ca6c02", "username.26@website.com", false, "Delia", "Liu", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "800fe41d-0292-4284-aa80-7b13746fbc51", false, "Minneapolis", "username26", "MN", "55403" },
                    { "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088", 0, "c952830e-2bf8-418d-b05d-2a682d12e819", "username.27@website.com", false, "Pedro", "Anthony", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "c003ee22-a171-478b-ba99-9ac4c66def73", false, "Minneapolis", "username27", "MN", "55403" },
                    { "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a", 0, "82f3cd6a-1f9b-457d-be6e-5ab65edecf26", "username.28@website.com", false, "Roman", "Jackson", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "e8b06299-3cc1-49c2-bd2b-974b36894180", false, "Minneapolis", "username28", "MN", "55403" },
                    { "e47ff457-1df0-4275-9d6c-e76fe98fa961", 0, "7a5ed749-508f-4154-818d-d2e1bcfbfecf", "username.29@website.com", false, "Cory", "Cunningham", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "3e81b478-2b51-4d2b-bab0-ac5eea13f213", false, "Minneapolis", "username29", "MN", "55403" },
                    { "a1abf5b1-34bd-46cd-ace4-7623fe26813b", 0, "efa42e8e-179a-430e-b879-59729643ffdb", "username.30@website.com", false, "Rosemarie", "McGuire", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "5593f0a9-c2ec-4ba6-a895-39735ef7f003", false, "Minneapolis", "username30", "MN", "55403" },
                    { "6f57cdbe-e41f-4d6b-8e11-ebe076723861", 0, "46fdaad9-75b5-4677-90f1-21805c1fe1d5", "username.31@website.com", false, "Frances", "Cantu", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "31a7f6b5-a55e-4836-837e-2388ee07872b", false, "Minneapolis", "username31", "MN", "55403" },
                    { "caacdd8d-c803-4680-aa29-fe0d99f67abb", 0, "d369e591-80d1-4d72-abcf-f48ef65ac238", "username.32@website.com", false, "Edward", "Bradford", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "e4a7c992-f0e9-43f4-be0d-11a2a2348585", false, "Minneapolis", "username32", "MN", "55403" },
                    { "d957f266-695c-4e51-bb05-ddd4c78ab54b", 0, "bb9e5330-38d0-4f12-9f49-fb94d9a6fcca", "username.33@website.com", false, "Merle", "Myers", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "3888b9b9-9261-4407-928c-551c98ff99d7", false, "Minneapolis", "username33", "MN", "55403" },
                    { "977a193e-b63c-4b74-8c2c-13fac432a3ff", 0, "54a4ce2c-3e2f-41f6-96ea-2706f425ea49", "username.34@website.com", false, "Gerald", "Livingston", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "33846984-727f-47ca-9992-53d5cebbb941", false, "Minneapolis", "username34", "MN", "55403" },
                    { "e303170d-4192-4733-b5a2-7eafea38e142", 0, "074025b6-008e-4484-bfc3-dcceaee44953", "username.35@website.com", false, "Deborah", "Simon", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "4dfa8518-24fa-4a85-8a6e-7494ad298f52", false, "Minneapolis", "username35", "MN", "55403" },
                    { "82c5f76c-51ee-4c0a-bc26-f96cac06b92b", 0, "e0df47a0-72b6-4442-a785-f287a4daeea9", "username.36@website.com", false, "Neal", "Thornton", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "f1ff325c-f7b8-4154-ad85-70a01c4a2cff", false, "Minneapolis", "username36", "MN", "55403" },
                    { "42d8c277-8adb-4479-9499-1f52b917b528", 0, "ab5428c1-e91a-48bf-92d1-22938d1cbe4f", "username.37@website.com", false, "Sandi", "Norton", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "09592ac3-1584-4ed8-91a4-e2e34fb1652c", false, "Minneapolis", "username37", "MN", "55403" },
                    { "e70b4e31-573d-4132-9867-4c0a7f7302ec", 0, "82d40c49-7827-4ee7-bf39-376adb403dfa", "username.38@website.com", false, "Julian", "Farley", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "304ad909-dc6a-49ce-ac8f-547b9dcf3f52", false, "Minneapolis", "username38", "MN", "55403" },
                    { "e5a62d42-8dde-4584-9107-19a825c9d241", 0, "06fc56e0-314a-4f55-ab56-46fb724dc804", "username.39@website.com", false, "Mercedes", "Stafford", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "cd76d1ac-ae58-400a-bcb0-f4c3cd6187a4", false, "Minneapolis", "username39", "MN", "55403" },
                    { "3047431e-a67a-47b7-8ff6-d524c3583be0", 0, "471680db-7a08-4b71-b14a-40a1a81703fb", "username.40@website.com", false, "Rene", "Gilmore", false, null, null, null, "AQAAAAEAACcQAAAAEPdhpwoFO9D08m7ShJwltbFOOjVhj0t0iYEr2RBbzkCJScWiTkfnD0J2drhMZg1FWA==", null, false, "82720385-aff4-44ba-a8b0-0d2a441d560e", false, "Minneapolis", "username40", "MN", "55403" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b1e5957-c8a2-4bb3-b9e4-49235dfbd3dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79012546-13c0-4fe7-9ad5-0a74a7945980");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f22c979-726f-4962-b2b5-bf5e83cc13f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6fbbd3-5b86-4154-bd59-10901df0ad81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3047431e-a67a-47b7-8ff6-d524c3583be0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f1d1ab-7b0b-49f5-9d45-5d44ca8d2d4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39dd92a6-b55d-4f0f-b614-76b15b550678");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e6268e0-e090-4291-a610-8004347721dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404e8d45-1b49-448a-be30-9ecc57b340af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406efbec-e351-4369-a812-d7a0df894b30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42d8c277-8adb-4479-9499-1f52b917b528");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48ed259d-18c9-47fe-9e67-111dbc445fd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4968a764-9310-40b7-b114-08ad4a191db5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55367a6a-2505-4ce4-99cf-b77d55df3320");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "558de276-cdd7-4f80-b7a7-9471e579788f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67b050e9-93d3-4539-a13b-dfbcf27361b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f57cdbe-e41f-4d6b-8e11-ebe076723861");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728d5de5-a876-4ec3-ae28-f9bd5d54e504");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737dd08e-80c1-45bd-a2b9-98a5d324cd1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c5f76c-51ee-4c0a-bc26-f96cac06b92b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8baa663b-5422-4e0d-9d89-8d85eacb0e5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c0f6526-4964-4e75-82cc-dc7f5c662e5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e68dbf-d08e-4b3a-bb44-642f44826249");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "977a193e-b63c-4b74-8c2c-13fac432a3ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9adfe112-4c41-4022-a5fe-62a83e8fc299");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1abf5b1-34bd-46cd-ace4-7623fe26813b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad20d1ce-eb30-4ef1-82bb-3de9190cefcb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b455a890-08c6-4e6f-bfe7-30cc99cf2f72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4769c29-8598-480b-b5d3-698700864869");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7629af8-b837-4e6d-a0d5-156a88c2749d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caacdd8d-c803-4680-aa29-fe0d99f67abb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd834580-5220-4fed-a923-fc03e1d3de14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6c218c0-a1f4-4ec4-a43a-ed23ba5f1088");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d957f266-695c-4e51-bb05-ddd4c78ab54b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbbd1a5a-1161-483e-a705-5cb5b640f239");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e303170d-4192-4733-b5a2-7eafea38e142");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47ff457-1df0-4275-9d6c-e76fe98fa961");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5a62d42-8dde-4584-9107-19a825c9d241");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70b4e31-573d-4132-9867-4c0a7f7302ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e741c863-683d-4a5b-aad9-7bec025a352b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f079118a-23ea-4723-a979-27ae21dafbe1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7e4aa9-de58-4e19-bc7c-cedabc8d1054");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "943ac117-3f5c-47fe-a39b-0b0f5d131691", "87b740f0-dfad-4e57-a9cb-e8f4d6c8ea1e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e33abd3-0735-4266-a81d-1788ead161fd", "ffc2803a-7ef4-4bbb-b0f7-75b3480ddde8", "Admin", "ADMIN" });
        }
    }
}
