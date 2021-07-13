using ECCUSBET_Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Calculations
{
    public class OrcamentoCalculation
    {
        public float ValorTotaldeCadaItem()
        {
            var entity = new OrcamentoEntity();
            return entity.Quantidade * entity.ValorUnitario;
        }

        public List<float> CustoTotaldaBacia()
        {
            var lista = new List<float>();
            lista.Add(ValorTotaldeCadaItem());
            return lista;
        }
    }
}
