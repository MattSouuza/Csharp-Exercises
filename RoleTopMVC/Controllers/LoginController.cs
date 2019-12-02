//**Arrumar o Login! */

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
    public class LoginController : Controller
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()        //** TODO: Mudar Index para Login*/
        {
            ViewData["NomeView"] = "Login";
            return View();
        }

        public IActionResult Login(IFormCollection form)
        {
            ViewData["NomeView"] = "Cadastro";
            try
            {
                System.Console.WriteLine("===================");
                System.Console.WriteLine(form["nEmail"]);
                System.Console.WriteLine(form["nPassword"]);
                System.Console.WriteLine("===================");
                var usuario = form["nEmail"];
                var senha = form["nPassword"];
                
                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        return View("Sucesso", new RespostaViewModel("Login Efetuado"));
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel($"{usuario} incorreto"));
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Usuário não existe"));
            }
        }
    }
}