using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chaos.Chess.Migrations
{
    public partial class AddedChessGametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    State = table.Column<int>(type: "integer", nullable: false),
                    Turn = table.Column<int>(type: "integer", nullable: false),
                    Winner = table.Column<int>(type: "integer", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChessGames",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GameSan = table.Column<string>(type: "text", nullable: true),
                    GameFen = table.Column<string>(type: "text", nullable: true),
                    GameAscii = table.Column<string>(type: "text", nullable: true),
                    DateStarted = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateFinished = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    GameStatusId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChessGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChessGames_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChessGames_GameStatusId",
                table: "ChessGames",
                column: "GameStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChessGames");

            migrationBuilder.DropTable(
                name: "GameStatus");
        }
    }
}
