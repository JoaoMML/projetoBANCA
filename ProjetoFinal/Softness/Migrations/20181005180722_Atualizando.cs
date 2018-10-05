using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class Atualizando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carga",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "Exercicios",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "Intervalo",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "Observacoes",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "Repeticoes",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "Treinos");

            migrationBuilder.AddColumn<string>(
                name: "NomeTreino",
                table: "Treinos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExercicioNome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExercicioTreinos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExercicioId = table.Column<int>(nullable: false),
                    TreinoId = table.Column<int>(nullable: false),
                    Series = table.Column<string>(nullable: true),
                    Repeticoes = table.Column<string>(nullable: true),
                    Carga = table.Column<string>(nullable: true),
                    Intervalo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercicioTreinos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExercicioTreinos_Exercicios_ExercicioId",
                        column: x => x.ExercicioId,
                        principalTable: "Exercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExercicioTreinos_Treinos_TreinoId",
                        column: x => x.TreinoId,
                        principalTable: "Treinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExercicioTreinos_ExercicioId",
                table: "ExercicioTreinos",
                column: "ExercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_ExercicioTreinos_TreinoId",
                table: "ExercicioTreinos",
                column: "TreinoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExercicioTreinos");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropColumn(
                name: "NomeTreino",
                table: "Treinos");

            migrationBuilder.AddColumn<string>(
                name: "Carga",
                table: "Treinos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exercicios",
                table: "Treinos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Intervalo",
                table: "Treinos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacoes",
                table: "Treinos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Repeticoes",
                table: "Treinos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Treinos",
                nullable: true);
        }
    }
}
