using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            CPpanel cPpanel = new CPpanel();    
            cPpanel.Show();
            this.Hide();
        }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            Dadd dadd = new Dadd();
            dadd.Show();
            this.Hide();
        }
    }
}
