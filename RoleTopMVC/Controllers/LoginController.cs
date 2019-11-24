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
        //         var usuario = form[email];
        //         var senha = form[senha];
        //     }
        //     catch (Exception e)
        //     {

        //     }
        // }
    }
}