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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
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
                SqlCommand cmd = new SqlCommand("select * from mUser where id_user='" + tbIdUser.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



                tbIdUser.Text = dt.Rows[0]["id_user"].ToString();
                tbNamaUser.Text = dt.Rows[0]["nama_user"].ToString();
                tbUsername.Text = dt.Rows[0]["username"].ToString();
                tbPassword.Text = dt.Rows[0]["password"].ToString();
                tbJabatan.Text = dt.Rows[0]["jabatan"].ToString();
                tbNoTelpUser.Text = dt.Rows[0]["telp_user"].ToString();




                tbNamaUser.Enabled = true;
                tbNamaUser.Enabled = true;
                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
                tbJabatan.Enabled = true;
                tbNoTelpUser.Enabled = true;


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


                com.CommandText = "sp_UpdateUser";
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@id_user", tbIdUser.Text);
                com.Parameters.AddWithValue("@nama_user", tbNamaUser.Text);
                com.Parameters.AddWithValue("@username", tbUsername.Text);
                com.Parameters.AddWithValue("@password", tbPassword.Text);
                com.Parameters.AddWithValue("@jabatan", tbJabatan.Text);
                com.Parameters.AddWithValue("@telp_user", tbNoTelpUser.Text);



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
                com.CommandText = "sp_DeleteUser";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_user", tbIdUser.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data user berhasil!", "HaloTek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear();

                }
                else
                {
                    MessageBox.Show("Delete data user gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
