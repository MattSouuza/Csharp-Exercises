using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class Agendamento2Controller : AbstractController
    {
        Agendamento2Repository agendamento2Repository = new Agendamento2Repository();
        public IActionResult Agendar2()
        {
            ViewData["NomeView"] = "Agendamento2";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult AgendamentoProcesso2(IFormCollection form)
        {
            ViewData["TextoView"] = "Agendamento";
            try
            {
                Evento agendamento2 = new Evento(form["nName"],form["nType"],form["nStatus"],form["nPlan"],form["nNumber"],DateTime.Parse(form["nDate"]),form["nTimeS"],form["nTimeE"],form["nMessage"]); // Adicionar o form para o valor total
                agendamento2Repository.Inserir(agendamento2);

                return RedirectToAction("Agendar3", "Agendamento3");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                ViewData["NomeView"] = "SucessoErro";

                return View("Erro", new RespostaViewModel());
            }
        }
    }
}
