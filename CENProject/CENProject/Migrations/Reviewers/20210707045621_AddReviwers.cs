using Microsoft.EntityFrameworkCore.Migrations;

namespace CENProject.Migrations.Reviewers
{
    public partial class AddReviwers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviewer",
                columns: table => new
                {
                    ReviewerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleInitial = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Affiliation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
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
                    OD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RA = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviewer", x => x.ReviewerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviewer");
        }
    }
}
