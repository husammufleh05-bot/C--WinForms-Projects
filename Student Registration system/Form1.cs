using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NUDAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bnRegister_Click(object sender, EventArgs e)
        {
            string Name;
            Name = tbName.Text;

            int Age = (int)NUDAge.Value;

            string Gender;
            if (rbFemale.Checked)
            {
                Gender = rbFemale.Text;
            }
            else
            {
                Gender = rbMale.Text;
            }

            string Department;
           Department = CBSubject.SelectedItem != null ? CBSubject.SelectedItem.ToString() : "Not Selected";

            string Skills;

            Skills = "";

            if (CBCSharb.Checked)
            {
                Skills += CBCSharb.Text;
            }
            if (cbSQL.Checked)
            {
                Skills += cbSQL.Text;
            }
            if (cbJava.Checked)
            {
                Skills += cbJava.Text;
            }
            if (CBPython.Checked)
            {
                Skills += CBPython.Text;
            }


            string Message = $"Name: {Name}" +
                           $"Age : {Age} " +
                           $"Gender : {Gender}" +
                           $"Department: {Department}" +
                           $"Skills: {Skills}";

            MessageBox.Show(Message, "Students Registration ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void bnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            NUDAge.Value = 18;

            rbMale.Checked=true;
            CBSubject.SelectedItem = null;
            CBCSharb.Checked = false;
            cbJava.Checked = false;
            cbSQL.Checked = false;
            CBPython.Checked = false;


        }
    }
}
