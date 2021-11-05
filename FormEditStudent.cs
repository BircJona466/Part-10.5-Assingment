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
    public partial class FormEditStudent : Form
    {
        int index;

        public FormEditStudent(int index)
        {
            InitializeComponent();
            this.index = index;
            
        }

        public void FormEditStudent_Load(object sender, EventArgs e)
        {
             
            
            lblSelection.Text = (formMain.students[index] + "");
             Student selection = formMain.students[index];
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
             Student selection = formMain.students[index];
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
                    selection.FirstName = txtFirstName.Text;
                    selection.LastName = txtLastName.Text;
                    this.Dispose();
                }
            }

        }
    }
}
