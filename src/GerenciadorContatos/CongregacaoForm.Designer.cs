namespace GerenciadorContatos
{
    partial class CongregacaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongregacaoForm));
            this.CongregacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.CongregacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.AlterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.PaginaAnteriorStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProximaPaginaStripButton = new System.Windows.Forms.ToolStripButton();
            this.CongregacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MunincipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingNavigator)).BeginInit();
            this.CongregacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunincipioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CongregacaoBindingNavigator
            // 
            this.CongregacaoBindingNavigator.AddNewItem = null;
            this.CongregacaoBindingNavigator.BindingSource = this.CongregacaoBindingSource;
            this.CongregacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.CongregacaoBindingNavigator.DeleteItem = null;
            this.CongregacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.AlterarToolStripButton,
            this.toolStripSeparator,
            this.PaginaAnteriorStripButton,
            this.ProximaPaginaStripButton});
            this.CongregacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.CongregacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.CongregacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.CongregacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.CongregacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.CongregacaoBindingNavigator.Name = "CongregacaoBindingNavigator";
            this.CongregacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.CongregacaoBindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.CongregacaoBindingNavigator.TabIndex = 0;
            this.CongregacaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // CongregacaoBindingSource
            // 
            this.CongregacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Congregacao);
            this.CongregacaoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.CongregacaoBindingSource_BindingComplete);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // AlterarToolStripButton
            // 
            this.AlterarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlterarToolStripButton.Image = global::GerenciadorContatos.Properties.Resources.Pencil_icon;
            this.AlterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlterarToolStripButton.Name = "AlterarToolStripButton";
            this.AlterarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AlterarToolStripButton.Text = "&Alterar";
            this.AlterarToolStripButton.Click += new System.EventHandler(this.AlterarToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // PaginaAnteriorStripButton
            // 
            this.PaginaAnteriorStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaginaAnteriorStripButton.Image = global::GerenciadorContatos.Properties.Resources.Alarm_Arrow_Up_icon;
            this.PaginaAnteriorStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaginaAnteriorStripButton.Name = "PaginaAnteriorStripButton";
            this.PaginaAnteriorStripButton.Size = new System.Drawing.Size(23, 22);
            this.PaginaAnteriorStripButton.Text = "Página anterior";
            this.PaginaAnteriorStripButton.Click += new System.EventHandler(this.PaginaAnteriorStripButton_Click);
            // 
            // ProximaPaginaStripButton
            // 
            this.ProximaPaginaStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProximaPaginaStripButton.Image = global::GerenciadorContatos.Properties.Resources.Alarm_Arrow_Down_icon;
            this.ProximaPaginaStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProximaPaginaStripButton.Name = "ProximaPaginaStripButton";
            this.ProximaPaginaStripButton.Size = new System.Drawing.Size(23, 22);
            this.ProximaPaginaStripButton.Text = "Próxima página";
            this.ProximaPaginaStripButton.Click += new System.EventHandler(this.ProximaPaginaStripButton_Click);
            // 
            // CongregacaoDataGridView
            // 
            this.CongregacaoDataGridView.AllowUserToAddRows = false;
            this.CongregacaoDataGridView.AllowUserToDeleteRows = false;
            this.CongregacaoDataGridView.AutoGenerateColumns = false;
            this.CongregacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CongregacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.municipioIdDataGridViewTextBoxColumn,
            this.Municipio});
            this.CongregacaoDataGridView.DataSource = this.CongregacaoBindingSource;
            this.CongregacaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CongregacaoDataGridView.Location = new System.Drawing.Point(0, 25);
            this.CongregacaoDataGridView.MultiSelect = false;
            this.CongregacaoDataGridView.Name = "CongregacaoDataGridView";
            this.CongregacaoDataGridView.ReadOnly = true;
            this.CongregacaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CongregacaoDataGridView.Size = new System.Drawing.Size(573, 354);
            this.CongregacaoDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // municipioIdDataGridViewTextBoxColumn
            // 
            this.municipioIdDataGridViewTextBoxColumn.DataPropertyName = "MunicipioId";
            this.municipioIdDataGridViewTextBoxColumn.HeaderText = "MunicipioId";
            this.municipioIdDataGridViewTextBoxColumn.Name = "municipioIdDataGridViewTextBoxColumn";
            this.municipioIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.municipioIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Municipio
            // 
            this.Municipio.DataPropertyName = "MunicipioId";
            this.Municipio.DataSource = this.MunincipioBindingSource;
            this.Municipio.DisplayMember = "Nome";
            this.Municipio.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Municipio.HeaderText = "Município";
            this.Municipio.Name = "Municipio";
            this.Municipio.ReadOnly = true;
            this.Municipio.ValueMember = "Id";
            this.Municipio.Width = 200;
            // 
            // MunincipioBindingSource
            // 
            this.MunincipioBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Municipio);
            // 
            // CongregacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 379);
            this.Controls.Add(this.CongregacaoDataGridView);
            this.Controls.Add(this.CongregacaoBindingNavigator);
            this.Name = "CongregacaoForm";
            this.Text = "Associações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CongregacaoForm_FormClosing);
            this.Load += new System.EventHandler(this.CongregacaoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingNavigator)).EndInit();
            this.CongregacaoBindingNavigator.ResumeLayout(false);
            this.CongregacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunincipioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator CongregacaoBindingNavigator;
        private System.Windows.Forms.BindingSource CongregacaoBindingSource;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton AlterarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton PaginaAnteriorStripButton;
        private System.Windows.Forms.ToolStripButton ProximaPaginaStripButton;
        private System.Windows.Forms.DataGridView CongregacaoDataGridView;
        private System.Windows.Forms.BindingSource MunincipioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Municipio;
    }
}