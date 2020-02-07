using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace detaclon
{
    public partial class AddingStoreForm : Form
    {
        public AddingStoreForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            string query = "INSERT INTO [STORE] VALUES (@Ville, @Nom, @Prenom)";

            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {

                cmd.Parameters.AddWithValue("@Ville", textbox_ville.Text);
                cmd.Parameters.AddWithValue("@Nom", textbox_nom.Text);
                cmd.Parameters.AddWithValue("@Prenom", textbox_prenom.Text);
                connection.Open();
                cmd.ExecuteScalar();
                connection.Close();
            }
            this.Close();
        }
    }
}
