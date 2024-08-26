using System;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class Navio : VMaritmo
    {
        #region | Propriedades Específicas |

        /// <summary>
        /// Define o tipo de carga
        /// </summary>
        public TipoCarga TipoCarga { get; set; }

        /// <summary>
        /// Define o comprimento do navio em metros
        /// </summary>
        private double comprimento = 0;
        public double Comprimento
        {
            get
            {
                return comprimento;
            }
            set
            {
                try
                {
                    comprimento = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: comprimento do navio não definido. " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Propriedade usando a enumeração do tipo de combustivel
        /// </summary>
        public TipoCombustivel TipoCombustivel { get; set; }

        #endregion

        #region | Métodos Específicos |

        /// <summary>
        /// Método específico para atracar o navio
        /// </summary>
        public void Atracar()
        {
            Console.WriteLine($"O navio de modelo {Modelo} está atracando no porto.");
        }

        /// <summary>
        /// Método específico para descarregar o navio
        /// </summary>
        public void Descarregar()
        {
            Console.WriteLine($"O navio de modelo {Modelo} está descarregando sua carga do tipo {TipoCarga}.");
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor do navio
        /// </summary>
        public Navio
            (string modelo, string marca, int anoFabricacao, double comprimento, TipoCarga tipoCarga, TipoCombustivel tipoCombustivel, int numMastro, TipoCasco tipoCasco)
            : base(modelo, marca, anoFabricacao, numMastro, tipoCasco)
        {
            Comprimento = comprimento;
            TipoCarga = tipoCarga;
            TipoCombustivel = tipoCombustivel;
            TipoCasco = tipoCasco;
        }

        #endregion
    }
}
