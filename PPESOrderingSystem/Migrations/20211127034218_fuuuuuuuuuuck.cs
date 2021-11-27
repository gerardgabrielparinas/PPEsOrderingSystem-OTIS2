using Microsoft.EntityFrameworkCore.Migrations;

namespace PPEsOrderingSystem.Migrations
{
    public partial class fuuuuuuuuuuck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Class",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                });
        }
    }
}
