using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade, string som) : base(nome, idade, som)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Andando sob 4 patinhas...");
        }

        public override void FazerBarulho()
        {
            Console.WriteLine("Au au au");
        }
    }
}
