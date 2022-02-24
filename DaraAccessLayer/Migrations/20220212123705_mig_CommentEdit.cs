using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaraAccessLayer.Migrations
{
    public partial class mig_CommentEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commets");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.CreateTable(
                name: "Commets",
                columns: table => new
                {
                    CommetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    CommetContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommetStatus = table.Column<bool>(type: "bit", nullable: false),
                    CommetTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommetUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commets", x => x.CommetId);
                    table.ForeignKey(
                        name: "FK_Commets_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commets_BlogId",
                table: "Commets",
                column: "BlogId");
        }
    }
}
