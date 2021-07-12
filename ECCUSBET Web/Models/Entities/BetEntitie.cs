using API_ECCUSBET.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ECCUSBET.Core.Entities
{
    public class BetEntitie
    {
        protected readonly int Npessoas, Intervalo;
        protected readonly double Temperatura;
        protected double ContrDiaruiaTotal, Pd;
        protected readonly int CLodoFresco = 1;
        protected int Ta;

        public double VolUtio { get; protected set; }
        public double ProfundidadeM { get; protected set; }
        public OcupacaoEnum SelecaoPadrao { get; protected set; }
        public double LarguradaBet { get; protected set; }
        public double ComprimentoBet { get; protected set; }

        public BetEntitie(double volUtio, double profundidadeM, OcupacaoEnum selecaoPadrao, double larguradaBet, double comprimentoBet)
        {
            VolUtio = volUtio;
            ProfundidadeM = profundidadeM;
            SelecaoPadrao = selecaoPadrao;
            LarguradaBet = larguradaBet;
            ComprimentoBet = comprimentoBet;
        }

        public BetEntitie(int npessoas, int intervalo, double temperatura)
        {
            Npessoas = npessoas;
            Intervalo = intervalo;
            Temperatura = temperatura;
        }
    }
}
