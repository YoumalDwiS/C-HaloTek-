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
    public partial class UpdateResep : Form
    {
        public UpdateResep()
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
                SqlCommand cmd = new SqlCommand("select * from mResep where id_resep='" + tbIdResep.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



                tbIdResep.Text = dt.Rows[0]["id_resep"].ToString();
                cbNamaCustomer.Text = dt.Rows[0]["id_customer"].ToString();
                cbNamaObat.Text = dt.Rows[0]["id_obat"].ToString();
                tbPenyakit.Text = dt.Rows[0]["penyakit"].ToString();
                dtTglInput.Text = dt.Rows[0]["tgl_input"].ToString();






                cbNamaCustomer.Enabled = true;
                cbNamaObat.Enabled = true;
                tbPenyakit.Enabled = true;
                dtTglInput.Enabled = true;




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


                com.CommandText = "sp_UpdateResep";
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@id_resep", tbIdResep.Text);
                com.Parameters.AddWithValue("@id_customer", cbNamaCustomer.SelectedValue);
                com.Parameters.AddWithValue("@id_obat", cbNamaObat.SelectedValue);
                com.Parameters.AddWithValue("@penyakit", tbPenyakit.Text);
                com.Parameters.AddWithValue("@tgl_input", dtTglInput.Value);
              



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
                com.CommandText = "sp_DeleteResep";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_resep", tbIdResep.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data resep berhasil!", "HaloTek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear();

                }
                else
                {
                    MessageBox.Show("Delete data resep gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
