namespace GerenciadorContatos
{
    partial class UnidadeFederacaoEditForm
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
            this.UnidadeFederacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtSigla = new System.Windows.Forms.TextBox();
            this.LblSigla = new System.Windows.Forms.Label();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaoBindingSource)).BeginInit();
            this.PnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UnidadeFederacaoBindingSource, "Nome", true));
            this.TxtNome.Location = new System.Drawing.Point(61, 35);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(369, 20);
            this.TxtNome.TabIndex = 3;
            this.TxtNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNome_Validating);
            // 
            // UnidadeFederacaoBindingSource
            // 
            this.UnidadeFederacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.UnidadeFederacao);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.CausesValidation = false;
            this.LblNome.Location = new System.Drawing.Point(12, 38);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // TxtSigla
            // 
            this.TxtSigla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UnidadeFederacaoBindingSource, "Sigla", true));
            this.TxtSigla.Location = new System.Drawing.Point(61, 9);
            this.TxtSigla.MaxLength = 2;
            this.TxtSigla.Name = "TxtSigla";
            this.TxtSigla.Size = new System.Drawing.Size(76, 20);
            this.TxtSigla.TabIndex = 1;
            this.TxtSigla.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSigla_Validating);
            // 
            // LblSigla
            // 
            this.LblSigla.AutoSize = true;
            this.LblSigla.CausesValidation = false;
            this.LblSigla.Location = new System.Drawing.Point(12, 12);
            this.LblSigla.Name = "LblSigla";
            this.LblSigla.Size = new System.Drawing.Size(33, 13);
            this.LblSigla.TabIndex = 0;
            this.LblSigla.Text = "Sigla:";
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.CausesValidation = false;
            this.PnlBotoes.Controls.Add(this.BtnCancela);
            this.PnlBotoes.Controls.Add(this.BtnConfirma);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotoes.Location = new System.Drawing.Point(0, 74);
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
            // UnidadeFederacaoEditForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(442, 108);
            this.ControlBox = false;
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtSigla);
            this.Controls.Add(this.LblSigla);
            this.Controls.Add(this.PnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UnidadeFederacaoEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unidade da Federação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnidadeFederacaoEditForm_FormClosing);
            this.Load += new System.EventHandler(this.UnidadeFederacaoEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaoBindingSource)).EndInit();
            this.PnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtSigla;
        private System.Windows.Forms.Label LblSigla;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.BindingSource UnidadeFederacaoBindingSource;
        private Componentes.CustomErrorProvider CustomErrorProvider;
    }
}