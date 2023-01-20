namespace Session_10
{
    public partial class Form1 : Form
    {
        University uni1= new University();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void PopulateStudents()
        {

            uni1.Student = new List<Student>();

            Student student1 = new Student()
            {
                Name = "Dimitris",
                Surname = "Raptodimos",
                
            };
            uni1.Student.Add(student1);

            Student student2 = new Student()
            {
                Name = "Fotis",
                Surname = "Chrysoulas",
              
            };
            uni1.Student.Add(student2);
            GrdStudents.AutoGenerateColumns = false;
            GrdStudents.DataSource = uni1.Student;
        }
        private void PopulateCourses()
        {

            uni1.Courses = new List<Course>();
            Guid id = Guid.Parse("{72F9974A-370C-4FCE-AD99-9A73FC089E60}");
            Course course1 = new Course()
            {
                Id= id,
                Code = "code4",
                Subject = "Math"

            };
            uni1.Courses.Add(course1);
            id = Guid.Parse("{76F3DD9E-AD79-4F68-9495-583D5ABAAA1A}");
            Course course2 = new Course()
            {
                 Code = "code5",
                 Subject = "English"

             };
            uni1.Courses.Add(course2);
            GrdCourse.AutoGenerateColumns = false;
            GrdCourse.DataSource = uni1.Courses;
        }
        private void PopulateGrades()
        {
            
            uni1.Grades = new List<Grade>();
            Guid id = Guid.Parse("{EBFC3580-0475-42F0-AA76-1D30E740FC3D}");
            Grade grade1 = new Grade()
            {
                Id = id,
                StudentId = Guid.Parse("{FC57578B-C226-4F95-9DB3-55E2395F9AC8}"),
                CourseId = Guid.Parse("{A9FED9F2-C650-46E1-BD9E-C0B89E97074C}"),
                Grades = 4
            };
            uni1.Grades.Add(grade1);
            id = Guid.Parse("{D9776111-6E52-4D61-B5E1-DB71952CFBC5}");
            Grade grade2 = new Grade()
            {
                Id = id,
                StudentId = Guid.Parse("{C6D6AD3F-D928-40F0-A059-FEDBE08F1A8E}"),
                CourseId = Guid.Parse("{CE97A16C-9042-4CCD-A35C-D339F76261CF}"),
                Grades = 7

            };
            uni1.Grades.Add(grade2);
            GrdGrade.AutoGenerateColumns = false;
            GrdGrade.DataSource = uni1.Grades;
        }
        private void PopulateSchedules()
        {

            uni1.Schedules = new List<Schedule>();
            Guid id = Guid.Parse("{832D991A-D812-4A22-BF80-9E14FC23002B}");
            Schedule schedule1 = new Schedule()
            {
                Id = id,
                CourseId = Guid.Parse("{B65DB63E-484B-4427-BD4E-2BE475970900}"),
                ProfessorId = Guid.Parse("{088668F9-4F5C-4A95-A1FC-69AEC042018C}"),
                Callendar = DateTime.Now

            };
            uni1.Schedules.Add(schedule1);
            id = Guid.Parse("{8336A9B2-A263-4C69-8FC5-76FB37CF05D2}");
            Schedule schedules2 = new Schedule()
            {
                Id = id,
                CourseId = Guid.Parse("{C194499A-C835-4A03-A3E1-4395956A55B9}"),
                ProfessorId = Guid.Parse("{88A21A07-2C5C-4F03-86AC-4EEDB87B983A}"),
                Callendar = DateTime.Now

            };
            uni1.Schedules.Add(schedules2);
            GrdSchedule.AutoGenerateColumns = false;
            GrdSchedule.DataSource = uni1.Schedules;
        }

        private void Students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            PopulateStudents();
            PopulateCourses();
            PopulateGrades();
            PopulateSchedules();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            uni1 = serializer.Deserialize<University>("test.json");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(uni1, "university.json");
        }
    }
}