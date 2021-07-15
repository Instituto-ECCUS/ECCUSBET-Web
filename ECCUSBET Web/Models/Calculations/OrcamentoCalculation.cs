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
        public OrcamentoCalculation(string servico, string equipamento, string material, double valorUnitario, int quantidade, double custoTotal) : base(servico, equipamento, material, valorUnitario, quantidade, custoTotal)
        {
        }

        public double ValorTotaldeCadaItem()
        {
           
            return Quantidade * ValorUnitario;
        }

        public List<double> CustoTotaldaBacia()
        {
            var lista = new List<double>();
            lista.Add(ValorTotaldeCadaItem());
            return lista;
        }
    }
}
