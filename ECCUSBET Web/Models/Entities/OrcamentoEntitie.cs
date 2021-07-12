using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Entities
{
    public class OrcamentoEntitie
    {
        public string DescricaodoItem { get; protected set; }
        public int Unidade { get; protected set; }
        public float PrecoporUnidade { get; protected set; }
        public float PrecoTotal { get; protected set; }
        public float CustoTotal { get; protected set; }

        public OrcamentoEntitie(string item, int unidade, float precoporUnidade, float precoTotal)
        {
            DescricaodoItem = item;
            Unidade = unidade;
            PrecoporUnidade = precoporUnidade;
            PrecoTotal = precoTotal;
        }
    }
}
