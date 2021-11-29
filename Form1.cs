using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_10._5_Student_Forms
{
    public partial class FormStudents : Form
    {
        public static List<Student> students = new List<Student>();

        public FormStudents()
        {
            InitializeComponent();
            students.Add(new Student("Erik", "Jeffery"));
            students.Add(new Student("Sam", "Faseruk"));
            students.Add(new Student("Ellanna", "Wilson"));
            students.Add(new Student("Kenny", "Fournie"));
            students.Add(new Student("Jonah", "Birch"));
            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddStudent frmAddStudent = new FormAddStudent();
            frmAddStudent.ShowDialog();
            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
        }
    }
}
