namespace GerenciadorContatos
{
    partial class SequenciaNumericaEditForm
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
            this.CmbCongregacao = new System.Windows.Forms.ComboBox();
            this.SequenciaNumericaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CongregacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtPreFixo = new System.Windows.Forms.TextBox();
            this.LblPreFixo = new System.Windows.Forms.Label();
            this.LblCongregacao = new System.Windows.Forms.Label();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.OperadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            this.LblOperadora = new System.Windows.Forms.Label();
            this.CmbOperadora = new System.Windows.Forms.ComboBox();
            this.LblInicio = new System.Windows.Forms.Label();
            this.TxtInicio = new System.Windows.Forms.TextBox();
            this.LblFim = new System.Windows.Forms.Label();
            this.TxtFim = new System.Windows.Forms.TextBox();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtCodigoArea = new System.Windows.Forms.TextBox();
            this.LblCodigoArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaNumericaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).BeginInit();
            this.PnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbCongregacao
            // 
            this.CmbCongregacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.SequenciaNumericaBindingSource, "CongregacaoId", true));
            this.CmbCongregacao.DataSource = this.CongregacaoBindingSource;
            this.CmbCongregacao.DisplayMember = "Nome";
            this.CmbCongregacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCongregacao.FormattingEnabled = true;
            this.CmbCongregacao.Location = new System.Drawing.Point(92, 7);
            this.CmbCongregacao.Name = "CmbCongregacao";
            this.CmbCongregacao.Size = new System.Drawing.Size(338, 21);
            this.CmbCongregacao.TabIndex = 1;
            this.CmbCongregacao.ValueMember = "Id";
            this.CmbCongregacao.Validating += new System.ComponentModel.CancelEventHandler(this.CmbCongregacao_Validating);
            // 
            // SequenciaNumericaBindingSource
            // 
            this.SequenciaNumericaBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.SequenciaNumerica);
            // 
            // CongregacaoBindingSource
            // 
            this.CongregacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Congregacao);
            // 
            // TxtPreFixo
            // 
            this.TxtPreFixo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SequenciaNumericaBindingSource, "PreFixo", true));
            this.TxtPreFixo.Location = new System.Drawing.Point(92, 88);
            this.TxtPreFixo.MaxLength = 5;
            this.TxtPreFixo.Name = "TxtPreFixo";
            this.TxtPreFixo.Size = new System.Drawing.Size(79, 20);
            this.TxtPreFixo.TabIndex = 7;
            this.TxtPreFixo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPreFixo_Validating);
            // 
            // LblPreFixo
            // 
            this.LblPreFixo.AutoSize = true;
            this.LblPreFixo.CausesValidation = false;
            this.LblPreFixo.Location = new System.Drawing.Point(12, 91);
            this.LblPreFixo.Name = "LblPreFixo";
            this.LblPreFixo.Size = new System.Drawing.Size(45, 13);
            this.LblPreFixo.TabIndex = 6;
            this.LblPreFixo.Text = "Pré-fixo:";
            // 
            // LblCongregacao
            // 
            this.LblCongregacao.AutoSize = true;
            this.LblCongregacao.CausesValidation = false;
            this.LblCongregacao.Location = new System.Drawing.Point(12, 11);
            this.LblCongregacao.Name = "LblCongregacao";
            this.LblCongregacao.Size = new System.Drawing.Size(74, 13);
            this.LblCongregacao.TabIndex = 0;
            this.LblCongregacao.Text = "Associação:";
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.CausesValidation = false;
            this.PnlBotoes.Controls.Add(this.BtnCancela);
            this.PnlBotoes.Controls.Add(this.BtnConfirma);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotoes.Location = new System.Drawing.Point(0, 196);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(442, 34);
            this.PnlBotoes.TabIndex = 14;
            // 
            // BtnCancela
            // 
            this.BtnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancela.Image = global::GerenciadorContatos.Properties.Resources.Action_delete_icon;
            this.BtnCancela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancela.Location = new System.Drawing.Point(338, 3);
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
            this.BtnConfirma.Location = new System.Drawing.Point(240, 3);
            this.BtnConfirma.Name = "BtnConfirma";
            this.BtnConfirma.Size = new System.Drawing.Size(92, 23);
            this.BtnConfirma.TabIndex = 0;
            this.BtnConfirma.Text = "Confirma";
            this.BtnConfirma.UseVisualStyleBackColor = true;
            this.BtnConfirma.Click += new System.EventHandler(this.BtnConfirma_Click);
            // 
            // OperadoraBindingSource
            // 
            this.OperadoraBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Operadora);
            // 
            // LblOperadora
            // 
            this.LblOperadora.AutoSize = true;
            this.LblOperadora.Location = new System.Drawing.Point(12, 37);
            this.LblOperadora.Name = "LblOperadora";
            this.LblOperadora.Size = new System.Drawing.Size(60, 13);
            this.LblOperadora.TabIndex = 2;
            this.LblOperadora.Text = "Operadora:";
            // 
            // CmbOperadora
            // 
            this.CmbOperadora.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.SequenciaNumericaBindingSource, "OperadoraId", true));
            this.CmbOperadora.DataSource = this.OperadoraBindingSource;
            this.CmbOperadora.DisplayMember = "Nome";
            this.CmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOperadora.FormattingEnabled = true;
            this.CmbOperadora.Location = new System.Drawing.Point(92, 34);
            this.CmbOperadora.Name = "CmbOperadora";
            this.CmbOperadora.Size = new System.Drawing.Size(338, 21);
            this.CmbOperadora.TabIndex = 3;
            this.CmbOperadora.ValueMember = "Id";
            this.CmbOperadora.Validating += new System.ComponentModel.CancelEventHandler(this.CmbOperadora_Validating);
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Location = new System.Drawing.Point(12, 118);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(37, 13);
            this.LblInicio.TabIndex = 8;
            this.LblInicio.Text = "Início:";
            // 
            // TxtInicio
            // 
            this.TxtInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SequenciaNumericaBindingSource, "Inicio", true));
            this.TxtInicio.Location = new System.Drawing.Point(92, 115);
            this.TxtInicio.MaxLength = 6;
            this.TxtInicio.Name = "TxtInicio";
            this.TxtInicio.Size = new System.Drawing.Size(79, 20);
            this.TxtInicio.TabIndex = 9;
            this.TxtInicio.Validating += new System.ComponentModel.CancelEventHandler(this.TxtInicio_Validating);
            // 
            // LblFim
            // 
            this.LblFim.AutoSize = true;
            this.LblFim.Location = new System.Drawing.Point(12, 144);
            this.LblFim.Name = "LblFim";
            this.LblFim.Size = new System.Drawing.Size(26, 13);
            this.LblFim.TabIndex = 10;
            this.LblFim.Text = "Fim:";
            // 
            // TxtFim
            // 
            this.TxtFim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SequenciaNumericaBindingSource, "Fim", true));
            this.TxtFim.Location = new System.Drawing.Point(92, 141);
            this.TxtFim.MaxLength = 6;
            this.TxtFim.Name = "TxtFim";
            this.TxtFim.Size = new System.Drawing.Size(79, 20);
            this.TxtFim.TabIndex = 11;
            this.TxtFim.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFim_Validating);
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Location = new System.Drawing.Point(12, 170);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.LblQuantidade.TabIndex = 12;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SequenciaNumericaBindingSource, "QuantidadeTelefonesCartao", true));
            this.TxtQuantidade.Location = new System.Drawing.Point(92, 167);
            this.TxtQuantidade.MaxLength = 6;
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(79, 20);
            this.TxtQuantidade.TabIndex = 13;
            this.TxtQuantidade.Validating += new System.ComponentModel.CancelEventHandler(this.TxtQuantidade_Validating);
            // 
            // TxtCodigoArea
            // 
            this.TxtCodigoArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SequenciaNumericaBindingSource, "CodigoArea", true));
            this.TxtCodigoArea.Location = new System.Drawing.Point(92, 62);
            this.TxtCodigoArea.MaxLength = 3;
            this.TxtCodigoArea.Name = "TxtCodigoArea";
            this.TxtCodigoArea.Size = new System.Drawing.Size(79, 20);
            this.TxtCodigoArea.TabIndex = 5;
            this.TxtCodigoArea.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigoArea_Validating);
            // 
            // LblCodigoArea
            // 
            this.LblCodigoArea.AutoSize = true;
            this.LblCodigoArea.CausesValidation = false;
            this.LblCodigoArea.Location = new System.Drawing.Point(12, 65);
            this.LblCodigoArea.Name = "LblCodigoArea";
            this.LblCodigoArea.Size = new System.Drawing.Size(67, 13);
            this.LblCodigoArea.TabIndex = 4;
            this.LblCodigoArea.Text = "Código área:";
            // 
            // SequenciaNumericaEditForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(442, 230);
            this.ControlBox = false;
            this.Controls.Add(this.TxtCodigoArea);
            this.Controls.Add(this.LblCodigoArea);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.LblQuantidade);
            this.Controls.Add(this.TxtFim);
            this.Controls.Add(this.LblFim);
            this.Controls.Add(this.TxtInicio);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.CmbOperadora);
            this.Controls.Add(this.LblOperadora);
            this.Controls.Add(this.CmbCongregacao);
            this.Controls.Add(this.TxtPreFixo);
            this.Controls.Add(this.LblPreFixo);
            this.Controls.Add(this.LblCongregacao);
            this.Controls.Add(this.PnlBotoes);
            this.Name = "SequenciaNumericaEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sequência númerica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SequenciaNumericaEditForm_FormClosing);
            this.Load += new System.EventHandler(this.SequenciaNumericaEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaNumericaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).EndInit();
            this.PnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbCongregacao;
        private System.Windows.Forms.TextBox TxtPreFixo;
        private System.Windows.Forms.Label LblPreFixo;
        private System.Windows.Forms.Label LblCongregacao;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.BindingSource SequenciaNumericaBindingSource;
        private System.Windows.Forms.BindingSource CongregacaoBindingSource;
        private System.Windows.Forms.BindingSource OperadoraBindingSource;
        private Componentes.CustomErrorProvider CustomErrorProvider;
        private System.Windows.Forms.Label LblOperadora;
        private System.Windows.Forms.ComboBox CmbOperadora;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.TextBox TxtInicio;
        private System.Windows.Forms.Label LblFim;
        private System.Windows.Forms.TextBox TxtFim;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtCodigoArea;
        private System.Windows.Forms.Label LblCodigoArea;
    }
}