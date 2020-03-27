using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace CognizantBank.Controllers
{
    public class SimulacaoController : Controller
    {
        public async Task<IActionResult> Simulacao()
        {
            var url = "http://economia.uol.com.br/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var values = htmlDocument.DocumentNode.Descendants("a").Where(node => node.GetAttributeValue("class", "").Equals("subtituloGrafico subtituloGraficoValor")).ToList();
            var result = Convert.ToDecimal(values.FirstOrDefault().InnerText.Replace("R$", "").Trim());
            ViewBag.ValorDolar = result;
            return View();
        }
    }
}