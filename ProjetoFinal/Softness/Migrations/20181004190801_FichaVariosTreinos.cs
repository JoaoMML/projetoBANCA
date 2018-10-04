using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class FichaVariosTreinos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "FichaTreinoId",
                table: "Treinos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_FichaTreinoId",
                table: "Treinos",
                column: "FichaTreinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treinos_FichaTreinos_FichaTreinoId",
                table: "Treinos",
                column: "FichaTreinoId",
                principalTable: "FichaTreinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treinos_FichaTreinos_FichaTreinoId",
                table: "Treinos");

            migrationBuilder.DropIndex(
                name: "IX_Treinos_FichaTreinoId",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "FichaTreinoId",
                table: "Treinos");

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
    }
}
