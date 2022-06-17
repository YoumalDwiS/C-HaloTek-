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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
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
                SqlCommand cmd = new SqlCommand("select * from mCustomer where id_customer='" + tbIdCustomer.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



                tbIdCustomer.Text = dt.Rows[0]["id_customer"].ToString();
                tbNamaCustomer.Text = dt.Rows[0]["nama_customer"].ToString();
                tbNoTelponCustomer.Text = dt.Rows[0]["telp_customer"].ToString();
               




                tbNamaCustomer.Enabled = true;
                tbNoTelponCustomer.Enabled = true;
                


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


                com.CommandText = "sp_UpdateCustomer";
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.AddWithValue("@id_customer", tbIdCustomer.Text);
                com.Parameters.AddWithValue("@nama_customer", tbNamaCustomer.Text);
                com.Parameters.AddWithValue("@telp_customer", tbNoTelponCustomer.Text);
                



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
                com.CommandText = "sp_DeleteCustomer";

                // mengatur tipe command yang akan digunaan
                com.CommandType = CommandType.StoredProcedure;

                //parameter yang akan dikirimkan ke sp di basis data
                com.Parameters.AddWithValue("@id_customer", tbIdCustomer.Text);

                connection.Open();

                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();
                // cek apakah ada data akan ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Delete data customer berhasil!", "HaloTek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear();

                }
                else
                {
                    MessageBox.Show("Delete data customer gagal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
