using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace lab
{
    public partial class InventoryForm : Form
    {
        String con = "Server=localhost;Database=dbSalesInventory; User = root; Password =1234";
        public InventoryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DisplayInveTable();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        public void DisplayInveTable()
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                MySqlCommand cmdItems = connection.CreateCommand();
                cmdItems.CommandText = "SELECT inventory.itemID,inventory.quantity,items.itemName FROM inventory LEFT JOIN items ON inventory.itemID = items.itemID ORDER BY inventory.quantity ASC ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdItems);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvMain.DataSource = ds.Tables[0].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR IN " + ex.Message);
            }
        }
    }
}
