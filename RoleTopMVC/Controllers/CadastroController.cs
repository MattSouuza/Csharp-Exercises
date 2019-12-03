using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public RespostaViewModel respostaViewModel = new RespostaViewModel();

        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["TextoView"] = "Cadastro";
            ViewData["NomeView"] = "SucessoErro";
            try
            {
                Cliente cliente = new Cliente(form["nName"],form["nCpf"],form["nEmail"],form["nPassword"],form["nPhone"]);
                clienteRepository.Inserir(cliente);

                return View("Sucesso", new RespostaViewModel());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                
                return View("Erro", new RespostaViewModel());
            }
        }
    }
}