using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class VAereo : Veiculo
    {
        #region | Propriedades |
        /// <summary>
        /// Define a altitude maxima
        /// </summary>
        private int altitude = 0;
        public int AltitudeMaxima
        {
            get
            {
                return altitude;
            }
            set
            {
                try
                {
                    altitude = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: altitude máxima não definida. " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Propriedade usando a enumeração do tipo de voo
        /// </summary>
        public TipoVoo TipoVoo { get; set; }

        #endregion

        #region | Metodos |
        /// <summary>
        /// Sobrescrita do metodo acelerar
        /// </summary>
        public override void Acelerar()
        {
            Console.WriteLine($"O veículo aereo de modelo {Modelo} está acelerando.");
        }

        /// <summary>
        /// Metodo especifico para decolar veiculo aereo
        /// </summary>
        public virtual void Decolar()
        {
            Console.WriteLine($"O veículo aereo de modelo {Modelo} está decolando.");
        }

        /// <summary>
        /// Metodo especifico para pousar veiculo aereo
        /// </summary>
        public void Pousar()
        {
            Console.WriteLine($"O veículo aereo de modelo {Modelo} está pousando.");
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor do veiculo aereo
        /// </summary>
        public VAereo
            (string modelo, string marca, int anoFabricacao, int altitudeMaxima, TipoVoo tipoVoo)
            : base(modelo, marca, anoFabricacao)
        {
            AltitudeMaxima = altitudeMaxima;
            TipoVoo = tipoVoo;
        }

        #endregion
    }
}