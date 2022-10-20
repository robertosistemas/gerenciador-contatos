namespace GerenciadorContatos
{
    partial class MainForm
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
            this.mnuOpcoes = new System.Windows.Forms.MenuStrip();
            this.SistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnidadeFederacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MunicipiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CongregacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublicadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SequenciasNumericasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CartoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOpcoes
            // 
            this.mnuOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SistemaToolStripMenuItem,
            this.CadastrosToolStripMenuItem,
            this.AjudaToolStripMenuItem});
            this.mnuOpcoes.Location = new System.Drawing.Point(0, 0);
            this.mnuOpcoes.Name = "mnuOpcoes";
            this.mnuOpcoes.Size = new System.Drawing.Size(1003, 24);
            this.mnuOpcoes.TabIndex = 1;
            this.mnuOpcoes.Text = "menuStrip1";
            // 
            // SistemaToolStripMenuItem
            // 
            this.SistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.SairToolStripMenuItem});
            this.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem";
            this.SistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.SistemaToolStripMenuItem.Text = "Sistema";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(90, 6);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // CadastrosToolStripMenuItem
            // 
            this.CadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UnidadeFederacaoToolStripMenuItem,
            this.MunicipiosToolStripMenuItem,
            this.CongregacoesToolStripMenuItem,
            this.PublicadoresToolStripMenuItem,
            this.OperadorasToolStripMenuItem,
            this.SequenciasNumericasToolStripMenuItem,
            this.CartoesToolStripMenuItem,
            this.contatosToolStripMenuItem});
            this.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem";
            this.CadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.CadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // UnidadeFederacaoToolStripMenuItem
            // 
            this.UnidadeFederacaoToolStripMenuItem.Name = "UnidadeFederacaoToolStripMenuItem";
            this.UnidadeFederacaoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.UnidadeFederacaoToolStripMenuItem.Text = "Unidade Federação";
            this.UnidadeFederacaoToolStripMenuItem.Click += new System.EventHandler(this.UnidadeFederacaoToolStripMenuItem_Click);
            // 
            // MunicipiosToolStripMenuItem
            // 
            this.MunicipiosToolStripMenuItem.Name = "MunicipiosToolStripMenuItem";
            this.MunicipiosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.MunicipiosToolStripMenuItem.Text = "Municípios";
            this.MunicipiosToolStripMenuItem.Click += new System.EventHandler(this.MunicipiosToolStripMenuItem_Click);
            // 
            // CongregacoesToolStripMenuItem
            // 
            this.CongregacoesToolStripMenuItem.Name = "CongregacoesToolStripMenuItem";
            this.CongregacoesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.CongregacoesToolStripMenuItem.Text = "Associações";
            this.CongregacoesToolStripMenuItem.Click += new System.EventHandler(this.CongregacoesToolStripMenuItem_Click);
            // 
            // PublicadoresToolStripMenuItem
            // 
            this.PublicadoresToolStripMenuItem.Name = "PublicadoresToolStripMenuItem";
            this.PublicadoresToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.PublicadoresToolStripMenuItem.Text = "Associados";
            this.PublicadoresToolStripMenuItem.Click += new System.EventHandler(this.PublicadoresToolStripMenuItem_Click);
            // 
            // OperadorasToolStripMenuItem
            // 
            this.OperadorasToolStripMenuItem.Name = "OperadorasToolStripMenuItem";
            this.OperadorasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OperadorasToolStripMenuItem.Text = "Operadoras";
            this.OperadorasToolStripMenuItem.Click += new System.EventHandler(this.OperadorasToolStripMenuItem_Click);
            // 
            // SequenciasNumericasToolStripMenuItem
            // 
            this.SequenciasNumericasToolStripMenuItem.Name = "SequenciasNumericasToolStripMenuItem";
            this.SequenciasNumericasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.SequenciasNumericasToolStripMenuItem.Text = "Sequências numéricas";
            this.SequenciasNumericasToolStripMenuItem.Click += new System.EventHandler(this.SequenciasNumericasToolStripMenuItem_Click);
            // 
            // CartoesToolStripMenuItem
            // 
            this.CartoesToolStripMenuItem.Name = "CartoesToolStripMenuItem";
            this.CartoesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.CartoesToolStripMenuItem.Text = "Cartões";
            this.CartoesToolStripMenuItem.Click += new System.EventHandler(this.CartoesToolStripMenuItem_Click);
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.contatosToolStripMenuItem.Text = "Contatos";
            this.contatosToolStripMenuItem.Click += new System.EventHandler(this.ContatosToolStripMenuItem_Click);
            // 
            // AjudaToolStripMenuItem
            // 
            this.AjudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SobreToolStripMenuItem});
            this.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem";
            this.AjudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.AjudaToolStripMenuItem.Text = "Ajuda";
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.SobreToolStripMenuItem.Text = "Sobre";
            this.SobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.mnuOpcoes);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuOpcoes;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de contatos";
            this.mnuOpcoes.ResumeLayout(false);
            this.mnuOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem SistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnidadeFederacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MunicipiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CongregacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PublicadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CartoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SequenciasNumericasToolStripMenuItem;
    }
}

