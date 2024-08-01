using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(double saldo, int numConta, string nome) : base(saldo, numConta, nome)
        {
        }
    }
}