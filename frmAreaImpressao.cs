using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine_Creator
{
    public partial class frmAreaImpressao : Form
    {
        public frmAreaImpressao()
        {
            InitializeComponent();
        }

        private void tblImpressaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblImpressaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazineDataSet);

        }

        private void frmAreaImpressao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazineDataSet.tblImpressao' table. You can move, or remove it, as needed.
            this.tblImpressaoTableAdapter.Fill(this.magazineDataSet.tblImpressao);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportCartela frm = new frmReportCartela();
            frm.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblImpressaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazineDataSet);
        }
    }
}
