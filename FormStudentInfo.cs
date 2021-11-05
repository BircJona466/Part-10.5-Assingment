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
    public partial class FormStudentInfo : Form
    {
        int index;
        
        public FormStudentInfo(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {
            lblStudentName.Text = (formMain.students[index] + "");
            Student selection = formMain.students[index];
            lblStudentEmail.Text = selection.Email;
            lblStudentNum.Text = Convert.ToString(selection.StudentNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void lblStudentEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentEmail_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
