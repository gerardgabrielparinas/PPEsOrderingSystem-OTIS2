using Microsoft.EntityFrameworkCore.Migrations;

namespace PPEsOrderingSystem.Migrations
{
    public partial class sellerinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryCatId = table.Column<int>(type: "int", nullable: true),
                    Catid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierInfo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SupplierInfo_Categories_categoryCatId",
                        column: x => x.categoryCatId,
                        principalTable: "Categories",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierInfo_categoryCatId",
                table: "SupplierInfo",
                column: "categoryCatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierInfo");
        }
    }
}
