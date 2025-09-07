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
            btnDonate = new Button();
            lblDonationTypeError = new Label();
            lblQuantityError = new Label();
            lblDescriptionError = new Label();
            lblDateError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblDonationType
            // 
            lblDonationType.AutoSize = true;
            lblDonationType.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblDonationType.Location = new Point(0, 164);
            lblDonationType.Name = "lblDonationType";
            lblDonationType.Size = new Size(105, 24);
            lblDonationType.TabIndex = 1;
            lblDonationType.Text = "Donation Type:";
            // 
            // lblDonationDate
            // 
            lblDonationDate.AutoSize = true;
            lblDonationDate.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblDonationDate.Location = new Point(0, 415);
            lblDonationDate.Name = "lblDonationDate";
            lblDonationDate.Size = new Size(105, 24);
            lblDonationDate.TabIndex = 12;
            lblDonationDate.Text = "Donation Date:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblDescription.Location = new Point(12, 274);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 24);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblQuantity.Location = new Point(27, 224);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(67, 24);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Quantity:";
            // 
            // mcDonationDate
            // 
            mcDonationDate.Location = new Point(102, 424);
            mcDonationDate.Name = "mcDonationDate";
            mcDonationDate.TabIndex = 4;
            // 
            // cmbDonationType
            // 
            cmbDonationType.FormattingEnabled = true;
            cmbDonationType.Items.AddRange(new object[] { "Food & Nutrition", "Medical & Health", "Clothing & Apparel", "Hygiene & Personal Care", "Shelter & Household" });
            cmbDonationType.Location = new Point(102, 165);
            cmbDonationType.Name = "cmbDonationType";
            cmbDonationType.Size = new Size(190, 28);
            cmbDonationType.TabIndex = 1;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(100, 224);
            nudQuantity.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(150, 27);
            nudQuantity.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(100, 277);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(309, 115);
            txtDescription.TabIndex = 3;
            // 
            // btnDonate
            // 
            btnDonate.BackColor = Color.DarkOliveGreen;
            btnDonate.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonate.Location = new Point(247, 674);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new Size(140, 43);
            btnDonate.TabIndex = 5;
            btnDonate.Text = "DONATE";
            btnDonate.UseVisualStyleBackColor = false;
            btnDonate.Click += btnDonate_Click;
            // 
            // lblDonationTypeError
            // 
            lblDonationTypeError.AutoSize = true;
            lblDonationTypeError.ForeColor = Color.DarkRed;
            lblDonationTypeError.Location = new Point(102, 196);
            lblDonationTypeError.Name = "lblDonationTypeError";
            lblDonationTypeError.Size = new Size(0, 20);
            lblDonationTypeError.TabIndex = 20;
            // 
            // lblQuantityError
            // 
            lblQuantityError.AutoSize = true;
            lblQuantityError.ForeColor = Color.DarkRed;
            lblQuantityError.Location = new Point(100, 254);
            lblQuantityError.Name = "lblQuantityError";
            lblQuantityError.Size = new Size(0, 20);
            lblQuantityError.TabIndex = 21;
            // 
            // lblDescriptionError
            // 
            lblDescriptionError.AutoSize = true;
            lblDescriptionError.ForeColor = Color.DarkRed;
            lblDescriptionError.Location = new Point(102, 395);
            lblDescriptionError.Name = "lblDescriptionError";
            lblDescriptionError.Size = new Size(0, 20);
            lblDescriptionError.TabIndex = 22;
            // 
            // lblDateError
            // 
            lblDateError.AutoSize = true;
            lblDateError.ForeColor = Color.DarkRed;
            lblDateError.Location = new Point(100, 640);
            lblDateError.Name = "lblDateError";
            lblDateError.Size = new Size(0, 20);
            lblDateError.TabIndex = 23;
            // 
            // DonationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(432, 745);
            Controls.Add(lblDateError);
            Controls.Add(lblDescriptionError);
            Controls.Add(lblQuantityError);
            Controls.Add(lblDonationTypeError);
            Controls.Add(btnDonate);
            Controls.Add(txtDescription);
            Controls.Add(nudQuantity);
            Controls.Add(cmbDonationType);
            Controls.Add(mcDonationDate);
            Controls.Add(lblQuantity);
            Controls.Add(lblDescription);
            Controls.Add(lblDonationDate);
            Controls.Add(lblDonationType);
            Controls.Add(pictureBox1);
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
        private Button btnDonate;
        private Label lblDonationTypeError;
        private Label lblQuantityError;
        private Label lblDescriptionError;
        private Label lblDateError;
    }
}