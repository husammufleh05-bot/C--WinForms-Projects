using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Medical_appointment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionStart;
        }

        private void CBTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // تعبئة الساعات
            for (int i = 8; i <= 16; i++)
            {
                string time;
                if (i < 12)
                {
                    time = i + ":00 AM";
                }
                else if (i == 12)
                {
                    time = "12:00 PM";
                }
                else
                {
                    time = (i - 12) + ":00 PM";
                }

                CBTime.Items.Add(time);
            }

            // تحديد أول عنصر بشكل افتراضي (اختياري)
            if (CBTime.Items.Count > 0)
            {
                CBTime.SelectedIndex = 0;
            }

            CBDoctor.Items.Add("Dr Ahmad ");
            CBDoctor.Items.Add("Dr Khaled ");
            CBDoctor.Items.Add("Dr Mustafa ");

            if (CBDoctor.Items.Count > 0)
                CBDoctor.SelectedIndex = 0;


        }

        private void btBookAppointment_Click(object sender, EventArgs e)
        {
            string PatientName = tbPatientName.Text;
            if(string.IsNullOrEmpty(PatientName))
            {
                MessageBox.Show("Warning", "Please Enter Patient Name");
                return;
            }
            string Doctor=CBDoctor.Text;

            string Date = dateTimePicker1.Text;
            string Type = rbCheckUP.Checked ? "Checked Up" : "Follow Up";


            string Summary = $"Appointment Successful\n" +
                            $"Patient Name {PatientName}\n" +
                            $"Doctor       {Doctor}\n" +
                            $"Date           {Date}\n" +
                            $"Type           {Type} ";

            MessageBox.Show(Summary,"Appontment Details");

        }
    }
}
