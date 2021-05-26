﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolvoPesados.Database;

namespace VolvoPesados.Migrations
{
    [DbContext(typeof(VolvoPesadosContext))]
    partial class VolvoPesadosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VolvoPesados.Models.Caminhao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoFabricacao")
                        .IsRequired();

                    b.Property<string>("AnoModelo")
                        .IsRequired();

                    b.Property<string>("Cor")
                        .IsRequired();

                    b.Property<int>("Eixo");

                    b.Property<string>("Iniciais")
                        .IsRequired();

                    b.Property<string>("Modelo")
                        .IsRequired();

                    b.Property<string>("Transmissao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Caminhoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnoFabricacao = "2021",
                            AnoModelo = "2022",
                            Cor = "Branco",
                            Eixo = 3,
                            Iniciais = "FH",
                            Modelo = "540",
                            Transmissao = "Automatico"
                        },
                        new
                        {
                            Id = 2,
                            AnoFabricacao = "2021",
                            AnoModelo = "2022",
                            Cor = "Amarelo",
                            Eixo = 2,
                            Iniciais = "FH",
                            Modelo = "460",
                            Transmissao = "Automatico"
                        },
                        new
                        {
                            Id = 3,
                            AnoFabricacao = "2021",
                            AnoModelo = "2022",
                            Cor = "Prata",
                            Eixo = 3,
                            Iniciais = "FH",
                            Modelo = "520",
                            Transmissao = "Automatico"
                        },
                        new
                        {
                            Id = 4,
                            AnoFabricacao = "2021",
                            AnoModelo = "2022",
                            Cor = "Preto",
                            Eixo = 4,
                            Iniciais = "FM",
                            Modelo = "370",
                            Transmissao = "Automatico"
                        },
                        new
                        {
                            Id = 5,
                            AnoFabricacao = "2021",
                            AnoModelo = "2022",
                            Cor = "Vermelho",
                            Eixo = 2,
                            Iniciais = "FM",
                            Modelo = "380",
                            Transmissao = "Automatico"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}