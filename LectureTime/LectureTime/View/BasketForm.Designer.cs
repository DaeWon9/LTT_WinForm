namespace LectureTime.View
{
    partial class BasketForm
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
            this.SearchResultFormInBasket = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfessorText = new System.Windows.Forms.TextBox();
            this.LectureNameText = new System.Windows.Forms.TextBox();
            this.GradeDropDown = new System.Windows.Forms.ComboBox();
            this.ClassificationDropDown = new System.Windows.Forms.ComboBox();
            this.DepartmentDropDown = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BasketGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.개설학과전공 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.학수번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.분반 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.교과목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.이수구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.학년 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.학점 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.강의실 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.교수명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.강의언어 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultFormInBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasketGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResultFormInBasket
            // 
            this.SearchResultFormInBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultFormInBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.번호,
            this.개설학과전공,
            this.학수번호,
            this.분반,
            this.교과목명,
            this.이수구분,
            this.학년,
            this.학점,
            this.시간,
            this.강의실,
            this.교수명,
            this.강의언어,
            this.add});
            this.SearchResultFormInBasket.Location = new System.Drawing.Point(30, 141);
            this.SearchResultFormInBasket.Name = "SearchResultFormInBasket";
            this.SearchResultFormInBasket.ReadOnly = true;
            this.SearchResultFormInBasket.RowTemplate.Height = 23;
            this.SearchResultFormInBasket.Size = new System.Drawing.Size(1213, 186);
            this.SearchResultFormInBasket.TabIndex = 6;
            this.SearchResultFormInBasket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResultFormInBasket_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "교수명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "교과목명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "학년";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "이수구분";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "개설학과전공";
            // 
            // ProfessorText
            // 
            this.ProfessorText.Location = new System.Drawing.Point(858, 63);
            this.ProfessorText.Name = "ProfessorText";
            this.ProfessorText.Size = new System.Drawing.Size(100, 21);
            this.ProfessorText.TabIndex = 16;
            // 
            // LectureNameText
            // 
            this.LectureNameText.Location = new System.Drawing.Point(696, 63);
            this.LectureNameText.Name = "LectureNameText";
            this.LectureNameText.Size = new System.Drawing.Size(100, 21);
            this.LectureNameText.TabIndex = 15;
            // 
            // GradeDropDown
            // 
            this.GradeDropDown.FormattingEnabled = true;
            this.GradeDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.GradeDropDown.Location = new System.Drawing.Point(497, 64);
            this.GradeDropDown.Name = "GradeDropDown";
            this.GradeDropDown.Size = new System.Drawing.Size(121, 20);
            this.GradeDropDown.TabIndex = 14;
            // 
            // ClassificationDropDown
            // 
            this.ClassificationDropDown.FormattingEnabled = true;
            this.ClassificationDropDown.Items.AddRange(new object[] {
            "교양필수",
            "전공필수",
            "전공선택"});
            this.ClassificationDropDown.Location = new System.Drawing.Point(309, 64);
            this.ClassificationDropDown.Name = "ClassificationDropDown";
            this.ClassificationDropDown.Size = new System.Drawing.Size(121, 20);
            this.ClassificationDropDown.TabIndex = 13;
            // 
            // DepartmentDropDown
            // 
            this.DepartmentDropDown.FormattingEnabled = true;
            this.DepartmentDropDown.Items.AddRange(new object[] {
            "컴퓨터공학과",
            "소프트웨어학과",
            "지능기전공학부",
            "기계항공우주공학부"});
            this.DepartmentDropDown.Location = new System.Drawing.Point(123, 64);
            this.DepartmentDropDown.Name = "DepartmentDropDown";
            this.DepartmentDropDown.Size = new System.Drawing.Size(121, 20);
            this.DepartmentDropDown.TabIndex = 12;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1061, 63);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 23);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "검색하기";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BasketGridView
            // 
            this.BasketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BasketGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.delete});
            this.BasketGridView.Location = new System.Drawing.Point(30, 352);
            this.BasketGridView.Name = "BasketGridView";
            this.BasketGridView.ReadOnly = true;
            this.BasketGridView.RowTemplate.Height = 23;
            this.BasketGridView.Size = new System.Drawing.Size(1213, 186);
            this.BasketGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "번호";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 40;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "개설학과전공";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 110;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "학수번호";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "분반";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 40;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "교과목명";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "이수구분";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "학년";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 40;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "학점";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 40;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "요일 및 강의시간";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 150;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "강의실";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "교수명";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "강의언어";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "취소";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // 번호
            // 
            this.번호.HeaderText = "번호";
            this.번호.Name = "번호";
            this.번호.ReadOnly = true;
            this.번호.Width = 40;
            // 
            // 개설학과전공
            // 
            this.개설학과전공.HeaderText = "개설학과전공";
            this.개설학과전공.Name = "개설학과전공";
            this.개설학과전공.ReadOnly = true;
            this.개설학과전공.Width = 110;
            // 
            // 학수번호
            // 
            this.학수번호.HeaderText = "학수번호";
            this.학수번호.Name = "학수번호";
            this.학수번호.ReadOnly = true;
            // 
            // 분반
            // 
            this.분반.HeaderText = "분반";
            this.분반.Name = "분반";
            this.분반.ReadOnly = true;
            this.분반.Width = 40;
            // 
            // 교과목명
            // 
            this.교과목명.HeaderText = "교과목명";
            this.교과목명.Name = "교과목명";
            this.교과목명.ReadOnly = true;
            this.교과목명.Width = 150;
            // 
            // 이수구분
            // 
            this.이수구분.HeaderText = "이수구분";
            this.이수구분.Name = "이수구분";
            this.이수구분.ReadOnly = true;
            // 
            // 학년
            // 
            this.학년.HeaderText = "학년";
            this.학년.Name = "학년";
            this.학년.ReadOnly = true;
            this.학년.Width = 40;
            // 
            // 학점
            // 
            this.학점.HeaderText = "학점";
            this.학점.Name = "학점";
            this.학점.ReadOnly = true;
            this.학점.Width = 40;
            // 
            // 시간
            // 
            this.시간.HeaderText = "요일 및 강의시간";
            this.시간.Name = "시간";
            this.시간.ReadOnly = true;
            this.시간.Width = 150;
            // 
            // 강의실
            // 
            this.강의실.HeaderText = "강의실";
            this.강의실.Name = "강의실";
            this.강의실.ReadOnly = true;
            // 
            // 교수명
            // 
            this.교수명.HeaderText = "교수명";
            this.교수명.Name = "교수명";
            this.교수명.ReadOnly = true;
            // 
            // 강의언어
            // 
            this.강의언어.HeaderText = "강의언어";
            this.강의언어.Name = "강의언어";
            this.강의언어.ReadOnly = true;
            // 
            // add
            // 
            this.add.HeaderText = "담기";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Text = "";
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 579);
            this.Controls.Add(this.BasketGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfessorText);
            this.Controls.Add(this.LectureNameText);
            this.Controls.Add(this.GradeDropDown);
            this.Controls.Add(this.ClassificationDropDown);
            this.Controls.Add(this.DepartmentDropDown);
            this.Controls.Add(this.SearchResultFormInBasket);
            this.Name = "BasketForm";
            this.Text = "BasketForm";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultFormInBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasketGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SearchResultFormInBasket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProfessorText;
        private System.Windows.Forms.TextBox LectureNameText;
        private System.Windows.Forms.ComboBox GradeDropDown;
        private System.Windows.Forms.ComboBox ClassificationDropDown;
        private System.Windows.Forms.ComboBox DepartmentDropDown;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView BasketGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn 번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 개설학과전공;
        private System.Windows.Forms.DataGridViewTextBoxColumn 학수번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분반;
        private System.Windows.Forms.DataGridViewTextBoxColumn 교과목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이수구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 학년;
        private System.Windows.Forms.DataGridViewTextBoxColumn 학점;
        private System.Windows.Forms.DataGridViewTextBoxColumn 시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 강의실;
        private System.Windows.Forms.DataGridViewTextBoxColumn 교수명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 강의언어;
        private System.Windows.Forms.DataGridViewButtonColumn add;
    }
}