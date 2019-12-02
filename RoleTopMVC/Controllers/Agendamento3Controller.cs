using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class Agendamento3Controller : Controller
    {
        public IActionResult Agendar3()
        {
            ViewData["NomeView"] = "Agendamento3";
            return View();
        }
    }
}