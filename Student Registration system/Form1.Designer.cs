namespace Student_Registration_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.CBSubject = new System.Windows.Forms.ComboBox();
            this.NUDAge = new System.Windows.Forms.NumericUpDown();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.bnRegister = new System.Windows.Forms.Button();
            this.bnClear = new System.Windows.Forms.Button();
            this.gbSkils = new System.Windows.Forms.GroupBox();
            this.CBCSharb = new System.Windows.Forms.CheckBox();
            this.cbSQL = new System.Windows.Forms.CheckBox();
            this.CBPython = new System.Windows.Forms.CheckBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAge)).BeginInit();
            this.gbSkils.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departments";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(187, 31);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(366, 37);
            this.tbName.TabIndex = 4;
            // 
            // CBSubject
            // 
            this.CBSubject.FormattingEnabled = true;
            this.CBSubject.Items.AddRange(new object[] {
            "Computer Science",
            "Software engineering",
            "Business Information Technology",
            "Computer Information System ",
            "Cyber Security",
            ""});
            this.CBSubject.Location = new System.Drawing.Point(235, 284);
            this.CBSubject.Name = "CBSubject";
            this.CBSubject.Size = new System.Drawing.Size(297, 28);
            this.CBSubject.TabIndex = 5;
            // 
            // NUDAge
            // 
            this.NUDAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAge.Location = new System.Drawing.Point(187, 115);
            this.NUDAge.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NUDAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NUDAge.Name = "NUDAge";
            this.NUDAge.Size = new System.Drawing.Size(183, 38);
            this.NUDAge.TabIndex = 6;
            this.NUDAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NUDAge.ValueChanged += new System.EventHandler(this.NUDAge_ValueChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(204, 200);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(368, 200);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "FeMale";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // bnRegister
            // 
            this.bnRegister.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnRegister.Location = new System.Drawing.Point(143, 381);
            this.bnRegister.Name = "bnRegister";
            this.bnRegister.Size = new System.Drawing.Size(246, 45);
            this.bnRegister.TabIndex = 9;
            this.bnRegister.Text = "Register";
            this.bnRegister.UseVisualStyleBackColor = false;
            this.bnRegister.Click += new System.EventHandler(this.bnRegister_Click);
            // 
            // bnClear
            // 
            this.bnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClear.Location = new System.Drawing.Point(470, 381);
            this.bnClear.Name = "bnClear";
            this.bnClear.Size = new System.Drawing.Size(246, 45);
            this.bnClear.TabIndex = 10;
            this.bnClear.Text = "Clear";
            this.bnClear.UseVisualStyleBackColor = true;
            this.bnClear.Click += new System.EventHandler(this.bnClear_Click);
            // 
            // gbSkils
            // 
            this.gbSkils.Controls.Add(this.cbJava);
            this.gbSkils.Controls.Add(this.CBPython);
            this.gbSkils.Controls.Add(this.cbSQL);
            this.gbSkils.Controls.Add(this.CBCSharb);
            this.gbSkils.Location = new System.Drawing.Point(604, 31);
            this.gbSkils.Name = "gbSkils";
            this.gbSkils.Size = new System.Drawing.Size(240, 324);
            this.gbSkils.TabIndex = 11;
            this.gbSkils.TabStop = false;
            this.gbSkils.Text = "Skils";
            // 
            // CBCSharb
            // 
            this.CBCSharb.AutoSize = true;
            this.CBCSharb.Location = new System.Drawing.Point(29, 37);
            this.CBCSharb.Name = "CBCSharb";
            this.CBCSharb.Size = new System.Drawing.Size(52, 24);
            this.CBCSharb.TabIndex = 0;
            this.CBCSharb.Text = "C#";
            this.CBCSharb.UseVisualStyleBackColor = true;
            // 
            // cbSQL
            // 
            this.cbSQL.AutoSize = true;
            this.cbSQL.Location = new System.Drawing.Point(29, 108);
            this.cbSQL.Name = "cbSQL";
            this.cbSQL.Size = new System.Drawing.Size(65, 24);
            this.cbSQL.TabIndex = 1;
            this.cbSQL.Text = "SQL";
            this.cbSQL.UseVisualStyleBackColor = true;
            // 
            // CBPython
            // 
            this.CBPython.AutoSize = true;
            this.CBPython.Location = new System.Drawing.Point(29, 179);
            this.CBPython.Name = "CBPython";
            this.CBPython.Size = new System.Drawing.Size(82, 24);
            this.CBPython.TabIndex = 2;
            this.CBPython.Text = "Python";
            this.CBPython.UseVisualStyleBackColor = true;
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(29, 250);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(66, 24);
            this.cbJava.TabIndex = 3;
            this.cbJava.Text = "Java";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.NUDAge);
            this.Controls.Add(this.gbSkils);
            this.Controls.Add(this.bnClear);
            this.Controls.Add(this.bnRegister);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.CBSubject);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDAge)).EndInit();
            this.gbSkils.ResumeLayout(false);
            this.gbSkils.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox CBSubject;
        private System.Windows.Forms.NumericUpDown NUDAge;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button bnRegister;
        private System.Windows.Forms.Button bnClear;
        private System.Windows.Forms.GroupBox gbSkils;
        private System.Windows.Forms.CheckBox cbJava;
        private System.Windows.Forms.CheckBox CBPython;
        private System.Windows.Forms.CheckBox cbSQL;
        private System.Windows.Forms.CheckBox CBCSharb;
    }
}

