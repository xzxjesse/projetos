using Atividade_WinForm.Enumerados;

namespace Atividade_WinForm.Interfaces
{
    public class IConta
    {
        public EStatusConta Status { get; set; }
        void Pagar()
        {
            Status = EStatusConta.Pago;
        }
        void Receber()
        {
            Status = EStatusConta.Recebido;
        }
    }
}
