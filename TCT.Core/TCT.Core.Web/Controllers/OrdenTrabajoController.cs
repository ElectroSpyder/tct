using Microsoft.AspNetCore.Mvc;
using TCT.Core.Modelo.ViewModels;
//https://bbbootstrap.com/snippets/request-demo-form-validation-12274818
namespace TCT.Core.Web.Controllers
{
    public class OrdenTrabajoController : Controller
    {
        public IActionResult Index()
        {
            var model = new OrdenTrabajoViewModel();
            return View(model);
        }

        public IActionResult AltaOT()
        {
            return View(new OrdenTrabajoViewModel());
        }
    }
}
