using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Půjčovna.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBorrows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Contact_PersonId",
                table: "Contact_Persons",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Borrow_Number = table.Column<int>(type: "int", nullable: false),
                    Borrow_Date_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Borrow_Date_To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total_Deposit = table.Column<int>(type: "int", nullable: false),
                    Total_Prize = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_PersonID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrows_Contact_Persons_Contact_PersonID",
                        column: x => x.Contact_PersonID,
                        principalTable: "Contact_Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrows_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrow_Things",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Things_To_BorrowID = table.Column<int>(type: "int", nullable: false),
                    BorrowsId = table.Column<int>(type: "int", nullable: false),
                    Real_Deposit = table.Column<int>(type: "int", nullable: false),
                    Prize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrow_Things", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Borrow_Things_Borrows_BorrowsId",
                        column: x => x.BorrowsId,
                        principalTable: "Borrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrow_Things_Things_To_Borrows_Things_To_BorrowID",
                        column: x => x.Things_To_BorrowID,
                        principalTable: "Things_To_Borrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrow_Things_BorrowsId",
                table: "Borrow_Things",
                column: "BorrowsId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrow_Things_Things_To_BorrowID",
                table: "Borrow_Things",
                column: "Things_To_BorrowID");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_Contact_PersonID",
                table: "Borrows",
                column: "Contact_PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_EmployeeID",
                table: "Borrows",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrow_Things");

            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contact_Persons",
                newName: "Contact_PersonId");
        }
    }
}
