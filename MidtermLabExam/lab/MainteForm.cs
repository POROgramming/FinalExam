using System.Data;
using MySqlConnector;
namespace lab
{
    public partial class MaintenanceForm : Form
    {
        String con;
        String itemCategory;
        String supplierName;
        String address;
        long contactNumber;
        int categoryID;
        String itemName;
        int basePrice;
        public MaintenanceForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            con = "Server=localhost;Database=dbSalesInventory; User = root; Password = 1234 ";
            txtPassword.UseSystemPasswordChar = true;
            //Load Current values of the Combobox
            PopulateCategoryComboBox();
            //Load Tables upon opening the form
            DisplayUsersTable(dataGridViewUsers);
            DisplayCategoryTable(dataGridViewCategory);
            DisplayItemsTable(dataGridViewItems);
            DisplaySuppliersTable(dataGridViewSuppliers);
        }
        //adding Items
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbxCategory.SelectedItem == null || string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("Please fill in all required fields.".ToUpper());
                return;
            }
            if (!int.TryParse(txtBasePrice.Text, out int parsedBasePrice))
            {
                MessageBox.Show("Contact number and base price should be valid integer values.".ToUpper());
                return;
            }
            //assigning values base on the users input
            this.itemCategory = cbxCategory.SelectedItem?.ToString();
            this.itemName = txtItemName.Text;
            this.basePrice = int.Parse(txtBasePrice.Text);
            // Check for null or empty values

            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();

                // Retrieve categoryID based on selected itemCategory
                string categoryIdQuery = "SELECT categoryId FROM itemCategory WHERE categoryName = @itemCategory";
                MySqlCommand categoryIdCommand = new MySqlCommand(categoryIdQuery, connection);
                categoryIdCommand.Parameters.AddWithValue("@itemCategory", itemCategory);

                // Execute the command and read the result
                object categoryIdResult = categoryIdCommand.ExecuteScalar();

                if (categoryIdResult != null)
                {
                    categoryID = Convert.ToInt32(categoryIdResult);

                    // Insert item information with retrieved categoryID based on the categoryName
                    string itemQuery = "INSERT INTO items(itemName, categoryID, basePrice) VALUES (@itemName, @categoryID, @basePrice)";
                    MySqlCommand cmdItems = new MySqlCommand(itemQuery, connection);
                    cmdItems.Parameters.AddWithValue("@itemName", this.itemName);
                    cmdItems.Parameters.AddWithValue("@categoryID", this.categoryID);
                    cmdItems.Parameters.AddWithValue("@basePrice", this.basePrice);
                    //confirmation
                    if (this.ShowConfirmation())
                    {
                        cmdItems.ExecuteNonQuery();
                        MessageBox.Show("Recorded Successfully");
                        DisplayItemsTable(dataGridViewItems);
                    }
                }
                else
                {
                    MessageBox.Show("Category not found");
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
        // for View Tables tab displaying tables
        private void btnUsers_Click(object sender, EventArgs e)
        {
            DisplayUsersTable(dgvMain);
        }

        private void btnItemCategory_Click(object sender, EventArgs e)
        {
            DisplayCategoryTable(dgvMain);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            DisplaySuppliersTable(dgvMain);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            DisplayItemsTable(dgvMain);
        }
        // Inserting User
        private void btnSubmitUser_Click(object sender, EventArgs e)
        {
            string enteredUserName = txtUserName.Text; 
            string enteredPassword = txtPassword.Text; 

            if (string.IsNullOrEmpty(enteredUserName) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Username and password cannot be empty or null.".ToUpper());
                return;
            }
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();

                // Check if the username already exists
                if (IsUsernameExists(enteredUserName))
                {
                    MessageBox.Show("Username already exists. Please choose a different username".ToUpper());
                    return;
                }

                // Insert the user information into the users table
                string userQuery = "INSERT INTO users (username, pass) VALUES (@username, @password)";
                MySqlCommand cmdUser = new MySqlCommand(userQuery, connection);
                cmdUser.Parameters.AddWithValue("@username", enteredUserName);
                cmdUser.Parameters.AddWithValue("@password", enteredPassword);
                //Confirmation
                if (this.ShowConfirmation())
                {
                    cmdUser.ExecuteNonQuery();
                    MessageBox.Show("User recorded successfully!".ToUpper());
                    DisplayUsersTable(dataGridViewUsers);
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
        // Insert Supplier
        private void btnSubmitSupplier_Click(object sender, EventArgs e)
        {
            // Check for null or empty values
            if (string.IsNullOrEmpty(txtSupplierName.Text) || string.IsNullOrEmpty(txtSupplierAdd.Text) ||
                string.IsNullOrEmpty(txtSupplierContact.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Validate contactNumber
            if (!long.TryParse(txtSupplierContact.Text, out long parsedContact))
            {
                MessageBox.Show("Contact number should be a valid integer value.");
                return;
            }

            this.supplierName = txtSupplierName.Text;
            this.address = txtSupplierAdd.Text;
            this.contactNumber = parsedContact;

            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();

                // Insert supplier information
                string supplierQuery = "INSERT INTO supplier (supplierName, address, contactNumber) " +
                                       "VALUES (@supplierName, @address, @contactNumber)";
                MySqlCommand cmdSupplier = new MySqlCommand(supplierQuery, connection);
                cmdSupplier.Parameters.AddWithValue("@supplierName", this.supplierName);
                cmdSupplier.Parameters.AddWithValue("@address", this.address);
                cmdSupplier.Parameters.AddWithValue("@contactNumber", this.contactNumber);
                //Confirmation
                if (this.ShowConfirmation())
                {
                    cmdSupplier.ExecuteNonQuery();
                    MessageBox.Show("Supplier information recorded successfully.");
                    DisplaySuppliersTable(dataGridViewSuppliers);
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
        // Inserting new Category
        private void btnSubmitCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            // Check for null or empty category name
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Category name cannot be empty or null.");
                return;
            }

            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();

                // Insert the category information into the itemCategory table
                string categoryQuery = "INSERT INTO itemCategory (categoryName) VALUES (@categoryName)";
                MySqlCommand cmdCategory = new MySqlCommand(categoryQuery, connection);
                cmdCategory.Parameters.AddWithValue("@categoryName", categoryName);
                // Confirmation
                if (this.ShowConfirmation())
                {
                    cmdCategory.ExecuteNonQuery();
                    MessageBox.Show("Category recorded successfully!".ToUpper());
                    DisplayCategoryTable(dataGridViewCategory);
                    //Load Current values of the Combobox
                    PopulateCategoryComboBox();
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

        public void btnBack_Click(object sender, EventArgs e)
        {
            MainForm openMainForm = new MainForm();
            openMainForm.Show();
            this.Hide();
        }
        /*
            METHODS
        */
        private bool IsUsernameExists(string username)
        {
            MySqlConnection connection = new MySqlConnection(con);

            try
            {
                connection.Open();

                // Validate to see if the username exists in the users table 
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                //returns true if the username already exists or if the count variable
                //have 1 value and return false if not
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; // Handle the error as needed
            }
            finally
            {
                connection.Close();
            }
        }
        public bool ShowConfirmation()
        {
            String message = "Are you sure you want to submit and continue?";
            DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }
        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = !chbShowPass.Checked;
            }
        }
        //Showing password value in checkbox
        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = !this.chbShowPass.Checked;
        }
        private void DisplayUsersTable(DataGridView gridName)
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();

                MySqlCommand cmdSupplier = connection.CreateCommand();
                cmdSupplier.CommandText = "SELECT * FROM users ORDER BY username ASC";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmdSupplier);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                gridName.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void DisplayCategoryTable(DataGridView gridName)
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                MySqlCommand cmdItemCateg = connection.CreateCommand();
                cmdItemCateg.CommandText = "SELECT * FROM itemCategory";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdItemCateg);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                gridName.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception x)
            {
                MessageBox.Show("ERROR: " + x.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void DisplaySuppliersTable(DataGridView gridSuppliers)
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                MySqlCommand cmdSuppliers = connection.CreateCommand();
                cmdSuppliers.CommandText = "SELECT * FROM supplier";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmdSuppliers);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                gridSuppliers.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void DisplayItemsTable(DataGridView gridItems)
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                MySqlCommand cmdItems = connection.CreateCommand();
                cmdItems.CommandText = "SELECT * FROM items";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmdItems);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                gridItems.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception er)
            {
                MessageBox.Show("ERROR: " + er.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void PopulateCategoryComboBox()
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();

                // Retrieve all category names from the itemCategory table
                string categoryQuery = "SELECT categoryName FROM itemCategory";
                MySqlCommand categoryCommand = new MySqlCommand(categoryQuery, connection);
                MySqlDataReader reader = categoryCommand.ExecuteReader();

                // Clear existing items in the ComboBox
                cbxCategory.Items.Clear();

                // Add each category name to the ComboBox
                while (reader.Read())
                {
                    string categoryName = reader["categoryName"].ToString();
                    cbxCategory.Items.Add(categoryName);
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
