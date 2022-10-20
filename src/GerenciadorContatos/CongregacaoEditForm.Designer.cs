namespace GerenciadorContatos
{
    partial class CongregacaoEditForm
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
            this.CongregacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.PnlBotoes = new System.Windows.Forms.Panel();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.LblMunicipio = new System.Windows.Forms.Label();
            this.CmbMunicipio = new System.Windows.Forms.ComboBox();
            this.MunincipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).BeginInit();
            this.PnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MunincipioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CongregacaoBindingSource, "Nome", true));
            this.TxtNome.Location = new System.Drawing.Point(81, 31);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(347, 20);
            this.TxtNome.TabIndex = 3;
            this.TxtNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNome_Validating);
            // 
            // CongregacaoBindingSource
            // 
            this.CongregacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Congregacao);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.CausesValidation = false;
            this.LblNome.Location = new System.Drawing.Point(12, 34);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CongregacaoBindingSource, "Numero", true));
            this.TxtNumero.Location = new System.Drawing.Point(81, 5);
            this.TxtNumero.MaxLength = 10;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(76, 20);
            this.TxtNumero.TabIndex = 1;
            this.TxtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumero_Validating);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.CausesValidation = false;
            this.LblNumero.Location = new System.Drawing.Point(12, 8);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(47, 13);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Número:";
            // 
            // PnlBotoes
            // 
            this.PnlBotoes.CausesValidation = false;
            this.PnlBotoes.Controls.Add(this.BtnCancela);
            this.PnlBotoes.Controls.Add(this.BtnConfirma);
            this.PnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBotoes.Location = new System.Drawing.Point(0, 90);
            this.PnlBotoes.Name = "PnlBotoes";
            this.PnlBotoes.Size = new System.Drawing.Size(442, 34);
            this.PnlBotoes.TabIndex = 6;
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
            // LblMunicipio
            // 
            this.LblMunicipio.AutoSize = true;
            this.LblMunicipio.Location = new System.Drawing.Point(12, 60);
            this.LblMunicipio.Name = "LblMunicipio";
            this.LblMunicipio.Size = new System.Drawing.Size(57, 13);
            this.LblMunicipio.TabIndex = 4;
            this.LblMunicipio.Text = "Município:";
            // 
            // CmbMunicipio
            // 
            this.CmbMunicipio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CongregacaoBindingSource, "MunicipioId", true));
            this.CmbMunicipio.DataSource = this.MunincipioBindingSource;
            this.CmbMunicipio.DisplayMember = "Nome";
            this.CmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMunicipio.FormattingEnabled = true;
            this.CmbMunicipio.Location = new System.Drawing.Point(81, 57);
            this.CmbMunicipio.Name = "CmbMunicipio";
            this.CmbMunicipio.Size = new System.Drawing.Size(347, 21);
            this.CmbMunicipio.TabIndex = 5;
            this.CmbMunicipio.ValueMember = "Id";
            this.CmbMunicipio.Validating += new System.ComponentModel.CancelEventHandler(this.CmbMunicipio_Validating);
            // 
            // MunincipioBindingSource
            // 
            this.MunincipioBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Municipio);
            // 
            // CongregacaoEditForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(442, 124);
            this.ControlBox = false;
            this.Controls.Add(this.CmbMunicipio);
            this.Controls.Add(this.LblMunicipio);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.PnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CongregacaoEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Associação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CongregacaoEditForm_FormClosing);
            this.Load += new System.EventHandler(this.CongregacaoEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).EndInit();
            this.PnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MunincipioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Panel PnlBotoes;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private System.Windows.Forms.BindingSource CongregacaoBindingSource;
        private System.Windows.Forms.ComboBox CmbMunicipio;
        private System.Windows.Forms.Label LblMunicipio;
        private System.Windows.Forms.BindingSource MunincipioBindingSource;
        private Componentes.CustomErrorProvider CustomErrorProvider;
    }
}