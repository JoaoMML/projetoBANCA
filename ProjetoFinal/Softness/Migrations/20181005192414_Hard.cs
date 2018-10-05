using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class Hard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExercicioTreinos");

            migrationBuilder.DropTable(
                name: "TreinoClientes");

            migrationBuilder.AddColumn<string>(
                name: "Carga",
                table: "Exercicios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Intervalo",
                table: "Exercicios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Repeticoes",
                table: "Exercicios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Exercicios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TreinoId",
                table: "Exercicios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercicios_TreinoId",
                table: "Exercicios",
                column: "TreinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercicios_Treinos_TreinoId",
                table: "Exercicios",
                column: "TreinoId",
                principalTable: "Treinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercicios_Treinos_TreinoId",
                table: "Exercicios");

            migrationBuilder.DropIndex(
                name: "IX_Exercicios_TreinoId",
                table: "Exercicios");

            migrationBuilder.DropColumn(
                name: "Carga",
                table: "Exercicios");

            migrationBuilder.DropColumn(
                name: "Intervalo",
                table: "Exercicios");

            migrationBuilder.DropColumn(
                name: "Repeticoes",
                table: "Exercicios");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "Exercicios");

            migrationBuilder.DropColumn(
                name: "TreinoId",
                table: "Exercicios");

            migrationBuilder.CreateTable(
                name: "ExercicioTreinos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Carga = table.Column<string>(nullable: true),
                    ExercicioId = table.Column<int>(nullable: false),
                    Intervalo = table.Column<string>(nullable: true),
                    Repeticoes = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: true),
                    TreinoId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "TreinoClientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    TipoTreino = table.Column<string>(nullable: false),
                    TreinoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreinoClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreinoClientes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoClientes_Treinos_TreinoId",
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

            migrationBuilder.CreateIndex(
                name: "IX_TreinoClientes_ClienteId",
                table: "TreinoClientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoClientes_TreinoId",
                table: "TreinoClientes",
                column: "TreinoId");
        }
    }
}
