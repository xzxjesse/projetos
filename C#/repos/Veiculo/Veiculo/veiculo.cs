using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo{
    public abstract class Veículo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }

        public Veículo(string marca, string modelo, int anoFabricacao)
        {
            Marca = marca;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
        }

        public abstract void Ligar();
        public abstract void Acelerar();
    }
}
