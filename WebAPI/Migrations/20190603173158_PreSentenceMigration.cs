using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class PreSentenceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PreSentences",
                columns: table => new
                {
                    PSid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseNumber = table.Column<string>(nullable: true),
                    CourtName = table.Column<string>(nullable: true),
                    NameOfOffender = table.Column<string>(nullable: true),
                    OffenderFatherName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ActSec = table.Column<string>(nullable: true),
                    DateOfReceiving = table.Column<string>(nullable: true),
                    LetterNumber = table.Column<string>(nullable: true),
                    PoliceStation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreSentences", x => x.PSid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreSentences");
        }
    }
}
