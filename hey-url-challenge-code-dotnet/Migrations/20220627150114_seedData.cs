using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hey_url_challenge_code_dotnet.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Urls",
                columns: new[] { "Id", "Count", "CreatedOn", "OriginalUrl", "ShortUrl" },
                values: new object[,]
                {

                    { new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95"), 24, new DateTime(2022, 1, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.ign.com", "DQRKT" },
                    { new Guid("74fe0975-5728-4bcf-91bf-9bde11cadf45"), 0, new DateTime(2022, 9, 7, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.sitepoint.com", "JNMKL" },
                    { new Guid("ee64be23-0256-473a-8de7-29a0ca185999"), 0, new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.bbc.com", "NVTHL" },
                    { new Guid("a97d89fb-1cc2-41c2-81c4-fadd0837f7eb"), 0, new DateTime(2022, 3, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.c-sharpcorner.com", "AHELK" },
                    { new Guid("3af55419-0fa8-49bc-8208-b8e660489209"), 0, new DateTime(2022, 4, 4, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.stackoverflow.com", "OHDRB" },
                    { new Guid("6bdaf583-afcd-42b0-9c4e-0eba7b21af0a"), 0, new DateTime(2022, 5, 5, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.codesandbox.io", "HTYHB" },
                    { new Guid("8890f231-fbf0-4600-a2fb-7679cd66760d"), 0, new DateTime(2022, 6, 6, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.support.appflyer.com", "BKMLI" },
                    { new Guid("927bf126-f8ea-4c0d-a3be-31258eba2332"), 0, new DateTime(2022, 7, 7, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.benalman.com", "TTUYH" },
                    { new Guid("05dc18f5-afbe-46e2-afc1-265cb00228ac"), 0, new DateTime(2022, 8, 7, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.techtargetcodecity.com", "UJKIL" },
                    { new Guid("f516248e-9e6d-4478-9d58-c8e47a25b839"), 0, new DateTime(2022, 10, 7, 10, 5, 0, 0, DateTimeKind.Unspecified), "http://www.gre.ac.uk", "JKMFD" }
                });

            migrationBuilder.InsertData(
                table: "Clicks",
                columns: new[] { "Id", "Browser", "CreatedOn", "Platform", "UrlId" },
                values: new object[,]
                {
                    { new Guid("6d871b23-8641-4a3c-b674-b07c931688a3"), "Chrome", new DateTime(2022, 1, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("b712cce8-5ae4-4757-ae6e-a7652544c192"), "Chrome", new DateTime(2022, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Ubuntu", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("71bc5242-1eff-4df5-b9da-6078cd44246c"), "Chrome", new DateTime(2022, 11, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Ubuntu", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("462abe3e-a52e-4c5f-8c61-fc23d8f37329"), "FireFox", new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Ubuntu", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("9e604509-ccad-4b68-82cb-824ac6573ba4"), "FireFox", new DateTime(2022, 1, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Ubuntu", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("7548b64f-d332-450a-b23d-e1526f060780"), "Safari", new DateTime(2022, 3, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "macOS", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("89d1f436-2692-4def-b890-c0cc507abec9"), "Safari", new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "macOS", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("160fada9-ca42-4825-a7d4-46c1347e91f9"), "Safari", new DateTime(2022, 1, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "macOS", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("7ffdd7e9-3a52-4754-8dfe-60e1183f78fd"), "IE", new DateTime(2022, 1, 1, 10, 11, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("bb28e46d-9518-4d5b-942a-7203e12df92b"), "Firefox", new DateTime(2022, 3, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), "macOS", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("36309302-9a62-401c-b416-f953f05f085c"), "Firefox", new DateTime(2022, 2, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), "macOS", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("715ec6e2-0e2b-498c-97a2-3644be890d10"), "Firefox", new DateTime(2022, 1, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), "macOS", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("aa299f3d-a7d4-4034-9b74-f6a8bbde3689"), "IE", new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("8ee92bd5-12aa-4b06-b840-e647acc3bcc5"), "Chrome", new DateTime(2022, 11, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("0306cf9c-f9fb-455b-8d06-7cf3d1faebd1"), "Chrome", new DateTime(2022, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("719e042c-993f-4c00-9866-ed76c6b2363a"), "Chrome", new DateTime(2022, 3, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("81e5cbdc-b887-4c7e-bd7a-1c13512385dc"), "Chrome", new DateTime(2022, 4, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("01ca4c22-9f49-42ff-a12c-805bbe6a806f"), "Chrome", new DateTime(2022, 5, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("b7b8e5af-59c7-4737-88b5-4b3698df9173"), "Chrome", new DateTime(2022, 6, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("39ec5ca2-ca84-411f-8a53-d3c4d71c5970"), "Chrome", new DateTime(2022, 2, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("acd7062b-c098-4d25-84d2-4904c7fc7750"), "Chrome", new DateTime(2022, 8, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("53b62b57-09ea-4816-a866-72a0337bc5b8"), "Chrome", new DateTime(2022, 9, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("a863dfc8-1711-442f-aab5-ade43e88e7e5"), "Chrome", new DateTime(2022, 10, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") },
                    { new Guid("64cffa01-8db2-40c2-a889-7c2a54d11f4d"), "Chrome", new DateTime(2022, 7, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), "Windows", new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95") }
                });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("01ca4c22-9f49-42ff-a12c-805bbe6a806f"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("0306cf9c-f9fb-455b-8d06-7cf3d1faebd1"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("160fada9-ca42-4825-a7d4-46c1347e91f9"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("36309302-9a62-401c-b416-f953f05f085c"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("39ec5ca2-ca84-411f-8a53-d3c4d71c5970"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("462abe3e-a52e-4c5f-8c61-fc23d8f37329"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("53b62b57-09ea-4816-a866-72a0337bc5b8"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("64cffa01-8db2-40c2-a889-7c2a54d11f4d"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("6d871b23-8641-4a3c-b674-b07c931688a3"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("715ec6e2-0e2b-498c-97a2-3644be890d10"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("719e042c-993f-4c00-9866-ed76c6b2363a"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("71bc5242-1eff-4df5-b9da-6078cd44246c"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("7548b64f-d332-450a-b23d-e1526f060780"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("7ffdd7e9-3a52-4754-8dfe-60e1183f78fd"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("81e5cbdc-b887-4c7e-bd7a-1c13512385dc"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("89d1f436-2692-4def-b890-c0cc507abec9"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("8ee92bd5-12aa-4b06-b840-e647acc3bcc5"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("9e604509-ccad-4b68-82cb-824ac6573ba4"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("a863dfc8-1711-442f-aab5-ade43e88e7e5"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("aa299f3d-a7d4-4034-9b74-f6a8bbde3689"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("acd7062b-c098-4d25-84d2-4904c7fc7750"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("b712cce8-5ae4-4757-ae6e-a7652544c192"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("b7b8e5af-59c7-4737-88b5-4b3698df9173"));

            migrationBuilder.DeleteData(
                table: "Clicks",
                keyColumn: "Id",
                keyValue: new Guid("bb28e46d-9518-4d5b-942a-7203e12df92b"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("05dc18f5-afbe-46e2-afc1-265cb00228ac"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("3af55419-0fa8-49bc-8208-b8e660489209"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("6bdaf583-afcd-42b0-9c4e-0eba7b21af0a"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("74fe0975-5728-4bcf-91bf-9bde11cadf45"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("822a78e2-df00-40e2-b153-6cc06ac7ff95"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("8890f231-fbf0-4600-a2fb-7679cd66760d"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("927bf126-f8ea-4c0d-a3be-31258eba2332"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("a97d89fb-1cc2-41c2-81c4-fadd0837f7eb"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("ee64be23-0256-473a-8de7-29a0ca185999"));

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: new Guid("f516248e-9e6d-4478-9d58-c8e47a25b839"));

        }
    }
}
