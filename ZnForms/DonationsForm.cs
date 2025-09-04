using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace ZnForms
{
    public partial class DonationsForm : Form
    {
        private readonly string _connString;

        public DonationsForm()
        {
            InitializeComponent();

            // Load connection string from appsettings.json
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                IConfiguration config = builder.Build();
                _connString = config.GetConnectionString("ZanempiloDB");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load configuration: {ex.Message}",
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void DonationsForm_Load(object sender, EventArgs e)
        {
            // Populate the donation type combo box
            cmbDonationType.Items.AddRange(new[]
            {
                "Food",
                "Clothes",
                "Books",
                "Money",
                "Other"
            });
            cmbDonationType.SelectedIndex = 0;

            // Set the date picker to today by default
            dtpDonationDate.Value = DateTime.Now.Date;
        }

        private void btnDonationsBack_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Gather inputs
            int donorId = (int)nudDonorID.Value;                    // NumericUpDown for Donor_ID
            string donationType = cmbDonationType.Text;
            DateTime donationDate = dtpDonationDate.Value;
            string description = txtDescription.Text.Trim();
            int quantity = (int)nudQuantity.Value;

            // 2. Basic validation
            if (donorId <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid Donor ID.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show(
                    "Quantity must be at least 1.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 3. Call the INSERT stored procedure
            try
            {
                using var conn = new SqlConnection(_connString);
                using var cmd = new SqlCommand("sp_ManageDonations", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Action",         "INSERT");
                cmd.Parameters.AddWithValue("@Donor_ID",       donorId);
                cmd.Parameters.AddWithValue("@DonationType",   donationType);
                cmd.Parameters.AddWithValue("@Donation_Date",  donationDate);
                cmd.Parameters.AddWithValue("@Description",    string.IsNullOrEmpty(description) 
                                                             ? (object)DBNull.Value 
                                                             : description);
                cmd.Parameters.AddWithValue("@Quantity",       quantity);

                conn.Open();
                var newId = cmd.ExecuteScalar();

                MessageBox.Show(
                    $"Donation recorded successfully (ID = {newId})",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Optionally clear inputs for next entry
                nudDonorID.Value = 1;
                cmbDonationType.SelectedIndex = 0;
                dtpDonationDate.Value = DateTime.Now.Date;
                txtDescription.Clear();
                nudQuantity.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error inserting donation: {ex.Message}",
                    "Insert Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
