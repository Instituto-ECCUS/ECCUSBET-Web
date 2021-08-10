using ECCUSBET_Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_ECCUSBET.Core.Entities
{

    public class BetEntity
    {
        public double VolUtio { get; protected set; }

        public double ProfundidadeM { get; protected set; }

        public string TipodeOcupacao { get; protected set; }

        public double LarguradaBet { get; protected set; }

        public double ComprimentoBet { get; protected set; }



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
