using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using CognizantBank.BLL.Interfaces;
using CognizantBank.Entities;
using System.Net.Http;
using HtmlAgilityPack;

namespace CognizantBank.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContaCorrenteBLL contaCorrenteBLL;

        public HomeController(IContaCorrenteBLL _contaCorrenteBLL)
        {
            contaCorrenteBLL = _contaCorrenteBLL;
        }


        //-------------------------------- CRIAR CONTA ------------------------------//

        [HttpGet]
        public IActionResult CriarConta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarConta(ContaCorrente UI)
        {
            contaCorrenteBLL.CriarConta(UI);
            return View();
        }


        //-------------------------------- SELECT CONTA ------------------------------//

        public IActionResult VisualizarConta()
        {            
            return View(contaCorrenteBLL.ObterContas());
        }


        //-------------------------------- UPDATE CONTA ------------------------------//

        [HttpGet]
        public IActionResult DebitoCredito()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult DebitoCredito(ContaCorrente UI, bool tipoConta)
        {
            contaCorrenteBLL.DebitoCredito(UI, tipoConta);
            return View();
        }


        //-------------------------------- DELETAR CONTA ------------------------------//

        [HttpGet]
        public IActionResult DeletarConta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeletarConta(ContaCorrente UI)
        {
            contaCorrenteBLL.DeletarConta(UI);
            return View();
        }    
    }
}
