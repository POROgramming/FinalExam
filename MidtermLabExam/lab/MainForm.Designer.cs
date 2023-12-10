namespace lab
{
    partial class MainForm
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
            lblAdmin = new Label();
            btnMainte = new Button();
            btnPOF = new Button();
            btnDelivery = new Button();
            btnInventory = new Button();
            btnSalesMonitor = new Button();
            picShowBackup = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picShowBackup).BeginInit();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.Transparent;
            lblAdmin.Font = new Font("Verdana", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdmin.ForeColor = Color.Black;
            lblAdmin.Location = new Point(263, 44);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(252, 42);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "MAIN FORM";
            // 
            // btnMainte
            // 
            btnMainte.BackColor = Color.CornflowerBlue;
            btnMainte.FlatStyle = FlatStyle.System;
            btnMainte.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainte.ForeColor = SystemColors.Control;
            btnMainte.Location = new Point(284, 164);
            btnMainte.Name = "btnMainte";
            btnMainte.Size = new Size(200, 41);
            btnMainte.TabIndex = 1;
            btnMainte.Text = "SHOW MAINTENANCE";
            btnMainte.UseVisualStyleBackColor = false;
            btnMainte.Click += btnMainte_Click;
            // 
            // btnPOF
            // 
            btnPOF.BackColor = Color.CornflowerBlue;
            btnPOF.FlatStyle = FlatStyle.System;
            btnPOF.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPOF.ForeColor = SystemColors.Control;
            btnPOF.Location = new Point(284, 211);
            btnPOF.Name = "btnPOF";
            btnPOF.Size = new Size(200, 41);
            btnPOF.TabIndex = 2;
            btnPOF.Text = "SHOW POINT OF SALES";
            btnPOF.UseVisualStyleBackColor = false;
            btnPOF.Click += btnPOF_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.BackColor = Color.CornflowerBlue;
            btnDelivery.FlatStyle = FlatStyle.System;
            btnDelivery.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelivery.ForeColor = SystemColors.Control;
            btnDelivery.Location = new Point(284, 258);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(200, 41);
            btnDelivery.TabIndex = 3;
            btnDelivery.Text = "SHOW DELIVERY";
            btnDelivery.UseVisualStyleBackColor = false;
            btnDelivery.Click += btnDelivery_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.CornflowerBlue;
            btnInventory.FlatStyle = FlatStyle.System;
            btnInventory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInventory.ForeColor = SystemColors.Control;
            btnInventory.Location = new Point(284, 352);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(200, 41);
            btnInventory.TabIndex = 4;
            btnInventory.Text = "SHOW INVENTORY";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSalesMonitor
            // 
            btnSalesMonitor.BackColor = Color.CornflowerBlue;
            btnSalesMonitor.FlatStyle = FlatStyle.System;
            btnSalesMonitor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalesMonitor.ForeColor = SystemColors.Control;
            btnSalesMonitor.Location = new Point(284, 305);
            btnSalesMonitor.Name = "btnSalesMonitor";
            btnSalesMonitor.Size = new Size(200, 41);
            btnSalesMonitor.TabIndex = 5;
            btnSalesMonitor.Text = "SHOW SALES MONITORING";
            btnSalesMonitor.UseVisualStyleBackColor = false;
            btnSalesMonitor.Click += btnSalesMonitor_Click;
            // 
            // picShowBackup
            // 
            picShowBackup.BackColor = SystemColors.ButtonFace;
            picShowBackup.Image = Properties.Resources.ImgBackup;
            picShowBackup.Location = new Point(663, 373);
            picShowBackup.Name = "picShowBackup";
            picShowBackup.Size = new Size(100, 50);
            picShowBackup.SizeMode = PictureBoxSizeMode.Zoom;
            picShowBackup.TabIndex = 7;
            picShowBackup.TabStop = false;
            picShowBackup.Click += picShowBackup_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(picShowBackup);
            Controls.Add(btnSalesMonitor);
            Controls.Add(btnInventory);
            Controls.Add(btnDelivery);
            Controls.Add(btnPOF);
            Controls.Add(btnMainte);
            Controls.Add(lblAdmin);
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)picShowBackup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmin;
        private Button btnMainte;
        private Button btnPOF;
        private Button btnDelivery;
        private Button btnInventory;
        private Button btnSalesMonitor;
        private PictureBox picShowBackup;
    }
}