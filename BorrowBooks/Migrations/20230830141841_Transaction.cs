using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BorrowBooks.Migrations
{
    public partial class Transaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PenaltyDateFrom",
                table: "TB_M_MEMBER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PenaltyDateTo",
                table: "TB_M_MEMBER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TB_R_BORROW_BOOK",
                columns: table => new
                {
                    BorrowedId = table.Column<string>(maxLength: 10, nullable: false),
                    BookCode = table.Column<string>(nullable: true),
                    MemberCode = table.Column<string>(nullable: true),
                    BorrowedDate = table.Column<DateTime>(nullable: true),
                    ReturnLimitDate = table.Column<DateTime>(nullable: true),
                    ReturnDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_R_BORROW_BOOK", x => x.BorrowedId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_R_BORROW_BOOK");

            migrationBuilder.DropColumn(
                name: "PenaltyDateFrom",
                table: "TB_M_MEMBER");

            migrationBuilder.DropColumn(
                name: "PenaltyDateTo",
                table: "TB_M_MEMBER");
        }
    }
}
