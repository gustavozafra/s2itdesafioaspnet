using S2IT.Desafio.Application.Interfaces;
using S2IT.Desafio.Application.ViewModels;
using S2IT.Desafio.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S2IT.Desafio.MVC.Controllers
{
    [Authorize]
    public class EmprestimoController : Controller
    {
        private IEmprestimoAppService _emprestimoAppService;
        private IJogoAppService _jogoAppService;
        private IAmigoAppService _amigoAppService;

        public EmprestimoController(IEmprestimoAppService emprestimoAppService, IJogoAppService jogoAppService, IAmigoAppService amigoAppService)
        {
            _emprestimoAppService = emprestimoAppService;
            _jogoAppService = jogoAppService;
            _amigoAppService = amigoAppService;
        }

        // GET: Emprestimo
        public ActionResult Index()
        {
            return View(_emprestimoAppService.ObterLista<EmprestimoViewModel>(var => var.IdUsuario == CookieManager.UsuarioId).OrderBy(var => var.IdStatusEmprestimo));
        }

        public ActionResult Emprestar()
        {
            return View(new EmprestimoUiModel
            {
                Jogos = _jogoAppService.ObterLista<JogoViewModel>(var => var.IdUsuario == CookieManager.UsuarioId && !var.Emprestimos.Any(a => a.IdStatusEmprestimo == 1)),
                Amigos = _amigoAppService.ObterLista<AmigoViewModel>(var => var.IdUsuario == CookieManager.UsuarioId)
            });
        }

        [HttpPost]
        public ActionResult Emprestar(long JogoId, long AmigoId)
        {
            var adicionado = _emprestimoAppService.Adicionar(new EmprestimoViewModel {
                IdJogo = JogoId,
                IdAmigo = AmigoId,
                IdUsuario = CookieManager.UsuarioId,
                DataEmprestimo = DateTime.Now,
                IdStatusEmprestimo = 1
            });

            if(adicionado == null)
                return Json(new { sucesso = false, mensagem = "Erro ao emprestar jogo! Verifique as informações e tente novamente!" });
            else
                return Json(new { sucesso = true, mensagem = "Jogo emprestado com sucesso" });
        }

        [HttpPost]
        public ActionResult Devolver(long EmprestimoId)
        {
            var emprestimo = _emprestimoAppService.Obter<EmprestimoViewModel>(var => var.IdUsuario == CookieManager.UsuarioId
                && var.IdEmprestimo == EmprestimoId);

            if (emprestimo == null)
                return Json(new { sucesso = false, mensagem = "Não encontramos emprestimo." });

            emprestimo.IdStatusEmprestimo = 2;
            emprestimo.DataDevolucao = DateTime.Now;

            var atualizado = _emprestimoAppService.Atualizar(emprestimo);

            if (atualizado == null)
                return Json(new { sucesso = false, mensagem = "Erro ao devolver jogo. Verifique as informações e tente novamente." });
            else
                return Json(new { sucesso = true, mensagem = "Jogo devolvido com sucesso" });
        }

    }
}