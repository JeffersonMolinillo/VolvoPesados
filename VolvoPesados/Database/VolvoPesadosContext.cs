using Microsoft.EntityFrameworkCore;
using VolvoPesados.Models;

namespace VolvoPesados.Database
{
    public class VolvoPesadosContext : DbContext
    {
        public VolvoPesadosContext(DbContextOptions<VolvoPesadosContext> options) : base(options)
        {

        }

        public DbSet<Caminhao> Caminhoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            =>
            modelBuilder.Entity<Caminhao>()
            .HasData(
                       new Caminhao {Id = 1, Inicial = "FH",Modelo = "540", Cor = "Branco",  Eixo = 3, AnoFabricacao = "2021", AnoModelo = "2021",Transmissao ="Automatico"},
                       new Caminhao {Id = 2, Inicial = "FH",Modelo = "460", Cor = "Amarelo", Eixo = 2, AnoFabricacao = "2021", AnoModelo = "2022",Transmissao ="Manual"},  
                       new Caminhao {Id = 3, Inicial = "FH",Modelo = "520", Cor = "Prata", Eixo = 3, AnoFabricacao = "2021", AnoModelo = "2021",Transmissao ="Automatico"},
                       new Caminhao {Id = 4, Inicial = "FM",Modelo = "370", Cor = "Preto", Eixo = 4, AnoFabricacao = "2021", AnoModelo = "2022",Transmissao ="Manual"},
                       new Caminhao {Id = 5, Inicial = "FM",Modelo = "380", Cor = "Vermelho", Eixo = 2, AnoFabricacao = "2021", AnoModelo = "2021",Transmissao ="Automatico"}
                    );

    }
}
