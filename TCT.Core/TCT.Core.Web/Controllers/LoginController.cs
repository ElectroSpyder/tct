namespace TCT.Core.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TCT.Core.Modelo.ViewModels;

    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            var model = new UsuarioViewModel();
            return View("Login", model);
        }

        [HttpPost]
        public IActionResult GetLogin(UsuarioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                if (model.NombreUsuario!= null && model.Contraseña != null)
                {

                }
                return View();
            }

            return View();
        }
    }
}
