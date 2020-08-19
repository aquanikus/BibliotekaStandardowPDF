using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotekaStandardowPDF.Migrations
{
    public partial class InitiaMgraion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dokumenty",
                columns: table => new
                {
                    Id_dokumentu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temat = table.Column<string>(nullable: true),
                    Tresc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokumenty", x => x.Id_dokumentu);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dokumenty");
        }
    }
}
