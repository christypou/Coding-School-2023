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
            this.GrdSchedule = new System.Windows.Forms.DataGridView();
            this.GradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.GrdStudents.Location = new System.Drawing.Point(36, 12);
            this.GrdStudents.Name = "GrdStudents";
            this.GrdStudents.RowHeadersWidth = 62;
            this.GrdStudents.RowTemplate.Height = 33;
            this.GrdStudents.Size = new System.Drawing.Size(684, 88);
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
            this.GrdCourse.Location = new System.Drawing.Point(36, 106);
            this.GrdCourse.Name = "GrdCourse";
            this.GrdCourse.RowHeadersWidth = 62;
            this.GrdCourse.RowTemplate.Height = 33;
            this.GrdCourse.Size = new System.Drawing.Size(684, 87);
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
            this.GrdGrade.Location = new System.Drawing.Point(36, 199);
            this.GrdGrade.Name = "GrdGrade";
            this.GrdGrade.RowHeadersWidth = 62;
            this.GrdGrade.RowTemplate.Height = 33;
            this.GrdGrade.Size = new System.Drawing.Size(684, 87);
            this.GrdGrade.TabIndex = 2;
            this.GrdGrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // GrdSchedule
            // 
            this.GrdSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSchedule.Location = new System.Drawing.Point(36, 292);
            this.GrdSchedule.Name = "GrdSchedule";
            this.GrdSchedule.RowHeadersWidth = 62;
            this.GrdSchedule.RowTemplate.Height = 33;
            this.GrdSchedule.Size = new System.Drawing.Size(684, 87);
            this.GrdSchedule.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}