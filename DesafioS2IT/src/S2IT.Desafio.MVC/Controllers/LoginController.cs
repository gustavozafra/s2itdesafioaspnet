using S2IT.Desafio.Application.Interfaces;
using S2IT.Desafio.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace S2IT.Desafio.MVC.Controllers
{
    public class LoginController : Controller
    {
        private IUsuarioAppService _usuarioAppService;

        public LoginController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpPost]
        public ActionResult Cadastrar(UsuarioViewModel usuario)
        {
            if (usuario == null)
                return Json(new { sucesso = false, mensagem = "Não há informações de usuário" });

            usuario.Senha = Util.Encoder.MD5(usuario.Senha);

            var adicionado = _usuarioAppService.Adicionar(usuario);

            if(adicionado == null)
                return Json(new { sucesso = false, mensagem = "Erro ao cadastrar usuario! Verifique as informações e tente novamente!" });
            else
                return Json(new { sucesso = true, mensagem = "Usuario cadastrado com sucesso" });
        }

        // GET: Login
        public ActionResult Index(string ReturnUrl = null)
        {
            ViewBag.ReturnUrl = ReturnUrl;

            if (User.Identity.IsAuthenticated)
                return RedirectToActionPermanent("Index", "Home");

            return View();
        }

        [HttpPost]
        public ActionResult Login(string Usuario, string Senha, string ReturnUrl = null)
        {
            string encodeSenha = Util.Encoder.MD5(Senha);
            var usuario = _usuarioAppService.Obter<UsuarioViewModel>(var => var.Login == Usuario && var.Senha == encodeSenha);

            if(usuario != null)
            {
                //
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                1, // versão Ticket
                usuario.Login, // Username
                DateTime.Now, // Criado em
                DateTime.Now.AddMinutes(60), // Expira em
                true, // persistir
                "*", // roles
                FormsAuthentication.FormsCookiePath);

                string hashCookies = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashCookies);

                //
                Response.Cookies.Add(cookie);

                CookieManager.UsuarioId = usuario.IdUsuario;

                if (String.IsNullOrEmpty(ReturnUrl))
                    ReturnUrl = "~/Home/Index";

                return Json(new { sucesso = true, mensagem = "Login realizado com sucesso.", returnUrl = ReturnUrl });
            }

            return Json(new { sucesso = false, mensagem = "Usuario não encontrado.", returnUrl = ReturnUrl });
        }

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}