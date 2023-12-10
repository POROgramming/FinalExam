namespace lab
{
    partial class DeliveryForm
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
            lblDelivery = new Label();
            btnBack = new Button();
            dgvDelivery = new DataGridView();
            dateDelivery = new DateTimePicker();
            cbxItems = new ComboBox();
            txtQuantity = new NumericUpDown();
            btnDeliver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDelivery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.Location = new Point(355, 9);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(57, 15);
            lblDelivery.TabIndex = 0;
            lblDelivery.Text = "DELIVERY";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(672, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvDelivery
            // 
            dgvDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDelivery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDelivery.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDelivery.Location = new Point(172, 39);
            dgvDelivery.Name = "dgvDelivery";
            dgvDelivery.RowTemplate.Height = 25;
            dgvDelivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDelivery.Size = new Size(444, 266);
            dgvDelivery.TabIndex = 3;
            // 
            // dateDelivery
            // 
            dateDelivery.Location = new Point(172, 330);
            dateDelivery.Name = "dateDelivery";
            dateDelivery.Size = new Size(200, 23);
            dateDelivery.TabIndex = 4;
            // 
            // cbxItems
            // 
            cbxItems.FormattingEnabled = true;
            cbxItems.Location = new Point(172, 359);
            cbxItems.Name = "cbxItems";
            cbxItems.Size = new Size(200, 23);
            cbxItems.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(172, 388);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(120, 23);
            txtQuantity.TabIndex = 6;
            // 
            // btnDeliver
            // 
            btnDeliver.Location = new Point(371, 406);
            btnDeliver.Name = "btnDeliver";
            btnDeliver.Size = new Size(75, 23);
            btnDeliver.TabIndex = 7;
            btnDeliver.Text = "DELIVER";
            btnDeliver.UseVisualStyleBackColor = true;
            btnDeliver.Click += btnDeliver_Click;
            // 
            // DeliveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeliver);
            Controls.Add(txtQuantity);
            Controls.Add(cbxItems);
            Controls.Add(dateDelivery);
            Controls.Add(dgvDelivery);
            Controls.Add(btnBack);
            Controls.Add(lblDelivery);
            Name = "DeliveryForm";
            Text = "DeliveryForm";
            ((System.ComponentModel.ISupportInitialize)dgvDelivery).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDelivery;
        private Button btnBack;
        private DataGridView dgvDelivery;
        private DateTimePicker dateDelivery;
        private ComboBox cbxItems;
        private NumericUpDown txtQuantity;
        private Button btnDeliver;
    }
}