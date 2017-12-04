using S2IT.Desafio.Application.Interfaces;
using S2IT.Desafio.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S2IT.Desafio.MVC.Controllers
{
    [Authorize]
    public class JogoController : Controller
    {
        private IJogoAppService _jogoAppService;

        public JogoController(IJogoAppService jogoAppService)
        {
            _jogoAppService = jogoAppService;
        }

        // GET: Jogo
        public ActionResult Index()
        {
            return View(_jogoAppService.ObterLista<JogoViewModel>(var => var.IdUsuario == CookieManager.UsuarioId));
        }

        [HttpPost]
        public ActionResult Cadastrar(JogoViewModel jogo)
        {
            if (jogo == null)
                return Json(new { sucesso = false, mensagem = "Não há informações de jogo" });

            jogo.IdUsuario = CookieManager.UsuarioId;

            var adicionado = _jogoAppService.Adicionar(jogo);

            if (adicionado == null)
                return Json(new { sucesso = false, mensagem = "Erro ao cadastrar jogo! Verifique as informações e tente novamente!" });
            else
                return Json(new { sucesso = true, mensagem = "Jogo cadastrado com sucesso" });
        }

        
    }
}