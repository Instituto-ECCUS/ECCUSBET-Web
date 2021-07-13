using API_ECCUSBET.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCUSBET_Web.Models.Calculations
{
    public class PneuCalculation : PneuEntity
    {


        public PneuCalculation(double larguraPneu, double perfil, double n_Roda) : base(larguraPneu, perfil, n_Roda)
        {
        }

        /// <summary>
        /// Método que retorna o volume de cada pneu ""<see cref="VolPneu"/>".
        /// </summary>
        /// <returns></returns>
        public double Dimensi_Pneu()
        {
            double RaioPeneu;
            DiametroPneu = 2 * Perfil + N_Roda;
            RaioPeneu = DiametroPneu / 2;
            VolPneu = Math.PI * Math.Pow(RaioPeneu, 2) * LarguraPneu;
            return VolPneu;
        }

        /// <summary>
        /// Método que retona a quantidade de pneus "<see cref="QTEPneus"/>". 
        /// </summary>
        /// <param name="volutio">Parâmetro a receber</param>
        /// <returns></returns>
        public double QTE_Pneu(double volutio)
        {
            QTEPneus = (int)(volutio / VolPneu);
            return QTEPneus;
        }
    }
}
