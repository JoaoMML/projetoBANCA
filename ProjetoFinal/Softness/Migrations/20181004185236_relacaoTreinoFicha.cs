using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class relacaoTreinoFicha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TreinoId",
                table: "FichaTreinos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FichaTreinos_TreinoId",
                table: "FichaTreinos",
                column: "TreinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_FichaTreinos_Treinos_TreinoId",
                table: "FichaTreinos",
                column: "TreinoId",
                principalTable: "Treinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichaTreinos_Treinos_TreinoId",
                table: "FichaTreinos");

            migrationBuilder.DropIndex(
                name: "IX_FichaTreinos_TreinoId",
                table: "FichaTreinos");

            migrationBuilder.DropColumn(
                name: "TreinoId",
                table: "FichaTreinos");
        }
    }
}
