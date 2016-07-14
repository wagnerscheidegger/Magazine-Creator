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
    public partial class frmCartelas2 : Form
    {
        public frmCartelas2()
        {
            InitializeComponent();
        }

        public void GeraListaCodPeliculas(ComboBox nomeCombo)
        {
            nomeCombo.Items.Clear();

            List<string> items = new List<string>();
            string connectionString = Magazine_Creator.Properties.Settings.Default.MagazinedasunhasConnectionString;
            SqlConnection conectasql = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT Cod FROM tblPeliculas GROUP BY Cod ORDER BY Cod ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conectasql;

            conectasql.Open();

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string item = reader.GetString(reader.GetOrdinal("Cod"));
                    nomeCombo.Items.Add(item);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nenhum Registro encontrado!");
            }

            conectasql.Close();
        }

        public void GeraListaCodFracesinhas(ComboBox nomeCombo)
        {
            nomeCombo.Items.Clear();

            List<string> items = new List<string>();
            string connectionString = Magazine_Creator.Properties.Settings.Default.MagazinedasunhasConnectionString;
            SqlConnection conectasql = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT Cod, Categoria FROM tblPeliculas WHERE(Categoria = 'Francesinha') GROUP BY Cod, Categoria ORDER BY Cod ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conectasql;

            conectasql.Open();

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string item = reader.GetString(reader.GetOrdinal("Cod"));
                    nomeCombo.Items.Add(item);
                }
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("Nenhum Registro encontrado!");
            }

            conectasql.Close();
        }

        public void AtualizaVisualizacaoPelicula(PictureBox nomePic, ComboBox nomeCombo)
        {
            nomePic.ImageLocation = "";
            string connectionString = Magazine_Creator.Properties.Settings.Default.MagazinedasunhasConnectionString;
            SqlConnection conectasql = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            string linhadecomando = "SELECT Cod, Imagem FROM tblPeliculas WHERE(Cod = N'" + nomeCombo.Text + "')";
            cmd.CommandText = linhadecomando;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conectasql;

            conectasql.Open();

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string item = reader.GetString(reader.GetOrdinal("Imagem"));
                    nomePic.ImageLocation = item;
                }
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("Nenhum Registro encontrado!");
            }

            conectasql.Close();
            nomePic.Update();

        }

        public void AtualizaVisualizacaoTodas()
        {
            AtualizaVisualizacaoPelicula(picMd1, cbMd1);
            AtualizaVisualizacaoPelicula(picMd2, cbMd2);
            AtualizaVisualizacaoPelicula(picMd3, cbMd3);
            AtualizaVisualizacaoPelicula(picMd4, cbMd4);
            AtualizaVisualizacaoPelicula(picMd5, cbMd5);
            AtualizaVisualizacaoPelicula(picMd6, cbMd6);
            AtualizaVisualizacaoPelicula(picMe1, cbMe1);
            AtualizaVisualizacaoPelicula(picMe2, cbMe2);
            AtualizaVisualizacaoPelicula(picMe3, cbMe3);
            AtualizaVisualizacaoPelicula(picMe4, cbMe4);
            AtualizaVisualizacaoPelicula(picMe5, cbMe5);
            AtualizaVisualizacaoPelicula(picMe6, cbMe6);
            AtualizaVisualizacaoPelicula(picFr1, cbFr1);
            AtualizaVisualizacaoPelicula(picFr2, cbFr2);
            AtualizaVisualizacaoPelicula(picFr3, cbFr3);
            AtualizaVisualizacaoPelicula(picFr4, cbFr4);
            AtualizaVisualizacaoPelicula(picFr5, cbFr5);
            AtualizaVisualizacaoPelicula(picFr6, cbFr6);
        }


        private void tblCartelasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.Validate();
                this.tblCartelasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.magazineDataSet);
                System.Windows.Forms.MessageBox.Show("Cartela: '" + txtCod.Text + "' criada com sucesso!");
                AtualizaVisualizacaoTodas();

                tblCartelasBindingNavigatorEdit.Enabled = true;
                tblCartelasBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;

                txtCod.Enabled = false;
                txtCategoria.Enabled = false;
                cbMd1.Enabled = false;
                cbMd2.Enabled = false;
                cbMd3.Enabled = false;
                cbMd4.Enabled = false;
                cbMd5.Enabled = false;
                cbMd6.Enabled = false;
                cbMe1.Enabled = false;
                cbMe2.Enabled = false;
                cbMe3.Enabled = false;
                cbMe4.Enabled = false;
                cbMe4.Enabled = false;
                cbMe5.Enabled = false;
                cbMe6.Enabled = false;
                cbFr1.Enabled = false;
                cbFr2.Enabled = false;
                cbFr3.Enabled = false;
                cbFr4.Enabled = false;
                cbFr4.Enabled = false;
                cbFr5.Enabled = false;
                cbFr6.Enabled = false;
            }
            catch (SqlException)
            {
                System.Windows.Forms.MessageBox.Show("Não foi possivel gravar os dados, verifique se todos os campos foram preenchidos");
                AtualizaVisualizacaoTodas();

                tblCartelasBindingNavigatorEdit.Enabled = false;
                tblCartelasBindingNavigatorSaveItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;

                txtCod.Enabled = true;
                txtCategoria.Enabled = true;
                cbMd1.Enabled = true;
                cbMd2.Enabled = true;
                cbMd3.Enabled = true;
                cbMd4.Enabled = true;
                cbMd5.Enabled = true;
                cbMd6.Enabled = true;
                cbMe1.Enabled = true;
                cbMe2.Enabled = true;
                cbMe3.Enabled = true;
                cbMe4.Enabled = true;
                cbMe4.Enabled = true;
                cbMe5.Enabled = true;
                cbMe6.Enabled = true;
                cbFr1.Enabled = true;
                cbFr2.Enabled = true;
                cbFr3.Enabled = true;
                cbFr4.Enabled = true;
                cbFr4.Enabled = true;
                cbFr5.Enabled = true;
                cbFr6.Enabled = true;
            }

        }


        private void frmCartelas2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazineDataSet.tblCartelas' table. You can move, or remove it, as needed.
            this.tblCartelasTableAdapter.Fill(this.magazineDataSet.tblCartelas);
            AtualizaVisualizacaoTodas();
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AtualizaVisualizacaoTodas();

            tblCartelasBindingNavigatorEdit.Enabled = false;
            tblCartelasBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;

            txtCod.Enabled = true;
            txtCategoria.Enabled = true;
            cbMd1.Enabled = true;
            cbMd2.Enabled = true;
            cbMd3.Enabled = true;
            cbMd4.Enabled = true;
            cbMd5.Enabled = true;
            cbMd6.Enabled = true;
            cbMe1.Enabled = true;
            cbMe2.Enabled = true;
            cbMe3.Enabled = true;
            cbMe4.Enabled = true;
            cbMe4.Enabled = true;
            cbMe5.Enabled = true;
            cbMe6.Enabled = true;
            cbFr1.Enabled = true;
            cbFr2.Enabled = true;
            cbFr3.Enabled = true;
            cbFr4.Enabled = true;
            cbFr4.Enabled = true;
            cbFr5.Enabled = true;
            cbFr6.Enabled = true;

            string connectionString = Magazine_Creator.Properties.Settings.Default.MagazinedasunhasConnectionString;
            SqlConnection conectasql = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;


            cmd.CommandText = "SELECT top 1 Id FROM tblCartelas ORDER BY Id DESC";
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
            else
            {
                txtId.Text = "1";
            }

            conectasql.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            AtualizaVisualizacaoTodas();
            txtCod.Enabled = false;
            txtCategoria.Enabled = false;
            cbMd1.Enabled = false;
            cbMd2.Enabled = false;
            cbMd3.Enabled = false;
            cbMd4.Enabled = false;
            cbMd5.Enabled = false;
            cbMd6.Enabled = false;
            cbMe1.Enabled = false;
            cbMe2.Enabled = false;
            cbMe3.Enabled = false;
            cbMe4.Enabled = false;
            cbMe4.Enabled = false;
            cbMe5.Enabled = false;
            cbMe6.Enabled = false;
            cbFr1.Enabled = false;
            cbFr2.Enabled = false;
            cbFr3.Enabled = false;
            cbFr4.Enabled = false;
            cbFr4.Enabled = false;
            cbFr5.Enabled = false;
            cbFr6.Enabled = false;
        }

        private void cbMd1_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMd1);
        }

        private void cbMd2_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMd2);
        }

        private void cbMd3_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMd3);
        }

        private void cbMd4_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMd4);
        }

        private void cbMd5_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMd5);
        }

        private void cbMd6_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMd6);
        }

        private void cbMe1_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMe1);
        }

        private void cbMe2_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMe2);
        }

        private void cbMe3_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMe3);
        }

        private void cbMe4_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMe4);
        }

        private void cbMe5_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMe5);
        }

        private void cbMe6_Click(object sender, EventArgs e)
        {
            GeraListaCodPeliculas(cbMe6);
        }

        private void cbMd1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMd1, cbMd1);
        }

        private void cbMd2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMd2, cbMd2);
        }

        private void cbMd3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMd3, cbMd3);
        }

        private void cbMd4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMd4, cbMd4);
        }

        private void cbMd5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMd5, cbMd5);
        }

        private void cbMd6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMd6, cbMd6);
        }

        private void cbMe1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMe1, cbMe1);
        }

        private void cbMe2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMe2, cbMe2);
        }

        private void cbMe3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMe3, cbMe3);
        }

        private void cbMe4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMe4, cbMe4);
        }

        private void cbMe5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMe5, cbMe5);
        }

        private void cbMe6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picMe6, cbMe6);
        }

        private void tblCartelasDataGridView_Click(object sender, EventArgs e)
        {
            AtualizaVisualizacaoTodas();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string connectionString = Magazine_Creator.Properties.Settings.Default.MagazinedasunhasConnectionString;
            SqlConnection conectasql = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from tblCartelas", conectasql);
            
            conectasql.Open();
            
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            da.Fill(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "Cod like'" + txtPesquisa.Text + "%'";

            if (txtPesquisa.Text != null)
            {
                tblCartelasBindingSource.DataSource = dv;
                AtualizaVisualizacaoTodas();
            }


            conectasql.Close();

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            AtualizaVisualizacaoTodas();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            AtualizaVisualizacaoTodas();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            AtualizaVisualizacaoTodas();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            AtualizaVisualizacaoTodas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = Magazine_Creator.Properties.Settings.Default.MagazinedasunhasConnectionString;
            SqlConnection conectasql = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            int lastId = 0;

            cmd.CommandText = "SELECT top 1 Id FROM tblImpressao ORDER BY Id DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conectasql;

            conectasql.Open();

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lastId = reader.GetInt32(0) + 1;
                }
            }
            else
            {
                lastId = 1;
            }

            conectasql.Close();

            string lastIdNun = lastId.ToString();
           
            cmd.CommandText = "INSERT into tblImpressao (Id, CartelaCod, Md1, Md2, Md3, Md4, Md5, Md6, Me1, Me2, Me3, Me4, Me5, Me6, Fr1, Fr2, Fr3, Fr4, Fr5, Fr6) VALUES (@Id, @CartelaCod, @Md1, @Md2, @Md3, @Md4, @Md5, @Md6, @Me1, @Me2, @Me3, @Me4, @Me5, @Me6, @Fr1, @Fr2, @Fr3, @Fr4, @Fr5, @Fr6)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", lastIdNun);
            cmd.Parameters.AddWithValue("@CartelaCod", txtCod.Text);
            cmd.Parameters.AddWithValue("@Md1", picMd1.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Md2", picMd2.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Md3", picMd3.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Md4", picMd4.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Md5", picMd5.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Md6", picMd6.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Me1", picMe1.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Me2", picMe2.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Me3", picMe3.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Me4", picMe4.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Me5", picMe5.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Me6", picMe6.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Fr1", picFr1.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Fr2", picFr2.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Fr3", picFr3.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Fr4", picFr4.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Fr5", picFr5.ImageLocation.ToString());
            cmd.Parameters.AddWithValue("@Fr6", picFr6.ImageLocation.ToString());
            cmd.Connection = conectasql;
            
            try
            {
                conectasql.Open();
                int recordsAffected = cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Cartela: '"+txtCod.Text+"' Adicionado a Tabela Impressões");
            }
            catch (SqlException)
            {
                System.Windows.Forms.MessageBox.Show("Não foi possivel gravar os dados na Tabela Impressões!");
            }
            finally
            {
                conectasql.Close();
            }

        }

        private void cbFr1_Click(object sender, EventArgs e)
        {
            GeraListaCodFracesinhas(cbFr1);
        }

        private void cbFr2_Click(object sender, EventArgs e)
        {
            GeraListaCodFracesinhas(cbFr2);
        }

        private void cbFr3_Click(object sender, EventArgs e)
        {
            GeraListaCodFracesinhas(cbFr3);
        }

        private void cbFr4_Click(object sender, EventArgs e)
        {
            GeraListaCodFracesinhas(cbFr4);
        }

        private void cbFr5_Click(object sender, EventArgs e)
        {
            GeraListaCodFracesinhas(cbFr5);
        }

        private void cbFr6_Click(object sender, EventArgs e)
        {
            GeraListaCodFracesinhas(cbFr6);
        }

        private void cbFr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picFr1, cbFr1);
        }

        private void cbFr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picFr2, cbFr2);
        }

        private void cbFr3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picFr3, cbFr3);
        }

        private void cbFr4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picFr4, cbFr4);
        }

        private void cbFr5_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picFr5, cbFr5);
        }

        private void cbFr6_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaVisualizacaoPelicula(picFr6, cbFr6);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AtualizaVisualizacaoTodas();
            tblCartelasBindingNavigatorEdit.Enabled = false;
            tblCartelasBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            txtCod.Enabled = true;
            txtCategoria.Enabled = true;
            cbMd1.Enabled = true;
            cbMd2.Enabled = true;
            cbMd3.Enabled = true;
            cbMd4.Enabled = true;
            cbMd5.Enabled = true;
            cbMd6.Enabled = true;
            cbMe1.Enabled = true;
            cbMe2.Enabled = true;
            cbMe3.Enabled = true;
            cbMe4.Enabled = true;
            cbMe4.Enabled = true;
            cbMe5.Enabled = true;
            cbMe6.Enabled = true;
            cbFr1.Enabled = true;
            cbFr2.Enabled = true;
            cbFr3.Enabled = true;
            cbFr4.Enabled = true;
            cbFr4.Enabled = true;
            cbFr5.Enabled = true;
            cbFr6.Enabled = true;
        }
    }
}
