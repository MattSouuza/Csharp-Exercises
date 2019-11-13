using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}