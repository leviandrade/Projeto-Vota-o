using Microsoft.AspNetCore.Mvc;

namespace Eleicao.API.Controllers.Eleicao
{
    public class EleicaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
