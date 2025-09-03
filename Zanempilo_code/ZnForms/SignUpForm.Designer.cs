namespace ZnForms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            btnSignUpPage = new Button();
            txtSignUpEmail = new TextBox();
            txtSignUpPassword = new TextBox();
            txtSignUpConfirmPassword = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            checkBoxPrivacy = new CheckBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignUpPage
            // 
            btnSignUpPage.BackColor = Color.DarkOliveGreen;
            btnSignUpPage.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUpPage.Location = new Point(60, 600);
            btnSignUpPage.Name = "btnSignUpPage";
            btnSignUpPage.Size = new Size(278, 57);
            btnSignUpPage.TabIndex = 0;
            btnSignUpPage.Text = "SIGN UP";
            btnSignUpPage.UseVisualStyleBackColor = false;
            btnSignUpPage.Click += btnSignUpPage_Click;
            // 
            // txtSignUpEmail
            // 
            txtSignUpEmail.Location = new Point(61, 375);
            txtSignUpEmail.Name = "txtSignUpEmail";
            txtSignUpEmail.Size = new Size(308, 27);
            txtSignUpEmail.TabIndex = 1;
            // 
            // txtSignUpPassword
            // 
            txtSignUpPassword.Location = new Point(93, 425);
            txtSignUpPassword.Name = "txtSignUpPassword";
            txtSignUpPassword.Size = new Size(276, 27);
            txtSignUpPassword.TabIndex = 2;
            // 
            // txtSignUpConfirmPassword
            // 
            txtSignUpConfirmPassword.Location = new Point(140, 479);
            txtSignUpConfirmPassword.Name = "txtSignUpConfirmPassword";
            txtSignUpConfirmPassword.Size = new Size(226, 27);
            txtSignUpConfirmPassword.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(4, 374);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 24);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(4, 425);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 24);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(1, 482);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(133, 24);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // checkBoxPrivacy
            // 
            checkBoxPrivacy.AutoSize = true;
            checkBoxPrivacy.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxPrivacy.Location = new Point(3, 530);
            checkBoxPrivacy.Name = "checkBoxPrivacy";
            checkBoxPrivacy.Size = new Size(209, 28);
            checkBoxPrivacy.TabIndex = 6;
            checkBoxPrivacy.Text = "I agree with privacy policy";
            checkBoxPrivacy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(3, 170);
            label3.Name = "label3";
            label3.Size = new Size(236, 72);
            label3.TabIndex = 9;
            label3.Text = "Sign Up";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(21, 242);
            label4.Name = "label4";
            label4.Size = new Size(139, 18);
            label4.TabIndex = 10;
            label4.Text = "Hello! let's join with us";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(4, 328);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 24);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(1, 279);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(84, 24);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(93, 280);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(276, 27);
            txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(93, 329);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(276, 27);
            txtLastName.TabIndex = 14;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 129, 116);
            ClientSize = new Size(432, 745);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(checkBoxPrivacy);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtSignUpConfirmPassword);
            Controls.Add(txtSignUpPassword);
            Controls.Add(txtSignUpEmail);
            Controls.Add(btnSignUpPage);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUpPage;
        private TextBox txtSignUpEmail;
        private TextBox txtSignUpPassword;
        private TextBox txtSignUpConfirmPassword;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private CheckBox checkBoxPrivacy;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
    }
}