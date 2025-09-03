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
            checkBoxRememberMe = new CheckBox();
            btnLogIn = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            lnklblForgotPassword = new LinkLabel();
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
            txtLogInPassword.Location = new Point(114, 404);
            txtLogInPassword.Name = "txtLogInPassword";
            txtLogInPassword.Size = new Size(276, 27);
            txtLogInPassword.TabIndex = 2;
            // 
            // lblLogPassword
            // 
            lblLogPassword.AutoSize = true;
            lblLogPassword.Font = new Font("Bahnschrift SemiLight Condensed", 12F);
            lblLogPassword.Location = new Point(25, 404);
            lblLogPassword.Name = "lblLogPassword";
            lblLogPassword.Size = new Size(77, 24);
            lblLogPassword.TabIndex = 2;
            lblLogPassword.Text = "Password:";
            // 
            // checkBoxRememberMe
            // 
            checkBoxRememberMe.AutoSize = true;
            checkBoxRememberMe.Font = new Font("Bahnschrift Condensed", 10.2F);
            checkBoxRememberMe.Location = new Point(12, 449);
            checkBoxRememberMe.Name = "checkBoxRememberMe";
            checkBoxRememberMe.Size = new Size(116, 25);
            checkBoxRememberMe.TabIndex = 3;
            checkBoxRememberMe.Text = "Remember me";
            checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DarkOliveGreen;
            btnLogIn.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnLogIn.Location = new Point(69, 505);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(278, 57);
            btnLogIn.TabIndex = 5;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(311, 53);
            label3.TabIndex = 11;
            label3.Text = "Welcome Back";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(25, 259);
            label4.Name = "label4";
            label4.Size = new Size(164, 18);
            label4.TabIndex = 12;
            label4.Text = "Hey! Good to see you again";
            // 
            // lnklblForgotPassword
            // 
            lnklblForgotPassword.AutoSize = true;
            lnklblForgotPassword.Font = new Font("Bahnschrift Condensed", 10.2F);
            lnklblForgotPassword.LinkColor = Color.Black;
            lnklblForgotPassword.Location = new Point(280, 449);
            lnklblForgotPassword.Name = "lnklblForgotPassword";
            lnklblForgotPassword.Size = new Size(110, 21);
            lnklblForgotPassword.TabIndex = 4;
            lnklblForgotPassword.TabStop = true;
            lnklblForgotPassword.Text = "Forgot Password ?";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(432, 745);
            Controls.Add(lnklblForgotPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogIn);
            Controls.Add(checkBoxRememberMe);
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
        private CheckBox checkBoxRememberMe;
        private Button btnLogIn;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private LinkLabel lnklblForgotPassword;
    }
}