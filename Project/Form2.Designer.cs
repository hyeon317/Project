namespace Project
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_grade1 = new System.Windows.Forms.RadioButton();
            this.rb_grade2 = new System.Windows.Forms.RadioButton();
            this.rb_grade3 = new System.Windows.Forms.RadioButton();
            this.rb_grade4 = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어_ac ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(253, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "대학생들의 휴학과 학업만족도";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 68);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 82);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어_ac", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "귀하의 학년을 선택해주세요 ( 현재 재학중인 학년을 선택해주시면 됩니다. )";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(35, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 42);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어_ac ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(30, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "문제1";
            // 
            // rb_grade1
            // 
            this.rb_grade1.AutoSize = true;
            this.rb_grade1.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_grade1.Location = new System.Drawing.Point(35, 206);
            this.rb_grade1.Name = "rb_grade1";
            this.rb_grade1.Size = new System.Drawing.Size(55, 18);
            this.rb_grade1.TabIndex = 3;
            this.rb_grade1.TabStop = true;
            this.rb_grade1.Text = "1학년";
            this.rb_grade1.UseVisualStyleBackColor = true;
            // 
            // rb_grade2
            // 
            this.rb_grade2.AutoSize = true;
            this.rb_grade2.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_grade2.Location = new System.Drawing.Point(35, 253);
            this.rb_grade2.Name = "rb_grade2";
            this.rb_grade2.Size = new System.Drawing.Size(55, 18);
            this.rb_grade2.TabIndex = 4;
            this.rb_grade2.TabStop = true;
            this.rb_grade2.Text = "2학년";
            this.rb_grade2.UseVisualStyleBackColor = true;
            // 
            // rb_grade3
            // 
            this.rb_grade3.AutoSize = true;
            this.rb_grade3.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_grade3.Location = new System.Drawing.Point(35, 298);
            this.rb_grade3.Name = "rb_grade3";
            this.rb_grade3.Size = new System.Drawing.Size(55, 18);
            this.rb_grade3.TabIndex = 5;
            this.rb_grade3.TabStop = true;
            this.rb_grade3.Text = "3학년";
            this.rb_grade3.UseVisualStyleBackColor = true;
            // 
            // rb_grade4
            // 
            this.rb_grade4.AutoSize = true;
            this.rb_grade4.Font = new System.Drawing.Font("나눔스퀘어_ac", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_grade4.Location = new System.Drawing.Point(35, 345);
            this.rb_grade4.Name = "rb_grade4";
            this.rb_grade4.Size = new System.Drawing.Size(55, 18);
            this.rb_grade4.TabIndex = 6;
            this.rb_grade4.TabStop = true;
            this.rb_grade4.Text = "4학년";
            this.rb_grade4.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.next.Location = new System.Drawing.Point(650, 401);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(120, 40);
            this.next.TabIndex = 8;
            this.next.Text = "다음으로 ▶";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit.Location = new System.Drawing.Point(12, 401);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(120, 40);
            this.exit.TabIndex = 7;
            this.exit.Text = "나가기";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.Transparent;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.prev.Location = new System.Drawing.Point(524, 401);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(120, 40);
            this.prev.TabIndex = 9;
            this.prev.Text = "◀ 이전으로";
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.rb_grade4);
            this.Controls.Add(this.rb_grade3);
            this.Controls.Add(this.rb_grade2);
            this.Controls.Add(this.rb_grade1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_grade1;
        private System.Windows.Forms.RadioButton rb_grade2;
        private System.Windows.Forms.RadioButton rb_grade3;
        private System.Windows.Forms.RadioButton rb_grade4;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button prev;
    }
}