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
    public partial class CPupd : Form
    {
        public CPupd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CPadd cPadd = new CPadd();
            cPadd.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CPupd cPupd = new CPupd();
            cPupd.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CPdel cPdel = new CPdel();
            cPdel.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CPser cPser = new CPser();
            cPser.Show();
            this.Hide();
        }
    }
}
