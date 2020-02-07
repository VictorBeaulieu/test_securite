using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detaclon
{
    public partial class AddingAisleForm : Form
    {
        public AddingAisleForm()
        {
            InitializeComponent();
            textBox1.Text = Program.ville;
            if (Program.user_role == "ADMIN")
            {
                
                textBox1.ReadOnly = false;
                textBox1.Enabled = true;
            }
            if (Program.user_role == "patron")
            {

                textBox1.ReadOnly = false;
                textBox1.Enabled = true;
            }
            if (Program.user_role == "chef de magasin")
            {
                
                textBox1.ReadOnly = true;
                textBox1.Enabled = false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            string query = "INSERT INTO [AISLE] VALUES (@ville, @aisle)";

            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {

                cmd.Parameters.AddWithValue("@aisle", textbox_name.Text);
                cmd.Parameters.AddWithValue("@ville", textBox1.Text);
                connection.Open();
                cmd.ExecuteScalar();
                connection.Close();
            }
            this.Close();
        }
    }
}
