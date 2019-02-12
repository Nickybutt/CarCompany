using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCarCompany.Data.Migrations
{
    public partial class ListToCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Usertjes_UserId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Cars",
                newName: "UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                newName: "IX_Cars_UserName");

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Usertjes_UserName",
                table: "Cars",
                column: "UserName",
                principalTable: "Usertjes",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Usertjes_UserName",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Cars",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_UserName",
                table: "Cars",
                newName: "IX_Cars_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Usertjes_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "Usertjes",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
