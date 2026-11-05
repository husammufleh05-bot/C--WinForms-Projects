namespace Medical_appointment
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.rbCheckUP = new System.Windows.Forms.RadioButton();
            this.rbFollowUP = new System.Windows.Forms.RadioButton();
            this.CBDoctor = new System.Windows.Forms.ComboBox();
            this.CBTime = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btBookAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(247, 54);
            this.tbPatientName.Multiline = true;
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(254, 46);
            this.tbPatientName.TabIndex = 5;
            // 
            // rbCheckUP
            // 
            this.rbCheckUP.AutoSize = true;
            this.rbCheckUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCheckUP.Location = new System.Drawing.Point(247, 346);
            this.rbCheckUP.Name = "rbCheckUP";
            this.rbCheckUP.Size = new System.Drawing.Size(115, 29);
            this.rbCheckUP.TabIndex = 9;
            this.rbCheckUP.TabStop = true;
            this.rbCheckUP.Text = "CheckUp";
            this.rbCheckUP.UseVisualStyleBackColor = true;
            // 
            // rbFollowUP
            // 
            this.rbFollowUP.AutoSize = true;
            this.rbFollowUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFollowUP.Location = new System.Drawing.Point(392, 346);
            this.rbFollowUP.Name = "rbFollowUP";
            this.rbFollowUP.Size = new System.Drawing.Size(121, 29);
            this.rbFollowUP.TabIndex = 10;
            this.rbFollowUP.TabStop = true;
            this.rbFollowUP.Text = "Follow-Up";
            this.rbFollowUP.UseVisualStyleBackColor = true;
            // 
            // CBDoctor
            // 
            this.CBDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDoctor.FormattingEnabled = true;
            this.CBDoctor.Location = new System.Drawing.Point(247, 130);
            this.CBDoctor.Name = "CBDoctor";
            this.CBDoctor.Size = new System.Drawing.Size(254, 39);
            this.CBDoctor.TabIndex = 11;
            // 
            // CBTime
            // 
            this.CBTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTime.FormattingEnabled = true;
            this.CBTime.Location = new System.Drawing.Point(247, 259);
            this.CBTime.Name = "CBTime";
            this.CBTime.Size = new System.Drawing.Size(254, 39);
            this.CBTime.TabIndex = 12;
            this.CBTime.SelectedIndexChanged += new System.EventHandler(this.CBTime_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 30);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(520, 54);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btBookAppointment
            // 
            this.btBookAppointment.BackColor = System.Drawing.Color.SlateGray;
            this.btBookAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBookAppointment.Location = new System.Drawing.Point(227, 381);
            this.btBookAppointment.Name = "btBookAppointment";
            this.btBookAppointment.Size = new System.Drawing.Size(330, 57);
            this.btBookAppointment.TabIndex = 17;
            this.btBookAppointment.Text = "Book Appointment";
            this.btBookAppointment.UseVisualStyleBackColor = false;
            this.btBookAppointment.Click += new System.EventHandler(this.btBookAppointment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBookAppointment);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CBTime);
            this.Controls.Add(this.CBDoctor);
            this.Controls.Add(this.rbFollowUP);
            this.Controls.Add(this.rbCheckUP);
            this.Controls.Add(this.tbPatientName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.RadioButton rbCheckUP;
        private System.Windows.Forms.RadioButton rbFollowUP;
        private System.Windows.Forms.ComboBox CBDoctor;
        private System.Windows.Forms.ComboBox CBTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btBookAppointment;
    }
}

