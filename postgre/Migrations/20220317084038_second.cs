using Microsoft.EntityFrameworkCore.Migrations;

namespace postgre.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_AuthorID",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_AuthorID",
                table: "books");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "books");

            migrationBuilder.AddColumn<int>(
                name: "AuthorFK",
                table: "books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1,
                column: "AuthorFK",
                value: 1);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 2,
                column: "AuthorFK",
                value: 2);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuthorFK",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_books_AuthorFK",
                table: "books",
                column: "AuthorFK");

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_AuthorFK",
                table: "books",
                column: "AuthorFK",
                principalTable: "authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_authors_AuthorFK",
                table: "books");

            migrationBuilder.DropIndex(
                name: "IX_books_AuthorFK",
                table: "books");

            migrationBuilder.DropColumn(
                name: "AuthorFK",
                table: "books");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "books",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_books_AuthorID",
                table: "books",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_books_authors_AuthorID",
                table: "books",
                column: "AuthorID",
                principalTable: "authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
