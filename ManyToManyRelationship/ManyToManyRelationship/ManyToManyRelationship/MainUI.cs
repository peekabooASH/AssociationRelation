using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyToManyRelationship
{
    public partial class MainUI : Form
    {
        List<Student> students = new List<Student>();

        List<Course> courses = new List<Course>();
 
        List<Enrollment> enrollments = new List<Enrollment>();

        public MainUI()
        {
            InitializeComponent();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryUI aStudentEntryUI = new StudentEntryUI(students);
            aStudentEntryUI.Show();
        }

        private void courseEntryButton_Click(object sender, EventArgs e)
        {
            CourseEntryUI aCourseEntryUI = new CourseEntryUI(courses);
            aCourseEntryUI.Show();
        }

        private void enrollmentButton_Click(object sender, EventArgs e)
        {
            EnrollmentUI aEnrollmentUI = new EnrollmentUI(students, courses, enrollments);
            aEnrollmentUI.Show();

        }
    }
}
