using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
namespace lab
{
    public partial class LogInForm : Form
    {
        String username;
        String password;
        MainForm mainForm = new MainForm();
        String con;
        public LogInForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        // Triggers when the user click the Submit and checks if the entered info is correct 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.username = txtUserName.Text;
            this.password = txtPassword.Text;
            con = "Server=localhost;Database=dbSalesInventory; User = root; Password = 1234 ";
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                /* in this the @username and @password will be a placeholder using a parameterized query
                   these placeholder will be replaced with actual values during execution
                   this prevents SQL injection  */
                cmd.CommandText = "SELECT * FROM users WHERE username = @username AND pass = @password";
                cmd.Parameters.AddWithValue("@username", this.username);
                cmd.Parameters.AddWithValue("@password", this.password);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Valid username and password, show the mainForm
                    MessageBox.Show("WELCOME " + this.username.ToUpper());
                    //redirected to MainForm
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    // Invalid username or password, show an error message
                    MessageBox.Show("Invalid username or password");
                }
                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chbShowPass.Checked;
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {

        }

    }
}