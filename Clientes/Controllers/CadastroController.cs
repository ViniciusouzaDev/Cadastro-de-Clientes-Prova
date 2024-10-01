using Clientes.Context;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Appcont _appCont;

        public CadastroController(Appcont appCont)
        {
            _appCont = appCont;
        }
        public IActionResult Index()
        {
            var alltasks = _appCont.Clientes.ToList();
            return View(alltasks);
        }
    }
}

