using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Půjčovna.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IDcard_number",
                table: "Contact_Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDcard_number",
                table: "Contact_Persons");
        }
    }
}
