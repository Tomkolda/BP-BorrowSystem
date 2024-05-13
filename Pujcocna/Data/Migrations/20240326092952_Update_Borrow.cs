using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Půjčovna.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_Borrow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Borrow_Things",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Borrow_Things_CategoryID",
                table: "Borrow_Things",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrow_Things_Categories_CategoryID",
                table: "Borrow_Things",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Name", "Surname", "Login", "Password", "Signature", "role" },
                values: new object[] { "admin", "", "admin", "admin", "admin", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrow_Things_Categories_CategoryID",
                table: "Borrow_Things");

            migrationBuilder.DropIndex(
                name: "IX_Borrow_Things_CategoryID",
                table: "Borrow_Things");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Borrow_Things");
        }
    }
}
