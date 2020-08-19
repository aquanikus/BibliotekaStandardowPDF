using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaStandardowPDF.Migrations
{
    public partial class SeedDokument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dokumenty",
                columns: new[] { "Id_dokumentu", "Temat", "Tresc" },
                values: new object[] { 1, "PRO-Q-OPL-doukuent1", "<h1>test</h1>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dokumenty",
                keyColumn: "Id_dokumentu",
                keyValue: 1);
        }
    }
}
