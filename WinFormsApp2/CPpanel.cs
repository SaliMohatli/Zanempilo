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
    public partial class CPpanel : Form
    {

        public CPpanel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlCPadd.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlCPupd.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlCPdel.Visible = true;
        }

        private void pnlCPupd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
