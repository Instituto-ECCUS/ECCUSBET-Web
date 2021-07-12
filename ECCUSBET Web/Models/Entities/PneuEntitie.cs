using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ECCUSBET.Core.Entities
{
    public class PneuEntitie
    {
        public double DiametroPneu { get; protected set; }
        public double LarguraPneu { get; protected set; }
        public double Perfil { get; protected set; }
        public double N_Roda { get; protected set; }
        public double VolPneu { get; protected set; }
        public int QTEPneus { get; protected set; }

        /// <summary>
        /// Construtor que inicia as propriedades já convertidas.
        /// </summary>
        /// <param name="larguraPneu">0.001 é fator de conversão. Assim o parâmetro é inicializado na unidade de medida correta.</param>
        /// <param name="perfil">O perfil já é inicializado como porcentagem.</param>
        /// <param name="n_Roda">o.o254 é fator de conversão. Assim o parâmetro é inicializado na unidade de medida correta.</param>
        public PneuEntitie(double larguraPneu, double perfil, double n_Roda)
        {
            LarguraPneu = larguraPneu * 0.001;
            Perfil = perfil / 100 * larguraPneu;
            N_Roda = n_Roda * 0.0254;
        }
    }
}
