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
using LectureTime.Utility;

namespace LectureTime.View
{
    public partial class BasketForm : Form
    {
        private LectureTimeSearcher lectureTimeSearcher;

        public BasketForm()
        {
            InitializeComponent();
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {
            lectureTimeSearcher = new LectureTimeSearcher();
            List<List<string>> lectureList = BasketData.Get().basketDataList;

            if (BasketGridView.RowCount > 0)
                BasketGridView.Rows.Clear();

            for (int no = 0; no < lectureList.Count; no++)
            {
                BasketGridView.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11], "취소하기");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedDepartment = "";
            string selectedClassification = "";
            string selectedGrade = "";

            if (SearchResultFormInBasket.RowCount > 0)
                SearchResultFormInBasket.Rows.Clear();

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
                SearchResultFormInBasket.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11], "관심과목담기");
            }
        }

        private void SearchResultFormInBasket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SearchResultFormInBasket.RowCount > 0 && e.RowIndex >= 0 && e.ColumnIndex == this.add.Index)
            {
                string num = SearchResultFormInBasket.Rows[e.RowIndex].Cells["번호"].Value.ToString();
                string department = SearchResultFormInBasket.Rows[e.RowIndex].Cells["개설학과전공"].Value.ToString();
                string hagsu = SearchResultFormInBasket.Rows[e.RowIndex].Cells["학수번호"].Value.ToString();
                string roomClass = SearchResultFormInBasket.Rows[e.RowIndex].Cells["분반"].Value.ToString();
                string name = SearchResultFormInBasket.Rows[e.RowIndex].Cells["교과목명"].Value.ToString();
                string classification = SearchResultFormInBasket.Rows[e.RowIndex].Cells["이수구분"].Value.ToString();
                string grade = SearchResultFormInBasket.Rows[e.RowIndex].Cells["학년"].Value.ToString();
                string classCount = SearchResultFormInBasket.Rows[e.RowIndex].Cells["학점"].Value.ToString();
                string time = SearchResultFormInBasket.Rows[e.RowIndex].Cells["시간"].Value.ToString();
                string room = SearchResultFormInBasket.Rows[e.RowIndex].Cells["강의실"].Value.ToString();
                string professor = SearchResultFormInBasket.Rows[e.RowIndex].Cells["교수명"].Value.ToString();
                string lang = SearchResultFormInBasket.Rows[e.RowIndex].Cells["강의언어"].Value.ToString();

                if (DataProcessing.Get().IsLectureNameOverlap(BasketData.Get().basketDataList, name))
                {
                    MessageBox.Show("해당과목과 동일한 이름의 과목이 이미 등록되어있습니다.");
                    return;
                }

                if (DataProcessing.Get().IsLectureTimeOverlap(BasketData.Get().basketDataList, time))
                {
                    MessageBox.Show("다른과목과 시간이 겹칩니다.");
                    return;
                }

                if(DataProcessing.Get().IsBaskGradeOver(classCount))
                {
                    MessageBox.Show("등록가능한 학점을 초과하였습니다.");
                    return;

                }

                BasketData.Get().basketDataList.Add(new List<string> {num, department, hagsu, roomClass, name, classification, grade, classCount, time, room, professor, lang });
                MessageBox.Show(string.Format("{0} 과목이 관심과목에 추가되었습니다!", name));

                List<List<string>> lectureList = BasketData.Get().basketDataList;

                if (BasketGridView.RowCount > 0)
                    BasketGridView.Rows.Clear();

                for (int no = 0; no < lectureList.Count; no++)
                {
                    BasketGridView.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11], "취소하기");
                }
            }
        }
    }
}
