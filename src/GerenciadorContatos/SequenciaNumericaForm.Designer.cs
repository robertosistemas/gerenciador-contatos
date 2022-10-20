namespace GerenciadorContatos
{
    partial class SequenciaNumericaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SequenciaNumericaForm));
            this.SequenciaNumericaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CongregacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OperadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SequenciaNumericaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.AlterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PaginaAnteriorStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProximaPaginaStripButton = new System.Windows.Forms.ToolStripButton();
            this.GerarCartoesContatosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SequenciaNumericaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congregacaoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operadoraIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CodigoArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preFixoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeTelefonesCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaNumericaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaNumericaBindingNavigator)).BeginInit();
            this.SequenciaNumericaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaNumericaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SequenciaNumericaBindingSource
            // 
            this.SequenciaNumericaBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.SequenciaNumerica);
            this.SequenciaNumericaBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.SequenciaNumericaBindingSource_BindingComplete);
            // 
            // CongregacaoBindingSource
            // 
            this.CongregacaoBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Congregacao);
            // 
            // OperadoraBindingSource
            // 
            this.OperadoraBindingSource.DataSource = typeof(GerenciadorContatos.Dominio.Operadora);
            // 
            // SequenciaNumericaBindingNavigator
            // 
            this.SequenciaNumericaBindingNavigator.AddNewItem = null;
            this.SequenciaNumericaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.SequenciaNumericaBindingNavigator.DeleteItem = null;
            this.SequenciaNumericaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.BindingNavigatorAddNewItem,
            this.BindingNavigatorDeleteItem,
            this.AlterarToolStripButton,
            this.toolStripSeparator1,
            this.PaginaAnteriorStripButton,
            this.ProximaPaginaStripButton,
            this.GerarCartoesContatosToolStripButton});
            this.SequenciaNumericaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.SequenciaNumericaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.SequenciaNumericaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.SequenciaNumericaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.SequenciaNumericaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.SequenciaNumericaBindingNavigator.Name = "SequenciaNumericaBindingNavigator";
            this.SequenciaNumericaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.SequenciaNumericaBindingNavigator.Size = new System.Drawing.Size(740, 25);
            this.SequenciaNumericaBindingNavigator.TabIndex = 0;
            this.SequenciaNumericaBindingNavigator.Text = "bindingNavigator1";
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
            // BindingNavigatorAddNewItem
            // 
            this.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorAddNewItem.Image")));
            this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            this.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorAddNewItem.Text = "Add new";
            this.BindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // BindingNavigatorDeleteItem
            // 
            this.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorDeleteItem.Image")));
            this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorDeleteItem.Text = "Delete";
            this.BindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // AlterarToolStripButton
            // 
            this.AlterarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AlterarToolStripButton.Image = global::GerenciadorContatos.Properties.Resources.Pencil_icon;
            this.AlterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlterarToolStripButton.Name = "AlterarToolStripButton";
            this.AlterarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AlterarToolStripButton.Text = "toolStripButton1";
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
            // GerarCartoesContatosToolStripButton
            // 
            this.GerarCartoesContatosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GerarCartoesContatosToolStripButton.Image = global::GerenciadorContatos.Properties.Resources.process_accept_icon;
            this.GerarCartoesContatosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GerarCartoesContatosToolStripButton.Name = "GerarCartoesContatosToolStripButton";
            this.GerarCartoesContatosToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.GerarCartoesContatosToolStripButton.Text = "&Gerar cartões e contatos";
            this.GerarCartoesContatosToolStripButton.Click += new System.EventHandler(this.GerarCartoesContatosToolStripButton_Click);
            // 
            // SequenciaNumericaDataGridView
            // 
            this.SequenciaNumericaDataGridView.AllowUserToAddRows = false;
            this.SequenciaNumericaDataGridView.AllowUserToDeleteRows = false;
            this.SequenciaNumericaDataGridView.AutoGenerateColumns = false;
            this.SequenciaNumericaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SequenciaNumericaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.congregacaoIdDataGridViewTextBoxColumn,
            this.operadoraIdDataGridViewTextBoxColumn,
            this.CodigoArea,
            this.preFixoDataGridViewTextBoxColumn,
            this.inicioDataGridViewTextBoxColumn,
            this.fimDataGridViewTextBoxColumn,
            this.quantidadeTelefonesCartaoDataGridViewTextBoxColumn});
            this.SequenciaNumericaDataGridView.DataSource = this.SequenciaNumericaBindingSource;
            this.SequenciaNumericaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SequenciaNumericaDataGridView.Location = new System.Drawing.Point(0, 25);
            this.SequenciaNumericaDataGridView.MultiSelect = false;
            this.SequenciaNumericaDataGridView.Name = "SequenciaNumericaDataGridView";
            this.SequenciaNumericaDataGridView.ReadOnly = true;
            this.SequenciaNumericaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SequenciaNumericaDataGridView.Size = new System.Drawing.Size(740, 354);
            this.SequenciaNumericaDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // congregacaoIdDataGridViewTextBoxColumn
            // 
            this.congregacaoIdDataGridViewTextBoxColumn.DataPropertyName = "CongregacaoId";
            this.congregacaoIdDataGridViewTextBoxColumn.DataSource = this.CongregacaoBindingSource;
            this.congregacaoIdDataGridViewTextBoxColumn.DisplayMember = "Nome";
            this.congregacaoIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.congregacaoIdDataGridViewTextBoxColumn.HeaderText = "Associação";
            this.congregacaoIdDataGridViewTextBoxColumn.Name = "congregacaoIdDataGridViewTextBoxColumn";
            this.congregacaoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.congregacaoIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.congregacaoIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.congregacaoIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.congregacaoIdDataGridViewTextBoxColumn.Width = 200;
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
            // CodigoArea
            // 
            this.CodigoArea.DataPropertyName = "CodigoArea";
            this.CodigoArea.HeaderText = "Código área";
            this.CodigoArea.Name = "CodigoArea";
            this.CodigoArea.ReadOnly = true;
            // 
            // preFixoDataGridViewTextBoxColumn
            // 
            this.preFixoDataGridViewTextBoxColumn.DataPropertyName = "PreFixo";
            this.preFixoDataGridViewTextBoxColumn.HeaderText = "Pré-fixo";
            this.preFixoDataGridViewTextBoxColumn.Name = "preFixoDataGridViewTextBoxColumn";
            this.preFixoDataGridViewTextBoxColumn.ReadOnly = true;
            this.preFixoDataGridViewTextBoxColumn.Width = 60;
            // 
            // inicioDataGridViewTextBoxColumn
            // 
            this.inicioDataGridViewTextBoxColumn.DataPropertyName = "Inicio";
            this.inicioDataGridViewTextBoxColumn.HeaderText = "Início";
            this.inicioDataGridViewTextBoxColumn.Name = "inicioDataGridViewTextBoxColumn";
            this.inicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inicioDataGridViewTextBoxColumn.Width = 50;
            // 
            // fimDataGridViewTextBoxColumn
            // 
            this.fimDataGridViewTextBoxColumn.DataPropertyName = "Fim";
            this.fimDataGridViewTextBoxColumn.HeaderText = "Fim";
            this.fimDataGridViewTextBoxColumn.Name = "fimDataGridViewTextBoxColumn";
            this.fimDataGridViewTextBoxColumn.ReadOnly = true;
            this.fimDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantidadeTelefonesCartaoDataGridViewTextBoxColumn
            // 
            this.quantidadeTelefonesCartaoDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeTelefonesCartao";
            this.quantidadeTelefonesCartaoDataGridViewTextBoxColumn.HeaderText = "Quantidade telefones por cartão";
            this.quantidadeTelefonesCartaoDataGridViewTextBoxColumn.Name = "quantidadeTelefonesCartaoDataGridViewTextBoxColumn";
            this.quantidadeTelefonesCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SequenciaNumericaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 379);
            this.Controls.Add(this.SequenciaNumericaDataGridView);
            this.Controls.Add(this.SequenciaNumericaBindingNavigator);
            this.Name = "SequenciaNumericaForm";
            this.Text = "Sequências numéricas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SequenciaNumericaForm_FormClosing);
            this.Load += new System.EventHandler(this.SequenciaNumericaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaNumericaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CongregacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaNumericaBindingNavigator)).EndInit();
            this.SequenciaNumericaBindingNavigator.ResumeLayout(false);
            this.SequenciaNumericaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SequenciaNumericaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource SequenciaNumericaBindingSource;
        private System.Windows.Forms.BindingSource CongregacaoBindingSource;
        private System.Windows.Forms.BindingSource OperadoraBindingSource;
        private System.Windows.Forms.BindingNavigator SequenciaNumericaBindingNavigator;
        private System.Windows.Forms.ToolStripButton BindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView SequenciaNumericaDataGridView;
        private System.Windows.Forms.ToolStripButton AlterarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton PaginaAnteriorStripButton;
        private System.Windows.Forms.ToolStripButton ProximaPaginaStripButton;
        private System.Windows.Forms.ToolStripButton GerarCartoesContatosToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn congregacaoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn operadoraIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn preFixoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeTelefonesCartaoDataGridViewTextBoxColumn;
    }
}