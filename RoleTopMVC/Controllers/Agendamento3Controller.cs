using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class Agendamento3Controller : AbstractController
    {
        public IActionResult Agendar3()
        {
            ViewData["NomeView"] = "Agendamento3";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}