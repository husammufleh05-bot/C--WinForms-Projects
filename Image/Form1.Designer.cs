namespace Image
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnOpenImage = new System.Windows.Forms.Button();
            this.bnSaveImage = new System.Windows.Forms.Button();
            this.bnClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 237);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(114, 313);
            this.tbFile.Multiline = true;
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(501, 52);
            this.tbFile.TabIndex = 1;
            this.tbFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "File:";
            // 
            // bnOpenImage
            // 
            this.bnOpenImage.BackColor = System.Drawing.Color.Blue;
            this.bnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnOpenImage.ForeColor = System.Drawing.Color.White;
            this.bnOpenImage.Location = new System.Drawing.Point(104, 385);
            this.bnOpenImage.Name = "bnOpenImage";
            this.bnOpenImage.Size = new System.Drawing.Size(127, 40);
            this.bnOpenImage.TabIndex = 3;
            this.bnOpenImage.Text = "Open Image";
            this.bnOpenImage.UseVisualStyleBackColor = false;
            this.bnOpenImage.Click += new System.EventHandler(this.bnOpenImage_Click);
            // 
            // bnSaveImage
            // 
            this.bnSaveImage.BackColor = System.Drawing.Color.Blue;
            this.bnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnSaveImage.ForeColor = System.Drawing.Color.White;
            this.bnSaveImage.Location = new System.Drawing.Point(318, 385);
            this.bnSaveImage.Name = "bnSaveImage";
            this.bnSaveImage.Size = new System.Drawing.Size(127, 40);
            this.bnSaveImage.TabIndex = 4;
            this.bnSaveImage.Text = "Save Image";
            this.bnSaveImage.UseVisualStyleBackColor = false;
            this.bnSaveImage.Click += new System.EventHandler(this.bnSaveImage_Click);
            // 
            // bnClear
            // 
            this.bnClear.BackColor = System.Drawing.Color.Blue;
            this.bnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClear.ForeColor = System.Drawing.Color.White;
            this.bnClear.Location = new System.Drawing.Point(510, 385);
            this.bnClear.Name = "bnClear";
            this.bnClear.Size = new System.Drawing.Size(127, 40);
            this.bnClear.TabIndex = 5;
            this.bnClear.Text = "Clear";
            this.bnClear.UseVisualStyleBackColor = false;
            this.bnClear.Click += new System.EventHandler(this.bnClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnClear);
            this.Controls.Add(this.bnSaveImage);
            this.Controls.Add(this.bnOpenImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnOpenImage;
        private System.Windows.Forms.Button bnSaveImage;
        private System.Windows.Forms.Button bnClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

