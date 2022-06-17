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

namespace HaloTek
{
    public partial class InputObat : Form
    {
        public InputObat()
        {
            InitializeComponent();
        }

        private void InputObat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'haloTekDataSet.mKategori' table. You can move, or remove it, as needed.
            this.mKategoriTableAdapter.Fill(this.haloTekDataSet.mKategori);

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=HaloTek;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InputObat", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_obat", tbIdObat.Text);
            insert.Parameters.AddWithValue("nama_obat", tbNamaObat.Text);
            insert.Parameters.AddWithValue("id_kategori", cbNamaKategori.SelectedValue);
            insert.Parameters.AddWithValue("kandungan", tbKandungan.Text);
            insert.Parameters.AddWithValue("jenis", tbJenis.Text);
            insert.Parameters.AddWithValue("stok", tbStok.Text);
            insert.Parameters.AddWithValue("harga", tbHarga.Text);


            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data saved succesfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }
        }
    }
}
