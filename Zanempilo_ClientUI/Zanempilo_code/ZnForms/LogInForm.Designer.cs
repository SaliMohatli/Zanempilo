namespace ZnForms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            txtLogInEmail = new TextBox();
            lblLogInEmail = new Label();
            txtLogInPassword = new TextBox();
            lblLogPassword = new Label();
            btnLogIn = new Button();
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            lblHeading = new Label();
            lnklblSignUp = new LinkLabel();
            lblLoginEmailError = new Label();
            lblLoginPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLogInEmail
            // 
            txtLogInEmail.Location = new Point(82, 350);
            txtLogInEmail.Name = "txtLogInEmail";
            txtLogInEmail.Size = new Size(308, 27);
            txtLogInEmail.TabIndex = 1;
            // 
            // lblLogInEmail
            // 
            lblLogInEmail.AutoSize = true;
            lblLogInEmail.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblLogInEmail.Location = new Point(25, 349);
            lblLogInEmail.Name = "lblLogInEmail";
            lblLogInEmail.Size = new Size(51, 24);
            lblLogInEmail.TabIndex = 5;
            lblLogInEmail.Text = "Email:";
            // 
            // txtLogInPassword
            // 
            txtLogInPassword.Location = new Point(82, 403);
            txtLogInPassword.Name = "txtLogInPassword";
            txtLogInPassword.Size = new Size(308, 27);
            txtLogInPassword.TabIndex = 2;
            // 
            // lblLogPassword
            // 
            lblLogPassword.AutoSize = true;
            lblLogPassword.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblLogPassword.Location = new Point(-1, 403);
            lblLogPassword.Name = "lblLogPassword";
            lblLogPassword.Size = new Size(77, 24);
            lblLogPassword.TabIndex = 2;
            lblLogPassword.Text = "Password:";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkOliveGreen;
            btnLogIn.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnLogIn.Location = new Point(105, 536);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(278, 57);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.MidnightBlue;
            lblWelcome.Location = new Point(12, 206);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(311, 53);
            lblWelcome.TabIndex = 11;
            lblWelcome.Text = "Welcome Back";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.MidnightBlue;
            lblHeading.Location = new Point(25, 259);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(164, 18);
            lblHeading.TabIndex = 12;
            lblHeading.Text = "Hey! Good to see you again";
            // 
            // lnklblSignUp
            // 
            lnklblSignUp.AutoSize = true;
            lnklblSignUp.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lnklblSignUp.LinkColor = Color.Black;
            lnklblSignUp.Location = new Point(142, 610);
            lnklblSignUp.Name = "lnklblSignUp";
            lnklblSignUp.Size = new Size(211, 24);
            lnklblSignUp.TabIndex = 4;
            lnklblSignUp.TabStop = true;
            lnklblSignUp.Text = "Don't have Password ? Sign Up";
            lnklblSignUp.LinkClicked += lnklblForgotPassword_LinkClicked;
            // 
            // lblLoginEmailError
            // 
            lblLoginEmailError.AutoSize = true;
            lblLoginEmailError.ForeColor = Color.DarkRed;
            lblLoginEmailError.Location = new Point(82, 381);
            lblLoginEmailError.Name = "lblLoginEmailError";
            lblLoginEmailError.Size = new Size(0, 20);
            lblLoginEmailError.TabIndex = 14;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.ForeColor = Color.DarkRed;
            lblLoginPassword.Location = new Point(114, 433);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(0, 20);
            lblLoginPassword.TabIndex = 15;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(472, 745);
            Controls.Add(lblLoginPassword);
            Controls.Add(lblLoginEmailError);
            Controls.Add(lnklblSignUp);
            Controls.Add(lblHeading);
            Controls.Add(lblWelcome);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogIn);
            Controls.Add(lblLogPassword);
            Controls.Add(txtLogInPassword);
            Controls.Add(lblLogInEmail);
            Controls.Add(txtLogInEmail);
            Name = "LogInForm";
            Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogInEmail;
        private Label lblLogInEmail;
        private TextBox txtLogInPassword;
        private Label lblLogPassword;
        private Button btnLogIn;
        private PictureBox pictureBox1;
        private Label lblWelcome;
        private Label lblHeading;
        private LinkLabel lnklblSignUp;
        private Label lblLoginEmailError;
        private Label lblLoginPassword;
    }
}