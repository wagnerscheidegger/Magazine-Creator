using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.DataProcessing;

namespace Magazine_Creator
{
    public partial class frmReportCartela : Form
    {
        public frmReportCartela()
        {
            InitializeComponent();
        }

        private void frmReportCartela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'impressaoDataSet5.tblImpressaoPar' table. You can move, or remove it, as needed.
            this.tblImpressaoParTableAdapter3.Fill(this.impressaoDataSet5.tblImpressaoPar);
            // TODO: This line of code loads data into the 'impressaoDataSet5.tblImpressaoImpar' table. You can move, or remove it, as needed.
            this.tblImpressaoImparTableAdapter3.Fill(this.impressaoDataSet5.tblImpressaoImpar);


            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.RefreshReport();

        }
    }
}
