using ECCUSBET_Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Calculations
{
    public class OrcamentoCalculation : OrcamentoEntitie
    {
        public OrcamentoCalculation(string item, int unidade, float precoporUnidade, float precoTotal) : base(item, unidade, precoporUnidade, precoTotal)
        {
        }

        public float ValorTotal()
        {
            return Unidade * PrecoporUnidade;
        }

        public new List<float> CustoTotal() 
        {
            var lista = new List<float>();
            return lista;
        }
    }
}
