namespace TrainBooking
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.admin_chose = new System.Windows.Forms.RadioButton();
            this.passenger_chose = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(202, 171);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 16);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.888F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "                      Welcome";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(202, 262);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 16);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(341, 168);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(190, 22);
            this.txt_email.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(341, 262);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(190, 22);
            this.txt_pass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(326, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin_chose
            // 
            this.admin_chose.AutoSize = true;
            this.admin_chose.Location = new System.Drawing.Point(465, 318);
            this.admin_chose.Name = "admin_chose";
            this.admin_chose.Size = new System.Drawing.Size(66, 20);
            this.admin_chose.TabIndex = 6;
            this.admin_chose.TabStop = true;
            this.admin_chose.Text = "Admin";
            this.admin_chose.UseVisualStyleBackColor = true;
            // 
            // passenger_chose
            // 
            this.passenger_chose.AutoSize = true;
            this.passenger_chose.Location = new System.Drawing.Point(341, 318);
            this.passenger_chose.Name = "passenger_chose";
            this.passenger_chose.Size = new System.Drawing.Size(94, 20);
            this.passenger_chose.TabIndex = 7;
            this.passenger_chose.TabStop = true;
            this.passenger_chose.Text = "Passenger";
            this.passenger_chose.UseVisualStyleBackColor = true;
            this.passenger_chose.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Are you a new user?";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(462, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start here.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passenger_chose);
            this.Controls.Add(this.admin_chose);
            this.Controls.Add(this.button1);
            this.Controls.Add(label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton admin_chose;
        private System.Windows.Forms.RadioButton passenger_chose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

