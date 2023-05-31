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
    public partial class ApplyForm : Form
    {
        private LectureTimeSearcher lectureTimeSearcher;
        private MainForm mainForm;
        public ApplyForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ApplyForm_Load(object sender, EventArgs e)
        {
            lectureTimeSearcher = new LectureTimeSearcher();
            List<List<string>> lectureList = ApplyData.Get().applyDataList;

            if (ApplyGridView.RowCount > 0)
                ApplyGridView.Rows.Clear();

            for (int no = 0; no < lectureList.Count; no++)
            {
                ApplyGridView.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11], "취소하기");
            }
        }

 

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string selectedDepartment = "";
            string selectedClassification = "";
            string selectedGrade = "";

            if (SearchResultFormInApply.RowCount > 0)
                SearchResultFormInApply.Rows.Clear();

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
                SearchResultFormInApply.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11], "수강신청");
            }
        }

        private void SearchResultFormInApply_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SearchResultFormInApply.RowCount > 0 && e.RowIndex >= 0 && e.ColumnIndex == this.add.Index)
            {
                string num = SearchResultFormInApply.Rows[e.RowIndex].Cells["번호"].Value.ToString();
                string department = SearchResultFormInApply.Rows[e.RowIndex].Cells["개설학과전공"].Value.ToString();
                string hagsu = SearchResultFormInApply.Rows[e.RowIndex].Cells["학수번호"].Value.ToString();
                string roomClass = SearchResultFormInApply.Rows[e.RowIndex].Cells["분반"].Value.ToString();
                string name = SearchResultFormInApply.Rows[e.RowIndex].Cells["교과목명"].Value.ToString();
                string classification = SearchResultFormInApply.Rows[e.RowIndex].Cells["이수구분"].Value.ToString();
                string grade = SearchResultFormInApply.Rows[e.RowIndex].Cells["학년"].Value.ToString();
                string classCount = SearchResultFormInApply.Rows[e.RowIndex].Cells["학점"].Value.ToString();
                string time = SearchResultFormInApply.Rows[e.RowIndex].Cells["시간"].Value.ToString();
                string room = SearchResultFormInApply.Rows[e.RowIndex].Cells["강의실"].Value.ToString();
                string professor = SearchResultFormInApply.Rows[e.RowIndex].Cells["교수명"].Value.ToString();
                string lang = SearchResultFormInApply.Rows[e.RowIndex].Cells["강의언어"].Value.ToString();

                if (DataProcessing.Get().IsLectureNameOverlap(ApplyData.Get().applyDataList, name))
                {
                    MessageBox.Show("해당과목과 동일한 이름의 과목이 이미 등록되어있습니다.");
                    return;
                }

                if (DataProcessing.Get().IsLectureTimeOverlap(ApplyData.Get().applyDataList, time))
                {
                    MessageBox.Show("다른과목과 시간이 겹칩니다.");
                    return;
                }

                if (DataProcessing.Get().IsApplyGradeOver(classCount))
                {
                    MessageBox.Show("등록가능한 학점을 초과하였습니다.");
                    return;

                }

                ApplyData.Get().applyDataList.Add(new List<string> { num, department, hagsu, roomClass, name, classification, grade, classCount, time, room, professor, lang });
                MessageBox.Show(string.Format("{0} 과목이 수강 신청되었습니다!", name));

                List<List<string>> lectureList = ApplyData.Get().applyDataList;

                string data = "";
                string date = "";

                for (int no = 0; no < lectureList.Count; no++)
                {
                    data = lectureList[no][4] + "\n" + lectureList[no][9];
                    date = lectureList[no][8];
                    mainForm.setSchedule(data, date);
                }

                if (ApplyGridView.RowCount > 0)
                    ApplyGridView.Rows.Clear();

                for (int no = 0; no < lectureList.Count; no++)
                {
                    ApplyGridView.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11], "취소하기");
                }

                if (BasketData.Get().basketDataList.Count > 0)
                {
                    if (SearchResultFormInApply.RowCount > 0)
                        SearchResultFormInApply.Rows.Clear();

                    List<List<string>> basketLectureList = BasketData.Get().basketDataList;
                    List<string> noList = ApplyData.Get().GetNoList();



                    for (int no = 0; no < basketLectureList.Count; no++)
                    {
                        if (noList.Contains(basketLectureList[no][0]))
                            continue;
                        SearchResultFormInApply.Rows.Add(basketLectureList[no][0], basketLectureList[no][1], basketLectureList[no][2], basketLectureList[no][3], basketLectureList[no][4], basketLectureList[no][5], basketLectureList[no][6], basketLectureList[no][7], basketLectureList[no][8], basketLectureList[no][9], basketLectureList[no][10], basketLectureList[no][11], "수강신청");
                    }
                }
            }
        }

        private void ApplyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = ApplyGridView.Rows[e.RowIndex].Cells["교과목명2"].Value.ToString();

            if (ApplyGridView.RowCount > 0 && e.RowIndex >= 0 && e.ColumnIndex == this.delete.Index)
            {
                ApplyData.Get().applyDataList.RemoveAt(e.RowIndex);
                MessageBox.Show(string.Format("{0} 과목이 수강신청 과목에서 제거되었습니다!", name));

                List<List<string>> lectureList = ApplyData.Get().applyDataList;
                string data = "";
                string date = "";

                for (int no = 0; no < lectureList.Count; no++)
                {
                    data = lectureList[no][4] + "\n" + lectureList[no][9];
                    date = lectureList[no][8];
                    mainForm.setSchedule(data, date);
                }
                if (ApplyGridView.RowCount > 0)
                    ApplyGridView.Rows.Clear();

                for (int no = 0; no < lectureList.Count; no++)
                {
                    ApplyGridView.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11], "취소하기");
                }

            }
        }

        private void BasketButton_Click(object sender, EventArgs e)
        {
            if (BasketData.Get().basketDataList.Count > 0)
            {
                if (SearchResultFormInApply.RowCount > 0)
                    SearchResultFormInApply.Rows.Clear();

                List<List<string>> lectureList = BasketData.Get().basketDataList;
                List<string> noList = ApplyData.Get().GetNoList();



                for (int no = 0; no < lectureList.Count; no++)
                {
                    if (noList.Contains(lectureList[no][0]))
                        continue;
                    SearchResultFormInApply.Rows.Add(lectureList[no][0], lectureList[no][1], lectureList[no][2], lectureList[no][3], lectureList[no][4], lectureList[no][5], lectureList[no][6], lectureList[no][7], lectureList[no][8], lectureList[no][9], lectureList[no][10], lectureList[no][11], "수강신청");
                }
            }
            else
            {
                MessageBox.Show(string.Format("관심과목이 비어있습니다."));
            }
        }
    }
}
