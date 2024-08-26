using Atividade_WinForm.Classes;
using Atividade_WinForm.Enumerados;
using System;

namespace Atividade_WinForm.Validacao
{
    public class ValidacaoConta
    {
        // conta a pagar
        public void Validar(ContaPagar conta)
        {
            if (conta.DataVencimento > DateTime.Now)
                throw new ArgumentException("A data de vencimento não pode ser maior que a data atual.");
        }

        // conta a receber
        public void Validar(ContaReceber conta)
        {
            if (conta.DataRecebimento > DateTime.Now)
                throw new ArgumentException("A data de recebimento não pode ser maior que a data atual.");
        }

        // padrao
        public void ValidarContaBase(ContaBase conta)
        {
            if (conta.Valor <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");

            if (string.IsNullOrWhiteSpace(conta.Fornecedor))
                throw new ArgumentException("O campo fornecedor é obrigatório.");
        }
    }
}
