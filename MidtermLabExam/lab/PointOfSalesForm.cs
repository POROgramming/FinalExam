    using System;
    using System.Data;
    using System.Windows.Forms;
    using MySqlConnector;

namespace lab
{
    public partial class PointOfSalesForm : Form
    {
        MainForm openMainForm = new MainForm();
        DateTime currentDate = DateTime.Now;
        string con = "Server=localhost;Database=dbSalesInventory; User=root; Password=1234";

        public PointOfSalesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DisplayInveTable();

            dgvPOS.CellClick += dgvPOS_CellClick;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            openMainForm.Show();
            Hide();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Implement your checkout logic here
        }

        private void DisplayInveTable()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con);
                conn.Open();

                MySqlCommand cmdItems = new MySqlCommand("SELECT inventory.itemID,inventory.quantity,items.itemName FROM inventory LEFT JOIN items ON inventory.itemID = items.itemID", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdItems);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvPOS.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR IN " + ex.Message);
            }
        }

        private void dgvPOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblItemID.Text = $"Selected Item ID: {dgvPOS.Rows[e.RowIndex].Cells["itemID"].Value}";
                lblQuantity.Text = $"Quantity: {dgvPOS.Rows[e.RowIndex].Cells["quantity"].Value}";
                lblItemName.Text = $"Selected Item Name: {dgvPOS.Rows[e.RowIndex].Cells["itemName"].Value}";

            }
        }




        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            if (dgvPOS.SelectedRows.Count > 0 && dgvPOS.SelectedRows[0].Index != -1)
            {
                MySqlConnection connection = new MySqlConnection(con);
                connection.Open();

                int itemID = Convert.ToInt32(dgvPOS.SelectedRows[0].Cells["itemID"].Value);
                int totalAmount;
                if (int.TryParse(txtOrderQuantity.Text, out int orderQuantity))
                {
                    int itemQuantity = Convert.ToInt32(dgvPOS.SelectedRows[0].Cells["quantity"].Value);

                    if (orderQuantity <= 0 || orderQuantity > itemQuantity)
                    {
                        MessageBox.Show("Invalid order quantity. Please enter a valid quantity.");
                    }
                    else
                    {
                        MySqlCommand cmdAddToCart = new MySqlCommand("UPDATE inventory SET quantity = quantity - @quantity WHERE itemID = @itemID",connection);
                        cmdAddToCart.Parameters.AddWithValue("@quantity", orderQuantity);
                        cmdAddToCart.Parameters.AddWithValue("@itemID", itemID);

                        cmdAddToCart.ExecuteNonQuery();
                     
                        MySqlCommand cmdAmount = new MySqlCommand("SELECT baseprice FROM items Where itemID = @itemID",connection);
                        cmdAmount.Parameters.AddWithValue("@itemID", itemID);
                        object objAmount = cmdAmount.ExecuteScalar();

                        if(objAmount!= null) { 
                            totalAmount = Convert.ToInt32(objAmount);
                            totalAmount = totalAmount * orderQuantity;
                            string receiptDate = this.currentDate.ToString("yyyy-MM-dd");
                            MySqlCommand cmdReceipt = new MySqlCommand("INSERT INTO sales (receiptDate,itemID,quantity,totalAmount) VALUES(@receiptDate,@itemID,@quantity,@totalAmount)",connection);
                            cmdReceipt.Parameters.AddWithValue("@receiptDate", receiptDate);
                            cmdReceipt.Parameters.AddWithValue("@itemID", itemID);

                            MySqlCommand cmdUpdate = new MySqlCommand("SELECT quantity from inventory WHERE itemID = @itemID",connection);
                            
                            cmdReceipt.Parameters.AddWithValue("@quantity", orderQuantity);
                            cmdReceipt.Parameters.AddWithValue("@totalAmount", totalAmount);
                            cmdReceipt.ExecuteNonQuery();


                            MessageBox.Show("SUCCESSFULLY ORDERED!");
                            DisplayInveTable();
                            txtOrderQuantity.Text = "0";
                            SalesMonitorForm salesMonitorForm = new SalesMonitorForm();
                            salesMonitorForm.Show();
                           
                            connection.Close();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric order quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }

    }
}
