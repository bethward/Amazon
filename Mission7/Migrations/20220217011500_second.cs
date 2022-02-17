using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission7.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 2, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 3, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 4, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 5, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 6, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 7, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 8, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 9, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 10, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 11, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 12, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 13, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 14, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 15, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 16, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 17, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);
        }
    }
}
