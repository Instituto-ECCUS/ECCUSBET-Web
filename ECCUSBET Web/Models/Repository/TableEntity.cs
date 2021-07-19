using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Repository
{
    [DataContract]
    public class BaseEntity
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    [Table("Tabela de Dimensionamento")]
    public class TbDimensionamento : BaseEntity
    {
        [Required]
        public double Largura { get; private set; }
        [Required]
        public double Profundidade { get; private set; }
        [Required]
        public double Comprimento { get; private set; }
        [Required]
        public double Volume { get; private set; }
            
        public int CustoTotalID { get; private set; }
        public TbCustoTotal TbCustoTotal { get; private set; }

        public TbDimensionamento(double largura, double profundidade, double comprimento, double volume)
        {
            Largura = largura;
            Profundidade = profundidade;
            Comprimento = comprimento;
            Volume = volume;
        }
    }

    [Table("Tabela de Orçamento")]
    public class TbOrcamento : BaseEntity
    {
        [Required]
        public string Servico_Equipamento { get; private set; }
        [Required]
        public int Quantidade { get; private set; }
        [Required]
        public decimal PrecoUnitario { get; private set; }
        public decimal PrecoTotalporItem { get; private set; }

        public TbOrcamento(string servico_Equipamento, int quantidade, decimal precoUnitario, decimal precoTotalporItem)
        {
            Servico_Equipamento = servico_Equipamento;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            PrecoTotalporItem = precoTotalporItem;
        }
    }

    [Table("Tabela de Custo Total")]
    public class TbCustoTotal : BaseEntity
    {
        [Required]
        public decimal CustoTotaldaBet { get; private set; }

        [ForeignKey("TbDimensionamento")]
        public int DimensionbamentoID { get; private set; }
        public TbDimensionamento TbDimensionamento { get; private set; }


        public TbCustoTotal(decimal custoTotaldaBet)
        {
            CustoTotaldaBet = custoTotaldaBet;
        }
    }
}
