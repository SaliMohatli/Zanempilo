using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZnForms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            // Reset all error labels at the beginning of the click event
            lblLoginEmailError.Visible = false;
            lblLoginPassword.Visible = false;

            // Use a boolean flag to track validation status
            bool isValid = true;

            // 1. Validate Email
            if (string.IsNullOrWhiteSpace(txtLogInEmail.Text))
            {
                lblLoginEmailError.Text = "Email address is required.";
                lblLoginEmailError.Visible = true;
                isValid = false;
            }
            else
            {
                // Use a try-catch block to validate the email format
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtLogInEmail.Text);
                }
                catch
                {
                    lblLoginEmailError.Text = "Invalid email format.";
                    lblLoginEmailError.Visible = true;
                    isValid = false;
                }
            }

            // 2. Validate Password based on standard criteria
            string password = txtLogInPassword.Text;
            string passwordError = string.Empty;

            // Check for each password criterion and build the error message if a condition is not met
            if (string.IsNullOrWhiteSpace(password))
            {
                passwordError = "Password is required.";
                isValid = false;
            }
            else
            {
                // Minimum length check
                if (password.Length < 8)
                {
                    passwordError += "Password must be at least 8 characters long.\n";
                    isValid = false;
                }
                // Uppercase check
                if (!Regex.IsMatch(password, "[A-Z]"))
                {
                    passwordError += "Password must contain at least one uppercase letter.\n";
                    isValid = false;
                }
                // Lowercase check
                if (!Regex.IsMatch(password, "[a-z]"))
                {
                    passwordError += "Password must contain at least one lowercase letter.\n";
                    isValid = false;
                }
                // Number check
                if (!Regex.IsMatch(password, "[0-9]"))
                {
                    passwordError += "Password must contain at least one number.\n";
                    isValid = false;
                }
                // Special character check
                if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
                {
                    passwordError += "Password must contain at least one special character.\n";
                    isValid = false;
                }

                // Display the compiled password error message if there is one
                if (!string.IsNullOrEmpty(passwordError))
                {
                    lblLoginPassword.Text = passwordError;
                    lblLoginPassword.Visible = true;
                }
            
            // If all validations pass, you can proceed with authentication
            if (isValid)
            {
                DonationsForm DonationsForm = new DonationsForm();
                DonationsForm.Show();
                this.Hide();
            }
        }
        }

        private void lnklblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LastnameError signUpForm = new LastnameError();
            signUpForm.Show();
            this.Hide();
        }
    }
}
