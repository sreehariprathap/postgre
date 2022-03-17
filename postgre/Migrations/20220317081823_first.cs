using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace postgre.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    AuthorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_books_authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "AuthorID", "AuthorName" },
                values: new object[,]
                {
                    { 1, "sreehari" },
                    { 2, "nikhil" },
                    { 3, "akhil" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "AuthorID", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "japanese", "Ikigai", 10000 },
                    { 2, 2, "money", "rich dad poor dad", 50000 },
                    { 3, 3, "novel", "anxious people", 20000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_AuthorID",
                table: "books",
                column: "AuthorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "authors");
        }
    }
}
