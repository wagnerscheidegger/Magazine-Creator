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
using System.Data.SqlClient;



namespace Magazine_Creator
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void btPeliculas_Click(object sender, EventArgs e)
        {
            frmPeliculas frm = new frmPeliculas();
            frm.Show();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MagazineDataSet.tblCartelas' table. You can move, or remove it, as needed.
            this.tblCartelasTableAdapter.Fill(this.MagazineDataSet.tblCartelas);
            // TODO: This line of code loads data into the 'MagazineDataSet.tblPeliculas' table. You can move, or remove it, as needed.
            this.tblPeliculasTableAdapter.Fill(this.MagazineDataSet.tblPeliculas);

        }

        private void btCartelas_Click(object sender, EventArgs e)
        {
            frmCartelas2 frm = new frmCartelas2();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAreaImpressao frm = new frmAreaImpressao();
            frm.Show();
        }

    }
}
