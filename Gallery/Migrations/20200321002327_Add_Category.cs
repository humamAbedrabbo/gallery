using Microsoft.EntityFrameworkCore.Migrations;

namespace Gallery.Migrations
{
    public partial class Add_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b8518eea-fdd9-4142-9cb4-0c05c88901d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "64f355bb-f89a-48eb-b871-7423f7f46039");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c91efb7b-4ffe-457c-9a71-595d4c12c35a", "AQAAAAEAACcQAAAAEP9fqXWs1q6yKqnIg/YEKb/bpjwCIolfT9yHJpMZnO7ajGynK+E8Z5Gc/geUVqHXmA==", "cbf033cc-27c8-452d-871d-1d996f2309c5" });
        }
    }
}
