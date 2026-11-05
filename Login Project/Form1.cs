using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe == true)
            {
                tbUserName.Text = Properties.Settings.Default.saveduserName;
                tbPassword.Text = Properties.Settings.Default.savedPassword;
                cbRemeberMe.Checked = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }else
            {
                tbPassword.PasswordChar = '*';
            }
            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Warninig !!! please enter username and password ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

            if (tbUserName.Text == "admin" && tbPassword.Text == "123456")
            {
                if (cbRemeberMe.Checked)
                {
                    Properties.Settings.Default.saveduserName = tbUserName.Text;
                    Properties.Settings.Default.savedPassword= tbPassword.Text;
                    Properties.Settings.Default.RememberMe = true; 
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.saveduserName = "";
                    Properties.Settings.Default.savedPassword = "";
                    Properties.Settings.Default.RememberMe = false;
                    Properties.Settings.Default.Save();
                }
                MessageBox.Show("login is corrected", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
