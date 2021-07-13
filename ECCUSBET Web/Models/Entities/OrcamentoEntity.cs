using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Entities
{
    public class OrcamentoEntity : BaseEntity
    {
        [Required]
        public int IdDomansionamento { get; private set; }
        [Required]
        public string Servico { get; protected set; }
        [Required]
        public string Equipamento { get; protected set; }
        [Required]
        public string Material { get; protected set; }
        [Required]
        public float ValorUnitario { get; protected set; }
        [Required]
        public int Quantidade { get; protected set; }
        [Required]
        public int CustoTotal { get; protected set; }

        public OrcamentoEntity(int idDomansionamento, string servico, string equipamento, string material, float valorUnitario, int quantidade, int custoTotal)
        {
            IdDomansionamento = idDomansionamento;
            Servico = servico;
            Equipamento = equipamento;
            Material = material;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            CustoTotal = custoTotal;
        }

        public OrcamentoEntity()
        {
        }
    }
}
