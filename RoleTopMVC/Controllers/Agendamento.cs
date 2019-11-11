using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class Agendamento : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}