using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VolvoPesados.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caminhoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Iniciais = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    Cor = table.Column<string>(nullable: false),
                    Eixo = table.Column<int>(nullable: false),
                    AnoFabricacao = table.Column<string>(nullable: false),
                    AnoModelo = table.Column<string>(nullable: false),
                    Transmissao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhoes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Caminhoes",
                columns: new[] { "Id", "AnoFabricacao", "AnoModelo", "Cor", "Eixo", "Iniciais", "Modelo", "Transmissao" },
                values: new object[] { 1, "2021", "2022", "Amarelo", 2, "FM", "500", "Automatico" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhoes");
        }
    }
}
