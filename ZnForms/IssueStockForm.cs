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

namespace ZnForms
{
    public partial class IssueStockForm : Form
    {
        private readonly string _connString;
        public IssueStockForm()
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

        private void IssueStockForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand("sp_GetClientOrders", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            var dt = new DataTable();
            using var da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgvOrders.DataSource = dt;
        }
        private DataTable ExecuteProc(string procName)
        {
            using var conn = new SqlConnection(_connString);
            using var cmd = new SqlCommand(procName, conn) { CommandType = CommandType.StoredProcedure };
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void btnISBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dgvOrders.DataSource = ExecuteProc("sp_InsertClientOrder");


            try
            {
                // Gather input values
                int clientId = (int)nudClientID.Value;
                int stockId = (int)nudStockID.Value;
                int qty = (int)nudQuantity.Value;
                DateTime date = dtpOrderDate.Value;

                // Execute insert
                using var conn = new SqlConnection(_connString);
                using var cmd = new SqlCommand("sp_InsertClientOrder", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Client_ID", clientId);
                cmd.Parameters.AddWithValue("@Stock_ID", stockId);
                cmd.Parameters.AddWithValue("@Quantity", qty);
                cmd.Parameters.AddWithValue("@Order_Date", date);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order inserted successfully", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting order: {ex.Message}",
                                "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
