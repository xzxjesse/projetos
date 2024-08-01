using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo{
    public class Carro : Veículo
    {
        public Carro(string marca, string modelo, int anoFabricacao) : base(marca, modelo, anoFabricacao)
        {

        }

        public override void Ligar()
        {
            Console.WriteLine("Carro Ligado!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando o carro...");
        }
    }
}
