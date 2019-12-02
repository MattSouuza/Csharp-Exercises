using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : Controller
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            try
            {
                Cliente cliente = new Cliente(form["nName"],form["nCpf"],form["nEmail"],form["nPassword"],form["nPhone"]);
                clienteRepository.Inserir(cliente);

                @ViewData["NomeView"] = "SucessoErro";
                return View("Sucesso");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                
                @ViewData["NomeView"] = "SucessoErro";
                return View("Erro");
            }
        }
    }
}