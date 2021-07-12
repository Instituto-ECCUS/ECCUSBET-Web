using ECCUSBET_Web.Models.Calculations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Controllers
{
    public class CalculoController : Controller
    {
        /// <summary>
        /// Esse controlador gerencia os cálculos de dimansionamentos e orçamento.
        /// </summary>
        /// <returns></returns>
        public IActionResult Dimensionamento()
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

        public IActionResult CalcularOrcamento()
        {
            //var orcamento = new OrcamentoCalculation();
            //orcamento.ValorTotal();
            //orcamento.CustoTotal();
            return View();
        }
    }
}
