using Atividade_WinForm.Classes;
using Atividade_WinForm.Enumerados;
using Atividade_WinForm.Validacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_WinForm
{
    public partial class FormContasReceber : Form
    {
        public FormContasReceber()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vencimento_Click(object sender, EventArgs e)
        {

        }

        private void valor_Click(object sender, EventArgs e)
        {

        }

        private void fornecedor_Click(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void numNota_Click(object sender, EventArgs e)
        {

        }

        private void resposta_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resposta_Vencimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void resposta_Valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void resposta__Fornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void resposta_NumNota_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormContasReceber_Load(object sender, EventArgs e)
        {
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            // NumNota vazio ou não número
            if (string.IsNullOrEmpty(resposta_NumNota.Text) || !int.TryParse(resposta_NumNota.Text, out _))
            {
                errorProvider_NumNota.SetError(resposta_NumNota, "Este campo é obrigatório. Insira um número válido.");
            }
            else
            {
                errorProvider_NumNota.SetError(resposta_NumNota, string.Empty);
            }

            // Fornecedor vazio ou não válido
            if (string.IsNullOrEmpty(resposta_Fornecedor.Text))
            {
                errorProvider_Fornecedor.SetError(resposta_Fornecedor, "Este campo é obrigatório. Digite o nome do fornecedor.");
            }
            else
            {
                errorProvider_Fornecedor.SetError(resposta_Fornecedor, string.Empty);
            }

            // Valor vazio ou não número (aceita decimal)
            if (string.IsNullOrEmpty(resposta_Valor.Text) || !decimal.TryParse(resposta_Valor.Text, out _))
            {
                errorProvider_Valor.SetError(resposta_Valor, "Este campo é obrigatório. Insira um número válido, decimal com vígula ou inteiro.");
            }
            else
            {
                errorProvider_Valor.SetError(resposta_Valor, string.Empty);
            }

            // Vencimento maior do que hoje
            if (!DateTime.TryParse(resposta_Recebimento.Text, out DateTime vencimento) || vencimento > DateTime.Now)
            {
                errorProvider_Recebimento.SetError(resposta_Recebimento, "Este campo é obrigatório. A data de vencimento deve ser menor ou igual a data atual.");
            }
            else
            {
                errorProvider_Recebimento.SetError(resposta_Recebimento, string.Empty);
            }

            // Status vazio
            if (string.IsNullOrEmpty(resposta_Status.Text))
            {
                errorProvider_Status.SetError(resposta_Status, "Este campo é obrigatório. Selecione uma opção.");
            }
            else
            {
                errorProvider_Status.SetError(resposta_Status, string.Empty);
            }

            // criar uma instância de ContaReceber
            ContaReceber contaReceber = new ContaReceber
            {
                NumeroNota = int.TryParse(resposta_NumNota.Text, out int numeroNota) ? numeroNota : 0,
                Fornecedor = resposta_Fornecedor.Text,
                Valor = decimal.TryParse(resposta_Valor.Text, out decimal valor) ? valor : 0,
                DataRecebimento = DateTime.TryParse(resposta_Recebimento.Text, out DateTime dataRecebimento) ? dataRecebimento : DateTime.MinValue,
                Status = Enum.TryParse(resposta_Status.Text, out EStatusConta status) ? status : EStatusConta.Pendente
            };

            try
            {
                ValidacaoConta validador = new ValidacaoConta();
                validador.Validar(contaReceber);
                validador.ValidarContaBase(contaReceber);

                MessageBox.Show("Conta a pagar salva com sucesso!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void FormContasReceber_Load_1(object sender, EventArgs e)
        {

        }
    }
}
