using Microsoft.EntityFrameworkCore.Migrations;

namespace Lucky_MiguelAngelQuiroz.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lucky_MiguelAngelQuiroz",
                columns: table => new
                {
                    SuerteId = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    URL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lucky_MiguelAngelQuiroz", x => x.SuerteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lucky_MiguelAngelQuiroz");
        }
    }
}
