using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Passaro : Animal
    {
        public Passaro(string nome, int idade, string som) : base(nome, idade, som)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Voando...");
        }

        public override void FazerBarulho()
        {
            Console.WriteLine("Bem te vi");
        }
    }
}