using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace ZnForms
{
    public partial class IssueStockForm : Form
    {
        private readonly string _connString;

        public IssueStockForm()
        {
            InitializeComponent();

            // 1. Load connection string from appsettings.json
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                IConfiguration config = builder.Build();
                _connString = config.GetConnectionString("ZanempiloDB");

                // Quick test that the connection string is valid
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    // you can comment this out after you verify the connection
                    MessageBox.Show("Connected via appsettings.json!", 
                                    "Connection Test", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load configuration: {ex.Message}",
                                "Connection Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void IssueStockForm_Load(object sender, EventArgs e)
        {
            // Populate the grid when the form opens
            LoadOrders();
        }

        /// <summary>
        /// Loads all client orders into the DataGridView.
        /// Calls the stored procedure sp_GetClientOrders.
        /// </summary>
        private void LoadOrders()
        {
            dgvOrders.DataSource = ExecuteProc("sp_GetClientOrders");
        }

        /// <summary>
        /// Executes any stored procedure that returns a result set,
        /// and returns the data as a DataTable.
        /// </summary>
        /// <param name="procName">The name of the stored procedure.</param>
        private DataTable ExecuteProc(string procName)
        {
            var dt = new DataTable();

            using (var conn = new SqlConnection(_connString))
            using (var cmd  = new SqlCommand(procName, conn) { CommandType = CommandType.StoredProcedure })
            using (var da   = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            return dt;
        }

        /// <summary>
        /// Handler for the Back button – returns to the main menu.
        /// </summary>
        private void btnISBack_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();
            this.Hide();
        }

        /// <summary>
        /// Handler for the Submit button – inserts a new client order
        /// and refreshes the grid.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Gather inputs from the form
                int clientId = (int)nudClientID.Value;
                int stockId  = (int)nudStockID.Value;
                int qty      = (int)nudQuantity.Value;
                DateTime date= dtpOrderDate.Value.Date;
                TimeSpan time= DateTime.Now.TimeOfDay;

                // 2. Call the insert stored procedure
                using (var conn = new SqlConnection(_connString))
                using (var cmd  = new SqlCommand("sp_InsertClientOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Client_ID",  clientId);
                    cmd.Parameters.AddWithValue("@Stock_ID",   stockId);
                    cmd.Parameters.AddWithValue("@Quantity",   qty);
                    cmd.Parameters.AddWithValue("@Order_Date", date);
                    cmd.Parameters.AddWithValue("@Order_Time", time);

                    conn.Open();
                    var newId = cmd.ExecuteScalar();
                    MessageBox.Show($"Order inserted successfully (ID = {newId})",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                // 3. Refresh the grid so the new order appears
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting order: {ex.Message}",
                                "Insert Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
