using API_ECCUSBET.Core.Entities;
using API_ECCUSBET.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Calculations
{
    public class BetCalculation : BetEntitie
    {
        public BetCalculation(double volUtio, double profundidadeM, OcupacaoEnum selecaoPadrao, double larguradaBet, double comprimentoBet) : base(volUtio, profundidadeM, selecaoPadrao, larguradaBet, comprimentoBet)
        {
        }

        public BetCalculation(int npessoas, int intervalo, double temperatura) : base(npessoas, intervalo, temperatura)
        {
        }
              

        /// <summary>
        /// Calcula o período de detenção, com base na contribuiçaõ diário total, "<see cref="ContrDiaruiaTotal"/>".
        /// </summary>
        /// <returns>Retorna o período de detenção</returns>
        private double PeriododeDetencao()
        {
            ContrDiaruiaTotal = ((double)SelecaoPadrao * Npessoas);
            if (ContrDiaruiaTotal <= 1500)
            {
                Pd = 1;
            }
            else if (ContrDiaruiaTotal >= 1501 && ContrDiaruiaTotal <= 3000)
            {
                Pd = 0.92;
            }
            else if (ContrDiaruiaTotal >= 3001 && ContrDiaruiaTotal <= 4500)
            {
                Pd = 0.83;
            }
            else if (ContrDiaruiaTotal >= 4501 && ContrDiaruiaTotal <= 6000)
            {
                Pd = 0.75;
            }
            else if (ContrDiaruiaTotal >= 6001 && ContrDiaruiaTotal <= 7500)
            {
                Pd = 0.67;
            }
            else if (ContrDiaruiaTotal >= 7501 && ContrDiaruiaTotal <= 9000)
            {
                Pd = 0.58;
            }
            else
                Pd = 0.5;
            return Pd;
        }

        /// <summary>
        /// Calcula a taxa de acumulação com base na "<see cref="Temperatura"/>" e <see cref="Intervalo"/>.
        /// </summary>
        /// <returns>Taxa de acumulação</returns>
        private int TaxadeAcumulacao()
        {
            //SizingView sizingView = new SizingView();
            //if (sizingView.txtIntervalodeLimpeza.Text == null) //Compara se tem referência nula
            //{
            //    Ta = 0; // verificar o valor da requisição se é nulo 
            //}

            if (Intervalo == 1)
            {
                if (Temperatura <= 10)
                {
                    Ta = 94;
                }
                else if (Temperatura > 10 && Temperatura <= 20)
                {
                    Ta = 65;
                }
                else
                {
                    Ta = 57;
                }

            }
            else if (Intervalo == 2)
            {

                if (Temperatura <= 10)
                {
                    Ta = 134;
                }
                else if (Temperatura > 10 && Temperatura <= 20)
                {
                    Ta = 105;
                }
                else
                {
                    Ta = 97;
                }

            }
            else if (Intervalo == 3)
            {

                if (Temperatura <= 10)
                {
                    Ta = 174;
                }
                else if (Temperatura > 10 && Temperatura <= 20)
                {
                    Ta = 145;
                }
                else
                {
                    Ta = 137;
                }

            }
            else if (Intervalo == 4)
            {
                if (Temperatura <= 10)
                {
                    Ta = 214;
                }
                else if (Temperatura > 10 && Temperatura <= 20)
                {
                    Ta = 185;
                }
                else
                {
                    Ta = 177;
                }

            }
            else if (Intervalo == 5)
            {
                if (Temperatura <= 10)
                {
                    Ta = 254;
                }
                else if (Temperatura > 10 && Temperatura <= 20)
                {
                    Ta = 255;
                }
                else
                {
                    Ta = 217;
                }

            }
            return Ta;
        }

        /// <summary>
        /// Calcula a profundidade média com base no volume útio, "<see cref="VolUtio"/>".
        /// </summary>
        /// <returns></returns>
        public double ProfundidadeMedia()
        {
            //SizingView sizingView = new SizingView();
            //if (VolUtio == 0) // Verificação deve ser feita no post
            //{
            //    sizingView.TxtProfundidadeMedia.Text.= "0";
            //}

            if (VolUtio <= 6)
            {
                ProfundidadeM = 1.2;
            }
            else if (VolUtio > 6 && VolUtio <= 10)
            {
                ProfundidadeM = 1.5;
            }
            else
            {
                ProfundidadeM = 1.8;
            }
            return ProfundidadeM;
        }

        /// <summary>
        /// Calcula o dimensionamento da bacia.
        /// </summary>
        /// <returns>Dimensionamento "<see cref="VolUtio"/>"</returns>
        public double Dimensionamento()
        {
            VolUtio = (1000 + Npessoas * (((double)SelecaoPadrao * PeriododeDetencao()) + (TaxadeAcumulacao() * CLodoFresco))) / 1000;
            return VolUtio;
        }

        /// <summary>
        /// Calcula a largura da bacia, que é o diâmetro do pneu mais 1 metro.
        /// </summary>
        /// <param name="diametroPeneu"> Recebe o diâmetro o pneu.</param>
        /// <returns>Largura da bacia.</returns>
        public double Largura_Bet(double diametroPeneu)
        {
            LarguradaBet = diametroPeneu + 1.0;
            return LarguradaBet;
        }

        /// <summary>
        /// Calcula o comprimenta da bacia.
        /// </summary>
        /// <param name="quantidade"></param>
        /// <param name="largura"></param>
        /// <returns>Comprimento da bacia.</returns>
        public double ComprimentodaBaciat(int quantidade, double largura)
        {
            ComprimentoBet = quantidade * largura;
            return ComprimentoBet;
        }
    }
}
