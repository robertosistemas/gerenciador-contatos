namespace GerenciadorContatos
{
    partial class ContatoEditForm
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
            this.ContatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OperadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CartaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbCartao = new System.Windows.Forms.ComboBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCartao = new System.Windows.Forms.Label();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.LblOperadora = new System.Windows.Forms.Label();
            this.CmbOperadora = new System.Windows.Forms.ComboBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.PermiteLigarCheckBox = new System.Windows.Forms.CheckBox();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.LblObservacao = new System.Windows.Forms.Label();
            this.LblPermiteLigar = new System.Windows.Forms.Label();
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ContatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartaoBindingSource)).BeginInit();
            this.PnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContatoBindingSource
            // 
            this.ContatoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Contato);
            // 
            // OperadoraBindingSource
            // 
            this.OperadoraBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Operadora);
            // 
            // CartaoBindingSource
            // 
            this.CartaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Cartao);
            // 
            // CmbCartao
            // 
            this.CmbCartao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ContatoBindingSource, "CartaoId", true));
            this.CmbCartao.DataSource = this.CartaoBindingSource;
            this.CmbCartao.DisplayMember = "Numero";
            this.CmbCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCartao.FormattingEnabled = true;
            this.CmbCartao.Location = new System.Drawing.Point(106, 37);
            this.CmbCartao.Name = "CmbCartao";
            this.CmbCartao.Size = new System.Drawing.Size(338, 21);
            this.CmbCartao.TabIndex = 3;
            this.CmbCartao.ValueMember = "Id";
            this.CmbCartao.Validating += new System.ComponentModel.CancelEventHandler(this.CmbCartao_Validating);
            // 
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ContatoBindingSource, "Nome", true));
            this.TxtNome.Location = new System.Drawing.Point(106, 111);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(338, 20);
            this.TxtNome.TabIndex = 9;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.CausesValidation = false;
            this.LblNome.Location = new System.Drawing.Point(12, 114);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 8;
            this.LblNome.Text = "Nome:";
            // 
            // LblCartao
            // 
            this.LblCartao.AutoSize = true;
            this.LblCartao.CausesValidation = false;
            this.LblCartao.Location = new System.Drawing.Point(12, 40);
            this.LblCartao.Name = "LblCartao";
            this.LblCartao.Size = new System.Drawing.Size(41, 13);
            this.LblCartao.TabIndex = 2;
            this.LblCartao.Text = "Cartão:";
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.CausesValidation = false;
            this.PnlBotoes.Controls.Add(this.BtnCancela);
            this.PnlBotoes.Controls.Add(this.BtnConfirma);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotoes.Location = new System.Drawing.Point(0, 226);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(461, 34);
            this.PnlBotoes.TabIndex = 12;
            // 
            // BtnCancela
            // 
            this.BtnCancela.CausesValidation = false;
            this.BtnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancela.Image = global::GerenciadorContatos.Properties.Resources.Action_delete_icon;
            this.BtnCancela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancela.Location = new System.Drawing.Point(351, 3);
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
            this.BtnConfirma.Location = new System.Drawing.Point(253, 3);
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.Size = new System.Drawing.Size(92, 23);
            this.BtnConfirma.TabIndex = 0;
            this.BtnConfirma.Text = "Confirma";
            this.BtnConfirma.UseVisualStyleBackColor = true;
            this.BtnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // LblOperadora
            // 
            this.LblOperadora.AutoSize = true;
            this.LblOperadora.Location = new System.Drawing.Point(12, 13);
            this.LblOperadora.Name = "LblOperadora";
            this.LblOperadora.Size = new System.Drawing.Size(60, 13);
            this.LblOperadora.TabIndex = 0;
            this.LblOperadora.Text = "Operadora:";
            // 
            // CmbOperadora
            // 
            this.CmbOperadora.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ContatoBindingSource, "OperadoraId", true));
            this.CmbOperadora.DataSource = this.OperadoraBindingSource;
            this.CmbOperadora.DisplayMember = "Nome";
            this.CmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOperadora.FormattingEnabled = true;
            this.CmbOperadora.Location = new System.Drawing.Point(106, 10);
            this.CmbOperadora.Name = "CmbOperadora";
            this.CmbOperadora.Size = new System.Drawing.Size(338, 21);
            this.CmbOperadora.TabIndex = 1;
            this.CmbOperadora.ValueMember = "Id";
            this.CmbOperadora.Validating += new System.ComponentModel.CancelEventHandler(this.CmbOperadora_Validating);
            // 
            // TxtNumero
            // 
            this.TxtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ContatoBindingSource, "Numero", true));
            this.TxtNumero.Location = new System.Drawing.Point(106, 64);
            this.TxtNumero.MaxLength = 20;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(179, 20);
            this.TxtNumero.TabIndex = 5;
            this.TxtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumero_Validating);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.CausesValidation = false;
            this.LblNumero.Location = new System.Drawing.Point(12, 67);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(88, 13);
            this.LblNumero.TabIndex = 4;
            this.LblNumero.Text = "Número telefone:";
            // 
            // PermiteLigarCheckBox
            // 
            this.PermiteLigarCheckBox.AutoSize = true;
            this.PermiteLigarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ContatoBindingSource, "PermiteLigar", true));
            this.PermiteLigarCheckBox.Location = new System.Drawing.Point(106, 91);
            this.PermiteLigarCheckBox.Name = "PermiteLigarCheckBox";
            this.PermiteLigarCheckBox.Size = new System.Drawing.Size(15, 14);
            this.PermiteLigarCheckBox.TabIndex = 7;
            this.PermiteLigarCheckBox.UseVisualStyleBackColor = true;
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ContatoBindingSource, "Observacao", true));
            this.TxtObservacao.Location = new System.Drawing.Point(105, 137);
            this.TxtObservacao.MaxLength = 500;
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtObservacao.Size = new System.Drawing.Size(338, 76);
            this.TxtObservacao.TabIndex = 11;
            // 
            // LblObservacao
            // 
            this.LblObservacao.AutoSize = true;
            this.LblObservacao.CausesValidation = false;
            this.LblObservacao.Location = new System.Drawing.Point(12, 140);
            this.LblObservacao.Name = "LblObservacao";
            this.LblObservacao.Size = new System.Drawing.Size(68, 13);
            this.LblObservacao.TabIndex = 10;
            this.LblObservacao.Text = "Observação:";
            // 
            // LblPermiteLigar
            // 
            this.LblPermiteLigar.AutoSize = true;
            this.LblPermiteLigar.Location = new System.Drawing.Point(12, 92);
            this.LblPermiteLigar.Name = "LblPermiteLigar";
            this.LblPermiteLigar.Size = new System.Drawing.Size(67, 13);
            this.LblPermiteLigar.TabIndex = 6;
            this.LblPermiteLigar.Text = "Permite ligar:";
            // 
            // ContatoEditForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(461, 260);
            this.Controls.Add(this.LblPermiteLigar);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.LblObservacao);
            this.Controls.Add(this.PermiteLigarCheckBox);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.CmbOperadora);
            this.Controls.Add(this.LblOperadora);
            this.Controls.Add(this.CmbCartao);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblCartao);
            this.Controls.Add(this.PnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ContatoEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContatoEditForm_FormClosing);
            this.Load += new System.EventHandler(this.ContatoEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartaoBindingSource)).EndInit();
            this.PnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ContatoBindingSource;
        private System.Windows.Forms.BindingSource OperadoraBindingSource;
        private System.Windows.Forms.BindingSource CartaoBindingSource;
        private System.Windows.Forms.ComboBox CmbCartao;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCartao;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.Label LblOperadora;
        private System.Windows.Forms.ComboBox CmbOperadora;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.CheckBox PermiteLigarCheckBox;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Label LblObservacao;
        private System.Windows.Forms.Label LblPermiteLigar;
        private Componentes.CustomErrorProvider CustomErrorProvider;
    }
}