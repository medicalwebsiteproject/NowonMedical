using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace NowonMedical.Migrations
{
    /// <inheritdoc />
    public partial class NowonMedicalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminIPTbl",
                columns: table => new
                {
                    ip_v4 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminIPTbl", x => x.ip_v4);
                });

            migrationBuilder.CreateTable(
                name: "CommunityBoardTbl",
                columns: table => new
                {
                    BoardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityBoardTbl", x => x.BoardId);
                    table.CheckConstraint("CK_BoardType", "[Type] in ('Notice', 'News', 'Review')");
                });

            migrationBuilder.CreateTable(
                name: "BoardMediaTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    MediaPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardMediaTbl", x => x.Id);
                    table.CheckConstraint("CK_MediaType", "[MediaType] in ('Image', 'Video', 'File')");
                    table.ForeignKey(
                        name: "FK_BoardMediaTbl_CommunityBoardTbl_BoardId",
                        column: x => x.BoardId,
                        principalTable: "CommunityBoardTbl",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardMediaTbl_BoardId",
                table: "BoardMediaTbl",
                column: "BoardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminIPTbl");

            migrationBuilder.DropTable(
                name: "BoardMediaTbl");

            migrationBuilder.DropTable(
                name: "CommunityBoardTbl");
        }
    }
}
