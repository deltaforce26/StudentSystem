using StudentSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentSystem.DAL.Services;

namespace StudentSystem
{
    internal partial class StudentForm : Form
    {
        private StRepo _stRepo;
        private DataTable _stable;
        private string _tz;
        private string _password;
        public StudentForm(StRepo repo, string name = null!, string password = null!)
        {
            InitializeComponent();
            _stRepo = repo;
            _tz = name;
            label_st_name.Text = _tz;
            _password = password; 

        }

        public void Loaddata()
        {
            label_st_name.Text = _stable.Rows[0][1].ToString();
            label_debt.Text = 
        }

        private void button_signToCourse_Click(object sender, EventArgs e)
        {


            string cname = textBox_enterc_name.Text.Trim();
            if ( string.IsNullOrEmpty(cname))
            {
                MessageBox.Show("Required fields missing");
            }
            else
            {
                if (_stRepo.enrollStudent(_tz,_password, cname))
                {
                    MessageBox.Show($"You have enrolled successfully to {cname}");
                    _stable = _stRepo.GetStudent(_tz);
                    label_debt.Text = _stable.Rows[0][3].ToString();
                    textBox_enterc_name.Clear();
                }
                else
                {
                    MessageBox.Show("you are already enrolled to this course");
                }
            }


        }
    }
}
