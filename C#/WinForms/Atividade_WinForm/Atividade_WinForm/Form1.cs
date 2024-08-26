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
    public partial class Atividade_WinForm : Form
    {
        public Atividade_WinForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void caminho_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Administração/Clientes";
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Administração/Funcionários";
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            caminho.Text = "Administração/Estoque";
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Vendas/Pedidos";
        }

        private void emitirNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Vendas/Emitir Nota Fiscal";
        }

        private void PDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Vendas/PDV";
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Financeiro/Contas a Pagar";
            FormContasPagar formContasPagar = new FormContasPagar();
            formContasPagar.ShowDialog();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Financeiro/Contas a Receber";
            FormContasReceber formContasReceber = new FormContasReceber();
            formContasReceber.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Financeiro/Relatórios";
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            caminho.Text = "Financeiro/Relatórios/Contas a Pagar";
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            caminho.Text = "Financeiro/Relatórios/Contas a Receber";
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caminho.Text = "Financeiro/Relatórios/Fluxo de Caixa";
        }
    }
}
