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
    public partial class LastnameError : Form
    {
        public LastnameError()
        {
            InitializeComponent();
        }
      
        private void btnSignUpPage_Click(object sender, EventArgs e)
        {
            // Reset all error labels at the beginning of the click event
           label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            bool isValid = true;

            // 1. Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                label1.Text = "First name is required.";
                label1.Visible = true;
                isValid = false;
            }

            // 2. Validate Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                label2.Text = "Last name is required.";
                label2.Visible = true;
                isValid = false;
            }

            // 3. Validate Email
            if (string.IsNullOrWhiteSpace(txtSignUpEmail.Text))
            {
                label5.Text = "Email is required.";
                label5.Visible = true;
                isValid = false;
            }
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtSignUpEmail.Text);
                }
                catch
                {
                    label5.Text = "Invalid email format.";
                    label5.Visible = true;
                    isValid = false;
                }
            }

            // 4. Validate Password
            string password = txtSignUpPassword.Text;
            string passwordError = string.Empty;

            if (string.IsNullOrWhiteSpace(password))
            {
                passwordError = "Password is required.";
                isValid = false;
            }
            else
            {
                // Check for minimum length, uppercase, lowercase, number, and special character
                if (password.Length < 8)
                {
                    passwordError += "Password must be at least 8 characters long.\n";
                    isValid = false;
                }
                if (!Regex.IsMatch(password, "[A-Z]"))
                {
                    passwordError += "Must contain an uppercase letter.\n";
                    isValid = false;
                }
                if (!Regex.IsMatch(password, "[a-z]"))
                {
                    passwordError += "Must contain a lowercase letter.\n";
                    isValid = false;
                }
                if (!Regex.IsMatch(password, "[0-9]"))
                {
                    passwordError += "Must contain a number.\n";
                    isValid = false;
                }
                if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
                {
                    passwordError += "Must contain a special character.\n";
                    isValid = false;
                }

                if (!string.IsNullOrEmpty(passwordError))
                {
                    label6.Text = passwordError;
                    label6.Visible = true;
                }
            }

            // 5. Validate Confirm Password
            if (txtSignUpConfirmPassword.Text != password)
            {
                label7.Text = "Passwords do not match.";
                label7.Visible = true;
                isValid = false;
            }

            // 6. Validate Privacy Policy Checkbox
            if (!checkBoxPrivacy.Checked)
            {
                label8.Text="You must agree to the privacy policy.";
                label8.Visible = true;
                isValid = false;
            }

            // If all validations pass, you can proceed with the sign-up process
            if (isValid)
            {
                DonationsForm DonationsForm = new DonationsForm();
                DonationsForm.Show();
                this.Hide();
            }
        }

        }
    
}
