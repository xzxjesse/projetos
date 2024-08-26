using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class Aviao : VAereo
    {
        #region | Propriedades Específicas |

        /// <summary>
        /// Define quantidade de motores
        /// </summary>
        public int QtdMotores { get; set; }

        /// <summary>
        /// Propriedade usando a enumeração do tipo de combustivel
        /// </summary>
        public TipoCombustivel TipoCombustivel { get; set; }

        #endregion

        #region | Métodos Específicos |

        /// <summary>
        /// Sobrescrita do método específico para decolar o avião
        /// </summary>
        public override void Decolar()
        {
            Console.WriteLine($"O avião de modelo {Modelo} com {QtdMotores} motores está decolando.");
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor do avião
        /// </summary>
        public Aviao
            (string modelo, string marca, int anoFabricacao, int altitudeMaxima, TipoVoo tipoVoo, int qtdMotores, TipoCombustivel tipoCombustivel)
            : base(modelo, marca, anoFabricacao, altitudeMaxima, tipoVoo)
        {
            QtdMotores = qtdMotores;
            TipoCombustivel = tipoCombustivel;
        }

        #endregion

    }
}
