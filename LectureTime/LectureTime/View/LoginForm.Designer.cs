namespace LectureTime.View
{
    partial class LoginForm
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
            this.IdText = new System.Windows.Forms.TextBox();
            this.PwText = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdText
            // 
            this.IdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdText.Font = new System.Drawing.Font("굴림", 15F);
            this.IdText.Location = new System.Drawing.Point(480, 188);
            this.IdText.Margin = new System.Windows.Forms.Padding(9);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(580, 76);
            this.IdText.TabIndex = 0;
            // 
            // PwText
            // 
            this.PwText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwText.Font = new System.Drawing.Font("굴림", 15F);
            this.PwText.Location = new System.Drawing.Point(491, 434);
            this.PwText.Margin = new System.Windows.Forms.Padding(9);
            this.PwText.Name = "PwText";
            this.PwText.Size = new System.Drawing.Size(569, 76);
            this.PwText.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Firebrick;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(621, 606);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(9);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(302, 91);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "로그인";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(669, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(648, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 81);
            this.label2.TabIndex = 4;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1108, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 81);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(776, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(867, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "수강신청을 위해 아이디와 비밀번호를 입력해주세요.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.PwText);
            this.panel1.Controls.Add(this.IdText);
            this.panel1.Location = new System.Drawing.Point(448, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 810);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1119, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 81);
            this.label5.TabIndex = 8;
            this.label5.Text = "로그인";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 21F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(689, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1097, 84);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sejong Lecture Time Table";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2400, 1350);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(9);
            this.MinimumSize = new System.Drawing.Size(2436, 1453);
            this.Name = "LoginForm";
            this.Text = "  ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox PwText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}