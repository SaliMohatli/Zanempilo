namespace ZnForms
{
    partial class LandingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            btnSignUp = new Button();
            btnLogIn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkOliveGreen;
            btnSignUp.BackgroundImageLayout = ImageLayout.Zoom;
            btnSignUp.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(78, 467);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(278, 57);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkOliveGreen;
            btnLogIn.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.Location = new Point(78, 550);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(278, 57);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(432, 745);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogIn);
            Controls.Add(btnSignUp);
            Name = "LandingPage";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSignUp;
        private Button btnLogIn;
        private PictureBox pictureBox1;
    }
}
