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
    public partial class MaintainForm : Form
    {
        public MaintainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MaintainForm_Load(object sender, EventArgs e)
        {

            var builder = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            string connectionString = config.GetConnectionString("ZanempiloDB");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                MessageBox.Show("Connected Via appsetting.json!");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnMaintainBack_Click(object sender, EventArgs e)
        {

        }
    }
}
