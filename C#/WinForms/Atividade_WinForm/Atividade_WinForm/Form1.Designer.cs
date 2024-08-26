namespace Atividade_WinForm
{
    partial class Atividade_WinForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminho = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraçãoToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.estoqueToolStripMenuItem1});
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(214, 34);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.emitirNotaFiscalToolStripMenuItem,
            this.PDVToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // emitirNotaFiscalToolStripMenuItem
            // 
            this.emitirNotaFiscalToolStripMenuItem.Name = "emitirNotaFiscalToolStripMenuItem";
            this.emitirNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.emitirNotaFiscalToolStripMenuItem.Text = "Emitir Nota Fiscal";
            this.emitirNotaFiscalToolStripMenuItem.Click += new System.EventHandler(this.emitirNotaFiscalToolStripMenuItem_Click);
            // 
            // PDVToolStripMenuItem
            // 
            this.PDVToolStripMenuItem.Name = "PDVToolStripMenuItem";
            this.PDVToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.PDVToolStripMenuItem.Text = "PDV";
            this.PDVToolStripMenuItem.Click += new System.EventHandler(this.PDVToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem1,
            this.contasAReceberToolStripMenuItem1,
            this.fluxoDeCaixaToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // contasAPagarToolStripMenuItem1
            // 
            this.contasAPagarToolStripMenuItem1.Name = "contasAPagarToolStripMenuItem1";
            this.contasAPagarToolStripMenuItem1.Size = new System.Drawing.Size(250, 34);
            this.contasAPagarToolStripMenuItem1.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem1.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem1_Click);
            // 
            // contasAReceberToolStripMenuItem1
            // 
            this.contasAReceberToolStripMenuItem1.Name = "contasAReceberToolStripMenuItem1";
            this.contasAReceberToolStripMenuItem1.Size = new System.Drawing.Size(250, 34);
            this.contasAReceberToolStripMenuItem1.Text = "Contas a Receber";
            this.contasAReceberToolStripMenuItem1.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem1_Click);
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            this.fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            this.fluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de Caixa";
            this.fluxoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.fluxoDeCaixaToolStripMenuItem_Click);
            // 
            // caminho
            // 
            this.caminho.AutoSize = true;
            this.caminho.Location = new System.Drawing.Point(12, 421);
            this.caminho.Name = "caminho";
            this.caminho.Size = new System.Drawing.Size(166, 20);
            this.caminho.TabIndex = 1;
            this.caminho.Text = "... / Atividade WinForm";
            this.caminho.Click += new System.EventHandler(this.caminho_Click);
            // 
            // Atividade_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caminho);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Atividade_WinForm";
            this.Text = "Atividade WinForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.Label caminho;
    }
}

