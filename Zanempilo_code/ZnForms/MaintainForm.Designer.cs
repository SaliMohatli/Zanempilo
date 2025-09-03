namespace ZnForms
{
    partial class MaintainForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainForm));
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tbpClients = new TabPage();
            tbpDonations = new TabPage();
            tbpDonors = new TabPage();
            tbpStock = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpClients);
            tabControl1.Controls.Add(tbpDonations);
            tabControl1.Controls.Add(tbpDonors);
            tabControl1.Controls.Add(tbpStock);
            tabControl1.Location = new Point(3, 112);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(362, 358);
            tabControl1.TabIndex = 11;
            // 
            // tbpClients
            // 
            tbpClients.Location = new Point(4, 24);
            tbpClients.Name = "tbpClients";
            tbpClients.Padding = new Padding(3);
            tbpClients.Size = new Size(354, 330);
            tbpClients.TabIndex = 0;
            tbpClients.Text = "Clients";
            tbpClients.UseVisualStyleBackColor = true;
            // 
            // tbpDonations
            // 
            tbpDonations.Location = new Point(4, 24);
            tbpDonations.Name = "tbpDonations";
            tbpDonations.Padding = new Padding(3);
            tbpDonations.Size = new Size(354, 330);
            tbpDonations.TabIndex = 1;
            tbpDonations.Text = "Donations";
            tbpDonations.UseVisualStyleBackColor = true;
            // 
            // tbpDonors
            // 
            tbpDonors.Location = new Point(4, 24);
            tbpDonors.Name = "tbpDonors";
            tbpDonors.Padding = new Padding(3);
            tbpDonors.Size = new Size(354, 330);
            tbpDonors.TabIndex = 2;
            tbpDonors.Text = "Donors";
            tbpDonors.UseVisualStyleBackColor = true;
            // 
            // tbpStock
            // 
            tbpStock.Location = new Point(4, 24);
            tbpStock.Name = "tbpStock";
            tbpStock.Padding = new Padding(3);
            tbpStock.Size = new Size(354, 330);
            tbpStock.TabIndex = 3;
            tbpStock.Text = "Stock";
            tbpStock.UseVisualStyleBackColor = true;
            // 
            // MaintainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Name = "MaintainForm";
            Size = new Size(368, 473);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tbpClients;
        private TabPage tbpDonations;
        private TabPage tbpDonors;
        private TabPage tbpStock;
    }
}
