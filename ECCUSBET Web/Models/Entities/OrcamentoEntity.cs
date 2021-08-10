using API_ECCUSBET.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Entities
{
   
    public class OrcamentoEntity
    {
        public string Servico { get; protected set; }
    
        public string Equipamento { get; protected set; }
    
        public string Material { get; protected set; }
    
        public decimal ValorUnitario { get; protected set; }
    
        public int Quantidade { get; protected set; }
    
        public decimal CustoTotal { get; protected set; }
         

        public OrcamentoEntity(string servico, string equipamento, string material, decimal valorUnitario, int quantidade, decimal custoTotal)
        {
            Servico = servico;
            Equipamento = equipamento;
            Material = material;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            CustoTotal = custoTotal;
        }
    }
}
