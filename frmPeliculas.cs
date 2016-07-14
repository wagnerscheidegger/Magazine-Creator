using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Magazine_Creator
{
    public partial class frmPeliculas : Form
    {
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void tblPeliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblPeliculasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.magazineDataSet);
                System.Windows.Forms.MessageBox.Show("Película: '" + txtCod.Text + "' criada com sucesso!");
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                tblPeliculasBindingNavigatorEdit.Enabled = true;
                tblPeliculasBindingNavigatorSaveItem.Enabled = false;

                txtId.Enabled = false;
                txtCod.Enabled = false;
                cbCategoria.Enabled = false;
                txtImagem.Enabled = false;
                btLoadImagem.Visible = false;
                picImagem.Update();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Não foi possivel gravar os dados, verifique se todos os campos foram preenchidos");
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                tblPeliculasBindingNavigatorEdit.Enabled = false;
                tblPeliculasBindingNavigatorSaveItem.Enabled = true;

                txtId.Enabled = false;
                txtCod.Enabled = true;
                cbCategoria.Enabled = true;
                txtImagem.Enabled = true;
                btLoadImagem.Visible = true;
            }

        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazineDataSet.tblPeliculas' table. You can move, or remove it, as needed.
            this.tblPeliculasTableAdapter.Fill(this.magazineDataSet.tblPeliculas);

        }

        private void tblPeliculasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            picImagem.ImageLocation = txtImagem.Text;
            picImagem.Update();
        }

        string pathImagem = "";

        private void btLoadImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.JPG)|*.jpg|PNG Files(*.PNG)|*.png";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image imagem = Image.FromFile(dlg.FileName);
                pathImagem = dlg.FileName.ToString();
                txtImagem.Text = pathImagem;
                picImagem.Image = imagem;

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            tblPeliculasBindingNavigatorEdit.Enabled = false;
            tblPeliculasBindingNavigatorSaveItem.Enabled = true;

            txtId.Enabled = false;
            txtCod.Enabled = true;
            cbCategoria.Enabled = true;
            txtImagem.Enabled = false;
            btLoadImagem.Visible = true;
            picImagem.ImageLocation = "";

            string connectionString = Magazine_Creator.Properties.Settings.Default.MagazinedasunhasConnectionString;
            SqlConnection conectasql = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;


                cmd.CommandText = "SELECT top 1 Id FROM tblPeliculas ORDER BY Id DESC";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conectasql;

                conectasql.Open();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var lastId = reader.GetInt32(0) + 1;
                        txtId.Text = lastId.ToString();
                    }
                }

                conectasql.Close();

            
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            picImagem.ImageLocation = txtImagem.Text;
            picImagem.Update();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            picImagem.ImageLocation = txtImagem.Text;
            picImagem.Update();
        }

        private void tblPeliculasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            picImagem.ImageLocation = txtImagem.Text;
            picImagem.Update();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtCod.Enabled = false;
            cbCategoria.Enabled = false;
            txtImagem.Enabled = false;
            btLoadImagem.Visible = false;
            picImagem.Update();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            picImagem.ImageLocation = txtImagem.Text;
            picImagem.Update();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            picImagem.ImageLocation = txtImagem.Text;
            picImagem.Update();
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            cbCategoria.Items.Clear();
            List<string> items = new List<string>();
            string connectionString = Magazine_Creator.Properties.Settings.Default.MagazinedasunhasConnectionString;
            SqlConnection conectasql = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;


            cmd.CommandText = "SELECT Categoria FROM tblPeliculas GROUP BY Categoria ORDER BY Categoria DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conectasql;

            conectasql.Open();

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string item = reader.GetString(reader.GetOrdinal("Categoria"));
                    cbCategoria.Items.Add(item);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nenhum Registro encontrado!");
            }

            conectasql.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            tblPeliculasBindingNavigatorSaveItem.Enabled = true;
            tblPeliculasBindingNavigatorEdit.Enabled = false;

            txtId.Enabled = false;
            txtCod.Enabled = true;
            cbCategoria.Enabled = true;
            txtImagem.Enabled = false;
            btLoadImagem.Visible = true;
        }
    }
}
