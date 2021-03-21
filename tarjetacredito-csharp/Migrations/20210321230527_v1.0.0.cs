using Microsoft.EntityFrameworkCore.Migrations;

namespace tarjetacredito_csharp.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberCardCredit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthExpiration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearExpiration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCard");
        }
    }
}
