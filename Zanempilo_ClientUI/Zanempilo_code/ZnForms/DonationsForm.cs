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

        private void btnDonate_Click(object sender, EventArgs e)
        {
            // Reset all error labels at the beginning of the click event
            lblDonationTypeError.Visible = false;
            lblQuantityError.Visible = false;
            lblDescriptionError.Visible = false;
            lblDateError.Visible = false;

            // Use a boolean flag to track validation status
            bool isValid = true;

            // 1. Validate Donation Type
            if (cmbDonationType.SelectedItem == null)
            {
                lblDonationTypeError.Text = "Please select a donation type.";
                lblDonationTypeError.Visible = true;
                isValid = false;
            }

            // 2. Validate Quantity
            if (nudQuantity.Value <= 0)
            {
                lblQuantityError.Text = "Quantity must be greater than 0.";
                lblQuantityError.Visible = true;
                isValid = false;
            }

            // 3. Validate Description
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                lblDescriptionError.Text = "Please enter a description.";
                lblDescriptionError.Visible = true;
                isValid = false;
            }

            // 4. Validate Donation Date
            if (mcDonationDate.SelectionStart.Date < DateTime.Today.Date)
            {
                lblDateError.Text = "Date cannot be in the past.";
                lblDateError.Visible = true;
                isValid = false;
            }

            // If all validations pass
            if (isValid)
            {
                // All inputs are valid, proceed with the donation process.
                // For example, save data to a database.
                MessageBox.Show("Donation submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
   
}
