using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chaos.Chess.Migrations
{
    public partial class AddedGameStatusproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Winner",
                table: "GameStatus",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "string");

            migrationBuilder.AlterColumn<string>(
                name: "Turn",
                table: "GameStatus",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "string");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "GameStatus",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "string");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Winner",
                table: "GameStatus",
                type: "string",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "Turn",
                table: "GameStatus",
                type: "string",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "GameStatus",
                type: "string",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }
    }
}
