namespace GerenciadorContatos
{
    partial class CartaoFiltroForm
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
            this.LblDisponivel = new System.Windows.Forms.Label();
            this.LblDataInicio = new System.Windows.Forms.Label();
            this.LblDataFim = new System.Windows.Forms.Label();
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            this.CmbDisponivel = new System.Windows.Forms.ComboBox();
            this.SimNaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCmbCongregacaoLimpar = new System.Windows.Forms.Button();
            this.BtnCmbOperadoraLimpar = new System.Windows.Forms.Button();
            this.BtnCmbPublicadorLimpar = new System.Windows.Forms.Button();
            this.DtpDataInicio = new GerenciadorContatos.Componentes.NullableDateTimePicker();
            this.DtpDataFim = new GerenciadorContatos.Componentes.NullableDateTimePicker();
            this.PnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimNaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.CausesValidation = false;
            this.PnlBotoes.Controls.Add(this.BtnCancela);
            this.PnlBotoes.Controls.Add(this.BtnConfirma);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotoes.Location = new System.Drawing.Point(0, 201);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(455, 34);
            this.PnlBotoes.TabIndex = 17;
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
            this.CmbCongregacao.Size = new System.Drawing.Size(299, 21);
            this.CmbCongregacao.TabIndex = 1;
            this.CmbCongregacao.ValueMember = "Id";
            // 
            // CartaoBindingSource
            // 
            this.CartaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Dtos.CartaoFiltroDto);
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
            this.CmbOperadora.Size = new System.Drawing.Size(299, 21);
            this.CmbOperadora.TabIndex = 4;
            this.CmbOperadora.ValueMember = "Id";
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
            this.LblOperadora.TabIndex = 3;
            this.LblOperadora.Text = "Operadora:";
            // 
            // CmbPublicador
            // 
            this.CmbPublicador.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CartaoBindingSource, "PublicadorId", true));
            this.CmbPublicador.DataSource = this.PublicadorBindingSource;
            this.CmbPublicador.DisplayMember = "Nome";
            this.CmbPublicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPublicador.FormattingEnabled = true;
            this.CmbPublicador.Location = new System.Drawing.Point(90, 120);
            this.CmbPublicador.Name = "CmbPublicador";
            this.CmbPublicador.Size = new System.Drawing.Size(299, 21);
            this.CmbPublicador.TabIndex = 11;
            this.CmbPublicador.ValueMember = "Id";
            // 
            // PublicadorBindingSource
            // 
            this.PublicadorBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Publicador);
            // 
            // LblPublicador
            // 
            this.LblPublicador.AutoSize = true;
            this.LblPublicador.Location = new System.Drawing.Point(9, 123);
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
            this.LblNumero.TabIndex = 6;
            this.LblNumero.Text = "Número:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CartaoBindingSource, "Numero", true));
            this.TxtNumero.Location = new System.Drawing.Point(90, 66);
            this.TxtNumero.MaxLength = 20;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(123, 20);
            this.TxtNumero.TabIndex = 7;
            // 
            // LblDisponivel
            // 
            this.LblDisponivel.AutoSize = true;
            this.LblDisponivel.Location = new System.Drawing.Point(9, 96);
            this.LblDisponivel.Name = "LblDisponivel";
            this.LblDisponivel.Size = new System.Drawing.Size(61, 13);
            this.LblDisponivel.TabIndex = 8;
            this.LblDisponivel.Text = "Disponível:";
            // 
            // LblDataInicio
            // 
            this.LblDataInicio.AutoSize = true;
            this.LblDataInicio.Location = new System.Drawing.Point(9, 154);
            this.LblDataInicio.Name = "LblDataInicio";
            this.LblDataInicio.Size = new System.Drawing.Size(62, 13);
            this.LblDataInicio.TabIndex = 13;
            this.LblDataInicio.Text = "Data início:";
            // 
            // LblDataFim
            // 
            this.LblDataFim.AutoSize = true;
            this.LblDataFim.Location = new System.Drawing.Point(9, 180);
            this.LblDataFim.Name = "LblDataFim";
            this.LblDataFim.Size = new System.Drawing.Size(49, 13);
            this.LblDataFim.TabIndex = 15;
            this.LblDataFim.Text = "Data fim:";
            // 
            // CmbDisponivel
            // 
            this.CmbDisponivel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CartaoBindingSource, "Disponivel", true));
            this.CmbDisponivel.DataSource = this.SimNaoBindingSource;
            this.CmbDisponivel.DisplayMember = "Texto";
            this.CmbDisponivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDisponivel.FormattingEnabled = true;
            this.CmbDisponivel.Location = new System.Drawing.Point(90, 92);
            this.CmbDisponivel.Name = "CmbDisponivel";
            this.CmbDisponivel.Size = new System.Drawing.Size(121, 21);
            this.CmbDisponivel.TabIndex = 9;
            this.CmbDisponivel.ValueMember = "Valor";
            // 
            // SimNaoBindingSource
            // 
            this.SimNaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.SimNao);
            // 
            // BtnCmbCongregacaoLimpar
            // 
            this.BtnCmbCongregacaoLimpar.Location = new System.Drawing.Point(395, 12);
            this.BtnCmbCongregacaoLimpar.Name = "BtnCmbCongregacaoLimpar";
            this.BtnCmbCongregacaoLimpar.Size = new System.Drawing.Size(48, 21);
            this.BtnCmbCongregacaoLimpar.TabIndex = 2;
            this.BtnCmbCongregacaoLimpar.Text = "Limpar";
            this.BtnCmbCongregacaoLimpar.UseVisualStyleBackColor = true;
            this.BtnCmbCongregacaoLimpar.Click += new System.EventHandler(this.BtnCmbCongregacaoLimpar_Click);
            // 
            // BtnCmbOperadoraLimpar
            // 
            this.BtnCmbOperadoraLimpar.Location = new System.Drawing.Point(395, 39);
            this.BtnCmbOperadoraLimpar.Name = "BtnCmbOperadoraLimpar";
            this.BtnCmbOperadoraLimpar.Size = new System.Drawing.Size(48, 21);
            this.BtnCmbOperadoraLimpar.TabIndex = 5;
            this.BtnCmbOperadoraLimpar.Text = "Limpar";
            this.BtnCmbOperadoraLimpar.UseVisualStyleBackColor = true;
            this.BtnCmbOperadoraLimpar.Click += new System.EventHandler(this.BtnCmbOperadoraLimpar_Click);
            // 
            // BtnCmbPublicadorLimpar
            // 
            this.BtnCmbPublicadorLimpar.Location = new System.Drawing.Point(395, 120);
            this.BtnCmbPublicadorLimpar.Name = "BtnCmbPublicadorLimpar";
            this.BtnCmbPublicadorLimpar.Size = new System.Drawing.Size(48, 21);
            this.BtnCmbPublicadorLimpar.TabIndex = 12;
            this.BtnCmbPublicadorLimpar.Text = "Limpar";
            this.BtnCmbPublicadorLimpar.UseVisualStyleBackColor = true;
            this.BtnCmbPublicadorLimpar.Click += new System.EventHandler(this.BtnCmbPublicadorLimpar_Click);
            // 
            // DtpDataInicio
            // 
            this.DtpDataInicio.Checked = false;
            this.DtpDataInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CartaoBindingSource, "DataInicio", true));
            this.DtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataInicio.Location = new System.Drawing.Point(90, 148);
            this.DtpDataInicio.Name = "DtpDataInicio";
            this.DtpDataInicio.ShowCheckBox = true;
            this.DtpDataInicio.Size = new System.Drawing.Size(123, 20);
            this.DtpDataInicio.TabIndex = 14;
            this.DtpDataInicio.Value = new System.DateTime(2020, 5, 16, 16, 46, 4, 45);
            // 
            // DtpDataFim
            // 
            this.DtpDataFim.Checked = false;
            this.DtpDataFim.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CartaoBindingSource, "DataFim", true));
            this.DtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataFim.Location = new System.Drawing.Point(90, 174);
            this.DtpDataFim.Name = "DtpDataFim";
            this.DtpDataFim.ShowCheckBox = true;
            this.DtpDataFim.Size = new System.Drawing.Size(123, 20);
            this.DtpDataFim.TabIndex = 16;
            this.DtpDataFim.Value = new System.DateTime(2020, 5, 16, 16, 46, 10, 548);
            // 
            // CartaoFiltroForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(455, 235);
            this.ControlBox = false;
            this.Controls.Add(this.DtpDataFim);
            this.Controls.Add(this.DtpDataInicio);
            this.Controls.Add(this.BtnCmbPublicadorLimpar);
            this.Controls.Add(this.BtnCmbOperadoraLimpar);
            this.Controls.Add(this.BtnCmbCongregacaoLimpar);
            this.Controls.Add(this.CmbDisponivel);
            this.Controls.Add(this.LblDataFim);
            this.Controls.Add(this.LblDataInicio);
            this.Controls.Add(this.LblDisponivel);
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
            this.Name = "CartaoFiltroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtro de cartões";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CartaoFiltroForm_FormClosing);
            this.Load += new System.EventHandler(this.CartaoEditForm_Load);
            this.PnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimNaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label LblDisponivel;
        private System.Windows.Forms.Label LblDataInicio;
        private System.Windows.Forms.Label LblDataFim;
        private Componentes.CustomErrorProvider CustomErrorProvider;
        private System.Windows.Forms.BindingSource CartaoBindingSource;
        private System.Windows.Forms.ComboBox CmbDisponivel;
        private System.Windows.Forms.Button BtnCmbCongregacaoLimpar;
        private System.Windows.Forms.Button BtnCmbOperadoraLimpar;
        private System.Windows.Forms.Button BtnCmbPublicadorLimpar;
        private System.Windows.Forms.BindingSource SimNaoBindingSource;
        private Componentes.NullableDateTimePicker DtpDataInicio;
        private Componentes.NullableDateTimePicker DtpDataFim;
    }
}