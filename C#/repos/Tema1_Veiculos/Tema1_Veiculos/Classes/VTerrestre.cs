using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class VTerrestre : Veiculo
    {
        #region | Propriedades |
        /// <summary>
        /// Define a quantidade de rodas
        /// </summary>
        private int rodas = 0;
        public int QtdRodas
        {
            get
            {
                return rodas;
            }
            set
            {
                try
                {
                    rodas = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: quantidade de rodas não definida. "+ex.Message);
                }
            }
        }

        /// <summary>
        /// Propriedade usando a enumeração do tipo de terreno
        /// </summary>
        public TipoTerreno TipoTerreno { get; set; }

        #endregion

        #region | Metodos |
        /// <summary>
        /// Sobrescrita do metodo acelerar
        /// </summary>
        public override void Acelerar()
        {
            Console.WriteLine($"O veículo terrestre de modelo {Modelo} está acelerando.");
        }

        /// <summary>
        /// Sobrescrita do metodo parar
        /// </summary>
        public override void Parar()
        {
            Console.WriteLine($"O veículo terrestre de modelo {Modelo} está parando.");
        }

        /// <summary>
        /// Metodo especifico para estacionar veiculo terrestre
        /// </summary>
        public virtual void Estacionar()
        {
            Console.WriteLine($"O veículo terrestre de modelo {Modelo} está estacionando.");
        }

        #endregion

        #region | Construtor |

        /// <summary>
        /// Construtor de veiculo terrestre
        /// </summary>
        public VTerrestre
            (string modelo, string marca, int anoFabricacao, int qtdRodas, TipoTerreno tipoTerreno)
            : base(modelo, marca, anoFabricacao)
        {
            QtdRodas = qtdRodas;
            TipoTerreno = tipoTerreno;
        }

        #endregion
    }
}
