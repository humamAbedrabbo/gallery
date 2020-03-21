using Microsoft.EntityFrameworkCore.Migrations;

namespace Gallery.Migrations
{
    public partial class Add_Default_Photos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "ActionUrl", "Company", "Description", "FileName", "Length", "Name", "Owner", "Url" },
                values: new object[,]
                {
                    { 1, "https://google.com", "YamanCo", "Picture for a building", "building.jpg", 47785L, "Building", "Yaman", "img/building.jpg" },
                    { 2, "https://google.com", "YamanCo", "Some colorfull picture", "colorfull.jpg", 74193L, "Colorfull", "Yaman", "img/colorfull.jpg" },
                    { 3, "https://google.com", "YamanCo", "A deer", "deer.jpg", 85870L, "Deer", "Yaman", "img/deer.jpg" },
                    { 4, "https://google.com", "YamanCo", "A picture of a desk", "desk.jpg", 19666L, "Desk", "Yaman", "img/desk.jpg" },
                    { 5, "https://google.com", "YamanCo", "A picture of a bus", "bus.jpg", 78440L, "Bus", "Yaman", "img/bus.jpg" },
                    { 6, "https://google.com", "YamanCo", "A picture of bread", "drop.jpg", 53918L, "Bread", "Yaman", "img/drop.jpg" },
                    { 7, "https://google.com", "YamanCo", "A picture of lava", "lava.jpg", 55451L, "Lava", "Yaman", "img/lava.jpg" },
                    { 8, "https://google.com", "YamanCo", "A picture of stairs", "loft.jpg", 43047L, "Loft", "Yaman", "img/loft.jpg" },
                    { 9, "https://google.com", "YamanCo", "A picture of a race", "race.jpg", 91694L, "Race", "Yaman", "img/race.jpg" },
                    { 10, "https://google.com", "YamanCo", "A picture of a ryno", "ryno.jpg", 66237L, "Ryno", "Yaman", "img/ryno.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a01dc128-a0c9-4085-ac62-9eb990fbe638");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "753c12ac-dd7c-4cac-907b-6ba4a95275b7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38a71a59-ba20-455c-98ad-14b10ce57f2d", "AQAAAAEAACcQAAAAEH9X23oAqgkZeDBht4Ce9P1SCW1ppd+QpXlp6ZJGUxnE3Bng5aZ8FuZAZtLUeWfBgw==", "173fc680-0c64-47c9-8e80-092776687a27" });

            migrationBuilder.InsertData(
                table: "PhotoCategories",
                columns: new[] { "PhotoId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 4 },
                    { 4, 3 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 8, 2 },
                    { 9, 1 },
                    { 10, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "PhotoCategories",
                keyColumns: new[] { "PhotoId", "CategoryId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a4113977-112e-4136-990e-c479698ca30b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "88e211b1-5592-4b41-87f2-d6aa710d43cf");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebddc366-a72f-48bd-b78f-8e0b1f2ff152", "AQAAAAEAACcQAAAAEMSsTi+ZolDQF/XSZIaxPaZCAaxVPQsJ8fD2onnxH7i3+sfbsZDlHOvzQq/bZXdtHg==", "84ecb7f2-23a7-4b75-a77f-fff84e8442db" });
        }
    }
}
