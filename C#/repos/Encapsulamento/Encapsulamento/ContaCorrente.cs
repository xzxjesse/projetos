using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(double saldo, int numConta, string nome) : base(saldo, numConta, nome)
        {
        }

    }
}