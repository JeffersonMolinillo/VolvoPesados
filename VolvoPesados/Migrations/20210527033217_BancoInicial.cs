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
                    Inicial = table.Column<string>(nullable: false),
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
                columns: new[] { "Id", "AnoFabricacao", "AnoModelo", "Cor", "Eixo", "Inicial", "Modelo", "Transmissao" },
                values: new object[,]
                {
                    { 1, "2021", "2021", "Branco", 3, "FH", "540", "Automatico" },
                    { 2, "2021", "2022", "Amarelo", 2, "FH", "460", "Manual" },
                    { 3, "2021", "2021", "Prata", 3, "FH", "520", "Automatico" },
                    { 4, "2021", "2022", "Preto", 4, "FM", "370", "Manual" },
                    { 5, "2021", "2021", "Vermelho", 2, "FM", "380", "Automatico" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhoes");
        }
    }
}
