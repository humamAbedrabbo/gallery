using Microsoft.EntityFrameworkCore.Migrations;

namespace Gallery.Migrations
{
    public partial class Add_Default_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "General" },
                    { 2, "Architecture" },
                    { 3, "Technology" },
                    { 4, "Animals" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "92077472-b117-4a01-b9a1-88626bec60e8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "de259c0c-8bcb-41a2-8fd5-0a9809b7817b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aacd93ee-c9a3-469b-ae69-b4d8118993c8", "AQAAAAEAACcQAAAAEBrB/YKmupE48zi1d8RO5YT5KvD4ISB064yNNALsCIvk/+aYLMlLRT0ONF0V/x40bw==", "e2cd6f77-b40c-45ea-bd53-4918efd9cc6e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "65645e30-a67b-4efe-8547-dbcdd4cf5af4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d1e19a36-5fe8-448e-8a9a-e18affb357c5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49293c9d-7b9c-4e45-8f7f-07d846158850", "AQAAAAEAACcQAAAAEKq6YgTW7JOfF9Ome6TmnLTEtQ9HL7EsnbSZ2iKk2sy7DK3zi+bpb8Eef/0aSW2DeA==", "faafd798-7337-448f-a132-248afd7f1556" });
        }
    }
}
