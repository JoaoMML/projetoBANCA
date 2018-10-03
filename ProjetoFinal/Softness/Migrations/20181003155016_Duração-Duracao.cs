using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class DuraçãoDuracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoDuração",
                table: "FichaTreinos",
                newName: "TipoDuracao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoDuracao",
                table: "FichaTreinos",
                newName: "TipoDuração");
        }
    }
}
