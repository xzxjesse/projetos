using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class Bicicleta : VTerrestre
    {
        #region | Propriedades especificas |

        /// <summary>
        /// Define se tem marcha
        /// </summary>
        public bool Marcha { get; set; }

        #endregion

        #region | Métodos Específicos |

        /// <summary>
        /// Sobrescrita do metodo especifico para estacionar veiculo terrestre
        /// </summary>
        public override void Estacionar()
        {
            Console.WriteLine($"A bicileta de modelo {Modelo} está estacionando.");
        }

        /// <summary>
        /// Metodo especifico para trocar marcha de bicicleta
        /// </summary>
        public void TrocarMarcha()
        {
            if (Marcha)
            {
                Console.WriteLine($"A bicicleta de modelo {Modelo} está trocando de marcha.");
            }
            else
            {
                Console.WriteLine($"A bicicleta de modelo {Modelo} não possui marchas.");
            }
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor da bicicleta
        /// </summary>
        public Bicicleta
            (string modelo, string marca, int anoFabricacao, int qtdRodas, TipoTerreno tipoTerreno, bool marcha)
            : base(modelo, marca, anoFabricacao, qtdRodas, tipoTerreno)
        {
            Marcha = marcha;
        }
        #endregion
    }
}