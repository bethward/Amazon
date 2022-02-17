using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission7.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 18, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 19, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 20, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 21, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 22, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);
        }
    }
}
