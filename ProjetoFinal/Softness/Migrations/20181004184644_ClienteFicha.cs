using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class ClienteFicha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "FichaTreinos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FichaTreinos_ClienteId",
                table: "FichaTreinos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_FichaTreinos_Clientes_ClienteId",
                table: "FichaTreinos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichaTreinos_Clientes_ClienteId",
                table: "FichaTreinos");

            migrationBuilder.DropIndex(
                name: "IX_FichaTreinos_ClienteId",
                table: "FichaTreinos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "FichaTreinos");
        }
    }
}
