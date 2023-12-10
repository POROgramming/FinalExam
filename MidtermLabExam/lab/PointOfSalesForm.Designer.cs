namespace lab
{
    partial class PointOfSalesForm
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
            label1 = new Label();
            btnBack = new Button();
            dgvPOS = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            lblItemID = new Label();
            lblItemName = new Label();
            lblQuantity = new Label();
            btnCheckOut = new Button();
            txtOrderQuantity = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPOS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOrderQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(268, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 26);
            label1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(344, 391);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvPOS
            // 
            dgvPOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPOS.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPOS.Location = new Point(42, 79);
            dgvPOS.Name = "dgvPOS";
            dgvPOS.RowTemplate.Height = 25;
            dgvPOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPOS.Size = new Size(386, 272);
            dgvPOS.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 45);
            label2.Name = "label2";
            label2.Size = new Size(167, 22);
            label2.TabIndex = 3;
            label2.Text = "PRODUCT DETAILS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(525, 62);
            label3.Name = "label3";
            label3.Size = new Size(192, 22);
            label3.TabIndex = 7;
            label3.Text = "SELECTED PRODUCTS";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Location = new Point(479, 95);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(105, 15);
            lblItemID.TabIndex = 8;
            lblItemID.Text = "SELECTED ITEM ID:";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(479, 150);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(91, 15);
            lblItemName.TabIndex = 9;
            lblItemName.Text = "SELECTED ITEM:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(479, 124);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(66, 15);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "QUANTITY:";
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(560, 315);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(105, 36);
            btnCheckOut.TabIndex = 12;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click_1;
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.Location = new Point(591, 179);
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.Size = new Size(120, 23);
            txtOrderQuantity.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 181);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 15;
            label4.Text = "ORDER QUANTITY:";
            // 
            // PointOfSalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 449);
            Controls.Add(label4);
            Controls.Add(txtOrderQuantity);
            Controls.Add(btnCheckOut);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemName);
            Controls.Add(lblItemID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvPOS);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "PointOfSalesForm";
            ((System.ComponentModel.ISupportInitialize)dgvPOS).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOrderQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private DataGridView dgvPOS;
        private Label label2;
        private Label label3;
        private Label lblItemID;
        private Label lblItemName;
        private Label lblQuantity;
        private Button btnCheckOut;
        private NumericUpDown txtOrderQuantity;
        private Label label4;
    }
}