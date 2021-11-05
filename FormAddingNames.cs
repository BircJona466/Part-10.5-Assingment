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
    public partial class FormAddingNames : Form
    {
        public FormAddingNames()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {

            }
            else
            {
                if (txtLastName.Text == "")
                {

                }
                else
                {
                    formMain.students.Add(new Student(txtFirstName.Text, txtLastName.Text));
                    this.Dispose();
                }

            }
        }

        private void FormAddingNames_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        
    }
}
