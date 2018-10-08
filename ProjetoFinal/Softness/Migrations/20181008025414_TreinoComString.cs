using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class TreinoComString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeTreino",
                table: "Treinos",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeTreino",
                table: "Treinos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
