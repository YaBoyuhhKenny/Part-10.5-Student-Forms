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
    public partial class FormStudentDetails : Form
    {
        int index;
        public FormStudentDetails(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void FormStudentDetails_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"You have slelected info on: + {FormStudents.students[FormStudents.index]}.";
            lblName.Text = $"Name: {FormStudents.students[FormStudents.index]}";
            lblNumber.Text = $"Number: {FormStudents.students[FormStudents.index].StudentNumber}";
            lblEmail.Text = $"Email: {FormStudents.students[FormStudents.index].Email}";
        }
    }
}
