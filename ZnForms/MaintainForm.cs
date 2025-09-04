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

        }

        private void btnStockUpdate_Click(object sender, EventArgs e) //Stock Update
        {

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
    }
}
