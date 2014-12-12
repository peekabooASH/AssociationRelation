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
    public partial class CourseEntryUI : Form
    {
        private List<Course> courses;
      
       public CourseEntryUI(List<Course> courses)
        {
            InitializeComponent();
            this.courses = courses;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Course aCourse = new Course(codeTextBox.Text, titleTextBox.Text);
            courses.Add(aCourse);
        }
    }
}
