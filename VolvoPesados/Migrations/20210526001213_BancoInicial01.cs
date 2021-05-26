using Microsoft.EntityFrameworkCore.Migrations;

namespace VolvoPesados.Migrations
{
    public partial class BancoInicial01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Caminhoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cor", "Eixo", "Iniciais", "Modelo" },
                values: new object[] { "Branco", 3, "FH", "540" });

            migrationBuilder.InsertData(
                table: "Caminhoes",
                columns: new[] { "Id", "AnoFabricacao", "AnoModelo", "Cor", "Eixo", "Iniciais", "Modelo", "Transmissao" },
                values: new object[,]
                {
                    { 2, "2021", "2022", "Amarelo", 2, "FH", "460", "Automatico" },
                    { 3, "2021", "2022", "Prata", 3, "FH", "520", "Automatico" },
                    { 4, "2021", "2022", "Preto", 4, "FM", "370", "Automatico" },
                    { 5, "2021", "2022", "Vermelho", 2, "FM", "380", "Automatico" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Caminhoes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Caminhoes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Caminhoes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Caminhoes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Caminhoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cor", "Eixo", "Iniciais", "Modelo" },
                values: new object[] { "Amarelo", 2, "FM", "500" });
        }
    }
}
