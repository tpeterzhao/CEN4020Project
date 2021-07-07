using Microsoft.EntityFrameworkCore.Migrations;

namespace CENProject.Migrations.Reviews
{
    public partial class AddReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaperID = table.Column<int>(type: "int", nullable: false),
                    ReviewerID = table.Column<int>(type: "int", nullable: false),
                    AOT = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    ToT = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    SE = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    TQ = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    SoC = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    CoPW = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    Originality = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    CC = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    OoP = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    CoMM = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    Mechanics = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    WDC = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    SfP = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    PIiT = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    PfOPC = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    OR = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    ORC = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    CLT = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    CLA = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    Complete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
