using Microsoft.EntityFrameworkCore.Migrations;

namespace BorrowBooks.Migrations
{
    public partial class Books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_M_BOOK",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Title = table.Column<string>(maxLength: 256, nullable: true),
                    Author = table.Column<string>(maxLength: 100, nullable: true),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_BOOK", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_M_BOOK");
        }
    }
}
