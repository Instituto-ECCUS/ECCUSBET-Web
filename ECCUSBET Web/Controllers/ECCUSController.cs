using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Controllers
{
    public class ECCUSController : Controller
    {
        private readonly IConfiguration configuracao;

        public ECCUSController(IConfiguration config)
        {
            configuracao = config;
        }

        public IActionResult BemVindo()
        {
            var dev = configuracao["Desenvolvedor"];
            var linkedin = configuracao["Linkedin"];
            ViewData["Message"] = $"Desenvolvedor: {dev}, \n Linkedin: {linkedin}";
            return View();
        }

        /// <summary>
        /// Esse controlador gerencia os cálculos de dimansionamentos e orçamento.
        /// </summary>
        /// <returns></returns>
        public IActionResult Analise()
        {
            //var bet = new BetCalculation(ocupacao, npessoas, intervalo, temperatura);
            //var pneu = new TireCalculation(larguraPneu, perfil, aro);


            //// Chamada do métododo 
            //bet.Dimensionamento();
            //bet.ProfundidadeMedia();
            //pneu.Dimensi_Pneu();
            //bet.Largura_Bet(pneu.DiametroPneu);
            //pneu.QTE_Pneu(bet.VolUtio);
            //bet.ComprimentodaBaciat(pneu.QTEPneus, pneu.LarguraPneu);
            
            return View();
        }

        public IActionResult Desenvolvimento()
        {
            //var orcamento = new OrcamentoCalculation();
            //orcamento.ValorTotal();
            //orcamento.CustoTotal();
            return View();
        }

        public IActionResult Dimensionamento()
        {
            return View();
        }

        public IActionResult Manual()
        {
            return View();
        }

        public IActionResult NosAjude()
        {
            return View();
        }

    }
}
