using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class Carro : VTerrestre
    {
        #region | Propriedades especificas |
        
        /// <summary>
        /// Capacidade do porta malas em litros
        /// </summary>
        public double CapacidadePortaMalas {  get; set; }

        /// <summary>
        /// Propriedade usando a enumeração do tipo de combustivel
        /// </summary>
        public TipoCombustivel TipoCombustivel { get; set; }

        #endregion

        #region | Métodos Específicos |

        /// <summary>
        /// Sobrescrita do metodo especifico para estacionar veiculo terrestre
        /// </summary>
        public override void Estacionar()
        {
            Console.WriteLine($"O carro de modelo {Modelo} está estacionando.");
        }

        /// <summary>
        /// Metodo especifico para abrir o porta malas
        /// </summary>
        public void AbrirPortaMalas()
        {
            Console.WriteLine($"O porta-malas do carro de modelo {Modelo} está sendo aberto. Capacidade: {CapacidadePortaMalas} litros.");
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor do carro
        /// </summary>
        public Carro
            (string modelo, string marca, int anoFabricacao, int qtdRodas, TipoTerreno tipoTerreno, int capacidadePortaMalas, TipoCombustivel tipoCombustivel)
            : base(modelo, marca, anoFabricacao, qtdRodas, tipoTerreno)
        {
            CapacidadePortaMalas = capacidadePortaMalas;
            TipoCombustivel = tipoCombustivel;
        }
        #endregion
    }
}
