using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ZnForms
{
    public partial class MaintainForm : Form
    {
        private readonly string _connString;
        public MaintainForm()
        {
            InitializeComponent();
            try
            {
                var builder = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                IConfiguration config = builder.Build();
                _connString = config.GetConnectionString("ZanempiloDB");
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    MessageBox.Show("Connected Via appsetting.json!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load configuration: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MaintainForm_Load(object sender, EventArgs e)
        {
            cmbDonorsAddFieldtoedit.Items.AddRange(new String[]
            {
                "First_Name",
                "Last_Name",
                "Email"
            });
            cmbDonorsAddFieldtoedit.SelectedIndex = 0;


            cbxClientUpdate.Items.AddRange(new String[]
            {
                "First_Name",
                "Last_Name",
                "Email"
            });
            cbxClientUpdate.SelectedIndex = 0;

            cmbDonationsUpdateFieldToEdit.Items.AddRange(new String[]
            {
                "Donor_ID",
                "DonationType",
                "Donation_Date",
                "Description",
                "Quantity"
            });
            cmbDonationsUpdateFieldToEdit.SelectedIndex = 0;

            cmbStockUpdateFieldtoedit.Items.AddRange(new String[]
             {
                "Donation_ID",
                "Description",
                "Quantity_In_Stock"
             });
            cmbStockUpdateFieldtoedit.SelectedIndex = 0;
        }

        private void btnMaintainBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnClientAdd_Click(object sender, EventArgs e) //Client Add
        {
            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_ManageClient", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "INSERT");
            cmd.Parameters.AddWithValue("@First_Name", txtClientAddFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@Last_Name", txtClientAddLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", txtClientAddEmail.Text.Trim());

            conn.Open();
            var newId = cmd.ExecuteScalar();
            MessageBox.Show($"Client added with new ID: {newId}");
        }

        private void btnDonorsAdd_Click(object sender, EventArgs e) //Donor Add
        {
            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_ManageDonor", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "INSERT");
            cmd.Parameters.AddWithValue("@First_Name", txtDonorsAddFName.Text.Trim());
            cmd.Parameters.AddWithValue("@Last_Name", txtDonorsAddLName.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", txtDonorsAddEmail.Text.Trim());

            conn.Open();
            var newId = cmd.ExecuteScalar(); //returns newDonorId
            MessageBox.Show($"Donor added with new ID: {newId}");
        }

        private void btnDonorsUpdate_Click(object sender, EventArgs e) //Donor Update
        {
            int donorID = (int)nudDonorsAddDonorID.Value;
            string selectedField = cmbDonorsAddFieldtoedit.SelectedItem.ToString();
            string newValue = txtDonorsAddContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Please enter a value to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fName = "", lName = "", email = "";
            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("SELECT First_Name, Last_Name, Email FROM Donor WHERE Donor_ID = @Donor_ID", conn))
            {
                cmd.Parameters.AddWithValue("@Donor_ID", donorID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fName = reader["First_Name"].ToString();
                        lName = reader["Last_Name"].ToString();
                        email = reader["Email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Donor not found");
                        return;
                    }
                }
            }

            switch (selectedField)
            {
                case "First_Name": fName = newValue; break;
                case "Last_Name": lName = newValue; break;
                case "Email": email = newValue; break;

            }

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("sp_ManageDonor", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@Donor_ID", donorID);
                cmd.Parameters.AddWithValue("@First_Name", fName);
                cmd.Parameters.AddWithValue("@Last_Name", lName);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                var rows = cmd.ExecuteScalar();
                MessageBox.Show($"{rows} record(s) updated.");
            }
        }

        private void btnClientDelete_Click(object sender, EventArgs e) //Client Delete
        {
            int clientID = (int)nudClientIDDelete.Value;
            var result = MessageBox.Show($"Are you sure you want to delete Client {clientID}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                MessageBox.Show("Deletion cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_ManageClient", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@Client_ID", clientID);
            conn.Open();
            var rows = cmd.ExecuteScalar();
            MessageBox.Show($"{rows} record(s) updated.");
        }

        private void btnDonorsDelete_Click(object sender, EventArgs e) //Donors Delete
        {
            int donorID = (int)nudDonorsDeleteDonorID.Value;
            var result = MessageBox.Show($"Are you sure you want to delete Donor {donorID}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                MessageBox.Show("Deletion cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_ManageDonor", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@Donor_ID", donorID);
            conn.Open();
            var rows = cmd.ExecuteScalar();
            MessageBox.Show($"{rows} record(s) updated.");
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit
        {
            Application.Exit();
        }

        private void btnClientUpdate_Click(object sender, EventArgs e) //Client Update
        {
            int clientID = (int)nudClientIDUpdate.Value;
            string selectedField = cbxClientUpdate.SelectedItem.ToString();
            string newValue = txtClientUpdateContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Please enter a value to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fName = "", lName = "", email = "";
            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("SELECT First_Name, Last_Name, Email FROM Client WHERE Client_ID = @Client_ID", conn))
            {
                cmd.Parameters.AddWithValue("@Client_ID", clientID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fName = reader["First_Name"].ToString();
                        lName = reader["Last_Name"].ToString();
                        email = reader["Email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Client not found");
                        return;
                    }
                }
            }

            switch (selectedField)
            {
                case "First_Name": fName = newValue; break;
                case "Last_Name": lName = newValue; break;
                case "Email": email = newValue; break;

            }

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("sp_ManageClient", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@Client_ID", clientID);
                cmd.Parameters.AddWithValue("@First_Name", fName);
                cmd.Parameters.AddWithValue("@Last_Name", lName);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                var rows = cmd.ExecuteScalar();
                MessageBox.Show($"{rows} record(s) updated.");
            }
        }

        private void btnStockAdd_Click(object sender, EventArgs e) //Stock Add
        {
            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_ManageStock", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "INSERT");
            cmd.Parameters.AddWithValue("@Donation_ID", nudStockAddDonationID.Value);
            cmd.Parameters.AddWithValue("@Description", txtStockAddDescrition.Text.Trim());
            cmd.Parameters.AddWithValue("@Quantity_In_Stock", nudStockAddQuantity.Value);

            conn.Open();
            var newId = cmd.ExecuteScalar(); //returns newDonorId
            MessageBox.Show($"Stock added with new ID: {newId}");
        }

        private void btnStockUpdate_Click(object sender, EventArgs e) //Stock Update
        {
            int stockID = (int)nudStockUpdateStockID.Value;
            string selectedField = cmbStockUpdateFieldtoedit.SelectedItem.ToString();
            string newValue = txtStockUpdateContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Please enter a value to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string donationID = "", description = "", quantity = "";
            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("SELECT Donation_ID, Description, Quantity_In_Stock FROM Stock WHERE Stock_ID = @Stock_ID", conn))
            {
                cmd.Parameters.AddWithValue("@Stock_ID", stockID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        donationID = reader["Donation_ID"].ToString();
                        description = reader["Description"].ToString();
                        quantity = reader["Quantity_In_Stock"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Stock not found");
                        return;
                    }
                }
            }

            switch (selectedField)
            {
                case "Donation_ID": donationID = newValue; break;
                case "Description": description = newValue; break;
                case "Quantity_In_Stock": quantity = newValue; break;

            }

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("sp_ManageStock", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@Stock_ID", stockID);
                cmd.Parameters.AddWithValue("@Donation_ID", donationID);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Quantity_In_Stock", quantity);

                conn.Open();
                var rows = cmd.ExecuteScalar();
                MessageBox.Show($"{rows} record(s) updated.");
            }
        }

        private void btnStockDelete_Click(object sender, EventArgs e) //Stock Delete
        {
            int stockID = (int)nudStockDeleteStockID.Value;
            var result = MessageBox.Show($"Are you sure you want to delete Stock {stockID}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                MessageBox.Show("Deletion cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_ManageStock", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@Stock_ID", stockID);
            conn.Open();
            var rows = cmd.ExecuteScalar();
            MessageBox.Show($"{rows} record(s) updated.");
        }

        private void btnDonationsAdd_Click(object sender, EventArgs e) //Donations Add
        {
            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_ManageDonations", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "INSERT");
            cmd.Parameters.AddWithValue("@Donor_ID", nudDonationsAddDonorID.Value);
            cmd.Parameters.AddWithValue("@DonationType", txtDonationsAddDonationType.Text.Trim());
            cmd.Parameters.AddWithValue("@Donation_Date", dtpDonationsAddDonationDate.Value);
            cmd.Parameters.AddWithValue("@Description", txtDonationsAddDescription.Text.Trim());
            cmd.Parameters.AddWithValue("@Quantity", nudDonatoinsAddQuantity.Value);

            conn.Open();
            var newId = cmd.ExecuteScalar();
            MessageBox.Show($"Stock added with new ID: {newId}");
        }

        private void btnDonationsUpdate_Click(object sender, EventArgs e) //Donations Update
        {
            int donationsID = (int)nudDonationsUpdateDonationID.Value;
            string selectedField = cmbDonationsUpdateFieldToEdit.SelectedItem.ToString();
            string newValue = txtDonatoinsUpdateContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Please enter a value to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string donorID = "", donationType = "", donationDate = "", description = "",quantity = "";
            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("SELECT Donor_ID, DonationType, Donation_Date, Description, Quantity FROM Donation WHERE Donation_ID = @Donation_ID", conn))
            {
                cmd.Parameters.AddWithValue("@Donation_ID", donationsID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        donorID = reader["Donor_ID"].ToString();
                        donationType = reader["DonationType"].ToString();
                        donationDate = reader["Donation_Date"].ToString();
                        description = reader["Description"].ToString();
                        quantity = reader["Quantity"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Donation not found");
                        return;
                    }
                }
            }

            switch (selectedField)
            {
                case "Donor_ID": donorID = newValue; break;
                case "DonationType": donationType = newValue; break;
                case "Donation_Date": donationDate = newValue; break;
                case "Description": description = newValue; break;
                case "Quantity": quantity = newValue; break;

            }

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("sp_ManageDonations", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@Donation_ID", donationsID);
                cmd.Parameters.AddWithValue("@Donor_ID", donorID);
                cmd.Parameters.AddWithValue("@DonationType", donationType);
                cmd.Parameters.AddWithValue("@Donation_Date", donationDate);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                conn.Open();
                var rows = cmd.ExecuteScalar();
                MessageBox.Show($"{rows} record(s) updated.");
            }
        }

        private void btnDonationsDelete_Click(object sender, EventArgs e) //Donations Delete
        {
            int donationsID = (int)nudDonationsDeleteDonationID.Value;
            var result = MessageBox.Show($"Are you sure you want to delete Donation(s) {donationsID}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                MessageBox.Show("Deletion cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_ManageDonations", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@Donation_ID", donationsID);
            conn.Open();
            var rows = cmd.ExecuteScalar();
            MessageBox.Show($"{rows} record(s) updated.");
        }
    }
}
