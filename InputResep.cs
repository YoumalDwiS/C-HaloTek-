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
    public partial class InputResep : Form
    {
        public InputResep()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=.;Initial Catalog=HaloTek;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InputResep", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_resep", tbIdResep.Text);
            insert.Parameters.AddWithValue("id_customer", cbNamaCustomer.SelectedValue);
            insert.Parameters.AddWithValue("id_obat", cbNamaObat.SelectedValue);
            insert.Parameters.AddWithValue("penyakit", tbPenyakit.Text);
            insert.Parameters.AddWithValue("tgl_input", dtTglInput.Value);
            


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

        private void InputResep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'haloTekDataSet2.mObat' table. You can move, or remove it, as needed.
            this.mObatTableAdapter.Fill(this.haloTekDataSet2.mObat);
            // TODO: This line of code loads data into the 'haloTekDataSet1.mCustomer' table. You can move, or remove it, as needed.
            this.mCustomerTableAdapter.Fill(this.haloTekDataSet1.mCustomer);

        }
    }
}
