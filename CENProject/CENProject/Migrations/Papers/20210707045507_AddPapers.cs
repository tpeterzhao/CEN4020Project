using Microsoft.EntityFrameworkCore.Migrations;

namespace CENProject.Migrations.Papers
{
    public partial class AddPapers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paper",
                columns: table => new
                {
                    PaperID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    FilenameOriginal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Certification = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NotesToReviewers = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    AoA = table.Column<bool>(type: "bit", nullable: false),
                    Applications = table.Column<bool>(type: "bit", nullable: false),
                    Architecture = table.Column<bool>(type: "bit", nullable: false),
                    AI = table.Column<bool>(type: "bit", nullable: false),
                    CE = table.Column<bool>(type: "bit", nullable: false),
                    Curriculum = table.Column<bool>(type: "bit", nullable: false),
                    DS = table.Column<bool>(type: "bit", nullable: false),
                    Database = table.Column<bool>(type: "bit", nullable: false),
                    DL = table.Column<bool>(type: "bit", nullable: false),
                    DSS = table.Column<bool>(type: "bit", nullable: false),
                    ESI = table.Column<bool>(type: "bit", nullable: false),
                    FYC = table.Column<bool>(type: "bit", nullable: false),
                    GI = table.Column<bool>(type: "bit", nullable: false),
                    GW = table.Column<bool>(type: "bit", nullable: false),
                    GIP = table.Column<bool>(type: "bit", nullable: false),
                    HCI = table.Column<bool>(type: "bit", nullable: false),
                    LE = table.Column<bool>(type: "bit", nullable: false),
                    Literacy = table.Column<bool>(type: "bit", nullable: false),
                    MIC = table.Column<bool>(type: "bit", nullable: false),
                    Multimedia = table.Column<bool>(type: "bit", nullable: false),
                    NDC = table.Column<bool>(type: "bit", nullable: false),
                    NMC = table.Column<bool>(type: "bit", nullable: false),
                    OOI = table.Column<bool>(type: "bit", nullable: false),
                    OS = table.Column<bool>(type: "bit", nullable: false),
                    PP = table.Column<bool>(type: "bit", nullable: false),
                    Pedagogy = table.Column<bool>(type: "bit", nullable: false),
                    PL = table.Column<bool>(type: "bit", nullable: false),
                    Research = table.Column<bool>(type: "bit", nullable: false),
                    Security = table.Column<bool>(type: "bit", nullable: false),
                    SE = table.Column<bool>(type: "bit", nullable: false),
                    SAAD = table.Column<bool>(type: "bit", nullable: false),
                    UTITC = table.Column<bool>(type: "bit", nullable: false),
                    WAIP = table.Column<bool>(type: "bit", nullable: false),
                    Other = table.Column<bool>(type: "bit", nullable: false),
                    OD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paper", x => x.PaperID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paper");
        }
    }
}
