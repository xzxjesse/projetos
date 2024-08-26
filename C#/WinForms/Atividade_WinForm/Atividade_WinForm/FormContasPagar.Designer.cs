namespace Atividade_WinForm
{
    partial class FormContasPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resposta_NumNota = new System.Windows.Forms.TextBox();
            this.resposta_Fornecedor = new System.Windows.Forms.TextBox();
            this.resposta_Valor = new System.Windows.Forms.TextBox();
            this.resposta_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.resposta_Status = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numNota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fornecedor = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.vencimento = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.toolTip_NumNota = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Fornecedor = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Valor = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Vencimento = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Status = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_NumNota = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Fornecedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Valor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Vencimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Status = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NumNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Fornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Vencimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // resposta_NumNota
            // 
            this.resposta_NumNota.Location = new System.Drawing.Point(166, 107);
            this.resposta_NumNota.Name = "resposta_NumNota";
            this.resposta_NumNota.Size = new System.Drawing.Size(598, 26);
            this.resposta_NumNota.TabIndex = 0;
            this.toolTip_NumNota.SetToolTip(this.resposta_NumNota, "Digite o número da nota.");
            this.resposta_NumNota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.resposta_NumNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resposta_NumNota_KeyPress);
            // 
            // resposta_Fornecedor
            // 
            this.resposta_Fornecedor.Location = new System.Drawing.Point(166, 160);
            this.resposta_Fornecedor.Name = "resposta_Fornecedor";
            this.resposta_Fornecedor.Size = new System.Drawing.Size(598, 26);
            this.resposta_Fornecedor.TabIndex = 1;
            this.toolTip_Fornecedor.SetToolTip(this.resposta_Fornecedor, "Digite o nome do fornecedor.");
            this.resposta_Fornecedor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // resposta_Valor
            // 
            this.resposta_Valor.Location = new System.Drawing.Point(95, 216);
            this.resposta_Valor.Name = "resposta_Valor";
            this.resposta_Valor.Size = new System.Drawing.Size(181, 26);
            this.resposta_Valor.TabIndex = 2;
            this.toolTip_Valor.SetToolTip(this.resposta_Valor, "Digite o valor da conta a pagar.");
            this.resposta_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resposta_Valor_KeyPress);
            // 
            // resposta_Vencimento
            // 
            this.resposta_Vencimento.Location = new System.Drawing.Point(409, 214);
            this.resposta_Vencimento.Name = "resposta_Vencimento";
            this.resposta_Vencimento.Size = new System.Drawing.Size(355, 26);
            this.resposta_Vencimento.TabIndex = 3;
            this.toolTip_Vencimento.SetToolTip(this.resposta_Vencimento, "Selecione a data de vencimento.");
            // 
            // resposta_Status
            // 
            this.resposta_Status.FormattingEnabled = true;
            this.resposta_Status.Items.AddRange(new object[] {
            "Pendente",
            "Pago",
            "Cancelado"});
            this.resposta_Status.Location = new System.Drawing.Point(331, 319);
            this.resposta_Status.Name = "resposta_Status";
            this.resposta_Status.Size = new System.Drawing.Size(175, 28);
            this.resposta_Status.TabIndex = 4;
            this.toolTip_Status.SetToolTip(this.resposta_Status, "Selecione o status da conta.");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.salvar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // numNota
            // 
            this.numNota.AutoSize = true;
            this.numNota.Location = new System.Drawing.Point(31, 110);
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(129, 20);
            this.numNota.TabIndex = 9;
            this.numNota.Text = "Número da Nota:";
            this.numNota.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastro de Conta a Pagar";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fornecedor
            // 
            this.fornecedor.AutoSize = true;
            this.fornecedor.Location = new System.Drawing.Point(31, 163);
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Size = new System.Drawing.Size(95, 20);
            this.fornecedor.TabIndex = 11;
            this.fornecedor.Text = "Fornecedor:";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(31, 220);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(50, 20);
            this.valor.TabIndex = 12;
            this.valor.Text = "Valor:";
            // 
            // vencimento
            // 
            this.vencimento.AutoSize = true;
            this.vencimento.Location = new System.Drawing.Point(295, 219);
            this.vencimento.Name = "vencimento";
            this.vencimento.Size = new System.Drawing.Size(98, 20);
            this.vencimento.TabIndex = 13;
            this.vencimento.Text = "Vencimento:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(265, 322);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 20);
            this.status.TabIndex = 14;
            this.status.Text = "Status:";
            // 
            // errorProvider_NumNota
            // 
            this.errorProvider_NumNota.ContainerControl = this;
            // 
            // errorProvider_Fornecedor
            // 
            this.errorProvider_Fornecedor.ContainerControl = this;
            // 
            // errorProvider_Valor
            // 
            this.errorProvider_Valor.ContainerControl = this;
            // 
            // errorProvider_Vencimento
            // 
            this.errorProvider_Vencimento.ContainerControl = this;
            // 
            // errorProvider_Status
            // 
            this.errorProvider_Status.ContainerControl = this;
            // 
            // FormContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.status);
            this.Controls.Add(this.vencimento);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.fornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNota);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resposta_Status);
            this.Controls.Add(this.resposta_Vencimento);
            this.Controls.Add(this.resposta_Valor);
            this.Controls.Add(this.resposta_Fornecedor);
            this.Controls.Add(this.resposta_NumNota);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContasPagar";
            this.Text = "Contas a Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NumNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Fornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Vencimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resposta_NumNota;
        private System.Windows.Forms.TextBox resposta_Fornecedor;
        private System.Windows.Forms.TextBox resposta_Valor;
        private System.Windows.Forms.DateTimePicker resposta_Vencimento;
        private System.Windows.Forms.ComboBox resposta_Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label numNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fornecedor;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label vencimento;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ToolTip toolTip_NumNota;
        private System.Windows.Forms.ToolTip toolTip_Fornecedor;
        private System.Windows.Forms.ToolTip toolTip_Valor;
        private System.Windows.Forms.ToolTip toolTip_Vencimento;
        private System.Windows.Forms.ToolTip toolTip_Status;
        private System.Windows.Forms.ErrorProvider errorProvider_NumNota;
        private System.Windows.Forms.ErrorProvider errorProvider_Fornecedor;
        private System.Windows.Forms.ErrorProvider errorProvider_Valor;
        private System.Windows.Forms.ErrorProvider errorProvider_Vencimento;
        private System.Windows.Forms.ErrorProvider errorProvider_Status;
    }
}