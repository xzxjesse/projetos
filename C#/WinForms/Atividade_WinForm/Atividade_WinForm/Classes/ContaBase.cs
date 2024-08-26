using Atividade_WinForm.Enumerados;
using Atividade_WinForm.Interfaces;

namespace Atividade_WinForm.Classes
{
    public class ContaBase : IConta
    {
        public int NumeroNota { get; set; }
        public string Fornecedor { get; set; }
        public decimal Valor { get; set; }
        public EStatusConta Status { get; set; }
    }
}
