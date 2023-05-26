using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectureTime.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); 
        }

        private void SearchModeButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void ApplyModeButton_Click(object sender, EventArgs e)
        {
            ApplyForm applyForm = new ApplyForm();  
            applyForm.ShowDialog();
        }

        private void BasketModeButton_Click(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm();  
            basketForm.ShowDialog();
        }

    }
}
