using Microsoft.EntityFrameworkCore.Migrations;

namespace Gallery.Migrations
{
    public partial class Add_Photo_Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    FileName = table.Column<string>(maxLength: 100, nullable: false),
                    Url = table.Column<string>(maxLength: 200, nullable: false),
                    Length = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Owner = table.Column<string>(maxLength: 50, nullable: true),
                    Company = table.Column<string>(maxLength: 100, nullable: true),
                    ActionUrl = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoCategories",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoCategories", x => new { x.PhotoId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PhotoCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhotoCategories_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PhotoCategories_CategoryId",
                table: "PhotoCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_Name",
                table: "Photos",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhotoCategories");

            migrationBuilder.DropTable(
                name: "Photos");

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
    }
}
