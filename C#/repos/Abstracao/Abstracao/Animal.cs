using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Som { get; set; }
    }

    public Animal(string nome, int idade, string som)
    {
        Nome = nome;
        Idade = idade;
        Som = som;
    }

    public abstract void Mover();
    public abstract void FazerBarulho();
}
