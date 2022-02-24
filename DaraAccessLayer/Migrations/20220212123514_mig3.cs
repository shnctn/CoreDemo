using Microsoft.EntityFrameworkCore.Migrations;

namespace DaraAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Commets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commets_BlogId",
                table: "Commets",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commets_Blogs_BlogId",
                table: "Commets",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commets_Blogs_BlogId",
                table: "Commets");

            migrationBuilder.DropIndex(
                name: "IX_Commets_BlogId",
                table: "Commets");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Commets");
        }
    }
}
