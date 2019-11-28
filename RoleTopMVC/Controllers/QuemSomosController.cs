using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class QuemSomosController : Controller
    {
        public IActionResult quemSomos()
        {
            ViewData["NomeView"] = "QuemSomos";
            return View();
        }
    }
}