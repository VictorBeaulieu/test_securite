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
    public partial class AddingProductForm : Form
    {
        public AddingProductForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            string query = "INSERT INTO [PRODUCT] VALUES (@Nom, @Quantité)";

            SqlConnection connection;   
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                
                cmd.Parameters.AddWithValue("@Nom", textbox_name.Text);
                cmd.Parameters.AddWithValue("@Quantité", numericQuantity.Value);
                connection.Open();
                cmd.ExecuteScalar();
                connection.Close();
            }
            this.Close();

        }
    }
}
