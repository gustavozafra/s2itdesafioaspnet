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
    public class AmigoController : Controller
    {
        private IAmigoAppService _amigoAppService;

        public AmigoController(IAmigoAppService amigoAppService)
        {
            _amigoAppService = amigoAppService;
        }

        // GET: Amigo
        public ActionResult Index()
        {
            return View(_amigoAppService.ObterLista<AmigoViewModel>(var => var.IdUsuario == CookieManager.UsuarioId));
        }

        [HttpPost]
        public ActionResult Cadastrar(AmigoViewModel amigo)
        {
            if (amigo == null)
                return Json(new { sucesso = false, mensagem = "Não há informações de amigo" });

            amigo.IdUsuario = CookieManager.UsuarioId;

            var adicionado = _amigoAppService.Adicionar(amigo);

            if (adicionado == null)
                return Json(new { sucesso = false, mensagem = "Erro ao cadastrar amigo! Verifique as informações e tente novamente!" });
            else
                return Json(new { sucesso = true, mensagem = "Amigo cadastrado com sucesso" });
        }
    }
}