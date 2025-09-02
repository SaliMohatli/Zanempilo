namespace ZnForms
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }
    }
}
