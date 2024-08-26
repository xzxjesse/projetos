using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class Lancha : VMaritmo
    {
        #region | Propriedades Específicas |

        /// <summary>
        /// Define a capacidade de pessoas
        /// </summary>
        public int QtdPessoas { get; set; }

        /// <summary>
        /// Propriedade usando a enumeração do tipo de combustivel
        /// </summary>
        public TipoCombustivel TipoCombustivel { get; set; }

        #endregion

        #region | Métodos Específicos |

        /// <summary>
        /// Método específico para desembarque
        /// </summary>
        public void Desembarque()
        {
            Console.WriteLine($"As {QtdPessoas} pessoas estão desembarcando da lancha de modelo {Modelo}.");
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor da lancha
        /// </summary>
        public Lancha(string modelo, string marca, int anoFabricacao, int qtdPessoas, TipoCombustivel tipoCombustivel, int numMastro, TipoCasco tipoCasco)
            : base(modelo, marca, anoFabricacao, numMastro, tipoCasco)
        {
            QtdPessoas = qtdPessoas;
            TipoCombustivel = tipoCombustivel;
            NumMastro = numMastro;
            TipoCasco = tipoCasco;
        }

        #endregion
    }
}
