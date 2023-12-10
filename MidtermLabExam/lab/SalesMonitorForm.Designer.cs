namespace lab
{
    partial class SalesMonitorForm
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
            lblSalesMonitor = new Label();
            btnBack = new Button();
            dgvSales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // lblSalesMonitor
            // 
            lblSalesMonitor.AutoSize = true;
            lblSalesMonitor.Location = new Point(346, 29);
            lblSalesMonitor.Name = "lblSalesMonitor";
            lblSalesMonitor.Size = new Size(95, 15);
            lblSalesMonitor.TabIndex = 0;
            lblSalesMonitor.Text = "SALES MONITOR";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SteelBlue;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(665, 29);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvSales
            // 
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSales.Location = new Point(120, 75);
            dgvSales.Name = "dgvSales";
            dgvSales.RowTemplate.Height = 25;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(567, 303);
            dgvSales.TabIndex = 3;
            // 
            // SalesMonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSales);
            Controls.Add(btnBack);
            Controls.Add(lblSalesMonitor);
            Name = "SalesMonitorForm";
            Text = "SalesMonitorForm";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalesMonitor;
        private Button btnBack;
        private DataGridView dgvSales;
    }
}