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
    public partial class FormEditStudent : Form
    {
        public FormEditStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudents.students.RemoveAt(lstStudents.SelectedIndex);
            if (txtFirst.Text.Trim() != "" && txtLast.Text.Trim() != "")
            {
                FormStudents.students.Insert(lstStudents.SelectedIndex,new Student(txtFirst.Text, txtLast.Text));
                txtFirst.Text = "";
                txtLast.Text = "";
                lstStudents.DataSource = null;
                lstStudents.DataSource = FormStudents.students;
            }
        }
    }
}
