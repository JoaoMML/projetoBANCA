using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Softness.Migrations
{
    public partial class TreinoCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TreinoClientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TreinoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    TipoTreino = table.Column<string>(nullable: false)
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
                name: "IX_TreinoClientes_ClienteId",
                table: "TreinoClientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoClientes_TreinoId",
                table: "TreinoClientes",
                column: "TreinoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TreinoClientes");
        }
    }
}
