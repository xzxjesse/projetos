using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class VMaritmo : Veiculo
    {
        #region | Propriedades |
        /// <summary>
        /// Define a quantidade de mastros
        /// </summary>
        private int mastros = 0;
        public int NumMastro
        {
            get
            {
                return mastros;
            }
            set
            {
                try
                {
                    mastros = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: quantidade de mastros não definida. " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Propriedade usando a enumeração do tipo de casco
        /// </summary>
        public TipoCasco TipoCasco { get; set; }

        #endregion

        #region | Metodos |
        /// <summary>
        /// Sobrescrita do metodo acelerar
        /// </summary>
        public override void Acelerar()
        {
            Console.WriteLine($"O veículo maritmo de modelo {Modelo} está acelerando.");
        }

        /// <summary>
        /// Metodo especifico para ancorar veiculo maritmo
        /// </summary>
        public void Ancorar()
        {
            Console.WriteLine($"O veículo maritmo de modelo {Modelo} está ancorando.");
        }


        /// <summary>
        /// Metodo especifico para levantar ancora veiculo maritmo
        /// </summary>
        public void LevantarAncora()
        {
            Console.WriteLine($"O veículo maritmo de modelo {Modelo} está levantando âncora.");
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor de veiculo maritmo
        /// </summary>
        public VMaritmo
            (string modelo, string marca, int anoFabricacao, int numMastro, TipoCasco tipoCasco)
            : base(modelo, marca, anoFabricacao)
        {
            NumMastro = numMastro;
            TipoCasco = tipoCasco;
        }

        #endregion
    }
}