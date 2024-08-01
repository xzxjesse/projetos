using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public abstract class ContaBancaria
    {
        private double Saldo { get; set; }
        public int NumConta { get; set; }
        public string Nome { get; set; }


        public ContaBancaria(double saldo, int numConta, string nome)
        {
            Saldo = saldo;
            NumConta = numConta;
            Nome = nome;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor do depósito é inválido");
            }
            Saldo = +valor;
        }
        public void Sacar(double valor){
            if ((valor == 0) || (valor > Saldo))
            {
                Console.WriteLine("Valor do saque é inválido");
            }
            Saldo -= valor;
        }
    }
}