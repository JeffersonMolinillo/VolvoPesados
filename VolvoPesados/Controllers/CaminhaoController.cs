using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VolvoPesados.Models;
using VolvoPesados.Repository.Contracts;


namespace VolvoPesados.Controllers
{
    public class CaminhaoController : Controller
    {
        private ICaminhaoRepository _caminhaoRepository { get; }

        public CaminhaoController(ICaminhaoRepository caminhaoRepository)
        {
            _caminhaoRepository = caminhaoRepository;
        }



        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetTodosCaminhoes()
        {
            var caminhoes = _caminhaoRepository.ObterTodosCaminhoes();
            return View(caminhoes);
        }

        private List<Caminhao> GetCaminhoes()
        {
            return null;
        }
    }
}
