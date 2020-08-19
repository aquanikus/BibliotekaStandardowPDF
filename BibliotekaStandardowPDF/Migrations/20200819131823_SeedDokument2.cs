using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaStandardowPDF.Migrations
{
    public partial class SeedDokument2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dokumenty",
                table: "Dokumenty");

            migrationBuilder.DeleteData(
                table: "Dokumenty",
                keyColumn: "Id_dokumentu",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Dokumenty",
                newName: "Dokument");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dokument",
                table: "Dokument",
                column: "Id_dokumentu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dokument",
                table: "Dokument");

            migrationBuilder.RenameTable(
                name: "Dokument",
                newName: "Dokumenty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dokumenty",
                table: "Dokumenty",
                column: "Id_dokumentu");

            migrationBuilder.InsertData(
                table: "Dokumenty",
                columns: new[] { "Id_dokumentu", "Temat", "Tresc" },
                values: new object[] { 1, "PRO-Q-OPL-doukuent1", "<h1>test</h1>" });
        }
    }
}
