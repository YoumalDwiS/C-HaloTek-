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
    public partial class UpdateObat : Form
    {
        public UpdateObat()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source =.; initial catalog = HaloTek";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from mObat where id_obat='" + tbIdObat.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



                tbIdObat.Text = dt.Rows[0]["id_obat"].ToString();
                tbNamaObat.Text = dt.Rows[0]["nama_obat"].ToString();
                cbNamaKategori.SelectedValue = dt.Rows[0]["id_kategori"].ToString();
                tbKandungan.Text = dt.Rows[0]["kandungan"].ToString();
                tbJenis.Text = dt.Rows[0]["jenis"].ToString();
                tbStok.Text = dt.Rows[0]["stok"].ToString();
                tbHarga.Text = dt.Rows[0]["harga"].ToString();





                tbNamaObat.Enabled = true;
                cbNamaKategori.Enabled = true;
                tbKandungan.Enabled = true;
                tbJenis.Enabled = true;
                tbStok.Enabled = true;
                tbHarga.Enabled = true;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaf data tidak ditemukan", ex.Message
                    );
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=HaloTek";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;


                com.CommandText = "sp_UpdateObat";
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@id_obat", tbIdObat.Text);
                com.Parameters.AddWithValue("@nama_obat", tbNamaObat.Text);
                com.Parameters.AddWithValue("@id_kategori", cbNamaKategori.SelectedValue);
                com.Parameters.AddWithValue("@kandungan", tbKandungan.Text);
                com.Parameters.AddWithValue("@jenis", tbJenis.Text);
                com.Parameters.AddWithValue("@stok", tbStok.Text);
                com.Parameters.AddWithValue("@harga", tbHarga.Text);



                connection.Open();
                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();

                if (result != 0)
                {
                    MessageBox.Show("Update data berhasil");
                    // clear();
                }
                else
                {
                    MessageBox.Show("Update data gagal");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=HaloTek";
                SqlConnection connection = new SqlConnection(@connectionString);
                SqlCommand com = new SqlCommand();

                com.Connection = connection;
                com.CommandText = "sp_DeleteObat";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_obat", tbIdObat.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data obat berhasil!", "HaloTek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear();

                }
                else
                {
                    MessageBox.Show("Delete data obat gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
