namespace Atividade_WinForm
{
    partial class FormContasReceber
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
            this.status = new System.Windows.Forms.Label();
            this.recebimento = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.fornecedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numNota = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resposta_Status = new System.Windows.Forms.ComboBox();
            this.resposta_Recebimento = new System.Windows.Forms.DateTimePicker();
            this.resposta_Valor = new System.Windows.Forms.TextBox();
            this.resposta_Fornecedor = new System.Windows.Forms.TextBox();
            this.resposta_NumNota = new System.Windows.Forms.TextBox();
            this.toolTip_NumNota = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Fornecedor = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Valor = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Vencimento = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Status = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_NumNota = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Fornecedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Valor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Recebimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Status = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NumNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Fornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Recebimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(256, 312);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 20);
            this.status.TabIndex = 27;
            this.status.Text = "Status:";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // recebimento
            // 
            this.recebimento.AutoSize = true;
            this.recebimento.Location = new System.Drawing.Point(286, 209);
            this.recebimento.Name = "recebimento";
            this.recebimento.Size = new System.Drawing.Size(108, 20);
            this.recebimento.TabIndex = 26;
            this.recebimento.Text = "Recebimento:";
            this.recebimento.Click += new System.EventHandler(this.vencimento_Click);
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(22, 210);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(50, 20);
            this.valor.TabIndex = 25;
            this.valor.Text = "Valor:";
            this.valor.Click += new System.EventHandler(this.valor_Click);
            // 
            // fornecedor
            // 
            this.fornecedor.AutoSize = true;
            this.fornecedor.Location = new System.Drawing.Point(22, 153);
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Size = new System.Drawing.Size(95, 20);
            this.fornecedor.TabIndex = 24;
            this.fornecedor.Text = "Fornecedor:";
            this.fornecedor.Click += new System.EventHandler(this.fornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cadastro de Conta a Receber";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numNota
            // 
            this.numNota.AutoSize = true;
            this.numNota.Location = new System.Drawing.Point(22, 100);
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(129, 20);
            this.numNota.TabIndex = 22;
            this.numNota.Text = "Número da Nota:";
            this.numNota.Click += new System.EventHandler(this.numNota_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 41);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.salvar_Click);
            // 
            // resposta_Status
            // 
            this.resposta_Status.FormattingEnabled = true;
            this.resposta_Status.Items.AddRange(new object[] {
            "Pendente",
            "Recebido",
            "Cancelado"});
            this.resposta_Status.Location = new System.Drawing.Point(322, 309);
            this.resposta_Status.Name = "resposta_Status";
            this.resposta_Status.Size = new System.Drawing.Size(175, 28);
            this.resposta_Status.TabIndex = 19;
            this.toolTip_Status.SetToolTip(this.resposta_Status, "Selecione o status da conta.");
            this.resposta_Status.SelectedIndexChanged += new System.EventHandler(this.resposta_Status_SelectedIndexChanged);
            // 
            // resposta_Recebimento
            // 
            this.resposta_Recebimento.Location = new System.Drawing.Point(400, 204);
            this.resposta_Recebimento.Name = "resposta_Recebimento";
            this.resposta_Recebimento.Size = new System.Drawing.Size(355, 26);
            this.resposta_Recebimento.TabIndex = 18;
            this.toolTip_Vencimento.SetToolTip(this.resposta_Recebimento, "Selecione a data de vencimento.");
            this.resposta_Recebimento.ValueChanged += new System.EventHandler(this.resposta_Vencimento_ValueChanged);
            // 
            // resposta_Valor
            // 
            this.resposta_Valor.Location = new System.Drawing.Point(86, 206);
            this.resposta_Valor.Name = "resposta_Valor";
            this.resposta_Valor.Size = new System.Drawing.Size(181, 26);
            this.resposta_Valor.TabIndex = 17;
            this.toolTip_Valor.SetToolTip(this.resposta_Valor, "Digite o valor da conta a receber.");
            this.resposta_Valor.TextChanged += new System.EventHandler(this.resposta_Valor_TextChanged);
            // 
            // resposta_Fornecedor
            // 
            this.resposta_Fornecedor.Location = new System.Drawing.Point(157, 150);
            this.resposta_Fornecedor.Name = "resposta_Fornecedor";
            this.resposta_Fornecedor.Size = new System.Drawing.Size(598, 26);
            this.resposta_Fornecedor.TabIndex = 16;
            this.toolTip_Fornecedor.SetToolTip(this.resposta_Fornecedor, "Digite o nome do fornecedor.");
            this.resposta_Fornecedor.TextChanged += new System.EventHandler(this.resposta__Fornecedor_TextChanged);
            // 
            // resposta_NumNota
            // 
            this.resposta_NumNota.Location = new System.Drawing.Point(157, 97);
            this.resposta_NumNota.Name = "resposta_NumNota";
            this.resposta_NumNota.Size = new System.Drawing.Size(598, 26);
            this.resposta_NumNota.TabIndex = 15;
            this.toolTip_NumNota.SetToolTip(this.resposta_NumNota, "Digite o número da nota.");
            this.resposta_NumNota.TextChanged += new System.EventHandler(this.resposta_NumNota_TextChanged);
            // 
            // toolTip_NumNota
            // 
            this.toolTip_NumNota.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
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
            // errorProvider_Recebimento
            // 
            this.errorProvider_Recebimento.ContainerControl = this;
            // 
            // errorProvider_Status
            // 
            this.errorProvider_Status.ContainerControl = this;
            // 
            // FormContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.status);
            this.Controls.Add(this.recebimento);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.fornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNota);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resposta_Status);
            this.Controls.Add(this.resposta_Recebimento);
            this.Controls.Add(this.resposta_Valor);
            this.Controls.Add(this.resposta_Fornecedor);
            this.Controls.Add(this.resposta_NumNota);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContasReceber";
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.FormContasReceber_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_NumNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Fornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Recebimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label recebimento;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label fornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numNota;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox resposta_Status;
        private System.Windows.Forms.DateTimePicker resposta_Recebimento;
        private System.Windows.Forms.TextBox resposta_Valor;
        private System.Windows.Forms.TextBox resposta_Fornecedor;
        private System.Windows.Forms.TextBox resposta_NumNota;
        private System.Windows.Forms.ToolTip toolTip_NumNota;
        private System.Windows.Forms.ToolTip toolTip_Fornecedor;
        private System.Windows.Forms.ToolTip toolTip_Valor;
        private System.Windows.Forms.ToolTip toolTip_Vencimento;
        private System.Windows.Forms.ToolTip toolTip_Status;
        private System.Windows.Forms.ErrorProvider errorProvider_NumNota;
        private System.Windows.Forms.ErrorProvider errorProvider_Fornecedor;
        private System.Windows.Forms.ErrorProvider errorProvider_Valor;
        private System.Windows.Forms.ErrorProvider errorProvider_Recebimento;
        private System.Windows.Forms.ErrorProvider errorProvider_Status;
    }
}