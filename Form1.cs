using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_10._5_Assingment
{
    public partial class formMain : Form
    {public static List<Student> students = new List<Student>();
        
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add(new Student("Jonah", "Birch"));
            students.Add(new Student("Payton", "Callahan"));
            students.Add(new Student("Jackson (Cowie)", "Cowan"));
            students.Add(new Student("Andrew", "Dolbear"));
            students.Add(new Student("Jacob", "Byers"));
            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            FormAddingNames frmAddName = new FormAddingNames();
            frmAddName.ShowDialog();
            
            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                FormStudentInfo frmAddName = new FormStudentInfo(lstStudents.SelectedIndex);
                frmAddName.ShowDialog();
            
                lstStudents.DataSource = null;
                lstStudents.DataSource = students;
            }
            
            
            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            students.Sort();
            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            FormEditStudent frmEditStudent = new FormEditStudent(lstStudents.SelectedIndex);
            frmEditStudent.ShowDialog();

            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            { 
                students.RemoveAt(lstStudents.SelectedIndex);
                lstStudents.DataSource = null;
                lstStudents.DataSource = students;

            }
            
        }
    }
}
