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
    public partial class RecieveReportsForm : Form
    {
        public RecieveReportsForm()
        {
            InitializeComponent();
        }

        private void RecieveReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRRBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
