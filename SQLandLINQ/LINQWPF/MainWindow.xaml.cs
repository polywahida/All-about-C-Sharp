using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LINQWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentLINQDataContext dataContext;
        public MainWindow()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LINQWPF.Properties.Settings.StudentsInventoryConnectionString"].ConnectionString;
            dataContext = new StudentLINQDataContext(connectionString);
            InitializeComponent();
            //ShowAllStudentFromTuDarmstadt();
            //DeleteUniversityData();
            // InsertUniversities();
            //InsertStudents();
            UPdateStudentsName();

        }
        public void DeleteStudentTable()
        {
            dataContext.ExecuteCommand("delete from Students");
            
        }
        public void deleteUniversityData()
        {
            dataContext.ExecuteCommand("delete from University");
        }
        public void SHowAllStudentFromTuDarmstadt()
        {
            var studentFromTudarmstadt = from student in dataContext.Students
                                         where student.University.Name == "Tu Darmstadt"
                                         select MapStudents(student);
            var studentFromYale = dataContext.Students
                                 .Where(x => x.University.Name == "Yale")
                                 .Select(x => MapStudents(x));
            MyData.ItemsSource = studentFromTudarmstadt;
        }
        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");
            University UIU = new University();
            
            UIU.Name = "United International University";
            University IUB = new University();
            IUB.Name = "Independent University of Bangladesh";
            dataContext.Universities.InsertOnSubmit(UIU);
            dataContext.Universities.InsertOnSubmit(IUB);
            dataContext.SubmitChanges();
        }
        public void InsertStudents()
        {
            University UIU = dataContext.Universities.First(x => x.UnivarsityName.Equals("United International University"));
            University IUB = dataContext.Universities.First(x => x.UnivarsityName.Equals("Independent University of Bd"));

            List<Student> students = new List<Student>();
            students.Add (new Student { Name_ = "Rajit", Gender = "Male", UniversityId = IUB.Id });
            students.Add(new Student { Name_ = "Adil", Gender = "Male", UniversityId =UIU.Id });
            students.Add(new Student { Name_ = "Moinul", Gender = "Male", UniversityId = UIU.Id });
            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges ();
            MyData.ItemsSource = dataContext.Students;
        }
        public void UPdateStudentsName()
        {
            Student adil = dataContext.Students.FirstOrDefault(x => x.Name == "Adil");
            adil.Name_ = "Shojib";
            dataContext.SubmitChanges();
            MyData.ItemsSource = dataContext.Students;

        }

        private object MapStudents(Student student)
        {
            if (student == null)
            {
                return new Student();
            }
            return new
            {
                StudentName = student.Name,
                StudentUniversity = student.University.UnivarsityName,
                Gender = student.Gender
                StudentLecture = string.Join(",", student.StudentLectures.Select(x => x.Lecture.Name)),
            };
        }
       
    }
    
}

