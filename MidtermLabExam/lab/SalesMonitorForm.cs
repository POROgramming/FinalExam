using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace lab
{
    public partial class SalesMonitorForm : Form
    {
        String con;
        public SalesMonitorForm()
        {
            InitializeComponent();
            con = "Server=localhost; Database = dbSalesInventory; User = root; Password = 1234 ";
            this.StartPosition = FormStartPosition.CenterScreen;
            DisplaySales();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm openMainForm = new MainForm();
            openMainForm.Show();
            this.Hide();
        }
        private void DisplaySales()
        {
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            try
            {
                MySqlCommand cmdSales = connection.CreateCommand();
                cmdSales.CommandText = "SELECT * FROM sales ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSales);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvSales.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
