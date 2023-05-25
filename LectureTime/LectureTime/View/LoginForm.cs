using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LectureTime.Controller;
using LectureTime.Model;

namespace LectureTime.View
{
    public partial class LoginForm : Form
    {
        private UserServicer userServicer;
        public LoginForm()
        {
            InitializeComponent();
            this.userServicer = new UserServicer();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(userServicer.IsLoginSuccess(IdText.Text, PwText.Text))
            {
                this.Visible = false;

                MainForm mainForm = new MainForm();

                mainForm.ShowDialog();
            }
           
        }
    }
}
