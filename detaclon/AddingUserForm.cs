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
    public partial class AddingUserForm : Form
    {
        public AddingUserForm()
        {
            InitializeComponent();
            cb_role.SelectedIndex = 2;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            string query = "INSERT INTO [USER] VALUES (@FirstName, @LastName, @LoginID, @LoginPWD, @Role, @Ville)";

            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                
                cmd.Parameters.AddWithValue("@FirstName", textbox_prenom.Text);
                cmd.Parameters.AddWithValue("@LastName", textbox_nom.Text);
                cmd.Parameters.AddWithValue("@LoginID", textbox_prenom.Text.ToLower());
                cmd.Parameters.AddWithValue("@LoginPWD", textbox_prenom.Text.ToLower());
                cmd.Parameters.AddWithValue("@Role", cb_role.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Ville", textbox_ville.Text.ToString());
                connection.Open();
                cmd.ExecuteScalar();
                connection.Close();
            }
            this.Close();
            

        }
    }
}
