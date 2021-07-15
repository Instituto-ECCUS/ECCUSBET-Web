using API_ECCUSBET.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Entities
{
    [Table("Tabela de Orçamento")]
    public class OrcamentoEntity
    {
        public int IdOrcamento { get; private set; }
        [Required]
        public string Servico { get; protected set; }
        [Required]
        public string Equipamento { get; protected set; }
        [Required]
        public string Material { get; protected set; }
        [Required]
        public double ValorUnitario { get; protected set; }
        [Required]
        public int Quantidade { get; protected set; }
        [Required]
        public double CustoTotal { get; protected set; }

        //Relacionamento em que um BetEntity há um OrcamentoEntity, só basta definir que 1 BetEntity tem um Orcamento e definir aqui a chave estrangeira
        [ForeignKey("Dimensionamento")]
        public int IdDimensionamento { get; private set; }
        public virtual BetEntity Dimensionamento { get; private set; }


        public OrcamentoEntity(string servico, string equipamento, string material, double valorUnitario, int quantidade, double custoTotal)
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
