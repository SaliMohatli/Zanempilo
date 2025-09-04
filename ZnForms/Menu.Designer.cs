namespace ZnForms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnDonationForm = new Button();
            btnMaintain = new Button();
            btnRR = new Button();
            btnIS = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDonationForm
            // 
            btnDonationForm.Location = new Point(123, 171);
            btnDonationForm.Name = "btnDonationForm";
            btnDonationForm.Size = new Size(75, 23);
            btnDonationForm.TabIndex = 0;
            btnDonationForm.Text = "Donations";
            btnDonationForm.UseVisualStyleBackColor = true;
            btnDonationForm.Click += btnDonationForm_Click;
            // 
            // btnMaintain
            // 
            btnMaintain.Location = new Point(123, 200);
            btnMaintain.Name = "btnMaintain";
            btnMaintain.Size = new Size(75, 23);
            btnMaintain.TabIndex = 1;
            btnMaintain.Text = "Maintain";
            btnMaintain.UseVisualStyleBackColor = true;
            btnMaintain.Click += btnMaintain_Click;
            // 
            // btnRR
            // 
            btnRR.Location = new Point(123, 229);
            btnRR.Name = "btnRR";
            btnRR.Size = new Size(75, 23);
            btnRR.TabIndex = 2;
            btnRR.Text = "Receive Reports";
            btnRR.UseVisualStyleBackColor = true;
            btnRR.Click += btnRR_Click;
            // 
            // btnIS
            // 
            btnIS.Location = new Point(123, 258);
            btnIS.Name = "btnIS";
            btnIS.Size = new Size(75, 23);
            btnIS.TabIndex = 3;
            btnIS.Text = "Issue Stock";
            btnIS.UseVisualStyleBackColor = true;
            btnIS.Click += btnIS_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 17);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(297, 315);
            Controls.Add(pictureBox1);
            Controls.Add(btnIS);
            Controls.Add(btnRR);
            Controls.Add(btnMaintain);
            Controls.Add(btnDonationForm);
            Name = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDonationForm;
        private Button btnMaintain;
        private Button btnRR;
        private Button btnIS;
        private PictureBox pictureBox1;
    }
}
