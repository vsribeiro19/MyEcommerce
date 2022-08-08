using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
