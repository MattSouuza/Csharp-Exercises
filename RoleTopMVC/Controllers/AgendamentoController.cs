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
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Agendar()
        {
            var usuarioLogado = ObterUsuarioEmailSession(); //*esta variavel é o email do usuario*/
            var nomeUsuarioLogado = ObterUsuarioNomeSession(); //*esta variavel é o nome do usuario*/

            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.Cliente = clienteRepository.ObterPor(usuarioLogado); //*Insere as informações (por meio do ObterPor) no avm.Cliente que foram expecificadas pelo usuário*/
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

        public IActionResult AgendamentoProcesso1(IFormCollection form)
        {
            ViewData["TextoView"] = "Agendamento";
            avm.Cliente = agendamentoGeral.Cliente;
            Cliente cliente = new Cliente();

            // var nomeUsuarioLogado = ObterUsuarioNomeSession();
            // if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            // {
            // }

            try
            {
                cliente.Nome = form["nName"];
                cliente.Cpf = form["nCpf"];
                cliente.Email = form["nEmail"];
                cliente.Telefone = form["nPhone"];

                var linha = clienteRepository.FazerRegistroCSV(cliente);

                HttpContext.Session.SetString("cliente", linha);
                
                // agendamento1Repository.Inserir(agendamento)
                avm.UsuarioEmail = ObterUsuarioEmailSession();
                avm.UsuarioNome = ObterUsuarioNomeSession();
                return RedirectToAction("Agendar2",cliente);
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
                //Evento agendamento2 = new Evento(form["nName"],form["nType"],form["nStatus"],form["nPlan"],form["nNumber"],DateTime.Parse(form["nDate"]),form["nTimeS"],form["nTimeE"],form["nMessage"]); // Adicionar o form para o valor total
                Evento evento = new Evento();
                Cliente cliente = new Cliente();

                var linha = HttpContext.Session.GetString("cliente");
                cliente.Nome = clienteRepository.ExtrairValorDoCampo("nome", linha);
                cliente.Cpf = clienteRepository.ExtrairValorDoCampo("cpf", linha);
                cliente.Email = clienteRepository.ExtrairValorDoCampo("email", linha);
                cliente.Telefone = clienteRepository.ExtrairValorDoCampo("telefone", linha);

                evento.Cliente = cliente;

                evento.NomeEvento = form["nName"];
                evento.TipoEvento = form ["nType"];
                evento.StatusEvento = form["nStatus"];
                evento.Planos = form["nPlan"];
                evento.NumeroPessoas = form["nNumber"];
                evento.DataEvento = DateTime.Parse(form["nDate"]);
                evento.HoraInicio = form["nTimeS"];
                evento.HoraTermino = form["nTimeE"];
                evento.Descricao = form["nMessage"];

                linha = agendamentoRepository.FazerRegistroCSV(evento);
                
                HttpContext.Session.SetString("evento", linha);
                // agendamento2Repository.Inserir(agendamento2)
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
            ViewData["NomeView"] = "SucessoErro";
            Evento eventoPagamento = new Evento();
            eventoPagamento.Cliente = new Cliente(); 

            var linha = HttpContext.Session.GetString("evento");
            System.Console.WriteLine(linha);
            eventoPagamento.Cliente.Nome = clienteRepository.ExtrairValorDoCampo("nome", linha);
            eventoPagamento.Cliente.Cpf = clienteRepository.ExtrairValorDoCampo("cpf", linha);
            eventoPagamento.Cliente.Email = clienteRepository.ExtrairValorDoCampo("email", linha);
            eventoPagamento.Cliente.Telefone = clienteRepository.ExtrairValorDoCampo("telefone", linha);
            eventoPagamento.NomeEvento = agendamentoRepository.ExtrairValorDoCampo("evento_nome", linha);
            eventoPagamento.TipoEvento = agendamentoRepository.ExtrairValorDoCampo("evento_tipo", linha);
            eventoPagamento.StatusEvento = agendamentoRepository.ExtrairValorDoCampo("evento_status", linha);
            eventoPagamento.Planos = agendamentoRepository.ExtrairValorDoCampo("planos", linha);
            eventoPagamento.NumeroPessoas = agendamentoRepository.ExtrairValorDoCampo("numero_pessoas", linha);
            eventoPagamento.DataEvento = DateTime.Parse(agendamentoRepository.ExtrairValorDoCampo("data_evento", linha));
            eventoPagamento.HoraInicio = agendamentoRepository.ExtrairValorDoCampo("hora_inicio", linha);
            eventoPagamento.HoraTermino = agendamentoRepository.ExtrairValorDoCampo("hora_termino", linha);
            eventoPagamento.Descricao = agendamentoRepository.ExtrairValorDoCampo("descricao", linha);

            eventoPagamento.NomePropietario = form["name"];
            eventoPagamento.NumeroCartao = form ["number"];
            eventoPagamento.Cvv = form["code"];
            eventoPagamento.DataValidade = DateTime.Parse(form["date"]);

            if(agendamentoRepository.Inserir(eventoPagamento))
            {
                avm.UsuarioEmail = ObterUsuarioEmailSession();
                avm.UsuarioNome = ObterUsuarioNomeSession();
                return View("Sucesso", new RespostaViewModel());
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível realizar o agendamento corretamente"));
            }
        }
    }
}