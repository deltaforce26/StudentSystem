using StudentSystem.DAL.Repositories;
using StudentSystem.DAL.Services;

namespace StudentSystem
{
    internal partial class LoginForm : Form
    {
        private LoginRepo _loginRepo;
        FormHandler formHandler = new FormHandler();
        public LoginForm(LoginRepo repo)
        {
            InitializeComponent();
            _loginRepo = repo;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_userName.Text.Trim();
            string password = textBox_password.Text.Trim();
            if (_loginRepo.PasswordValidation(username, password))
            {
                MessageBox.Show("success");
                
                formHandler.ShowSecondForm(username, password);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHandler.ShowSigninForm();
            this.Close();
        }
    }
}
