namespace Login_Project
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRemeberMe = new System.Windows.Forms.CheckBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btClear = new System.Windows.Forms.Button();
            this.bnLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(289, 90);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '*';
            this.tbUserName.Size = new System.Drawing.Size(279, 42);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.UseSystemPasswordChar = true;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(289, 187);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(279, 42);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRemeberMe);
            this.groupBox1.Controls.Add(this.cbShowPassword);
            this.groupBox1.Location = new System.Drawing.Point(90, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cbRemeberMe
            // 
            this.cbRemeberMe.AutoSize = true;
            this.cbRemeberMe.Location = new System.Drawing.Point(39, 116);
            this.cbRemeberMe.Name = "cbRemeberMe";
            this.cbRemeberMe.Size = new System.Drawing.Size(148, 26);
            this.cbRemeberMe.TabIndex = 1;
            this.cbRemeberMe.Text = "Remember me";
            this.cbRemeberMe.UseVisualStyleBackColor = true;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(39, 50);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(161, 26);
            this.cbShowPassword.TabIndex = 0;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Location = new System.Drawing.Point(431, 515);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(150, 53);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            // 
            // bnLogin
            // 
            this.bnLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnLogin.Location = new System.Drawing.Point(160, 515);
            this.bnLogin.Name = "bnLogin";
            this.bnLogin.Size = new System.Drawing.Size(150, 53);
            this.bnLogin.TabIndex = 7;
            this.bnLogin.Text = "Login";
            this.bnLogin.UseVisualStyleBackColor = false;
            this.bnLogin.Click += new System.EventHandler(this.bnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 611);
            this.Controls.Add(this.bnLogin);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRemeberMe;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button bnLogin;
    }
}

