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
using System.Text.RegularExpressions;
using LectureTime.Utility;

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
            string before = "";
            string after = "";
            string total = "";
            string data = "자료구조, 센2B03";
            string date = "월 화 10:30~12:00";

            //ApplyGridView.Rows.Add(lectureList[no][4],lectureList[no][8], lectureList[no][9]);
            //4 = 교과목명, 8 = 화 목 10:00 ~ 11:00,   9 = 강의실

            if (dataGridView1.RowCount > 0)
                dataGridView1.Rows.Clear();

            //전체 시간
            TimeSpan currentTime = TimeSpan.Parse("09:00");
            TimeSpan interval = TimeSpan.FromMinutes(30);

            for (int no = 0; no < 22; no++)
            {
                before = currentTime.ToString(@"hh\:mm");
                after = (currentTime + interval).ToString(@"hh\:mm");
                total = before + "~" + after;
                dataGridView1.Rows.Add(total, "", "", "", "", "", "");
                currentTime += interval;
            }
        }
        private void setSchedule(string data, string date)
        {
            TimeSpan currentTime = TimeSpan.Parse("09:00");
            TimeSpan interval = TimeSpan.FromMinutes(30);

            // 시간 추출
            string temp = exportDate(date);
            string[] time = temp.Split('~');
            TimeSpan start = TimeSpan.Parse(time[0]);
            TimeSpan end = TimeSpan.Parse(time[1]);

            for (int no = 0; no < 22; no++)
            {
                if (currentTime >= start && currentTime < end)
                {
                    if (date.Contains("월"))
                    {
                        dataGridView1.Rows[no].Cells["monday"].Value = data;
                    }
                    if (date.Contains("화"))
                    {
                        dataGridView1.Rows[no].Cells["tuesday"].Value = data;
                    }
                    if (date.Contains("수"))
                    {
                        dataGridView1.Rows[no].Cells["whensday"].Value = data;
                    }
                    if (date.Contains("목"))
                    {
                        dataGridView1.Rows[no].Cells["thursday"].Value = data;
                    }
                    if (date.Contains("금"))
                    {
                        dataGridView1.Rows[no].Cells["friday"].Value = data;
                    }
                    if (date.Contains("토"))
                    {
                        dataGridView1.Rows[no].Cells["saturday"].Value = data;
                    }
                }
                currentTime += interval;
            }
            dataGridView1.Refresh();
        }

        
        private string exportDate(string date)
        {
            string pattern = @"\d{2}:\d{2}~\d{2}:\d{2}";
            string data = "";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(date);

            foreach (Match match in matches)
            {
                data = match.Value;
            }
            return data;

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

        private void setSchedule_Click(object sender, EventArgs e)
        {
            List<List<string>> lectureList = ApplyData.Get().applyDataList;
            string data = "";
            string date = "";

            for (int no = 0; no < lectureList.Count; no++)
            {
                data = lectureList[no][4] + "\n" + lectureList[no][9];
                date = lectureList[no][8];
                setSchedule(data, date);
            }
        }
    }
}
