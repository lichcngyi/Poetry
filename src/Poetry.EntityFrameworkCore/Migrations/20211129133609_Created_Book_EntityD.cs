using Microsoft.EntityFrameworkCore.Migrations;

namespace Poetry.Migrations
{
    public partial class Created_Book_EntityD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyId",
                table: "PoetryDatas",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyId",
                table: "PoetryClassifys",
                type: "varchar(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyId",
                table: "PoetryDatas");

            migrationBuilder.DropColumn(
                name: "MyId",
                table: "PoetryClassifys");
        }
    }
}
