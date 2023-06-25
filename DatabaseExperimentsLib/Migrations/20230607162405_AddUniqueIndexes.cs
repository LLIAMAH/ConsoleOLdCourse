using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseExperimentsLib.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Publishers_Name",
                table: "Publishers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookTypes_Name",
                table: "BookTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_Title_Year",
                table: "Books",
                columns: new[] { "Title", "Year" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_FirstName_LastName",
                table: "Authors",
                columns: new[] { "FirstName", "LastName" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Publishers_Name",
                table: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_BookTypes_Name",
                table: "BookTypes");

            migrationBuilder.DropIndex(
                name: "IX_Books_Title_Year",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Authors_FirstName_LastName",
                table: "Authors");
        }
    }
}
