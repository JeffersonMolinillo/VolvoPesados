using PagedList;
using System.Collections.Generic;
using VolvoPesados.Models;


namespace VolvoPesados.Repository.Contracts
{
    public interface ICaminhaoRepository
    {
        void Atualizar(Caminhao caminhao);
        
        void Cadastrar(Caminhao caminhoes);

        void Excluir(Caminhao caminhao);
    
        List<Caminhao> ObterTodosCaminhoes();

        Caminhao ObterCaminhaoPorId(int id);


    }
}
