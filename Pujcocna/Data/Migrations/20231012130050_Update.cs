using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Půjčovna.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Things_To_Borrows_CategoryId",
                table: "Things_To_Borrows");

            migrationBuilder.CreateIndex(
                name: "IX_Things_To_Borrows_CategoryId",
                table: "Things_To_Borrows",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Things_To_Borrows_CategoryId",
                table: "Things_To_Borrows");

            migrationBuilder.CreateIndex(
                name: "IX_Things_To_Borrows_CategoryId",
                table: "Things_To_Borrows",
                column: "CategoryId",
                unique: true);
        }
    }
}
