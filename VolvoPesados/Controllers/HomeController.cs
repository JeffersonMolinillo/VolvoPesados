using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VolvoPesados.Libraries.Lang;
using VolvoPesados.Models;
using VolvoPesados.Repository.Contracts;

namespace VolvoPesados.Controllers
{
    public class HomeController : Controller
    {
        public ICaminhaoRepository _repository { get; }

        public HomeController(ICaminhaoRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var caminhao = _repository.ObterTodosCaminhoes();
            return View(caminhao);
        }

        [HttpGet]
        public IActionResult CadastrarCaminhao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarCaminhao(Caminhao caminhao)
        {
            if (ModelState.IsValid)
            {
                _repository.Cadastrar(caminhao);
                TempData["MENSSAGEM_DE_SUCESSO"] = Mensagem.MSG_REGISTRO_SALVO_COM_SUCESSO;
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(CadastrarCaminhao));
        }

        [HttpGet]
        public IActionResult EditarCaminhao(int id)
        {            
            return View(_repository.ObterCaminhaoPorId(id));
        }

        [HttpPost]
        public IActionResult EditarCaminhao(Caminhao caminhao, int id)
        {
            if(ModelState.IsValid)
            {
                _repository.Atualizar(caminhao);
                TempData["MSG_REGISTRO_ATUALIZADO_COM_SUCESSO"] = Mensagem.MSG_REGISTRO_ATUALIZADO_COM_SUCESSO;
                return RedirectToAction(nameof(EditarCaminhao));
            }
            return View(caminhao);
        }
        [HttpGet]
        public IActionResult ExcluirCaminhao(int id)
        {
            if(id != 0)
            {
                Caminhao caminhao = _repository.ObterCaminhaoPorId(id);
                _repository.Excluir(caminhao);
                TempData["MSG_REGISTRO_DELETADO_COM_SUCESSO"] = Mensagem.MSG_REGISTRO_DELETADO_COM_SUCESSO; //retorna mensagem de exclusão.
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
