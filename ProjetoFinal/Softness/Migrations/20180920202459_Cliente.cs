using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class Cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Pessoas_PessoaId",
                table: "Funcionarios");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Funcionarios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Pessoas_PessoaId",
                table: "Funcionarios",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Pessoas_PessoaId",
                table: "Funcionarios");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Funcionarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Pessoas_PessoaId",
                table: "Funcionarios",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
