using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class LoginTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "frontendLogins",
                columns: table => new
                {
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pass_word = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_frontendLogins", x => x.user_name);
                });

            migrationBuilder.CreateTable(
                name: "kitchenLogins",
                columns: table => new
                {
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pass_word = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitchenLogins", x => x.user_name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "frontendLogins");

            migrationBuilder.DropTable(
                name: "kitchenLogins");
        }
    }
}
