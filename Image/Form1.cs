using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png|Text Files|*.txt|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFile.Text = openFileDialog1.FileName;

                using (var bmpTemp = new Bitmap(openFileDialog1.FileName))
                {
                    pictureBox1.Image = new Bitmap(bmpTemp);
                }
            }

        }

        private void bnSaveImage_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image==null)
            {
                MessageBox.Show("No picture To Save it ", "No picture", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
            saveFileDialog1.Title = "save picture as name ::";
            saveFileDialog1.FileName = "MY_IMAGE";

            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try 
                {
                    string extintion= System.IO.Path.GetExtension(saveFileDialog1.FileName).ToLower();
                    // 2. حفظ الصورة بالصيغة الصحيحة بناءً على اختيار المستخدم
                    if (extintion == ".png")
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else if (extintion == ".bmp")
                    {
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    else
                    {
                        // الصيغة الافتراضية إذا لم يحدد هي JPEG
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }

                    // 3. رسالة تأكيد النجاح
                    MessageBox.Show("تم حفظ الصورة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error in save file" + ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void bnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            tbFile.Text = null;
        }
    }
}
