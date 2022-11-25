using Microsoft.AspNetCore.Mvc;

namespace Eleicao.API.Controllers.Acesso
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
