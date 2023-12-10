namespace lab
{
    partial class MaintenanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
            txtCategory = new Label();
            cbxCategory = new ComboBox();
            lblItemName = new Label();
            lblBasePrice = new Label();
            txtItemName = new TextBox();
            txtBasePrice = new TextBox();
            btnSubmit = new Button();
            btnUsers = new Button();
            btnItemCategory = new Button();
            btnSuppliers = new Button();
            btnItems = new Button();
            dgvMain = new DataGridView();
            tabMainte = new TabControl();
            tabUsers = new TabPage();
            dataGridViewUsers = new DataGridView();
            chbShowPass = new CheckBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnSubmitUser = new Button();
            lblCPassword = new Label();
            lblCUserName = new Label();
            tabNewITem = new TabPage();
            dataGridViewItems = new DataGridView();
            tabSuppliers = new TabPage();
            dataGridViewSuppliers = new DataGridView();
            btnSubmitSupplier = new Button();
            txtSupplierContact = new TextBox();
            txtSupplierAdd = new TextBox();
            txtSupplierName = new TextBox();
            lblSupplierContact = new Label();
            lblSupplierAddress = new Label();
            lblSupplierName = new Label();
            tabCategory = new TabPage();
            dataGridViewCategory = new DataGridView();
            btnSubmitCategory = new Button();
            lblCategory = new Label();
            txtCategoryName = new TextBox();
            tabTables = new TabPage();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            tabMainte.SuspendLayout();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tabNewITem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            tabTables.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.AutoSize = true;
            txtCategory.ForeColor = SystemColors.HighlightText;
            txtCategory.Location = new Point(21, 22);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(152, 15);
            txtCategory.TabIndex = 2;
            txtCategory.Text = "SELECT ITEM CATEGORY";
            // 
            // cbxCategory
            // 
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Items.AddRange(new object[] { "Laptops", "Desktops", "Keyboards", "Computer Mouse", "Monitors" });
            cbxCategory.Location = new Point(21, 37);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(248, 23);
            cbxCategory.TabIndex = 3;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.ForeColor = SystemColors.HighlightText;
            lblItemName.Location = new Point(24, 92);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(77, 15);
            lblItemName.TabIndex = 8;
            lblItemName.Text = "ITEM NAME:";
            // 
            // lblBasePrice
            // 
            lblBasePrice.AutoSize = true;
            lblBasePrice.ForeColor = SystemColors.HighlightText;
            lblBasePrice.Location = new Point(24, 147);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(80, 15);
            lblBasePrice.TabIndex = 9;
            lblBasePrice.Text = "BASE PRICE:";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(24, 110);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(248, 21);
            txtItemName.TabIndex = 12;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(24, 177);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(248, 21);
            txtBasePrice.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(91, 234);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(91, 40);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.Location = new Point(575, 28);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(126, 45);
            btnUsers.TabIndex = 15;
            btnUsers.Text = "DISPLAY USERS";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnItemCategory
            // 
            btnItemCategory.Location = new Point(575, 90);
            btnItemCategory.Name = "btnItemCategory";
            btnItemCategory.Size = new Size(126, 45);
            btnItemCategory.TabIndex = 16;
            btnItemCategory.Text = "DISPLAY ITEM CATEGORY";
            btnItemCategory.UseVisualStyleBackColor = true;
            btnItemCategory.Click += btnItemCategory_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(575, 149);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(126, 45);
            btnSuppliers.TabIndex = 17;
            btnSuppliers.Text = "DISPLAY SUPPLIERS";
            btnSuppliers.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(575, 211);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(126, 45);
            btnItems.TabIndex = 18;
            btnItems.Text = "DISPLAY ITEMS";
            btnItems.UseVisualStyleBackColor = true;
            btnItems.Click += btnItems_Click;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToDeleteRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.BackgroundColor = SystemColors.ControlLight;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMain.GridColor = SystemColors.ControlLight;
            dgvMain.Location = new Point(25, 22);
            dgvMain.Name = "dgvMain";
            dgvMain.RowHeadersWidth = 62;
            dgvMain.RowTemplate.Height = 25;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.Size = new Size(531, 389);
            dgvMain.TabIndex = 1;
            // 
            // tabMainte
            // 
            tabMainte.AllowDrop = true;
            tabMainte.Controls.Add(tabUsers);
            tabMainte.Controls.Add(tabNewITem);
            tabMainte.Controls.Add(tabSuppliers);
            tabMainte.Controls.Add(tabCategory);
            tabMainte.Controls.Add(tabTables);
            tabMainte.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabMainte.Location = new Point(0, -1);
            tabMainte.Name = "tabMainte";
            tabMainte.SelectedIndex = 0;
            tabMainte.Size = new Size(721, 449);
            tabMainte.TabIndex = 23;
            // 
            // tabUsers
            // 
            tabUsers.BackColor = SystemColors.GradientInactiveCaption;
            tabUsers.BackgroundImage = (Image)resources.GetObject("tabUsers.BackgroundImage");
            tabUsers.BorderStyle = BorderStyle.FixedSingle;
            tabUsers.Controls.Add(dataGridViewUsers);
            tabUsers.Controls.Add(chbShowPass);
            tabUsers.Controls.Add(txtPassword);
            tabUsers.Controls.Add(txtUserName);
            tabUsers.Controls.Add(btnSubmitUser);
            tabUsers.Controls.Add(lblCPassword);
            tabUsers.Controls.Add(lblCUserName);
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(713, 421);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "CREATE USERS";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = SystemColors.ControlLight;
            dataGridViewUsers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewUsers.Location = new Point(24, 19);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 62;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(661, 241);
            dataGridViewUsers.TabIndex = 6;
            // 
            // chbShowPass
            // 
            chbShowPass.AutoSize = true;
            chbShowPass.BackColor = Color.Transparent;
            chbShowPass.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbShowPass.ForeColor = SystemColors.HighlightText;
            chbShowPass.Location = new Point(195, 361);
            chbShowPass.Name = "chbShowPass";
            chbShowPass.Size = new Size(111, 18);
            chbShowPass.TabIndex = 5;
            chbShowPass.Text = "Show password";
            chbShowPass.UseVisualStyleBackColor = false;
            chbShowPass.CheckedChanged += chbShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 326);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 21);
            txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Snow;
            txtUserName.Location = new Point(188, 281);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(376, 21);
            txtUserName.TabIndex = 3;
            // 
            // btnSubmitUser
            // 
            btnSubmitUser.Location = new Point(610, 379);
            btnSubmitUser.Name = "btnSubmitUser";
            btnSubmitUser.Size = new Size(75, 23);
            btnSubmitUser.TabIndex = 2;
            btnSubmitUser.Text = "SUBMIT";
            btnSubmitUser.UseVisualStyleBackColor = true;
            btnSubmitUser.Click += btnSubmitUser_Click;
            // 
            // lblCPassword
            // 
            lblCPassword.AutoSize = true;
            lblCPassword.BackColor = Color.Transparent;
            lblCPassword.ForeColor = SystemColors.HighlightText;
            lblCPassword.Location = new Point(25, 326);
            lblCPassword.Name = "lblCPassword";
            lblCPassword.Size = new Size(123, 15);
            lblCPassword.TabIndex = 1;
            lblCPassword.Text = "ENTER PASSWORD:";
            // 
            // lblCUserName
            // 
            lblCUserName.AutoSize = true;
            lblCUserName.BackColor = Color.Transparent;
            lblCUserName.ForeColor = SystemColors.HighlightText;
            lblCUserName.Location = new Point(25, 281);
            lblCUserName.Name = "lblCUserName";
            lblCUserName.Size = new Size(123, 15);
            lblCUserName.TabIndex = 0;
            lblCUserName.Text = "ENTER USERNAME:";
            // 
            // tabNewITem
            // 
            tabNewITem.BackgroundImage = (Image)resources.GetObject("tabNewITem.BackgroundImage");
            tabNewITem.Controls.Add(dataGridViewItems);
            tabNewITem.Controls.Add(txtCategory);
            tabNewITem.Controls.Add(cbxCategory);
            tabNewITem.Controls.Add(lblItemName);
            tabNewITem.Controls.Add(lblBasePrice);
            tabNewITem.Controls.Add(btnSubmit);
            tabNewITem.Controls.Add(txtItemName);
            tabNewITem.Controls.Add(txtBasePrice);
            tabNewITem.Location = new Point(4, 24);
            tabNewITem.Name = "tabNewITem";
            tabNewITem.Padding = new Padding(3);
            tabNewITem.Size = new Size(713, 421);
            tabNewITem.TabIndex = 0;
            tabNewITem.Text = "CREATE NEW ITEM";
            tabNewITem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItems.BackgroundColor = SystemColors.ControlLight;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewItems.GridColor = SystemColors.ControlLight;
            dataGridViewItems.Location = new Point(291, 19);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 62;
            dataGridViewItems.RowTemplate.Height = 25;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(405, 393);
            dataGridViewItems.TabIndex = 15;
            // 
            // tabSuppliers
            // 
            tabSuppliers.BackgroundImage = (Image)resources.GetObject("tabSuppliers.BackgroundImage");
            tabSuppliers.Controls.Add(dataGridViewSuppliers);
            tabSuppliers.Controls.Add(btnSubmitSupplier);
            tabSuppliers.Controls.Add(txtSupplierContact);
            tabSuppliers.Controls.Add(txtSupplierAdd);
            tabSuppliers.Controls.Add(txtSupplierName);
            tabSuppliers.Controls.Add(lblSupplierContact);
            tabSuppliers.Controls.Add(lblSupplierAddress);
            tabSuppliers.Controls.Add(lblSupplierName);
            tabSuppliers.Location = new Point(4, 24);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Padding = new Padding(3);
            tabSuppliers.Size = new Size(713, 421);
            tabSuppliers.TabIndex = 2;
            tabSuppliers.Text = "CREATE SUPPLIERS";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliers.BackgroundColor = SystemColors.ControlLight;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewSuppliers.Location = new Point(32, 26);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 62;
            dataGridViewSuppliers.RowTemplate.Height = 25;
            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers.Size = new Size(650, 206);
            dataGridViewSuppliers.TabIndex = 7;
            // 
            // btnSubmitSupplier
            // 
            btnSubmitSupplier.Location = new Point(600, 265);
            btnSubmitSupplier.Name = "btnSubmitSupplier";
            btnSubmitSupplier.Size = new Size(75, 23);
            btnSubmitSupplier.TabIndex = 6;
            btnSubmitSupplier.Text = "SUBMIT";
            btnSubmitSupplier.UseVisualStyleBackColor = true;
            btnSubmitSupplier.Click += btnSubmitSupplier_Click;
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Location = new Point(318, 361);
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.Size = new Size(238, 21);
            txtSupplierContact.TabIndex = 5;
            // 
            // txtSupplierAdd
            // 
            txtSupplierAdd.Location = new Point(318, 314);
            txtSupplierAdd.Name = "txtSupplierAdd";
            txtSupplierAdd.Size = new Size(238, 21);
            txtSupplierAdd.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(318, 268);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(238, 21);
            txtSupplierName.TabIndex = 3;
            // 
            // lblSupplierContact
            // 
            lblSupplierContact.AutoSize = true;
            lblSupplierContact.ForeColor = SystemColors.HighlightText;
            lblSupplierContact.Location = new Point(90, 365);
            lblSupplierContact.Name = "lblSupplierContact";
            lblSupplierContact.Size = new Size(185, 15);
            lblSupplierContact.TabIndex = 2;
            lblSupplierContact.Text = "SUPPLIER CONTACT NUMBER:";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.ForeColor = SystemColors.HighlightText;
            lblSupplierAddress.Location = new Point(90, 318);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(131, 15);
            lblSupplierAddress.TabIndex = 1;
            lblSupplierAddress.Text = "SUPPLIER ADDRESS:";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.ForeColor = SystemColors.HighlightText;
            lblSupplierName.Location = new Point(90, 270);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(108, 15);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "SUPPLIER NAME:";
            // 
            // tabCategory
            // 
            tabCategory.BackgroundImage = (Image)resources.GetObject("tabCategory.BackgroundImage");
            tabCategory.BackgroundImageLayout = ImageLayout.None;
            tabCategory.BorderStyle = BorderStyle.FixedSingle;
            tabCategory.Controls.Add(dataGridViewCategory);
            tabCategory.Controls.Add(btnSubmitCategory);
            tabCategory.Controls.Add(lblCategory);
            tabCategory.Controls.Add(txtCategoryName);
            tabCategory.Location = new Point(4, 24);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3);
            tabCategory.Size = new Size(713, 421);
            tabCategory.TabIndex = 4;
            tabCategory.Text = "CREATE CATEGORY";
            tabCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategory.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewCategory.Location = new Point(57, 56);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.RowHeadersWidth = 62;
            dataGridViewCategory.RowTemplate.Height = 25;
            dataGridViewCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategory.Size = new Size(592, 332);
            dataGridViewCategory.TabIndex = 3;
            // 
            // btnSubmitCategory
            // 
            btnSubmitCategory.Location = new Point(559, 26);
            btnSubmitCategory.Name = "btnSubmitCategory";
            btnSubmitCategory.Size = new Size(75, 23);
            btnSubmitCategory.TabIndex = 2;
            btnSubmitCategory.Text = "SUBMIT";
            btnSubmitCategory.UseVisualStyleBackColor = true;
            btnSubmitCategory.Click += btnSubmitCategory_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = SystemColors.HighlightText;
            lblCategory.Location = new Point(57, 31);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(112, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "CATEGORY NAME:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(186, 29);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(355, 21);
            txtCategoryName.TabIndex = 0;
            // 
            // tabTables
            // 
            tabTables.BackgroundImage = (Image)resources.GetObject("tabTables.BackgroundImage");
            tabTables.Controls.Add(dgvMain);
            tabTables.Controls.Add(btnSuppliers);
            tabTables.Controls.Add(btnUsers);
            tabTables.Controls.Add(btnItemCategory);
            tabTables.Controls.Add(btnItems);
            tabTables.Location = new Point(4, 24);
            tabTables.Name = "tabTables";
            tabTables.Padding = new Padding(3);
            tabTables.Size = new Size(713, 421);
            tabTables.TabIndex = 3;
            tabTables.Text = "VIEW TABLES";
            tabTables.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(727, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 34);
            btnBack.TabIndex = 24;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 449);
            Controls.Add(btnBack);
            Controls.Add(tabMainte);
            Name = "MaintenanceForm";
            Text = "Maintenance Form";
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            tabMainte.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tabNewITem.ResumeLayout(false);
            tabNewITem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            tabSuppliers.ResumeLayout(false);
            tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            tabCategory.ResumeLayout(false);
            tabCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            tabTables.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label txtCategory;
        private ComboBox cbxCategory;
        private Label lblItemName;
        private Label lblBasePrice;
        private TextBox txtItemName;
        private TextBox txtBasePrice;
        private Button btnSubmit;
        private Button btnUsers;
        private Button btnItemCategory;
        private Button btnSuppliers;
        private Button btnItems;
        private DataGridView dgvMain;
        private TabControl tabMainte;
        private TabPage tabNewITem;
        private TabPage tabUsers;
        private TabPage tabSuppliers;
        private TabPage tabTables;
        private Label lblCPassword;
        private Label lblCUserName;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnSubmitUser;
        private CheckBox chbShowPass;
        private Label lblSupplierContact;
        private Label lblSupplierAddress;
        private Label lblSupplierName;
        private TextBox txtSupplierContact;
        private TextBox txtSupplierAdd;
        private TextBox txtSupplierName;
        private Button btnSubmitSupplier;
        private TabPage tabCategory;
        private Button btnSubmitCategory;
        private Label lblCategory;
        private TextBox txtCategoryName;
        private DataGridView dataGridViewUsers;
        private DataGridView dataGridViewItems;
        private DataGridView dataGridViewSuppliers;
        private DataGridView dataGridViewCategory;
        private Button btnBack;
    }
}