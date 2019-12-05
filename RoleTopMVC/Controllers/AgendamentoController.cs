//*Fazer um AgendamentoController ÚNICO*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AgendamentoController : AbstractController
    {
        Evento agendamentoGeral = new Evento();
        AgendamentoViewModel avm = new AgendamentoViewModel();
        ClienteRepository clienteRepository = new ClienteRepository();
        Agendamento1Repository agendamento1Repository = new Agendamento1Repository();
        Agendamento2Repository agendamento2Repository = new Agendamento2Repository();

        public IActionResult Agendar()
        {
            var usuarioLogado = ObterUsuarioEmailSession(); //*esta variavel é o email do usuario*/
            var nomeUsuarioLogado = ObterUsuarioNomeSession(); //*esta variavel é o nome do usuario*/

            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.Cliente = clienteRepository.ObterPor(usuarioLogado); //*Insere as informações (por meio do ObterPor) que o usuário expecificou, no avm.Cliente*/
            }
            else
            {
                avm.Cliente = new Cliente();
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado); //*clienteLogado contem as informações do usuario*/
            if(clienteLogado != null)
            {
                avm.Cliente = clienteLogado;
            }

            var emailCliente = ObterUsuarioEmailSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                avm.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            avm.UsuarioEmail = ObterUsuarioEmailSession();
            avm.UsuarioNome = ObterUsuarioNomeSession();
            
            ViewData["NomeView"] = "Agendamento";
            return View(avm);
        }

        [HttpPost]
        public IActionResult AgendamentoProcesso1(IFormCollection form)
        {
            ViewData["TextoView"] = "Agendamento";
            avm.Cliente = agendamentoGeral.Cliente;

            // var nomeUsuarioLogado = ObterUsuarioNomeSession();
            // if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            // {
            // }

            try
            {
                Evento agendamento1 = new Evento(form["nName"],form["nCpf"],form["nEmail"],form["nPhone"]);
                agendamento1 = agendamentoGeral;
                // agendamento1Repository.Inserir(agendamento)
                avm.UsuarioEmail = ObterUsuarioEmailSession();
                avm.UsuarioNome = ObterUsuarioNomeSession();
                return RedirectToAction("Agendar2");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                ViewData["NomeView"] = "SucessoErro";
                return View("Erro", new RespostaViewModel());
            }
        }

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
                // agendamento2Repository.Inserir(agendamento2);

                avm.UsuarioEmail = ObterUsuarioEmailSession();
                avm.UsuarioNome = ObterUsuarioNomeSession();
                return RedirectToAction("Agendar3");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                ViewData["NomeView"] = "SucessoErro";

                return View("Erro", new RespostaViewModel("Não foi possível realizar o agendamento corretamente"));
            }
        }

        public IActionResult Agendar3()
        {
            ViewData["NomeView"] = "Agendamento3";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult AgendamentoProcesso3(IFormCollection form)
        {
            ViewData["TextoView"] = "Agendamento";
            try
            {
                Evento agendamento3 = new Evento(form["name"],form["number"],form["code"],form["cpf"],DateTime.Parse(form["date"]));
                agendamento3 = agendamentoGeral;

                avm.UsuarioEmail = ObterUsuarioEmailSession();
                avm.UsuarioNome = ObterUsuarioNomeSession();
                return View("Sucesso", new RespostaViewModel());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Não foi possível realizar o agendamento corretamente"));
            }
        }
    }
}