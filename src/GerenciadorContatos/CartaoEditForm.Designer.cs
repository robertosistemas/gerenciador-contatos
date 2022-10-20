namespace GerenciadorContatos
{
    partial class CartaoEditForm
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
            this.LblCongregacao = new System.Windows.Forms.Label();
            this.CmbCongregacao = new System.Windows.Forms.ComboBox();
            this.CartaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CongregacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CmbOperadora = new System.Windows.Forms.ComboBox();
            this.OperadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblOperadora = new System.Windows.Forms.Label();
            this.CmbPublicador = new System.Windows.Forms.ComboBox();
            this.PublicadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblPublicador = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtFaixaNumerica = new System.Windows.Forms.TextBox();
            this.LblFaixaNumerica = new System.Windows.Forms.Label();
            this.LblDisponivel = new System.Windows.Forms.Label();
            this.ChkDisponivel = new System.Windows.Forms.CheckBox();
            this.LblDataInicio = new System.Windows.Forms.Label();
            this.LblDataFim = new System.Windows.Forms.Label();
            this.LblObservacao = new System.Windows.Forms.Label();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            this.DtpDataInicio = new GerenciadorContatos.Componentes.NullableDateTimePicker();
            this.DtpDataFim = new GerenciadorContatos.Componentes.NullableDateTimePicker();
            this.PnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.CausesValidation = false;
            this.PnlBotoes.Controls.Add(this.BtnCancela);
            this.PnlBotoes.Controls.Add(this.BtnConfirma);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotoes.Location = new System.Drawing.Point(0, 316);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(442, 34);
            this.PnlBotoes.TabIndex = 18;
            // 
            // BtnCancela
            // 
            this.BtnCancela.CausesValidation = false;
            this.BtnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancela.Image = global::GerenciadorContatos.Properties.Resources.Action_delete_icon;
            this.BtnCancela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancela.Location = new System.Drawing.Point(336, 3);
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
            this.BtnConfirma.Location = new System.Drawing.Point(238, 3);
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.Size = new System.Drawing.Size(92, 23);
            this.BtnConfirma.TabIndex = 0;
            this.BtnConfirma.Text = "Confirma";
            this.BtnConfirma.UseVisualStyleBackColor = true;
            this.BtnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // LblCongregacao
            // 
            this.LblCongregacao.AutoSize = true;
            this.LblCongregacao.Location = new System.Drawing.Point(9, 15);
            this.LblCongregacao.Name = "LblCongregacao";
            this.LblCongregacao.Size = new System.Drawing.Size(74, 13);
            this.LblCongregacao.TabIndex = 0;
            this.LblCongregacao.Text = "Associação:";
            // 
            // CmbCongregacao
            // 
            this.CmbCongregacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CartaoBindingSource, "CongregacaoId", true));
            this.CmbCongregacao.DataSource = this.CongregacaoBindingSource;
            this.CmbCongregacao.DisplayMember = "Nome";
            this.CmbCongregacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCongregacao.FormattingEnabled = true;
            this.CmbCongregacao.Location = new System.Drawing.Point(90, 12);
            this.CmbCongregacao.Name = "CmbCongregacao";
            this.CmbCongregacao.Size = new System.Drawing.Size(338, 21);
            this.CmbCongregacao.TabIndex = 1;
            this.CmbCongregacao.ValueMember = "Id";
            this.CmbCongregacao.Validating += new System.ComponentModel.CancelEventHandler(this.CmbCongregacao_Validating);
            // 
            // CartaoBindingSource
            // 
            this.CartaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Cartao);
            // 
            // CongregacaoBindingSource
            // 
            this.CongregacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Congregacao);
            // 
            // CmbOperadora
            // 
            this.CmbOperadora.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CartaoBindingSource, "OperadoraId", true));
            this.CmbOperadora.DataSource = this.OperadoraBindingSource;
            this.CmbOperadora.DisplayMember = "Nome";
            this.CmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOperadora.FormattingEnabled = true;
            this.CmbOperadora.Location = new System.Drawing.Point(90, 39);
            this.CmbOperadora.Name = "CmbOperadora";
            this.CmbOperadora.Size = new System.Drawing.Size(338, 21);
            this.CmbOperadora.TabIndex = 3;
            this.CmbOperadora.ValueMember = "Id";
            this.CmbOperadora.Validating += new System.ComponentModel.CancelEventHandler(this.CmbOperadora_Validating);
            // 
            // OperadoraBindingSource
            // 
            this.OperadoraBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Operadora);
            // 
            // LblOperadora
            // 
            this.LblOperadora.AutoSize = true;
            this.LblOperadora.Location = new System.Drawing.Point(9, 42);
            this.LblOperadora.Name = "LblOperadora";
            this.LblOperadora.Size = new System.Drawing.Size(60, 13);
            this.LblOperadora.TabIndex = 2;
            this.LblOperadora.Text = "Operadora:";
            // 
            // CmbPublicador
            // 
            this.CmbPublicador.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CartaoBindingSource, "PublicadorId", true));
            this.CmbPublicador.DataSource = this.PublicadorBindingSource;
            this.CmbPublicador.DisplayMember = "Nome";
            this.CmbPublicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPublicador.FormattingEnabled = true;
            this.CmbPublicador.Location = new System.Drawing.Point(90, 138);
            this.CmbPublicador.Name = "CmbPublicador";
            this.CmbPublicador.Size = new System.Drawing.Size(338, 21);
            this.CmbPublicador.TabIndex = 11;
            this.CmbPublicador.ValueMember = "Id";
            this.CmbPublicador.Validating += new System.ComponentModel.CancelEventHandler(this.CmbPublicador_Validating);
            // 
            // PublicadorBindingSource
            // 
            this.PublicadorBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Publicador);
            // 
            // LblPublicador
            // 
            this.LblPublicador.AutoSize = true;
            this.LblPublicador.Location = new System.Drawing.Point(9, 141);
            this.LblPublicador.Name = "LblPublicador";
            this.LblPublicador.Size = new System.Drawing.Size(60, 13);
            this.LblPublicador.TabIndex = 10;
            this.LblPublicador.Text = "Associado:";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(9, 69);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(47, 13);
            this.LblNumero.TabIndex = 4;
            this.LblNumero.Text = "Número:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CartaoBindingSource, "Numero", true));
            this.TxtNumero.Location = new System.Drawing.Point(90, 66);
            this.TxtNumero.MaxLength = 20;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(123, 20);
            this.TxtNumero.TabIndex = 5;
            this.TxtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumero_Validating);
            // 
            // TxtFaixaNumerica
            // 
            this.TxtFaixaNumerica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CartaoBindingSource, "FaixaNumerica", true));
            this.TxtFaixaNumerica.Location = new System.Drawing.Point(90, 92);
            this.TxtFaixaNumerica.MaxLength = 35;
            this.TxtFaixaNumerica.Name = "TxtFaixaNumerica";
            this.TxtFaixaNumerica.Size = new System.Drawing.Size(227, 20);
            this.TxtFaixaNumerica.TabIndex = 7;
            this.TxtFaixaNumerica.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFaixaNumerica_Validating);
            // 
            // LblFaixaNumerica
            // 
            this.LblFaixaNumerica.AutoSize = true;
            this.LblFaixaNumerica.Location = new System.Drawing.Point(9, 95);
            this.LblFaixaNumerica.Name = "LblFaixaNumerica";
            this.LblFaixaNumerica.Size = new System.Drawing.Size(81, 13);
            this.LblFaixaNumerica.TabIndex = 6;
            this.LblFaixaNumerica.Text = "Faixa numérica:";
            // 
            // LblDisponivel
            // 
            this.LblDisponivel.AutoSize = true;
            this.LblDisponivel.Location = new System.Drawing.Point(9, 118);
            this.LblDisponivel.Name = "LblDisponivel";
            this.LblDisponivel.Size = new System.Drawing.Size(61, 13);
            this.LblDisponivel.TabIndex = 8;
            this.LblDisponivel.Text = "Disponível:";
            // 
            // ChkDisponivel
            // 
            this.ChkDisponivel.AutoSize = true;
            this.ChkDisponivel.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.CartaoBindingSource, "Disponivel", true));
            this.ChkDisponivel.Location = new System.Drawing.Point(90, 118);
            this.ChkDisponivel.Name = "ChkDisponivel";
            this.ChkDisponivel.Size = new System.Drawing.Size(15, 14);
            this.ChkDisponivel.TabIndex = 9;
            this.ChkDisponivel.UseVisualStyleBackColor = true;
            this.ChkDisponivel.Validating += new System.ComponentModel.CancelEventHandler(this.ChkDisponivel_Validating);
            // 
            // LblDataInicio
            // 
            this.LblDataInicio.AutoSize = true;
            this.LblDataInicio.Location = new System.Drawing.Point(9, 172);
            this.LblDataInicio.Name = "LblDataInicio";
            this.LblDataInicio.Size = new System.Drawing.Size(62, 13);
            this.LblDataInicio.TabIndex = 12;
            this.LblDataInicio.Text = "Data início:";
            // 
            // LblDataFim
            // 
            this.LblDataFim.AutoSize = true;
            this.LblDataFim.Location = new System.Drawing.Point(9, 198);
            this.LblDataFim.Name = "LblDataFim";
            this.LblDataFim.Size = new System.Drawing.Size(49, 13);
            this.LblDataFim.TabIndex = 14;
            this.LblDataFim.Text = "Data fim:";
            // 
            // LblObservacao
            // 
            this.LblObservacao.AutoSize = true;
            this.LblObservacao.Location = new System.Drawing.Point(9, 221);
            this.LblObservacao.Name = "LblObservacao";
            this.LblObservacao.Size = new System.Drawing.Size(68, 13);
            this.LblObservacao.TabIndex = 16;
            this.LblObservacao.Text = "Observação:";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CartaoBindingSource, "Observacao", true));
            this.TxtObservacao.Location = new System.Drawing.Point(90, 218);
            this.TxtObservacao.MaxLength = 500;
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtObservacao.Size = new System.Drawing.Size(338, 91);
            this.TxtObservacao.TabIndex = 17;
            // 
            // DtpDataInicio
            // 
            this.DtpDataInicio.Checked = false;
            this.DtpDataInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CartaoBindingSource, "DataInicio", true));
            this.DtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataInicio.Location = new System.Drawing.Point(90, 166);
            this.DtpDataInicio.Name = "DtpDataInicio";
            this.DtpDataInicio.ShowCheckBox = true;
            this.DtpDataInicio.Size = new System.Drawing.Size(116, 20);
            this.DtpDataInicio.TabIndex = 13;
            this.DtpDataInicio.Value = new System.DateTime(2020, 5, 16, 15, 15, 36, 774);
            this.DtpDataInicio.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDataInicio_Validating);
            // 
            // DtpDataFim
            // 
            this.DtpDataFim.Checked = false;
            this.DtpDataFim.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CartaoBindingSource, "DataFim", true));
            this.DtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataFim.Location = new System.Drawing.Point(90, 192);
            this.DtpDataFim.Name = "DtpDataFim";
            this.DtpDataFim.ShowCheckBox = true;
            this.DtpDataFim.Size = new System.Drawing.Size(116, 20);
            this.DtpDataFim.TabIndex = 15;
            this.DtpDataFim.Value = new System.DateTime(2020, 5, 16, 15, 15, 36, 774);
            this.DtpDataFim.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDataFim_Validating);
            // 
            // CartaoEditForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(442, 350);
            this.ControlBox = false;
            this.Controls.Add(this.DtpDataFim);
            this.Controls.Add(this.DtpDataInicio);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.LblObservacao);
            this.Controls.Add(this.LblDataFim);
            this.Controls.Add(this.LblDataInicio);
            this.Controls.Add(this.ChkDisponivel);
            this.Controls.Add(this.LblDisponivel);
            this.Controls.Add(this.TxtFaixaNumerica);
            this.Controls.Add(this.LblFaixaNumerica);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.CmbPublicador);
            this.Controls.Add(this.LblPublicador);
            this.Controls.Add(this.CmbOperadora);
            this.Controls.Add(this.LblOperadora);
            this.Controls.Add(this.CmbCongregacao);
            this.Controls.Add(this.LblCongregacao);
            this.Controls.Add(this.PnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CartaoEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cartão";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CartaoEditForm_FormClosing);
            this.Load += new System.EventHandler(this.CartaoEditForm_Load);
            this.PnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource CartaoBindingSource;
        private System.Windows.Forms.BindingSource OperadoraBindingSource;
        private System.Windows.Forms.BindingSource CongregacaoBindingSource;
        private System.Windows.Forms.BindingSource PublicadorBindingSource;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.Label LblCongregacao;
        private System.Windows.Forms.ComboBox CmbCongregacao;
        private System.Windows.Forms.ComboBox CmbOperadora;
        private System.Windows.Forms.Label LblOperadora;
        private System.Windows.Forms.ComboBox CmbPublicador;
        private System.Windows.Forms.Label LblPublicador;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtFaixaNumerica;
        private System.Windows.Forms.Label LblFaixaNumerica;
        private System.Windows.Forms.Label LblDisponivel;
        private System.Windows.Forms.CheckBox ChkDisponivel;
        private System.Windows.Forms.Label LblDataInicio;
        private System.Windows.Forms.Label LblDataFim;
        private System.Windows.Forms.Label LblObservacao;
        private System.Windows.Forms.TextBox TxtObservacao;
        private Componentes.CustomErrorProvider CustomErrorProvider;
        private Componentes.NullableDateTimePicker DtpDataInicio;
        private Componentes.NullableDateTimePicker DtpDataFim;
    }
}