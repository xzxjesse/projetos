using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade, string som) : base(nome, idade, som)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Andando sob 4 patinhas e soltando muito pelo...");
        }

        public override void FazerBarulho()
        {
            Console.WriteLine("Miau miau miau");
        }
    }
}
