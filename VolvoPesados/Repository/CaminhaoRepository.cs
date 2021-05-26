using Microsoft.Extensions.Configuration;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using VolvoPesados.Database;
using VolvoPesados.Models;
using VolvoPesados.Repository.Contracts;

namespace VolvoPesados.Repository
{
    public class CaminhaoRepository : ICaminhaoRepository
    {
        private readonly VolvoPesadosContext _context;
        private readonly IConfiguration _configuration;


        public CaminhaoRepository(VolvoPesadosContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public void Cadastrar(Caminhao caminhoes)
        {
            _context.Add(caminhoes);
            _context.SaveChanges();
        }

        public Caminhao ObterCaminhao(int id)
        {
            throw new System.NotImplementedException();
        }

        public Caminhao ObterCaminhaoPorId(int id)
        {
            return _context.Caminhoes.Find(id);
        }

        public List<Caminhao> ObterTodosCaminhoes()
        {
            var listaCaminhoes = _context.Caminhoes.ToList();

            return listaCaminhoes;
        }

        public void Atualizar(Caminhao caminhao)
        {
            _context.Update(caminhao);
            _context.SaveChanges();
        }

        public void Excluir(Caminhao caminhao)
        {
            _context.Remove(caminhao);
            _context.SaveChanges();
        }

      
    }
}
