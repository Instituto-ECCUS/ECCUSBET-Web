using API_ECCUSBET.Core.Entities;
using ECCUSBET_Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Calculations
{
    public class OrcamentoCalculation : OrcamentoEntity
    {
        public OrcamentoCalculation(string servico, string equipamento, string material, decimal valorUnitario, int quantidade, decimal custoTotal) : base(servico, equipamento, material, valorUnitario, quantidade, custoTotal)
        {
        }

        public decimal ValorTotaldeCadaItem()
        {
            return Quantidade * ValorUnitario;
        }

        public decimal CustoTotaldaBacia()
        {
            return ValorTotaldeCadaItem() * 13;
        }
    }
}
