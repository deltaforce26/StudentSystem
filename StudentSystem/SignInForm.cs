using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentSystem.DAL.Repositories;

namespace StudentSystem
{
    internal partial class SignInForm : Form
    {
        private SignInRepo _signInRepo;
        public SignInForm(SignInRepo repo)
        {
            InitializeComponent();
            _signInRepo = repo;
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            string fname = textBox_fname.Text.Trim();
            string lname = textBox_lname.Text.Trim();
            string password = textBox_password.Text.Trim();
            bool res = _signInRepo.addStudent(fname,lname,password);
            if (res)
            {
                MessageBox.Show("You have signin successfully");
            }
        }
    }
}
