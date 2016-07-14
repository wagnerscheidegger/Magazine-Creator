namespace Magazine_Creator
{
    partial class frmPeliculas
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label codLabel;
            System.Windows.Forms.Label imagemLabel;
            System.Windows.Forms.Label imagemLabel1;
            System.Windows.Forms.Label categoriaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeliculas));
            this.tblPeliculasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblPeliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazineDataSet = new Magazine_Creator.MagazineDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tblPeliculasBindingNavigatorEdit = new System.Windows.Forms.ToolStripButton();
            this.tblPeliculasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblPeliculasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btLoadImagem = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tblPeliculasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tblPeliculasTableAdapter = new Magazine_Creator.MagazineDataSetTableAdapters.tblPeliculasTableAdapter();
            this.tableAdapterManager = new Magazine_Creator.MagazineDataSetTableAdapters.TableAdapterManager();
            this.tblPeliculasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            codLabel = new System.Windows.Forms.Label();
            imagemLabel = new System.Windows.Forms.Label();
            imagemLabel1 = new System.Windows.Forms.Label();
            categoriaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingNavigator)).BeginInit();
            this.tblPeliculasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 69);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // codLabel
            // 
            codLabel.AutoSize = true;
            codLabel.Location = new System.Drawing.Point(18, 95);
            codLabel.Name = "codLabel";
            codLabel.Size = new System.Drawing.Size(43, 13);
            codLabel.TabIndex = 4;
            codLabel.Text = "Código:";
            // 
            // imagemLabel
            // 
            imagemLabel.AutoSize = true;
            imagemLabel.Location = new System.Drawing.Point(18, 147);
            imagemLabel.Name = "imagemLabel";
            imagemLabel.Size = new System.Drawing.Size(47, 13);
            imagemLabel.TabIndex = 8;
            imagemLabel.Text = "Imagem:";
            // 
            // imagemLabel1
            // 
            imagemLabel1.AutoSize = true;
            imagemLabel1.Location = new System.Drawing.Point(18, 183);
            imagemLabel1.Name = "imagemLabel1";
            imagemLabel1.Size = new System.Drawing.Size(69, 13);
            imagemLabel1.TabIndex = 12;
            imagemLabel1.Text = "Visualização:";
            // 
            // categoriaLabel1
            // 
            categoriaLabel1.AutoSize = true;
            categoriaLabel1.Location = new System.Drawing.Point(18, 120);
            categoriaLabel1.Name = "categoriaLabel1";
            categoriaLabel1.Size = new System.Drawing.Size(55, 13);
            categoriaLabel1.TabIndex = 13;
            categoriaLabel1.Text = "Categoria:";
            // 
            // tblPeliculasBindingNavigator
            // 
            this.tblPeliculasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblPeliculasBindingNavigator.BindingSource = this.tblPeliculasBindingSource;
            this.tblPeliculasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPeliculasBindingNavigator.CountItemFormat = "de {0}";
            this.tblPeliculasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblPeliculasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblPeliculasBindingNavigatorEdit,
            this.tblPeliculasBindingNavigatorSaveItem});
            this.tblPeliculasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblPeliculasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPeliculasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPeliculasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPeliculasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPeliculasBindingNavigator.Name = "tblPeliculasBindingNavigator";
            this.tblPeliculasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPeliculasBindingNavigator.Size = new System.Drawing.Size(708, 25);
            this.tblPeliculasBindingNavigator.TabIndex = 0;
            this.tblPeliculasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar Película";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // tblPeliculasBindingSource
            // 
            this.tblPeliculasBindingSource.DataMember = "tblPeliculas";
            this.tblPeliculasBindingSource.DataSource = this.magazineDataSet;
            // 
            // magazineDataSet
            // 
            this.magazineDataSet.DataSetName = "MagazineDataSet";
            this.magazineDataSet.EnforceConstraints = false;
            this.magazineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Apagar Película";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
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
            // tblPeliculasBindingNavigatorEdit
            // 
            this.tblPeliculasBindingNavigatorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPeliculasBindingNavigatorEdit.Image = ((System.Drawing.Image)(resources.GetObject("tblPeliculasBindingNavigatorEdit.Image")));
            this.tblPeliculasBindingNavigatorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tblPeliculasBindingNavigatorEdit.Name = "tblPeliculasBindingNavigatorEdit";
            this.tblPeliculasBindingNavigatorEdit.Size = new System.Drawing.Size(23, 22);
            this.tblPeliculasBindingNavigatorEdit.Text = "Editar Película";
            this.tblPeliculasBindingNavigatorEdit.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tblPeliculasBindingNavigatorSaveItem
            // 
            this.tblPeliculasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPeliculasBindingNavigatorSaveItem.Enabled = false;
            this.tblPeliculasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPeliculasBindingNavigatorSaveItem.Image")));
            this.tblPeliculasBindingNavigatorSaveItem.Name = "tblPeliculasBindingNavigatorSaveItem";
            this.tblPeliculasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblPeliculasBindingNavigatorSaveItem.Text = "Salvar Película";
            this.tblPeliculasBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblPeliculasBindingNavigatorSaveItem_Click);
            // 
            // tblPeliculasDataGridView
            // 
            this.tblPeliculasDataGridView.AllowUserToAddRows = false;
            this.tblPeliculasDataGridView.AllowUserToDeleteRows = false;
            this.tblPeliculasDataGridView.AutoGenerateColumns = false;
            this.tblPeliculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPeliculasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblPeliculasDataGridView.DataSource = this.tblPeliculasBindingSource;
            this.tblPeliculasDataGridView.Location = new System.Drawing.Point(242, 66);
            this.tblPeliculasDataGridView.Name = "tblPeliculasDataGridView";
            this.tblPeliculasDataGridView.ReadOnly = true;
            this.tblPeliculasDataGridView.Size = new System.Drawing.Size(454, 316);
            this.tblPeliculasDataGridView.TabIndex = 1;
            this.tblPeliculasDataGridView.TabStop = false;
            this.tblPeliculasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPeliculasDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod";
            this.dataGridViewTextBoxColumn2.FillWeight = 70F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Imagem";
            this.dataGridViewTextBoxColumn4.FillWeight = 200F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Imagem";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPeliculasBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(93, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtCod
            // 
            this.txtCod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPeliculasBindingSource, "Cod", true));
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(93, 92);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(131, 20);
            this.txtCod.TabIndex = 1;
            // 
            // txtImagem
            // 
            this.txtImagem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPeliculasBindingSource, "Imagem", true));
            this.txtImagem.Enabled = false;
            this.txtImagem.Location = new System.Drawing.Point(93, 144);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(131, 20);
            this.txtImagem.TabIndex = 3;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(93, 183);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(131, 160);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 10;
            this.picImagem.TabStop = false;
            // 
            // btLoadImagem
            // 
            this.btLoadImagem.Location = new System.Drawing.Point(108, 349);
            this.btLoadImagem.Name = "btLoadImagem";
            this.btLoadImagem.Size = new System.Drawing.Size(100, 23);
            this.btLoadImagem.TabIndex = 4;
            this.btLoadImagem.Text = "Carregar Imagem";
            this.btLoadImagem.UseVisualStyleBackColor = true;
            this.btLoadImagem.Visible = false;
            this.btLoadImagem.Click += new System.EventHandler(this.btLoadImagem_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPeliculasBindingSource, "Categoria", true));
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblPeliculasBindingSource2, "Categoria", true));
            this.cbCategoria.Enabled = false;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(93, 117);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(131, 21);
            this.cbCategoria.TabIndex = 2;
            this.cbCategoria.Click += new System.EventHandler(this.cbCategoria_Click);
            // 
            // tblPeliculasBindingSource2
            // 
            this.tblPeliculasBindingSource2.DataMember = "tblPeliculas";
            this.tblPeliculasBindingSource2.DataSource = this.magazineDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cadastro de Películas";
            // 
            // tblPeliculasTableAdapter
            // 
            this.tblPeliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCartelasTableAdapter = null;
            this.tableAdapterManager.tblImpressaoTableAdapter = null;
            this.tableAdapterManager.tblPeliculasTableAdapter = this.tblPeliculasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Magazine_Creator.MagazineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblPeliculasBindingSource1
            // 
            this.tblPeliculasBindingSource1.DataMember = "tblPeliculas";
            this.tblPeliculasBindingSource1.DataSource = this.magazineDataSet;
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(categoriaLabel1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(imagemLabel1);
            this.Controls.Add(this.btLoadImagem);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(codLabel);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(imagemLabel);
            this.Controls.Add(this.txtImagem);
            this.Controls.Add(this.tblPeliculasDataGridView);
            this.Controls.Add(this.tblPeliculasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Peliculas";
            this.Load += new System.EventHandler(this.frmPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingNavigator)).EndInit();
            this.tblPeliculasBindingNavigator.ResumeLayout(false);
            this.tblPeliculasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MagazineDataSet magazineDataSet;
        private System.Windows.Forms.BindingSource tblPeliculasBindingSource;
        private MagazineDataSetTableAdapters.tblPeliculasTableAdapter tblPeliculasTableAdapter;
        private MagazineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblPeliculasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblPeliculasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblPeliculasDataGridView;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btLoadImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.BindingSource tblPeliculasBindingSource2;
        private System.Windows.Forms.BindingSource tblPeliculasBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tblPeliculasBindingNavigatorEdit;
    }
}