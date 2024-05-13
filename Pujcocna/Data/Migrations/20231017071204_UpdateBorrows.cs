using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Půjčovna.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBorrows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Borrows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Borrows");
        }
    }
}
