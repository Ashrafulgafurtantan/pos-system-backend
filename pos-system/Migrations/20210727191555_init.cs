using Microsoft.EntityFrameworkCore.Migrations;

namespace pos_system.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<float>(type: "real", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_of_entry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    pid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<float>(type: "real", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_of_purchase = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    pid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<float>(type: "real", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_of_purchase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    return_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_charge = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Session = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.username);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
