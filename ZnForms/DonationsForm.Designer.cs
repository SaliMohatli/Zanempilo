namespace ZnForms
{
    partial class DonationsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonationsForm));
            pictureBox1 = new PictureBox();
            lblDonationType = new Label();
            lblDonationDate = new Label();
            lblDescription = new Label();
            lblQuantity = new Label();
            mcDonationDate = new MonthCalendar();
            cmbDonationType = new ComboBox();
            nudQuantity = new NumericUpDown();
            txtDescription = new TextBox();
            btnDonationsBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblDonationType
            // 
            lblDonationType.AutoSize = true;
            lblDonationType.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblDonationType.Location = new Point(0, 176);
            lblDonationType.Name = "lblDonationType";
            lblDonationType.Size = new Size(85, 19);
            lblDonationType.TabIndex = 1;
            lblDonationType.Text = "Donation Type:";
            // 
            // lblDonationDate
            // 
            lblDonationDate.AutoSize = true;
            lblDonationDate.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblDonationDate.Location = new Point(0, 367);
            lblDonationDate.Name = "lblDonationDate";
            lblDonationDate.Size = new Size(86, 19);
            lblDonationDate.TabIndex = 12;
            lblDonationDate.Text = "Donation Date:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblDescription.Location = new Point(15, 248);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(71, 19);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblQuantity.Location = new Point(33, 209);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 19);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Quantity:";
            // 
            // mcDonationDate
            // 
            mcDonationDate.Location = new Point(97, 367);
            mcDonationDate.Margin = new Padding(8, 7, 8, 7);
            mcDonationDate.Name = "mcDonationDate";
            mcDonationDate.TabIndex = 15;
            // 
            // cmbDonationType
            // 
            cmbDonationType.FormattingEnabled = true;
            cmbDonationType.Items.AddRange(new object[] { "Food & Nutrition", "Medical & Health", "Clothing & Apparel", "Hygiene & Personal Care", "Shelter & Household" });
            cmbDonationType.Location = new Point(97, 176);
            cmbDonationType.Margin = new Padding(3, 2, 3, 2);
            cmbDonationType.Name = "cmbDonationType";
            cmbDonationType.Size = new Size(132, 23);
            cmbDonationType.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(97, 209);
            nudQuantity.Margin = new Padding(3, 2, 3, 2);
            nudQuantity.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(131, 23);
            nudQuantity.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(97, 248);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(237, 87);
            txtDescription.TabIndex = 18;
            // 
            // btnDonationsBack
            // 
            btnDonationsBack.Location = new Point(295, 543);
            btnDonationsBack.Name = "btnDonationsBack";
            btnDonationsBack.Size = new Size(75, 23);
            btnDonationsBack.TabIndex = 19;
            btnDonationsBack.Text = "BACK";
            btnDonationsBack.UseVisualStyleBackColor = true;
            btnDonationsBack.Click += btnDonationsBack_Click;
            // 
            // DonationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(382, 578);
            Controls.Add(btnDonationsBack);
            Controls.Add(txtDescription);
            Controls.Add(nudQuantity);
            Controls.Add(cmbDonationType);
            Controls.Add(mcDonationDate);
            Controls.Add(lblQuantity);
            Controls.Add(lblDescription);
            Controls.Add(lblDonationDate);
            Controls.Add(lblDonationType);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DonationsForm";
            Text = "DonationsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDonationType;
        private Label lblDonationDate;
        private Label lblDescription;
        private Label lblQuantity;
        private MonthCalendar mcDonationDate;
        private ComboBox cmbDonationType;
        private NumericUpDown nudQuantity;
        private TextBox txtDescription;
        private Button btnDonationsBack;
    }
}