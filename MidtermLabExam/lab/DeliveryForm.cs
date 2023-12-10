using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace lab
{
    public partial class DeliveryForm : Form
    {
        String con;
        public DeliveryForm()
        {
            con = "Server=localhost;Database=dbSalesInventory; User = root; Password =1234";
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            DisplayDeliveryTable();
            PopulateComboBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            String deliveryDate = dateDelivery.Value.ToString("yyyy-MM-dd");
            String selectedItem = cbxItems.SelectedItem?.ToString();
            int quantity = Convert.ToInt32(txtQuantity.Value);

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.");
                return;
            }

            MySqlConnection connection = new MySqlConnection(con);
            {
                try
                {
                    connection.Open();

                    // Retrieve itemID
                    string itemIDQuery = "SELECT itemID FROM items WHERE itemName = @itemName";
                    MySqlCommand itemIDCommand = new MySqlCommand(itemIDQuery, connection);
                    itemIDCommand.Parameters.AddWithValue("@itemName", selectedItem);
                    object itemID = itemIDCommand.ExecuteScalar();

                    if (itemID != null)
                    {
                        int itemIDValue = Convert.ToInt32(itemID);

                        // Insert or update delivery record
                        string deliveryQuery = "INSERT INTO delivery (deliveryDate, itemID, quantity) VALUES (@deliveryDate, @itemID, @quantity)";
                                        
                        MySqlCommand cmdDelivery = new MySqlCommand(deliveryQuery, connection);

                        cmdDelivery.Parameters.AddWithValue("@itemID", itemIDValue);
                        cmdDelivery.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                        cmdDelivery.Parameters.AddWithValue("@quantity", quantity);

                        cmdDelivery.ExecuteNonQuery();
                        MessageBox.Show("Recorded Successfully");

                        // Check if itemID exists in inventory table
                        string inventoryCheckQuery = "SELECT COUNT(*) FROM inventory WHERE itemID = @itemID";
                        MySqlCommand inventoryCheckCommand = new MySqlCommand(inventoryCheckQuery, connection);
                        inventoryCheckCommand.Parameters.AddWithValue("@itemID", itemIDValue);

                        int inventoryCount = Convert.ToInt32(inventoryCheckCommand.ExecuteScalar());

                        if (inventoryCount > 0)
                        {
                            // Update existing row in inventory
                            string inventoryUpdateQuery = "UPDATE inventory SET quantity = quantity + @quantity WHERE itemID = @itemID";
                            MySqlCommand inventoryUpdateCommand = new MySqlCommand(inventoryUpdateQuery, connection);
                            inventoryUpdateCommand.Parameters.AddWithValue("@itemID", itemIDValue);
                            inventoryUpdateCommand.Parameters.AddWithValue("@quantity", quantity);

                            inventoryUpdateCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            // Insert new row in inventory
                            string inventoryInsertQuery = "INSERT INTO inventory (itemID, quantity) VALUES (@itemID, @quantity)";
                            MySqlCommand inventoryInsertCommand = new MySqlCommand(inventoryInsertQuery, connection);
                            inventoryInsertCommand.Parameters.AddWithValue("@itemID", itemIDValue);
                            inventoryInsertCommand.Parameters.AddWithValue("@quantity", quantity);

                            inventoryInsertCommand.ExecuteNonQuery();
                        }

                        DisplayDeliveryTable();
                    }
                    else
                    {
                        MessageBox.Show("Item not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void DisplayDeliveryTable()
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                MySqlCommand cmdQuery = connection.CreateCommand();
                cmdQuery.CommandText = "SELECT * FROM delivery ORDER BY deliveryDate ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdQuery);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgvDelivery.DataSource = ds.Tables[0].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void PopulateComboBox()
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();

                // Retrieve all category names from the itemCategory table
                string itemQuery = "SELECT itemName FROM items";
                MySqlCommand itemCommand = new MySqlCommand(itemQuery, connection);
                MySqlDataReader reader = itemCommand.ExecuteReader();

                // Clear existing items in the ComboBox
                cbxItems.Items.Clear();

                // Add each category name to the ComboBox
                while (reader.Read())
                {
                    string itemName = reader["itemName"].ToString();
                    cbxItems.Items.Add(itemName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
