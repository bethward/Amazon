using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission7.Migrations
{
    public partial class ItStoppedCompliling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { "Doris Kearns Goodwin", "Biography", "Non-Fiction", "978-0743270755", 944, 14.58f, "Simon & Schuster", "Team of Rivals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { "Laura Hillenbrand", "Historical", "Non-Fiction", "978-0812974492", 538, 13.33f, "Random House", "Unbroken" });

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

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.95f, "Signet", "Les Miserables" });
        }
    }
}
