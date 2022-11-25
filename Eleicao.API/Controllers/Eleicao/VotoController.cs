using Microsoft.AspNetCore.Mvc;

namespace Eleicao.API.Controllers.Eleicao
{
    public class VotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
