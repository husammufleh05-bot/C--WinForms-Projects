namespace Calculator
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
            this.bnPlus = new System.Windows.Forms.Button();
            this.bnMultiple = new System.Windows.Forms.Button();
            this.bnMius = new System.Windows.Forms.Button();
            this.bnquarter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bnPlus
            // 
            this.bnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnPlus.Location = new System.Drawing.Point(29, 241);
            this.bnPlus.Name = "bnPlus";
            this.bnPlus.Size = new System.Drawing.Size(143, 65);
            this.bnPlus.TabIndex = 4;
            this.bnPlus.Text = "+";
            this.bnPlus.UseVisualStyleBackColor = false;
            this.bnPlus.Click += new System.EventHandler(this.bnPlus_Click);
            // 
            // bnMultiple
            // 
            this.bnMultiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMultiple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnMultiple.Location = new System.Drawing.Point(441, 241);
            this.bnMultiple.Name = "bnMultiple";
            this.bnMultiple.Size = new System.Drawing.Size(143, 65);
            this.bnMultiple.TabIndex = 5;
            this.bnMultiple.Text = "*";
            this.bnMultiple.UseVisualStyleBackColor = false;
            this.bnMultiple.Click += new System.EventHandler(this.bnMultiple_Click);
            // 
            // bnMius
            // 
            this.bnMius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnMius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnMius.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnMius.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnMius.Location = new System.Drawing.Point(242, 241);
            this.bnMius.Name = "bnMius";
            this.bnMius.Size = new System.Drawing.Size(143, 65);
            this.bnMius.TabIndex = 6;
            this.bnMius.Text = "-";
            this.bnMius.UseVisualStyleBackColor = false;
            this.bnMius.Click += new System.EventHandler(this.button5_Click);
            // 
            // bnquarter
            // 
            this.bnquarter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bnquarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnquarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnquarter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnquarter.Location = new System.Drawing.Point(633, 241);
            this.bnquarter.Name = "bnquarter";
            this.bnquarter.Size = new System.Drawing.Size(143, 65);
            this.bnquarter.TabIndex = 7;
            this.bnquarter.Text = "%";
            this.bnquarter.UseVisualStyleBackColor = false;
            this.bnquarter.Click += new System.EventHandler(this.bnquarter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number 2:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(95, 63);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(152, 32);
            this.lb.TabIndex = 9;
            this.lb.Text = "Number 1: ";
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(303, 73);
            this.tbNumber1.Multiline = true;
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(205, 31);
            this.tbNumber1.TabIndex = 10;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(303, 136);
            this.tbNumber2.Multiline = true;
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(205, 32);
            this.tbNumber2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Result:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(303, 353);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(205, 32);
            this.tbResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnquarter);
            this.Controls.Add(this.bnMius);
            this.Controls.Add(this.bnMultiple);
            this.Controls.Add(this.bnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnPlus;
        private System.Windows.Forms.Button bnMultiple;
        private System.Windows.Forms.Button bnMius;
        private System.Windows.Forms.Button bnquarter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResult;
    }
}

