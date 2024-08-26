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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividade_WinForm
{
    public partial class FormContasPagar : Form
    {
        public FormContasPagar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
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
            if (!DateTime.TryParse(resposta_Vencimento.Text, out DateTime vencimento) || vencimento > DateTime.Now)
            {
                errorProvider_Vencimento.SetError(resposta_Vencimento, "Este campo é obrigatório. A data de vencimento deve ser menor ou igual a data atual.");
            }
            else
            {
                errorProvider_Vencimento.SetError(resposta_Vencimento, string.Empty);
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

            // criar uma instância de ContaPagar
            ContaPagar contaPagar = new ContaPagar
            {
                NumeroNota = int.TryParse(resposta_NumNota.Text, out int numeroNota) ? numeroNota : 0,
                Fornecedor = resposta_Fornecedor.Text,
                Valor = decimal.TryParse(resposta_Valor.Text, out decimal valor) ? valor : 0,
                DataVencimento = DateTime.TryParse(resposta_Vencimento.Text, out DateTime dataVencimento) ? dataVencimento : DateTime.MinValue,
                Status = Enum.TryParse(resposta_Status.Text, out EStatusConta status) ? status : EStatusConta.Pendente
            };

            try
            {
                ValidacaoConta validador = new ValidacaoConta();
                validador.Validar(contaPagar);
                validador.ValidarContaBase(contaPagar);

                MessageBox.Show("Conta a pagar salva com sucesso!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resposta_NumNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica e bloqueia se não for número

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void resposta_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um número, uma vírgula, ou uma tecla de controle como Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                // Se não for um número, vírgula ou tecla de controle, cancela o evento para evitar que o caractere seja inserido
                e.Handled = true;
            }

            // Permite apenas uma vírgula (para decimal)
            if (e.KeyChar == ',' && (sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true; // Cancela o evento se já houver uma vírgula no TextBox
            }
        }
    }
}
