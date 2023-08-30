using Microsoft.EntityFrameworkCore.Migrations;

namespace BorrowBooks.Migrations
{
    public partial class Members : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_M_MEMBER",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 5, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_MEMBER", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_M_MEMBER");
        }
    }
}
