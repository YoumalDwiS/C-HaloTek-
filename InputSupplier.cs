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
    public partial class InputSupplier : Form
    {
        public InputSupplier()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=HaloTek;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InputSupplier", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_supplier", tbIdSupplier.Text);
            insert.Parameters.AddWithValue("nama_supplier", tbNamaSupplier.Text);
            insert.Parameters.AddWithValue("telp_supplier", tbNoTelponSupplier.Text);
            insert.Parameters.AddWithValue("alamat", tbAlamatSupplier.Text);
            


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
