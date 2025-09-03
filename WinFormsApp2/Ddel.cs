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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }
        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            Dupd dupd = new Dupd();
            dupd.Show();
            this.Hide();
        }

        private void btnDAdd_Click(object sender, EventArgs e)
        {
            Dadd dadd = new Dadd();
            dadd.Show();
            this.Hide();
        }

        private void btnDDelete_Click(object sender, EventArgs e)
        {
            Donor ddel = new Donor();
            ddel.Show();
            this.Hide();
        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {
            Dsear dsear = new Dsear();
            dsear.Show();
            this.Hide();
        }
    }
}
