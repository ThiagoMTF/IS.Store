using IS.Store.Domain.Contracts.Repositories;
using IS.Store.Domain.Helpers;
using IS.Store.UI.ViewModels.Conta.Login;
using System.Web.Mvc;
using System.Web.Security;

namespace IS.Store.UI.Controllers
{
    public class ContaController:Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public ContaController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public ActionResult Login(string ReturnUrl)
        {
            var model = new LoginVM { ReturnUrl = ReturnUrl };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var usuario = _usuarioRepository.Get(model.Email);
            if(usuario == null)
            {
                ModelState.AddModelError("Email", "O e-mail não foi localizado.");
            } else
            {
                if (usuario.Senha != model.Senha.Encrypt())
                {
                    ModelState.AddModelError("Senha", "Senha incorreta.");
                }
            }


            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);
                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        protected override void Dispose(bool disposing)
        {}
    }
}