namespace GerenciadorContatos
{
    partial class ContatoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContatoForm));
            this.ContatoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ContatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PaginaAnteriorStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProximaPaginaStripButton = new System.Windows.Forms.ToolStripButton();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OperadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CartaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContatoDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operadoraIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cartaoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permiteLigarDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ContatoBindingNavigator)).BeginInit();
            this.ContatoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContatoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ContatoBindingNavigator
            // 
            this.ContatoBindingNavigator.AddNewItem = null;
            this.ContatoBindingNavigator.BindingSource = this.ContatoBindingSource;
            this.ContatoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ContatoBindingNavigator.DeleteItem = null;
            this.ContatoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator1,
            this.PaginaAnteriorStripButton,
            this.ProximaPaginaStripButton,
            this.FiltrarToolStripButton});
            this.ContatoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ContatoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ContatoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ContatoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ContatoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ContatoBindingNavigator.Name = "ContatoBindingNavigator";
            this.ContatoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ContatoBindingNavigator.Size = new System.Drawing.Size(771, 25);
            this.ContatoBindingNavigator.TabIndex = 0;
            this.ContatoBindingNavigator.Text = "bindingNavigator1";
            // 
            // ContatoBindingSource
            // 
            this.ContatoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Contato);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FiltrarToolStripButton.Image = global::GerenciadorContatos.Properties.Resources.filter;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FiltrarToolStripButton.Text = "&Filtrar";
            this.FiltrarToolStripButton.Click += new System.EventHandler(this.FiltrarToolStripButton_Click);
            // 
            // OperadoraBindingSource
            // 
            this.OperadoraBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Operadora);
            // 
            // CartaoBindingSource
            // 
            this.CartaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Cartao);
            // 
            // ContatoDataGridView
            // 
            this.ContatoDataGridView.AllowUserToAddRows = false;
            this.ContatoDataGridView.AllowUserToDeleteRows = false;
            this.ContatoDataGridView.AutoGenerateColumns = false;
            this.ContatoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContatoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.operadoraIdDataGridViewTextBoxColumn,
            this.cartaoIdDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.permiteLigarDataGridViewCheckBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
            this.ContatoDataGridView.DataSource = this.ContatoBindingSource;
            this.ContatoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContatoDataGridView.Location = new System.Drawing.Point(0, 25);
            this.ContatoDataGridView.MultiSelect = false;
            this.ContatoDataGridView.Name = "ContatoDataGridView";
            this.ContatoDataGridView.ReadOnly = true;
            this.ContatoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContatoDataGridView.Size = new System.Drawing.Size(771, 354);
            this.ContatoDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // operadoraIdDataGridViewTextBoxColumn
            // 
            this.operadoraIdDataGridViewTextBoxColumn.DataPropertyName = "OperadoraId";
            this.operadoraIdDataGridViewTextBoxColumn.DataSource = this.OperadoraBindingSource;
            this.operadoraIdDataGridViewTextBoxColumn.DisplayMember = "Nome";
            this.operadoraIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.operadoraIdDataGridViewTextBoxColumn.HeaderText = "Operadora";
            this.operadoraIdDataGridViewTextBoxColumn.Name = "operadoraIdDataGridViewTextBoxColumn";
            this.operadoraIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.operadoraIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.operadoraIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.operadoraIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // cartaoIdDataGridViewTextBoxColumn
            // 
            this.cartaoIdDataGridViewTextBoxColumn.DataPropertyName = "CartaoId";
            this.cartaoIdDataGridViewTextBoxColumn.DataSource = this.CartaoBindingSource;
            this.cartaoIdDataGridViewTextBoxColumn.DisplayMember = "Numero";
            this.cartaoIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cartaoIdDataGridViewTextBoxColumn.HeaderText = "Cartão";
            this.cartaoIdDataGridViewTextBoxColumn.Name = "cartaoIdDataGridViewTextBoxColumn";
            this.cartaoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cartaoIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cartaoIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cartaoIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permiteLigarDataGridViewCheckBoxColumn
            // 
            this.permiteLigarDataGridViewCheckBoxColumn.DataPropertyName = "PermiteLigar";
            this.permiteLigarDataGridViewCheckBoxColumn.HeaderText = "Permite ligar";
            this.permiteLigarDataGridViewCheckBoxColumn.Name = "permiteLigarDataGridViewCheckBoxColumn";
            this.permiteLigarDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 379);
            this.Controls.Add(this.ContatoDataGridView);
            this.Controls.Add(this.ContatoBindingNavigator);
            this.Name = "ContatoForm";
            this.Text = "Contatos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContatoForm_FormClosing);
            this.Load += new System.EventHandler(this.ContatoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContatoBindingNavigator)).EndInit();
            this.ContatoBindingNavigator.ResumeLayout(false);
            this.ContatoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContatoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator ContatoBindingNavigator;
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
        private System.Windows.Forms.BindingSource ContatoBindingSource;
        private System.Windows.Forms.BindingSource OperadoraBindingSource;
        private System.Windows.Forms.BindingSource CartaoBindingSource;
        private System.Windows.Forms.DataGridView ContatoDataGridView;
        private System.Windows.Forms.ToolStripButton AlterarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PaginaAnteriorStripButton;
        private System.Windows.Forms.ToolStripButton ProximaPaginaStripButton;
        private System.Windows.Forms.ToolStripButton FiltrarToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn operadoraIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cartaoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permiteLigarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
    }
}