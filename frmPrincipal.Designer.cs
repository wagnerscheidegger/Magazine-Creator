namespace Magazine_Creator
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btPeliculas = new System.Windows.Forms.Button();
            this.btCartelas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MagazineDataSet = new Magazine_Creator.MagazineDataSet();
            this.tblPeliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPeliculasTableAdapter = new Magazine_Creator.MagazineDataSetTableAdapters.tblPeliculasTableAdapter();
            this.tblCartelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCartelasTableAdapter = new Magazine_Creator.MagazineDataSetTableAdapters.tblCartelasTableAdapter();
            this.tblCartelasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MagazineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartelasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartelasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPeliculas
            // 
            this.btPeliculas.Location = new System.Drawing.Point(12, 364);
            this.btPeliculas.Name = "btPeliculas";
            this.btPeliculas.Size = new System.Drawing.Size(103, 23);
            this.btPeliculas.TabIndex = 0;
            this.btPeliculas.Text = "Cadastrar Películas";
            this.btPeliculas.UseVisualStyleBackColor = true;
            this.btPeliculas.Click += new System.EventHandler(this.btPeliculas_Click);
            // 
            // btCartelas
            // 
            this.btCartelas.Location = new System.Drawing.Point(146, 364);
            this.btCartelas.Name = "btCartelas";
            this.btCartelas.Size = new System.Drawing.Size(103, 23);
            this.btCartelas.TabIndex = 1;
            this.btCartelas.Text = "Criar Cartelas";
            this.btCartelas.UseVisualStyleBackColor = true;
            this.btCartelas.Click += new System.EventHandler(this.btCartelas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fila de Impressão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MagazineDataSet
            // 
            this.MagazineDataSet.DataSetName = "MagazineDataSet";
            this.MagazineDataSet.EnforceConstraints = false;
            this.MagazineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPeliculasBindingSource
            // 
            this.tblPeliculasBindingSource.DataMember = "tblPeliculas";
            this.tblPeliculasBindingSource.DataSource = this.MagazineDataSet;
            // 
            // tblPeliculasTableAdapter
            // 
            this.tblPeliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tblCartelasBindingSource
            // 
            this.tblCartelasBindingSource.DataMember = "tblCartelas";
            this.tblCartelasBindingSource.DataSource = this.MagazineDataSet;
            // 
            // tblCartelasTableAdapter
            // 
            this.tblCartelasTableAdapter.ClearBeforeFill = true;
            // 
            // tblCartelasBindingSource1
            // 
            this.tblCartelasBindingSource1.DataMember = "tblCartelas";
            this.tblCartelasBindingSource1.DataSource = this.MagazineDataSet;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(395, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCartelas);
            this.Controls.Add(this.btPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazine Creator";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MagazineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartelasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartelasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPeliculas;
        private System.Windows.Forms.Button btCartelas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblPeliculasBindingSource;
        private MagazineDataSet MagazineDataSet;
        private MagazineDataSetTableAdapters.tblPeliculasTableAdapter tblPeliculasTableAdapter;
        private System.Windows.Forms.BindingSource tblCartelasBindingSource;
        private MagazineDataSetTableAdapters.tblCartelasTableAdapter tblCartelasTableAdapter;
        private System.Windows.Forms.BindingSource tblCartelasBindingSource1;
    }
}

