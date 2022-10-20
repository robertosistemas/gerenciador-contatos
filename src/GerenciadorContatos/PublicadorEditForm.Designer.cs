namespace GerenciadorContatos
{
    partial class PublicadorEditForm
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.PublicadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCongregacao = new System.Windows.Forms.Label();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.CmbCongregacao = new System.Windows.Forms.ComboBox();
            this.CongregacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PublicadorBindingSource)).BeginInit();
            this.PnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PublicadorBindingSource, "Nome", true));
            this.TxtNome.Location = new System.Drawing.Point(92, 34);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(338, 20);
            this.TxtNome.TabIndex = 3;
            this.TxtNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNome_Validating);
            // 
            // PublicadorBindingSource
            // 
            this.PublicadorBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Publicador);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.CausesValidation = false;
            this.LblNome.Location = new System.Drawing.Point(12, 37);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // LblCongregacao
            // 
            this.LblCongregacao.AutoSize = true;
            this.LblCongregacao.CausesValidation = false;
            this.LblCongregacao.Location = new System.Drawing.Point(12, 10);
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
            this.PnlBotoes.Location = new System.Drawing.Point(0, 63);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(442, 34);
            this.PnlBotoes.TabIndex = 4;
            // 
            // BtnCancela
            // 
            this.BtnCancela.CausesValidation = false;
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
            // CmbCongregacao
            // 
            this.CmbCongregacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.PublicadorBindingSource, "CongregacaoId", true));
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
            // CongregacaoBindingSource
            // 
            this.CongregacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Congregacao);
            // 
            // PublicadorEditForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(442, 97);
            this.ControlBox = false;
            this.Controls.Add(this.CmbCongregacao);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblCongregacao);
            this.Controls.Add(this.PnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PublicadorEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Associado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PublicadorEditForm_FormClosing);
            this.Load += new System.EventHandler(this.PublicadorEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PublicadorBindingSource)).EndInit();
            this.PnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCongregacao;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.ComboBox CmbCongregacao;
        private System.Windows.Forms.BindingSource PublicadorBindingSource;
        private System.Windows.Forms.BindingSource CongregacaoBindingSource;
        private Componentes.CustomErrorProvider CustomErrorProvider;
    }
}