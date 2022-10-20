namespace GerenciadorContatos
{
    partial class ContatoFiltroForm
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
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.ContatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbOperadora = new System.Windows.Forms.ComboBox();
            this.OperadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblOperadora = new System.Windows.Forms.Label();
            this.LblNumeroTelefone = new System.Windows.Forms.Label();
            this.TxtNumeroTelefone = new System.Windows.Forms.TextBox();
            this.LblPermiteLigar = new System.Windows.Forms.Label();
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            this.CmbPermiteLigar = new System.Windows.Forms.ComboBox();
            this.SimNaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCmbOperadoraLimpar = new System.Windows.Forms.Button();
            this.TxtNumeroCartao = new System.Windows.Forms.TextBox();
            this.LblNumeroCartao = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.PnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimNaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.CausesValidation = false;
            this.PnlBotoes.Controls.Add(this.BtnCancela);
            this.PnlBotoes.Controls.Add(this.BtnConfirma);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotoes.Location = new System.Drawing.Point(0, 149);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(465, 34);
            this.PnlBotoes.TabIndex = 11;
            // 
            // BtnCancela
            // 
            this.BtnCancela.CausesValidation = false;
            this.BtnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancela.Image = global::GerenciadorContatos.Properties.Resources.Action_delete_icon;
            this.BtnCancela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancela.Location = new System.Drawing.Point(364, 3);
            this.BtnCancela.Name = "BtnCancela";
            this.BtnCancela.Size = new System.Drawing.Size(92, 23);
            this.BtnCancela.TabIndex = 1;
            this.BtnCancela.Text = "Cancela";
            this.BtnCancela.UseVisualStyleBackColor = true;
            this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
            // 
            // BtnConfirma
            // 
            this.BtnConfirma.CausesValidation = false;
            this.BtnConfirma.Image = global::GerenciadorContatos.Properties.Resources.Action_ok_icon;
            this.BtnConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirma.Location = new System.Drawing.Point(266, 3);
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.Size = new System.Drawing.Size(92, 23);
            this.BtnConfirma.TabIndex = 0;
            this.BtnConfirma.Text = "Confirma";
            this.BtnConfirma.UseVisualStyleBackColor = true;
            this.BtnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // ContatoBindingSource
            // 
            this.ContatoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Dtos.ContatoFiltroDto);
            // 
            // CmbOperadora
            // 
            this.CmbOperadora.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ContatoBindingSource, "OperadoraId", true));
            this.CmbOperadora.DataSource = this.OperadoraBindingSource;
            this.CmbOperadora.DisplayMember = "Nome";
            this.CmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOperadora.FormattingEnabled = true;
            this.CmbOperadora.Location = new System.Drawing.Point(102, 12);
            this.CmbOperadora.Name = "CmbOperadora";
            this.CmbOperadora.Size = new System.Drawing.Size(299, 21);
            this.CmbOperadora.TabIndex = 1;
            this.CmbOperadora.ValueMember = "Id";
            // 
            // OperadoraBindingSource
            // 
            this.OperadoraBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Operadora);
            // 
            // LblOperadora
            // 
            this.LblOperadora.AutoSize = true;
            this.LblOperadora.Location = new System.Drawing.Point(9, 15);
            this.LblOperadora.Name = "LblOperadora";
            this.LblOperadora.Size = new System.Drawing.Size(60, 13);
            this.LblOperadora.TabIndex = 0;
            this.LblOperadora.Text = "Operadora:";
            // 
            // LblNumeroTelefone
            // 
            this.LblNumeroTelefone.AutoSize = true;
            this.LblNumeroTelefone.Location = new System.Drawing.Point(9, 69);
            this.LblNumeroTelefone.Name = "LblNumeroTelefone";
            this.LblNumeroTelefone.Size = new System.Drawing.Size(88, 13);
            this.LblNumeroTelefone.TabIndex = 5;
            this.LblNumeroTelefone.Text = "Número telefone:";
            // 
            // TxtNumeroTelefone
            // 
            this.TxtNumeroTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ContatoBindingSource, "NumeroTelefone", true));
            this.TxtNumeroTelefone.Location = new System.Drawing.Point(102, 66);
            this.TxtNumeroTelefone.MaxLength = 20;
            this.TxtNumeroTelefone.Name = "TxtNumeroTelefone";
            this.TxtNumeroTelefone.Size = new System.Drawing.Size(122, 20);
            this.TxtNumeroTelefone.TabIndex = 6;
            // 
            // LblPermiteLigar
            // 
            this.LblPermiteLigar.AutoSize = true;
            this.LblPermiteLigar.Location = new System.Drawing.Point(9, 96);
            this.LblPermiteLigar.Name = "LblPermiteLigar";
            this.LblPermiteLigar.Size = new System.Drawing.Size(67, 13);
            this.LblPermiteLigar.TabIndex = 7;
            this.LblPermiteLigar.Text = "Permite ligar:";
            // 
            // CmbPermiteLigar
            // 
            this.CmbPermiteLigar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ContatoBindingSource, "PermiteLigar", true));
            this.CmbPermiteLigar.DataSource = this.SimNaoBindingSource;
            this.CmbPermiteLigar.DisplayMember = "Texto";
            this.CmbPermiteLigar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPermiteLigar.FormattingEnabled = true;
            this.CmbPermiteLigar.Location = new System.Drawing.Point(102, 92);
            this.CmbPermiteLigar.Name = "CmbPermiteLigar";
            this.CmbPermiteLigar.Size = new System.Drawing.Size(121, 21);
            this.CmbPermiteLigar.TabIndex = 8;
            this.CmbPermiteLigar.ValueMember = "Valor";
            // 
            // SimNaoBindingSource
            // 
            this.SimNaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.SimNao);
            // 
            // BtnCmbOperadoraLimpar
            // 
            this.BtnCmbOperadoraLimpar.Location = new System.Drawing.Point(408, 12);
            this.BtnCmbOperadoraLimpar.Name = "BtnCmbOperadoraLimpar";
            this.BtnCmbOperadoraLimpar.Size = new System.Drawing.Size(48, 21);
            this.BtnCmbOperadoraLimpar.TabIndex = 2;
            this.BtnCmbOperadoraLimpar.Text = "Limpar";
            this.BtnCmbOperadoraLimpar.UseVisualStyleBackColor = true;
            this.BtnCmbOperadoraLimpar.Click += new System.EventHandler(this.BtnCmbOperadoraLimpar_Click);
            // 
            // TxtNumeroCartao
            // 
            this.TxtNumeroCartao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ContatoBindingSource, "NumeroCartao", true));
            this.TxtNumeroCartao.Location = new System.Drawing.Point(102, 39);
            this.TxtNumeroCartao.MaxLength = 20;
            this.TxtNumeroCartao.Name = "TxtNumeroCartao";
            this.TxtNumeroCartao.Size = new System.Drawing.Size(122, 20);
            this.TxtNumeroCartao.TabIndex = 4;
            // 
            // LblNumeroCartao
            // 
            this.LblNumeroCartao.AutoSize = true;
            this.LblNumeroCartao.Location = new System.Drawing.Point(9, 42);
            this.LblNumeroCartao.Name = "LblNumeroCartao";
            this.LblNumeroCartao.Size = new System.Drawing.Size(80, 13);
            this.LblNumeroCartao.TabIndex = 3;
            this.LblNumeroCartao.Text = "Número cartão:";
            // 
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ContatoBindingSource, "Nome", true));
            this.TxtNome.Location = new System.Drawing.Point(102, 119);
            this.TxtNome.MaxLength = 20;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(299, 20);
            this.TxtNome.TabIndex = 10;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(8, 122);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 9;
            this.LblNome.Text = "Nome:";
            // 
            // ContatoFiltroForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(465, 183);
            this.ControlBox = false;
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNumeroCartao);
            this.Controls.Add(this.LblNumeroCartao);
            this.Controls.Add(this.BtnCmbOperadoraLimpar);
            this.Controls.Add(this.CmbPermiteLigar);
            this.Controls.Add(this.LblPermiteLigar);
            this.Controls.Add(this.TxtNumeroTelefone);
            this.Controls.Add(this.LblNumeroTelefone);
            this.Controls.Add(this.CmbOperadora);
            this.Controls.Add(this.LblOperadora);
            this.Controls.Add(this.PnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ContatoFiltroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtro de contatos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContatoFiltroForm_FormClosing);
            this.Load += new System.EventHandler(this.CartaoEditForm_Load);
            this.PnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimNaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource OperadoraBindingSource;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.ComboBox CmbOperadora;
        private System.Windows.Forms.Label LblOperadora;
        private System.Windows.Forms.Label LblNumeroTelefone;
        private System.Windows.Forms.TextBox TxtNumeroTelefone;
        private System.Windows.Forms.Label LblPermiteLigar;
        private Componentes.CustomErrorProvider CustomErrorProvider;
        private System.Windows.Forms.BindingSource ContatoBindingSource;
        private System.Windows.Forms.ComboBox CmbPermiteLigar;
        private System.Windows.Forms.Button BtnCmbOperadoraLimpar;
        private System.Windows.Forms.BindingSource SimNaoBindingSource;
        private System.Windows.Forms.TextBox TxtNumeroCartao;
        private System.Windows.Forms.Label LblNumeroCartao;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
    }
}