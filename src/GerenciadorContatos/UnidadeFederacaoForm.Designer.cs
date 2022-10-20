namespace GerenciadorContatos
{
    partial class UnidadeFederacaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadeFederacaoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnidadeFederacaobindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.UnidadeFederacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PaginaAnteriorStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProximaPaginaStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnidadeFederacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaobindingNavigator)).BeginInit();
            this.UnidadeFederacaobindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UnidadeFederacaobindingNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 28);
            this.panel1.TabIndex = 0;
            // 
            // UnidadeFederacaobindingNavigator
            // 
            this.UnidadeFederacaobindingNavigator.AddNewItem = null;
            this.UnidadeFederacaobindingNavigator.BindingSource = this.UnidadeFederacaoBindingSource;
            this.UnidadeFederacaobindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.UnidadeFederacaobindingNavigator.DeleteItem = null;
            this.UnidadeFederacaobindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorSeparator3,
            this.PaginaAnteriorStripButton,
            this.ProximaPaginaStripButton});
            this.UnidadeFederacaobindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.UnidadeFederacaobindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.UnidadeFederacaobindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.UnidadeFederacaobindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.UnidadeFederacaobindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.UnidadeFederacaobindingNavigator.Name = "UnidadeFederacaobindingNavigator";
            this.UnidadeFederacaobindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.UnidadeFederacaobindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.UnidadeFederacaobindingNavigator.TabIndex = 0;
            this.UnidadeFederacaobindingNavigator.Text = "bindingNavigator1";
            // 
            // UnidadeFederacaoBindingSource
            // 
            this.UnidadeFederacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.UnidadeFederacao);
            this.UnidadeFederacaoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.UnidadeFederacaoBindingSource_BindingComplete);
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
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // UnidadeFederacaoDataGridView
            // 
            this.UnidadeFederacaoDataGridView.AllowUserToAddRows = false;
            this.UnidadeFederacaoDataGridView.AllowUserToDeleteRows = false;
            this.UnidadeFederacaoDataGridView.AutoGenerateColumns = false;
            this.UnidadeFederacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnidadeFederacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.siglaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.UnidadeFederacaoDataGridView.DataSource = this.UnidadeFederacaoBindingSource;
            this.UnidadeFederacaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnidadeFederacaoDataGridView.Location = new System.Drawing.Point(0, 28);
            this.UnidadeFederacaoDataGridView.MultiSelect = false;
            this.UnidadeFederacaoDataGridView.Name = "UnidadeFederacaoDataGridView";
            this.UnidadeFederacaoDataGridView.ReadOnly = true;
            this.UnidadeFederacaoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnidadeFederacaoDataGridView.Size = new System.Drawing.Size(573, 351);
            this.UnidadeFederacaoDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // siglaDataGridViewTextBoxColumn
            // 
            this.siglaDataGridViewTextBoxColumn.DataPropertyName = "Sigla";
            this.siglaDataGridViewTextBoxColumn.HeaderText = "Sigla";
            this.siglaDataGridViewTextBoxColumn.Name = "siglaDataGridViewTextBoxColumn";
            this.siglaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // UnidadeFederacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 379);
            this.Controls.Add(this.UnidadeFederacaoDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "UnidadeFederacaoForm";
            this.Text = "Unidades da Federação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnidadeFederacaoForm_FormClosing);
            this.Load += new System.EventHandler(this.UnidadeFederacaoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaobindingNavigator)).EndInit();
            this.UnidadeFederacaobindingNavigator.ResumeLayout(false);
            this.UnidadeFederacaobindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadeFederacaoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView UnidadeFederacaoDataGridView;
        private System.Windows.Forms.BindingSource UnidadeFederacaoBindingSource;
        private System.Windows.Forms.BindingNavigator UnidadeFederacaobindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton AlterarToolStripButton;
        private System.Windows.Forms.ToolStripButton PaginaAnteriorStripButton;
        private System.Windows.Forms.ToolStripButton ProximaPaginaStripButton;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
    }
}