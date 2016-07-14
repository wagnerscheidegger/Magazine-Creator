namespace Magazine_Creator
{
    partial class frmReportCartela
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblImpressaoImparBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impressaoDataSet5 = new Magazine_Creator.ImpressaoDataSet();
            this.tblImpressaoParBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblImpressaoImparTableAdapter3 = new Magazine_Creator.ImpressaoDataSetTableAdapters.tblImpressaoImparTableAdapter();
            this.tblImpressaoParTableAdapter3 = new Magazine_Creator.ImpressaoDataSetTableAdapters.tblImpressaoParTableAdapter();
            this.tableAdapterManager = new Magazine_Creator.ImpressaoDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tblImpressaoImparBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impressaoDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImpressaoParBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblImpressaoImparBindingSource
            // 
            this.tblImpressaoImparBindingSource.DataMember = "tblImpressaoImpar";
            this.tblImpressaoImparBindingSource.DataSource = this.impressaoDataSet5;
            // 
            // impressaoDataSet5
            // 
            this.impressaoDataSet5.DataSetName = "ImpressaoDataSet";
            this.impressaoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblImpressaoParBindingSource
            // 
            this.tblImpressaoParBindingSource.DataMember = "tblImpressaoPar";
            this.tblImpressaoParBindingSource.DataSource = this.impressaoDataSet5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblImpressaoImparBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.tblImpressaoParBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Magazine_Creator.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(747, 709);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblImpressaoImparTableAdapter3
            // 
            this.tblImpressaoImparTableAdapter3.ClearBeforeFill = true;
            // 
            // tblImpressaoParTableAdapter3
            // 
            this.tblImpressaoParTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblImpressaoImparTableAdapter = this.tblImpressaoImparTableAdapter3;
            this.tableAdapterManager.tblImpressaoParTableAdapter = this.tblImpressaoParTableAdapter3;
            this.tableAdapterManager.UpdateOrder = Magazine_Creator.ImpressaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmReportCartela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 709);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportCartela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de Cartelas";
            this.Load += new System.EventHandler(this.frmReportCartela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblImpressaoImparBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impressaoDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImpressaoParBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ImpressaoDataSet ImpressaoParDataSet;
        private ImpressaoDataSet ImpressaoDataSet;
        private ImpressaoDataSet impressaoDataSet1;
        private ImpressaoDataSetTableAdapters.tblImpressaoParTableAdapter tblImpressaoParTableAdapter1;
        private ImpressaoDataSetTableAdapters.tblImpressaoImparTableAdapter tblImpressaoImparTableAdapter1;
        private ImpressaoDataSet impressaoDataSet2;
        private ImpressaoDataSetTableAdapters.tblImpressaoParTableAdapter tblImpressaoParTableAdapter;
        private ImpressaoDataSet impressaoDataSet3;
        private ImpressaoDataSetTableAdapters.tblImpressaoImparTableAdapter tblImpressaoImparTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ImpressaoDataSet impressaoDataSet4;
        private System.Windows.Forms.BindingSource tblImpressaoImparBindingSource;
        private ImpressaoDataSetTableAdapters.tblImpressaoImparTableAdapter tblImpressaoImparTableAdapter2;
        private System.Windows.Forms.BindingSource tblImpressaoParBindingSource;
        private ImpressaoDataSetTableAdapters.tblImpressaoParTableAdapter tblImpressaoParTableAdapter2;
        private ImpressaoDataSet impressaoDataSet5;
        private ImpressaoDataSetTableAdapters.tblImpressaoImparTableAdapter tblImpressaoImparTableAdapter3;
        private ImpressaoDataSetTableAdapters.tblImpressaoParTableAdapter tblImpressaoParTableAdapter3;
        private ImpressaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}