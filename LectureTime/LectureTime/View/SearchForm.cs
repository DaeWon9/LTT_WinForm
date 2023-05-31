using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LectureTime.Model;
using LectureTime.Controller;

namespace LectureTime.View
{
    public partial class SearchForm : Form
    {
        private LectureTimeSearcher lectureTimeSearcher;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SearchResultView.AutoGenerateColumns = false;
            lectureTimeSearcher = new LectureTimeSearcher();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedDepartment = "";
            string selectedClassification = "";
            string selectedGrade = "";

            if (SearchResultView.RowCount > 0)
                SearchResultView.Rows.Clear();

            if (DepartmentDropDown.SelectedItem != null)
            {
                selectedDepartment = DepartmentDropDown.SelectedItem.ToString();
            }
            if (ClassificationDropDown.SelectedItem != null)
            {
                selectedClassification = ClassificationDropDown.SelectedItem.ToString();
            }
            if (GradeDropDown.SelectedItem != null)
            {
                selectedGrade = GradeDropDown.SelectedItem.ToString();
            }

            List<List<string>> lectureList = lectureTimeSearcher.Search(selectedDepartment, selectedClassification, selectedGrade, LectureNameText.Text, ProfessorText.Text);
            int lectureCount = lectureList.Count;

            for (int no = 0; no < lectureCount; no++)
            {
                Console.WriteLine(lectureList[no]);
                SearchResultView.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11]);
            }
        }
    }
}
