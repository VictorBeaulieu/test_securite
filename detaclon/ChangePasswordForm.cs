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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            string query = "UPDATE[User] SET LoginPWD = @PWD WHERE(FirstName = '" + Program.firstname + "' AND LastName = '" + Program.lastname + "')";

            SqlConnection connection;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {

                
                connection.Open();
                cmd.Parameters.AddWithValue("@PWD", textbox_new_PWD.Text);
                cmd.ExecuteScalar();
                connection.Close();
            }
            this.Close();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["detaclon.Properties.Settings.detaclonDatabaseConnectionString"].ConnectionString;
            SqlConnection connection;
            DataTable table = new DataTable();
            string query = "SELECT FirstName, LastName, LoginId, LoginPWD, Role FROM[USER] WHERE LoginID =\'" + Program.login_ID + "\'";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                connection.Open();

                adapter.Fill(table);
                connection.Close();
            }

            textbox_current_PWD.Text = table.Rows[0].Field<string>("LoginPWD");
        }
    }
}
