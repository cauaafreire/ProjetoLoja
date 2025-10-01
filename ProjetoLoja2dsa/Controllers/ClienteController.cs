using Microsoft.AspNetCore.Mvc;

namespace ProjetoLoja2dsa.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
