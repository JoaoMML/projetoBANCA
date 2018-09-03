using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class PessoaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pessoas_PessoaId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pessoas_PessoaId",
                table: "Usuarios",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pessoas_PessoaId",
                table: "Usuarios");

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
