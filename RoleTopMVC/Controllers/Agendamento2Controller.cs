using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class Agendamento2Controller :Controller
    {
        public IActionResult Agendar2()
        {
            ViewData["NomeView"] = "Agendamento2";
            return View();
        }

        // public IActionResult Agendamento2(IFormCollection form)
        // {

        // }
    }
}