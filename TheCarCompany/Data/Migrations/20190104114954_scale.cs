using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCarCompany.Data.Migrations
{
    public partial class scale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Scale",
                table: "Usertjes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scale",
                table: "Usertjes");
        }
    }
}
