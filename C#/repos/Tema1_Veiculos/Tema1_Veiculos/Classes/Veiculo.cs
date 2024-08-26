using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1_Veiculos.Classes;
using Tema1_Veiculos.Enumerados;

namespace Tema1_Veiculos.Classes
{
    public class Veiculo {

        #region | Propriedades |
        /// <summary>
        /// Modelo do veiculo
        /// </summary>
        private string nomeModelo;

        public string Modelo
        {
            get 
            { 
                return nomeModelo ?? ""; 
            }
            set   
            {
                if ((value != null) && (value.Length <= 60))
                {
                    nomeModelo = value;
                }
                else
                {
                    nomeModelo = null;
                }
            }
        }

        /// <summary>
        /// Marca do veiculo
        /// </summary>

        private string nomeMarca;
        public string Marca
        {
            get 
            {
                return nomeMarca ?? "";
            }
            set 
            {
                if ((value != null) && (value.Length <= 60))
                {
                    nomeMarca = value;
                }
                else
                {
                    nomeMarca = null;
                }
            }
        }

        /// <summary>
        /// Ano de fabricacao do veiculo
        /// </summary>
        private int anoFabricacao;
        public int Fabricacao
        {
            get
            {
                return anoFabricacao;
            }
            set
            {
                if ((value < 0) || (value < DateTime.Now.Year))
                {
                    anoFabricacao = value;
                }
                else
                {
                    throw new ArgumentException("Ano de fabricação inválido!");
                }
            }
        }
        #endregion

        #region | Metodos |
        /// <summary>
        /// Metodo para acelerar
        /// </summary>
        public virtual void Acelerar ()
        {
            Console.WriteLine("O veículo está acelerando.");
        }

        /// <summary>
        /// Metodo para parar
        /// </summary>

        public virtual void Parar()
        {
            Console.WriteLine("O veículo está parando.");
        }

        #endregion

        #region | Construtor |
        /// <summary>
        /// Construtor do veiculo
        /// </summary>
        public Veiculo (string modelo, string marca, int fabricacao)
        {
            Modelo = modelo;
            Marca = marca;
            Fabricacao = fabricacao;
        }
        #endregion
    }
}
