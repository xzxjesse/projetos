using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class Helicoptero : VAereo
    {
        #region | Propriedades Específicas |

        /// <summary>
        /// Define se o helicóptero está em modo de resgate
        /// </summary>
        public bool ModoResgateAtivo { get; set; }

        /// <summary>
        /// Propriedade usando a enumeração do tipo de combustivel
        /// </summary>
        public TipoCombustivel TipoCombustivel { get; set; }

        #endregion

        #region | Métodos Específicos |

        /// <summary>
        /// Sobrescrita do método específico para decolar o helicóptero
        /// </summary>
        public override void Decolar()
        {
            Console.WriteLine($"O helicóptero de modelo {Modelo} está decolando.");
        }

        /// <summary>
        /// Método específico para ativar o modo de resgate
        /// </summary>
        public void AtivarModoResgate()
        {
            ModoResgateAtivo = true;
            Console.WriteLine($"O helicóptero de modelo {Modelo} está em modo de resgate.");
        }

        /// <summary>
        /// Método específico para desativar o modo de resgate
        /// </summary>
        public void DesativarModoResgate()
        {
            ModoResgateAtivo = false;
            Console.WriteLine($"O helicóptero de modelo {Modelo} desativou o modo de resgate.");
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor do helicóptero
        /// </summary>
        public Helicoptero
            (string modelo, string marca, int anoFabricacao, int altitudeMaxima, TipoVoo tipoVoo, TipoCombustivel tipoCombustivel)
            : base(modelo, marca, anoFabricacao, altitudeMaxima, tipoVoo)
        {
            ModoResgateAtivo = false;
            TipoCombustivel = tipoCombustivel;
        }

        #endregion
    }
}
