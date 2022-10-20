namespace GerenciadorContatos
{
    partial class MunicipioEditForm
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
            this.BotoesPanel = new System.Windows.Forms.Panel();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnConfirma = new System.Windows.Forms.Button();
            this.CustomErrorProvider = new GerenciadorContatos.Componentes.CustomErrorProvider(this.components);
            this.CmbUnidadeFederacao = new System.Windows.Forms.ComboBox();
            this.MunicipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnidadeFederacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblUnidadeFederacao = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.BotoesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BotoesPanel
            // 
            this.BotoesPanel.Controls.Add(this.BtnCancela);
            this.BotoesPanel.Controls.Add(this.BtnConfirma);
            this.BotoesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BotoesPanel.Location = new System.Drawing.Point(0, 64);
            this.BotoesPanel.Name = "BotoesPanel";
            this.BotoesPanel.Size = new System.Drawing.Size(442, 34);
            this.BotoesPanel.TabIndex = 4;
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
            // CmbUnidadeFederacao
            // 
            this.CmbUnidadeFederacao.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.MunicipioBindingSource, "UnidadeFederacaoId", true));
            this.CmbUnidadeFederacao.DataSource = this.UnidadeFederacaoBindingSource;
            this.CmbUnidadeFederacao.DisplayMember = "Nome";
            this.CmbUnidadeFederacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidadeFederacao.FormattingEnabled = true;
            this.CmbUnidadeFederacao.Location = new System.Drawing.Point(118, 31);
            this.CmbUnidadeFederacao.Name = "CmbUnidadeFederacao";
            this.CmbUnidadeFederacao.Size = new System.Drawing.Size(312, 21);
            this.CmbUnidadeFederacao.TabIndex = 3;
            this.CmbUnidadeFederacao.ValueMember = "Id";
            this.CmbUnidadeFederacao.Validating += new System.ComponentModel.CancelEventHandler(this.CmbUnidadeFederacao_Validating);
            // 
            // MunicipioBindingSource
            // 
            this.MunicipioBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Municipio);
            // 
            // UnidadeFederacaoBindingSource
            // 
            this.UnidadeFederacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.UnidadeFederacao);
            // 
            // LblUnidadeFederacao
            // 
            this.LblUnidadeFederacao.AutoSize = true;
            this.LblUnidadeFederacao.Location = new System.Drawing.Point(8, 34);
            this.LblUnidadeFederacao.Name = "LblUnidadeFederacao";
            this.LblUnidadeFederacao.Size = new System.Drawing.Size(104, 13);
            this.LblUnidadeFederacao.TabIndex = 2;
            this.LblUnidadeFederacao.Text = "Unidade Federação:";
            // 
            // TxtNome
            // 
            this.TxtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MunicipioBindingSource, "Nome", true));
            this.TxtNome.Location = new System.Drawing.Point(118, 5);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(312, 20);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNome_Validating);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.CausesValidation = false;
            this.LblNome.Location = new System.Drawing.Point(8, 9);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // MunicipioEditForm
            // 
            this.AcceptButton = this.BtnConfirma;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.BtnCancela;
            this.ClientSize = new System.Drawing.Size(442, 98);
            this.ControlBox = false;
            this.Controls.Add(this.CmbUnidadeFederacao);
            this.Controls.Add(this.LblUnidadeFederacao);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.BotoesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MunicipioEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Município";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MunicipioEditForm_FormClosing);
            this.Load += new System.EventHandler(this.MunicipioEditForm_Load);
            this.BotoesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BotoesPanel;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnConfirma;
        private Componentes.CustomErrorProvider CustomErrorProvider;
        private System.Windows.Forms.ComboBox CmbUnidadeFederacao;
        private System.Windows.Forms.Label LblUnidadeFederacao;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.BindingSource MunicipioBindingSource;
        private System.Windows.Forms.BindingSource UnidadeFederacaoBindingSource;
    }
}