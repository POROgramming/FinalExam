using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class MainForm : Form
    {
        MaintenanceForm mainteForm = new MaintenanceForm();
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void btnMainte_Click(object sender, EventArgs e)
        {
            mainteForm.Show();
            this.Hide();
        }

        private void btnPOF_Click(object sender, EventArgs e)
        {
            PointOfSalesForm salesForm = new PointOfSalesForm();
            salesForm.Show();
            this.Hide();
        }

        private void picShowBackup_Click(object sender, EventArgs e)
        {
            BackUpRestoreForm backUpRestoreForm = new BackUpRestoreForm();
            backUpRestoreForm.Show();
            this.Hide();
        }

        private void btnSalesMonitor_Click(object sender, EventArgs e)
        {
            SalesMonitorForm salesMForm = new SalesMonitorForm();
            salesMForm.Show();
            this.Hide();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
            this.Hide();
        }
    }
}
