using Microsoft.EntityFrameworkCore.Migrations;

namespace Gallery.Migrations
{
    public partial class Add_Admin_UserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "fb5b2cda-e5a4-4b27-b58b-cbefe1206dff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "60ecd4a2-ef30-46dd-818e-5a0155b08cea");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1", "1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56c2626b-4440-4bf9-8ac0-36e9c22336b5", "AQAAAAEAACcQAAAAEIGk9cFSQKSK6tqouTnvIrgybsxiLuCBUCeNEcjA5/DmlB9Cg/Vq2s1TWpGsp0iLcQ==", "8fcf78e1-7989-42cf-bb9e-948fdb8464c9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1", "1" });

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
        }
    }
}
