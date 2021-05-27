using NSubstitute;
using VolvoPesados.Models;
using VolvoPesados.Repository.Contracts;
using Xunit;

namespace VolvoPesadosTestXUnit
{
    public class Test
    {

        private ICaminhaoRepository mock;

        [Fact]
        public void CadastrarCaminhao()
        {
            Caminhao caminhao = new Caminhao {Id = 1, Inicial = "FM", Modelo = "300",Cor = "Verde", Eixo = 2, AnoFabricacao = "2019", AnoModelo = "2019", Transmissao = "Manual" };

            mock = Substitute.For<ICaminhaoRepository>();
            mock.Cadastrar(caminhao);

        }

        [Fact]
        public void EditarCaminhao()
        {
            Caminhao caminhao = new Caminhao { Id = 2, Inicial = "FH", Modelo = "300", Cor = "Verde", Eixo = 2, AnoFabricacao = "2019", AnoModelo = "2019", Transmissao = "Manual" };

            mock = Substitute.For<ICaminhaoRepository>();

            mock.Atualizar(caminhao);

        }

        [Fact]
        public void ExcluirCaminhao()
        {
            Caminhao caminhao = new Caminhao { Id = 3, Inicial = "FH", Modelo = "300", Cor = "Verde", Eixo = 2, AnoFabricacao = "2019", AnoModelo = "2019", Transmissao = "Manual" };

            mock = Substitute.For<ICaminhaoRepository>();

            mock.Excluir(caminhao);

        }
    }
}

