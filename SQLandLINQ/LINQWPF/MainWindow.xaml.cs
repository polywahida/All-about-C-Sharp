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
            SHowAllStudentFromTuDarmstadt();
        }
        public void SHowAllStudentFromTuDarmstadt()
        {
            var studentFromTudarmstadt = from student in dataContext.Students
                                         where student.University.Name == "Tu Darmstadt"
                                         select student;
            MyData.ItemsSource = studentFromTudarmstadt;
        }
    }
}
