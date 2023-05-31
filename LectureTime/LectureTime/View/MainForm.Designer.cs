namespace LectureTime.View
{
    partial class MainForm
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
            this.SearchModeButton = new System.Windows.Forms.Button();
            this.BasketModeButton = new System.Windows.Forms.Button();
            this.ApplyModeButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whensday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ExcelSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchModeButton
            // 
            this.SearchModeButton.Location = new System.Drawing.Point(849, 153);
            this.SearchModeButton.Name = "SearchModeButton";
            this.SearchModeButton.Size = new System.Drawing.Size(119, 39);
            this.SearchModeButton.TabIndex = 0;
            this.SearchModeButton.Text = "강의검색";
            this.SearchModeButton.UseVisualStyleBackColor = true;
            this.SearchModeButton.Click += new System.EventHandler(this.SearchModeButton_Click);
            // 
            // BasketModeButton
            // 
            this.BasketModeButton.Location = new System.Drawing.Point(849, 221);
            this.BasketModeButton.Name = "BasketModeButton";
            this.BasketModeButton.Size = new System.Drawing.Size(119, 38);
            this.BasketModeButton.TabIndex = 1;
            this.BasketModeButton.Text = "관심과목";
            this.BasketModeButton.UseVisualStyleBackColor = true;
            this.BasketModeButton.Click += new System.EventHandler(this.BasketModeButton_Click);
            // 
            // ApplyModeButton
            // 
            this.ApplyModeButton.Location = new System.Drawing.Point(849, 292);
            this.ApplyModeButton.Name = "ApplyModeButton";
            this.ApplyModeButton.Size = new System.Drawing.Size(119, 38);
            this.ApplyModeButton.TabIndex = 2;
            this.ApplyModeButton.Text = "수강신청";
            this.ApplyModeButton.UseVisualStyleBackColor = true;
            this.ApplyModeButton.Click += new System.EventHandler(this.ApplyModeButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(870, 58);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "로그아웃";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.monday,
            this.tuesday,
            this.whensday,
            this.thursday,
            this.friday,
            this.saturday});
            this.dataGridView1.Location = new System.Drawing.Point(29, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(804, 575);
            this.dataGridView1.TabIndex = 4;
            // 
            // title
            // 
            this.title.HeaderText = "시간표";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.title.Width = 125;
            // 
            // monday
            // 
            this.monday.HeaderText = "월";
            this.monday.MinimumWidth = 6;
            this.monday.Name = "monday";
            this.monday.Width = 125;
            // 
            // tuesday
            // 
            this.tuesday.HeaderText = "화";
            this.tuesday.MinimumWidth = 6;
            this.tuesday.Name = "tuesday";
            this.tuesday.Width = 125;
            // 
            // whensday
            // 
            this.whensday.HeaderText = "수";
            this.whensday.MinimumWidth = 6;
            this.whensday.Name = "whensday";
            this.whensday.Width = 125;
            // 
            // thursday
            // 
            this.thursday.HeaderText = "목";
            this.thursday.MinimumWidth = 6;
            this.thursday.Name = "thursday";
            this.thursday.Width = 125;
            // 
            // friday
            // 
            this.friday.HeaderText = "금";
            this.friday.MinimumWidth = 6;
            this.friday.Name = "friday";
            this.friday.Width = 125;
            // 
            // saturday
            // 
            this.saturday.HeaderText = "토";
            this.saturday.MinimumWidth = 6;
            this.saturday.Name = "saturday";
            this.saturday.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "시간표 확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.setSchedule_Click);
            // 
            // ExcelSaveButton
            // 
            this.ExcelSaveButton.Location = new System.Drawing.Point(849, 423);
            this.ExcelSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExcelSaveButton.Name = "ExcelSaveButton";
            this.ExcelSaveButton.Size = new System.Drawing.Size(119, 37);
            this.ExcelSaveButton.TabIndex = 6;
            this.ExcelSaveButton.Text = "엑셀저장";
            this.ExcelSaveButton.UseVisualStyleBackColor = true;
            this.ExcelSaveButton.Click += new System.EventHandler(this.ExcelSaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 669);
            this.Controls.Add(this.ExcelSaveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ApplyModeButton);
            this.Controls.Add(this.BasketModeButton);
            this.Controls.Add(this.SearchModeButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchModeButton;
        private System.Windows.Forms.Button BasketModeButton;
        private System.Windows.Forms.Button ApplyModeButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn whensday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn saturday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExcelSaveButton;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}