﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolvoPesados.Database;

namespace VolvoPesados.Migrations
{
    [DbContext(typeof(VolvoPesadosContext))]
    [Migration("20210527033217_BancoInicial")]
    partial class BancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Inicial")
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
                            AnoModelo = "2021",
                            Cor = "Branco",
                            Eixo = 3,
                            Inicial = "FH",
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
                            Inicial = "FH",
                            Modelo = "460",
                            Transmissao = "Manual"
                        },
                        new
                        {
                            Id = 3,
                            AnoFabricacao = "2021",
                            AnoModelo = "2021",
                            Cor = "Prata",
                            Eixo = 3,
                            Inicial = "FH",
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
                            Inicial = "FM",
                            Modelo = "370",
                            Transmissao = "Manual"
                        },
                        new
                        {
                            Id = 5,
                            AnoFabricacao = "2021",
                            AnoModelo = "2021",
                            Cor = "Vermelho",
                            Eixo = 2,
                            Inicial = "FM",
                            Modelo = "380",
                            Transmissao = "Automatico"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}