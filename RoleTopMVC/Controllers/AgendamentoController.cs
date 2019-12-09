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
            var usuarioLogado = ObterUsuarioEmailSession(); //* esta variavel é o email do usuario
            var nomeUsuarioLogado = ObterUsuarioNomeSession(); //* esta variavel é o nome do usuario

            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.Cliente = clienteRepository.ObterPor(usuarioLogado); //* Insere as informações (por meio do ObterPor) no avm.Cliente que foram expecificadas pelo usuário
            }
            else
            {
                avm.Cliente = new Cliente();
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado); //* clienteLogado contem as informações do usuario
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
            Cliente cliente = new Cliente(); //* Classe Cliente, onde as informações vão ser inseridas, nesse método

            try
            {
                cliente.Nome = form["nName"]; //* As informações inseridas pelo usuário (no form), vão ser inseridas na classe
                cliente.Cpf = form["nCpf"];
                cliente.Email = form["nEmail"];
                cliente.Telefone = form["nPhone"];

                var linha = clienteRepository.FazerRegistroCSV(cliente); //* As informações expecificadas pelo usuario, irão ser escritas em uma string só
                /**
                * ! A string sera criada, porém não sera inserida no CSV ainda
                */

                HttpContext.Session.SetString("cliente", linha); //* "cliente" é a chave, ela poderia ser qualquer outro nome, porém, quando for obter o valor (que é linha), é necessário chamar o nome da chave correto 
                //* linha contem as informações do usuario em uma string. Essa string é armazenada no Estado de sessão, assim, preservando a informação  

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
                // Adicionar o valor total
                Evento evento = new Evento(); //* Classe Evento, onde as informações vão ser inseridas, nesse método
                Cliente cliente = new Cliente(); //* Classe Cliente, onde as informações vão ser inseridas, nesse método

                var linha = HttpContext.Session.GetString("cliente"); //* As informações da primeira tela do agendamento são armazenadas (pelo GetString) na var linha, ou seja, a aquela string inteira (ver no Repository) é inserida nessa nova variavel
                
                cliente.Nome = clienteRepository.ExtrairValorDoCampo("nome", linha); //* "nome" se refere ao campo, onde o método ExtrairValorDoCampo irar retirar o valor da linha e ira inserir na classe
                cliente.Cpf = clienteRepository.ExtrairValorDoCampo("cpf", linha);
                cliente.Email = clienteRepository.ExtrairValorDoCampo("email", linha);
                cliente.Telefone = clienteRepository.ExtrairValorDoCampo("telefone", linha);

                evento.Cliente = cliente; //* Evento contem Cliente (por meio de composição), cliente (que é a classe que contem as informações, e que foi instanciada no começo do método), passa suas informações para Cliente que está contida em Evento 

                evento.NomeEvento = form["nName"]; //* As informações inseridas pelo usuário (no form), vão ser inseridas na classe
                evento.TipoEvento = form ["nType"];
                evento.StatusEvento = form["nStatus"];
                evento.Planos = form["nPlan"];
                evento.NumeroPessoas = form["nNumber"];
                evento.DataEvento = DateTime.Parse(form["nDate"]);
                evento.HoraInicio = form["nTimeS"];
                evento.HoraTermino = form["nTimeE"];
                evento.Descricao = form["nMessage"];

                linha = agendamentoRepository.FazerRegistroCSV(evento); //* As informações expecificadas pelo usuario, irão ser escritas em uma string só
                
                HttpContext.Session.SetString("evento", linha); //* linha contem as informações do usuario em uma string. Essa string é armazenada no Estado de sessão, assim, preservando a informação

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
            /**
            * ! Mesmo que Cliente seja uma composição de Evento, Cliente ainda precisa ser instânciado!
            */

            var linha = HttpContext.Session.GetString("evento"); //* Obtem as informações
            System.Console.WriteLine(linha);
            eventoPagamento.Cliente.Nome = clienteRepository.ExtrairValorDoCampo("nome", linha); //* Aloca as informações da linha e insere-as na classe
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

            eventoPagamento.NomePropietario = form["name"]; //* Aloca as informações fornecidas pelo usuario e as insere na classe
            eventoPagamento.NumeroCartao = form ["number"];
            eventoPagamento.Cvv = form["code"];
            eventoPagamento.DataValidade = DateTime.Parse(form["date"]);

            if(agendamentoRepository.Inserir(eventoPagamento)) //* Aqui é onde as informações do usuario são escritas no CSV
            {
                return View("Sucesso", new RespostaViewModel());
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível realizar o agendamento corretamente"));
            }
        }
    }
}