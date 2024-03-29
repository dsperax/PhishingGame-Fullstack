﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using phishing.Models;

namespace phishing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Autenticacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvaUsuario([FromBody] Usuario usuario)
        {           
            TempData["nome"] = usuario.Nome;
            TempData["email"] = usuario.Email;
            TempData["pontuacao"] = 0;
            return Json("Salvo com sucesso!");
        }
    }
}
