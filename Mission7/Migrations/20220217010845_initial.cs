using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission7.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    Classification = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    PageCount = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 1, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
