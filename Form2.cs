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
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
            lstStudents.DataSource = null;
            lstStudents.DataSource = FormStudents.students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
