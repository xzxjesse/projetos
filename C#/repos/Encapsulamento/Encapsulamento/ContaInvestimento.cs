using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaInvestimento : ContaBancaria
    {
        public ContaInvestimento(double saldo, int numConta, string nome) : base(saldo, numConta, nome)
        {
        }

    }
}
