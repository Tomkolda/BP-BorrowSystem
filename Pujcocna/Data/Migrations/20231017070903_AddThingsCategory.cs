using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Půjčovna.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddThingsCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Things_To_Borrows_Categories_CategoryId",
                table: "Things_To_Borrows");

            migrationBuilder.DropIndex(
                name: "IX_Things_To_Borrows_CategoryId",
                table: "Things_To_Borrows");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Things_To_Borrows");

            migrationBuilder.CreateTable(
                name: "Things_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Things_To_BorrowID = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Things_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Things_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Things_Categories_Things_To_Borrows_Things_To_BorrowID",
                        column: x => x.Things_To_BorrowID,
                        principalTable: "Things_To_Borrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Things_Categories_CategoryId",
                table: "Things_Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Things_Categories_Things_To_BorrowID",
                table: "Things_Categories",
                column: "Things_To_BorrowID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Things_Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Things_To_Borrows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Things_To_Borrows_CategoryId",
                table: "Things_To_Borrows",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Things_To_Borrows_Categories_CategoryId",
                table: "Things_To_Borrows",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
