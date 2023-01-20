namespace Session_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrdStudents = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdCourse = new System.Windows.Forms.DataGridView();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdGrade = new System.Windows.Forms.DataGridView();
            this.GradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrdSchedule = new System.Windows.Forms.DataGridView();
            this.ScheduleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfessorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Callendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdStudents
            // 
            this.GrdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentSurname});
            this.GrdStudents.Location = new System.Drawing.Point(36, 44);
            this.GrdStudents.Name = "GrdStudents";
            this.GrdStudents.RowHeadersWidth = 62;
            this.GrdStudents.RowTemplate.Height = 33;
            this.GrdStudents.Size = new System.Drawing.Size(684, 111);
            this.GrdStudents.TabIndex = 0;
            this.GrdStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Students_CellContentClick);
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 8;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 150;
            // 
            // StudentSurname
            // 
            this.StudentSurname.DataPropertyName = "Surname";
            this.StudentSurname.HeaderText = "Surname";
            this.StudentSurname.MinimumWidth = 8;
            this.StudentSurname.Name = "StudentSurname";
            this.StudentSurname.Width = 150;
            // 
            // GrdCourse
            // 
            this.GrdCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.CourseCode,
            this.CourseSubject});
            this.GrdCourse.Location = new System.Drawing.Point(36, 199);
            this.GrdCourse.Name = "GrdCourse";
            this.GrdCourse.RowHeadersWidth = 62;
            this.GrdCourse.RowTemplate.Height = 33;
            this.GrdCourse.Size = new System.Drawing.Size(684, 110);
            this.GrdCourse.TabIndex = 1;
            this.GrdCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "Id";
            this.CourseId.HeaderText = "Id";
            this.CourseId.MinimumWidth = 8;
            this.CourseId.Name = "CourseId";
            this.CourseId.Width = 150;
            // 
            // CourseCode
            // 
            this.CourseCode.DataPropertyName = "Code";
            this.CourseCode.HeaderText = "Code";
            this.CourseCode.MinimumWidth = 8;
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.Width = 150;
            // 
            // CourseSubject
            // 
            this.CourseSubject.DataPropertyName = "Subject";
            this.CourseSubject.HeaderText = "Subject";
            this.CourseSubject.MinimumWidth = 8;
            this.CourseSubject.Name = "CourseSubject";
            this.CourseSubject.Width = 150;
            // 
            // GrdGrade
            // 
            this.GrdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradeId,
            this.StudentId,
            this.dataGridViewTextBoxColumn1,
            this.Grade});
            this.GrdGrade.Location = new System.Drawing.Point(36, 353);
            this.GrdGrade.Name = "GrdGrade";
            this.GrdGrade.RowHeadersWidth = 62;
            this.GrdGrade.RowTemplate.Height = 33;
            this.GrdGrade.Size = new System.Drawing.Size(684, 105);
            this.GrdGrade.TabIndex = 2;
            this.GrdGrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // GradeId
            // 
            this.GradeId.DataPropertyName = "Id";
            this.GradeId.HeaderText = "Id";
            this.GradeId.MinimumWidth = 8;
            this.GradeId.Name = "GradeId";
            this.GradeId.Width = 150;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.MinimumWidth = 8;
            this.StudentId.Name = "StudentId";
            this.StudentId.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CourseId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Course Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grades";
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 8;
            this.Grade.Name = "Grade";
            this.Grade.Width = 150;
            // 
            // GrdSchedule
            // 
            this.GrdSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleId,
            this.dataGridViewTextBoxColumn2,
            this.ProfessorId,
            this.Callendar});
            this.GrdSchedule.Location = new System.Drawing.Point(36, 503);
            this.GrdSchedule.Name = "GrdSchedule";
            this.GrdSchedule.RowHeadersWidth = 62;
            this.GrdSchedule.RowTemplate.Height = 33;
            this.GrdSchedule.Size = new System.Drawing.Size(684, 107);
            this.GrdSchedule.TabIndex = 3;
            // 
            // ScheduleId
            // 
            this.ScheduleId.DataPropertyName = "Id";
            this.ScheduleId.HeaderText = "Id";
            this.ScheduleId.MinimumWidth = 8;
            this.ScheduleId.Name = "ScheduleId";
            this.ScheduleId.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CourseId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Course Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // ProfessorId
            // 
            this.ProfessorId.DataPropertyName = "ProfessorId";
            this.ProfessorId.HeaderText = "Professor Id";
            this.ProfessorId.MinimumWidth = 8;
            this.ProfessorId.Name = "ProfessorId";
            this.ProfessorId.Width = 150;
            // 
            // Callendar
            // 
            this.Callendar.DataPropertyName = "Callendar";
            this.Callendar.HeaderText = "Calendar";
            this.Callendar.MinimumWidth = 8;
            this.Callendar.Name = "Callendar";
            this.Callendar.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Student";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Course";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 315);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 31);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Student";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(36, 464);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 31);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Schedule";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(737, 145);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(112, 63);
            this.BtnLoad.TabIndex = 8;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(737, 257);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 63);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 622);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GrdSchedule);
            this.Controls.Add(this.GrdGrade);
            this.Controls.Add(this.GrdCourse);
            this.Controls.Add(this.GrdStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GrdStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GrdStudents;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn StudentSurname;
        private DataGridView GrdCourse;
        private DataGridView GrdGrade;
        private DataGridView GrdSchedule;
        private DataGridViewTextBoxColumn CourseId;
        private DataGridViewTextBoxColumn CourseCode;
        private DataGridViewTextBoxColumn CourseSubject;
        private DataGridViewTextBoxColumn GradeId;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn ScheduleId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ProfessorId;
        private DataGridViewTextBoxColumn Callendar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button BtnLoad;
        private Button BtnSave;
    }
}