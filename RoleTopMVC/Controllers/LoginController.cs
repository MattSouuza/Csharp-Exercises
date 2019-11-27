using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;

namespace RoleTopMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Login";
            return View();
        }

        // public IActionResult Login(IFormCollection form)
        // {
        //     try
        //     {
        //         System.Console.WriteLine("===================");
        //         System.Console.WriteLine(form["nEmail"]);
        //         System.Console.WriteLine(form["nPassword"]);
        //         System.Console.WriteLine("===================");
        //         var usuario = form["nEmail"];
        //         var senha = form["nPassword"];
        //     }
        //     catch (Exception e)
        //     {

        //     }
        // }
    }
}