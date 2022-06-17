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
    public partial class InputUser : Form
    {
        public InputUser()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=HaloTek;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InputUser", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_user", tbIdUser.Text);
            insert.Parameters.AddWithValue("nama_user", tbNamaUser.Text);
            insert.Parameters.AddWithValue("username", tbUsername.Text);
            insert.Parameters.AddWithValue("password", tbPassword.Text);
            insert.Parameters.AddWithValue("jabatan", tbJabatan.Text);
            insert.Parameters.AddWithValue("telp_user", tbNoTelpUser.Text);
            


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
