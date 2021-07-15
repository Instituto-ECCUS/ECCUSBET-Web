using ECCUSBET_Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_ECCUSBET.Core.Entities
{
    [Table("Tabela de Dimensionamento")]
    public class BetEntity
    {
        public int IdDimensionamento { get; private set; }
        [Required]
        public double VolUtio { get; protected set; }
        [Required]
        public double ProfundidadeM { get; protected set; }
        [Required]
        public string TipodeOcupacao { get; protected set; }
        [Required]
        public double LarguradaBet { get; protected set; }
        [Required]
        public double ComprimentoBet { get; protected set; }

        public int IdOrcamento { get; private set; }

        public virtual OrcamentoEntity Orcamento { get; private set; }

        public BetEntity(double volUtio, double profundidadeM, string tipodeOcupacao, double larguradaBet, double comprimentoBet)
        {
            VolUtio = volUtio;
            ProfundidadeM = profundidadeM;
            TipodeOcupacao = tipodeOcupacao;
            LarguradaBet = larguradaBet;
            ComprimentoBet = comprimentoBet;
        }
    }
}
