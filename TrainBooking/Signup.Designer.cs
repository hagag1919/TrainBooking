namespace TrainBooking
{
    partial class Signup
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Admin_chose = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phoneNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(224, 166);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 16);
            label3.TabIndex = 12;
            label3.Text = "Full Name";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(224, 209);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 16);
            label2.TabIndex = 17;
            label2.Text = "Email";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(363, 343);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 20);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Passenger";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Admin_chose
            // 
            this.Admin_chose.AutoSize = true;
            this.Admin_chose.Location = new System.Drawing.Point(487, 343);
            this.Admin_chose.Name = "Admin_chose";
            this.Admin_chose.Size = new System.Drawing.Size(66, 20);
            this.Admin_chose.TabIndex = 14;
            this.Admin_chose.TabStop = true;
            this.Admin_chose.Text = "Admin";
            this.Admin_chose.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(363, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(363, 257);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(190, 22);
            this.txt_pass.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(363, 163);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(190, 22);
            this.txt_name.TabIndex = 10;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(224, 257);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 16);
            this.password.TabIndex = 9;
            this.password.Text = "Password";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.888F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 68);
            this.label1.TabIndex = 8;
            this.label1.Text = "                      Signing up\r\n";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(363, 209);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(190, 22);
            this.txt_email.TabIndex = 16;
            // 
            // txt_phoneNum
            // 
            this.txt_phoneNum.Location = new System.Drawing.Point(363, 304);
            this.txt_phoneNum.Name = "txt_phoneNum";
            this.txt_phoneNum.Size = new System.Drawing.Size(190, 22);
            this.txt_phoneNum.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(224, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone number";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(713, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 63;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_phoneNum);
            this.Controls.Add(label2);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Admin_chose);
            this.Controls.Add(this.button1);
            this.Controls.Add(label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Sign up Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton Admin_chose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txt_email;
    }
}