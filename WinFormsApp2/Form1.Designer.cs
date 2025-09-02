namespace WinFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnReports = new Button();
            btnStock = new Button();
            btnOrders = new Button();
            btnDonations = new Button();
            btnDonors = new Button();
            btnClients = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.DarkOliveGreen;
            btnReports.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnReports.Location = new Point(450, 450);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(141, 41);
            btnReports.TabIndex = 28;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.DarkOliveGreen;
            btnStock.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnStock.Location = new Point(450, 403);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(141, 41);
            btnStock.TabIndex = 27;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.DarkOliveGreen;
            btnOrders.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnOrders.Location = new Point(450, 356);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(141, 41);
            btnOrders.TabIndex = 26;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnDonations
            // 
            btnDonations.BackColor = Color.DarkOliveGreen;
            btnDonations.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDonations.Location = new Point(450, 309);
            btnDonations.Name = "btnDonations";
            btnDonations.Size = new Size(141, 41);
            btnDonations.TabIndex = 25;
            btnDonations.Text = "Donations";
            btnDonations.UseVisualStyleBackColor = false;
            // 
            // btnDonors
            // 
            btnDonors.BackColor = Color.DarkOliveGreen;
            btnDonors.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnDonors.Location = new Point(450, 262);
            btnDonors.Name = "btnDonors";
            btnDonors.Size = new Size(141, 41);
            btnDonors.TabIndex = 24;
            btnDonors.Text = "Donors";
            btnDonors.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.DarkOliveGreen;
            btnClients.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnClients.Location = new Point(450, 215);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(141, 41);
            btnClients.TabIndex = 23;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold);
            label1.Location = new Point(426, 94);
            label1.Name = "label1";
            label1.Size = new Size(187, 42);
            label1.TabIndex = 22;
            label1.Text = "Main Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(1149, 633);
            Controls.Add(btnReports);
            Controls.Add(btnStock);
            Controls.Add(btnOrders);
            Controls.Add(btnDonations);
            Controls.Add(btnDonors);
            Controls.Add(btnClients);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReports;
        private Button btnStock;
        private Button btnOrders;
        private Button btnDonations;
        private Button btnDonors;
        private Button btnClients;
        private Label label1;
        private PictureBox pictureBox1;
    }
}