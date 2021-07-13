using ECCUSBET_Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_ECCUSBET.Core.Entities
{
    public class BetEntity : BaseEntity
    {
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

        public BetEntity(double volUtio, double profundidadeM, string selecaoPadrao, double larguradaBet, double comprimentoBet)
        {
            VolUtio = volUtio;
            ProfundidadeM = profundidadeM;
            TipodeOcupacao = selecaoPadrao;
            LarguradaBet = larguradaBet;
            ComprimentoBet = comprimentoBet;
        }
             
    }
}
