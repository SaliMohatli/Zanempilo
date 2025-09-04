using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZnForms
{
    public partial class DonationsForm : Form
    {
        public DonationsForm()
        {
            InitializeComponent();
        }

        private void btnDonationsBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int quantity = (int)nudQuantity.Value;
            string donationType = cmbDonationType.SelectedItem?.ToString() ?? "Not Selected";
            string description = txtDescription.Text;
        }
    }
}
