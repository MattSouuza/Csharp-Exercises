using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class Agendamento2Controller : AbstractController
    {
        public IActionResult Agendar2()
        {
            ViewData["NomeView"] = "Agendamento2";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        // public IActionResult Agendamento2(IFormCollection form)
        // {

        // }
    }
}