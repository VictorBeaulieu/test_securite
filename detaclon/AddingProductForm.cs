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

        public decimal qty_product(string name)
        {
            decimal qty = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            string query = "SELECT quantité FROM [PRODUCT] WHERE nom ='name'";

            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                qty = (decimal)cmd.ExecuteScalar();
                connection.Close();
            }
            this.Close();
            return qty;
        }

        public void add_product(string name, decimal qty)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            string query = "INSERT INTO [PRODUCT] VALUES (@Nom, @Quantité)";

            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {

                cmd.Parameters.AddWithValue("@Nom", name);
                cmd.Parameters.AddWithValue("@Quantité", qty);
                connection.Open();
                cmd.ExecuteScalar();
                connection.Close();
            }
            this.Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.add_product(textbox_name.Text, numericQuantity.Value);
        }
    }
}
