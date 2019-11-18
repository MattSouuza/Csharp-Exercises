using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;

namespace RoleTopMVC.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Agendar()
        {
            ViewData["NomeView"] = "Agendamento";
            return View();
        }
    }
}