using Microsoft.EntityFrameworkCore.Migrations;

namespace Gallery.Migrations
{
    public partial class Add_Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "c91efb7b-4ffe-457c-9a71-595d4c12c35a", "admin@gallery", false, false, null, "ADMIN@GALLERY", "ADMIN@GALLERY", "AQAAAAEAACcQAAAAEP9fqXWs1q6yKqnIg/YEKb/bpjwCIolfT9yHJpMZnO7ajGynK+E8Z5Gc/geUVqHXmA==", null, false, "cbf033cc-27c8-452d-871d-1d996f2309c5", false, "admin@gallery" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "eecc3fdc-c687-434f-a52f-cc2d9b280de1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ca6496c9-2560-4283-8373-e163a9e77703");
        }
    }
}
