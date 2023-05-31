namespace LectureTime.View
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DepartmentDropDown = new System.Windows.Forms.ComboBox();
            this.ClassificationDropDown = new System.Windows.Forms.ComboBox();
            this.GradeDropDown = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchResultView = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hagsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureNameText = new System.Windows.Forms.TextBox();
            this.ProfessorText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultView)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentDropDown
            // 
            this.DepartmentDropDown.FormattingEnabled = true;
            this.DepartmentDropDown.Items.AddRange(new object[] {
            "컴퓨터공학과",
            "소프트웨어학과",
            "지능기전공학부",
            "기계항공우주공학부"});
            this.DepartmentDropDown.Location = new System.Drawing.Point(99, 39);
            this.DepartmentDropDown.Name = "DepartmentDropDown";
            this.DepartmentDropDown.Size = new System.Drawing.Size(121, 20);
            this.DepartmentDropDown.TabIndex = 0;
            // 
            // ClassificationDropDown
            // 
            this.ClassificationDropDown.FormattingEnabled = true;
            this.ClassificationDropDown.Items.AddRange(new object[] {
            "교양필수",
            "전공필수",
            "전공선택"});
            this.ClassificationDropDown.Location = new System.Drawing.Point(285, 39);
            this.ClassificationDropDown.Name = "ClassificationDropDown";
            this.ClassificationDropDown.Size = new System.Drawing.Size(121, 20);
            this.ClassificationDropDown.TabIndex = 1;
            // 
            // GradeDropDown
            // 
            this.GradeDropDown.FormattingEnabled = true;
            this.GradeDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.GradeDropDown.Location = new System.Drawing.Point(473, 39);
            this.GradeDropDown.Name = "GradeDropDown";
            this.GradeDropDown.Size = new System.Drawing.Size(121, 20);
            this.GradeDropDown.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1029, 36);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "검색하기";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchResultView
            // 
            this.SearchResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Department,
            this.Hagsu,
            this.Class,
            this.LectureName,
            this.Classification,
            this.Grade,
            this.Credit,
            this.date,
            this.LectureRoom,
            this.Professor,
            this.Language});
            this.SearchResultView.Location = new System.Drawing.Point(12, 93);
            this.SearchResultView.Name = "SearchResultView";
            this.SearchResultView.ReadOnly = true;
            this.SearchResultView.RowTemplate.Height = 23;
            this.SearchResultView.Size = new System.Drawing.Size(1115, 322);
            this.SearchResultView.TabIndex = 4;
            // 
            // No
            // 
            this.No.HeaderText = "번호";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // Department
            // 
            this.Department.HeaderText = "개설학과전공";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 110;
            // 
            // Hagsu
            // 
            this.Hagsu.HeaderText = "학수번호";
            this.Hagsu.Name = "Hagsu";
            this.Hagsu.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.HeaderText = "분반";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 40;
            // 
            // LectureName
            // 
            this.LectureName.HeaderText = "교과목명";
            this.LectureName.Name = "LectureName";
            this.LectureName.ReadOnly = true;
            this.LectureName.Width = 150;
            // 
            // Classification
            // 
            this.Classification.HeaderText = "이수구분";
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "학년";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 40;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "학점";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 40;
            // 
            // date
            // 
            this.date.HeaderText = "요일 및 강의시간";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // LectureRoom
            // 
            this.LectureRoom.HeaderText = "강의실";
            this.LectureRoom.Name = "LectureRoom";
            this.LectureRoom.ReadOnly = true;
            // 
            // Professor
            // 
            this.Professor.HeaderText = "교수명";
            this.Professor.Name = "Professor";
            this.Professor.ReadOnly = true;
            // 
            // Language
            // 
            this.Language.HeaderText = "강의언어";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            // 
            // LectureNameText
            // 
            this.LectureNameText.Location = new System.Drawing.Point(672, 38);
            this.LectureNameText.Name = "LectureNameText";
            this.LectureNameText.Size = new System.Drawing.Size(100, 21);
            this.LectureNameText.TabIndex = 5;
            // 
            // ProfessorText
            // 
            this.ProfessorText.Location = new System.Drawing.Point(834, 38);
            this.ProfessorText.Name = "ProfessorText";
            this.ProfessorText.Size = new System.Drawing.Size(100, 21);
            this.ProfessorText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "개설학과전공";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "이수구분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "학년";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "교과목명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(787, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "교수명";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 425);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfessorText);
            this.Controls.Add(this.LectureNameText);
            this.Controls.Add(this.SearchResultView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.GradeDropDown);
            this.Controls.Add(this.ClassificationDropDown);
            this.Controls.Add(this.DepartmentDropDown);
            this.Name = "SearchForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DepartmentDropDown;
        private System.Windows.Forms.ComboBox ClassificationDropDown;
        private System.Windows.Forms.ComboBox GradeDropDown;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView SearchResultView;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hagsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.TextBox LectureNameText;
        private System.Windows.Forms.TextBox ProfessorText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}