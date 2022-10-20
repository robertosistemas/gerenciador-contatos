namespace GerenciadorContatos
{
    partial class OperadoraEditForm
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.OperadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            this.PnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.CausesValidation = false;
            this.LblCodigo.Location = new System.Drawing.Point(12, 12);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(43, 13);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Código:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OperadoraBindingSource, "Codigo", true));
            this.TxtCodigo.Location = new System.Drawing.Point(61, 9);
            this.TxtCodigo.MaxLength = 10;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(76, 20);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // OperadoraBindingSource
            // 
            this.OperadoraBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Operadora);
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
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OperadoraBindingSource, "Nome", true));
            this.TxtNome.Location = new System.Drawing.Point(61, 35);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(367, 20);
            this.TxtNome.TabIndex = 3;
            this.TxtNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNome_Validating);
            // 
            // OperadoraEditForm
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
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.PnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OperadoraEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Operadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperadoraEditForm_FormClosing);
            this.Load += new System.EventHandler(this.OperadoraEditForm_Load);
            this.PnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.BindingSource OperadoraBindingSource;
        private Componentes.CustomErrorProvider CustomErrorProvider;
    }
}