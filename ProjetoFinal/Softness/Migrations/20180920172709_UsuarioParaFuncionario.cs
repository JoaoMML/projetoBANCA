using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class UsuarioParaFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pessoas_PessoaId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Funcionarios");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_PessoaId",
                table: "Funcionarios",
                newName: "IX_Funcionarios_PessoaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Pessoas_PessoaId",
                table: "Funcionarios",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Pessoas_PessoaId",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "Usuarios");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_PessoaId",
                table: "Usuarios",
                newName: "IX_Usuarios_PessoaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pessoas_PessoaId",
                table: "Usuarios",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
