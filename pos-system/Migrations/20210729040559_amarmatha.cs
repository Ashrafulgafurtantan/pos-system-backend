using Microsoft.EntityFrameworkCore.Migrations;

namespace pos_system.Migrations
{
    public partial class amarmatha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "username", "password", "role" },
                values: new object[] { "admin", "admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "username",
                keyValue: "admin");
        }
    }
}
