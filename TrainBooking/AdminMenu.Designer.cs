namespace TrainBooking
{
    partial class AdminMenu
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
            this.button2 = new System.Windows.Forms.Button();
            this.Update_train = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Up_trainID = new System.Windows.Forms.TextBox();
            this.txt_new_trainName = new System.Windows.Forms.TextBox();
            this.txt_new_seatsNo = new System.Windows.Forms.TextBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.add_train = new System.Windows.Forms.Button();
            this.txt_seatsNo = new System.Windows.Forms.TextBox();
            this.txt_trainName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tripNo = new System.Windows.Forms.TextBox();
            this.txt_tripDate = new System.Windows.Forms.TextBox();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.txt_tripTime = new System.Windows.Forms.TextBox();
            this.txt_sourse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_new_sourse = new System.Windows.Forms.TextBox();
            this.txt_new_tripTime = new System.Windows.Forms.TextBox();
            this.txt_new_destination = new System.Windows.Forms.TextBox();
            this.txt_new_tripDate = new System.Windows.Forms.TextBox();
            this.txt_Up_tripNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_trianIDdelet = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txt_tripNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 68);
            this.label1.TabIndex = 21;
            this.label1.Text = "                 System control screen\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(470, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 38);
            this.button2.TabIndex = 23;
            this.button2.Text = "Add Trip";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Update_train
            // 
            this.Update_train.BackColor = System.Drawing.Color.Bisque;
            this.Update_train.Location = new System.Drawing.Point(876, 512);
            this.Update_train.Name = "Update_train";
            this.Update_train.Size = new System.Drawing.Size(105, 38);
            this.Update_train.TabIndex = 24;
            this.Update_train.Text = "Update Train";
            this.Update_train.UseVisualStyleBackColor = false;
            this.Update_train.Click += new System.EventHandler(this.Update_train_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Location = new System.Drawing.Point(191, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 38);
            this.button4.TabIndex = 25;
            this.button4.Text = "Update Trip";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(996, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 45);
            this.label2.TabIndex = 26;
            this.label2.Text = "Train Section";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.128F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(70, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 45);
            this.label3.TabIndex = 27;
            this.label3.Text = "Trip Section";
            // 
            // txt_Up_trainID
            // 
            this.txt_Up_trainID.Location = new System.Drawing.Point(854, 340);
            this.txt_Up_trainID.Name = "txt_Up_trainID";
            this.txt_Up_trainID.Size = new System.Drawing.Size(150, 22);
            this.txt_Up_trainID.TabIndex = 31;
            // 
            // txt_new_trainName
            // 
            this.txt_new_trainName.Location = new System.Drawing.Point(854, 404);
            this.txt_new_trainName.Name = "txt_new_trainName";
            this.txt_new_trainName.Size = new System.Drawing.Size(150, 22);
            this.txt_new_trainName.TabIndex = 33;
            // 
            // txt_new_seatsNo
            // 
            this.txt_new_seatsNo.Location = new System.Drawing.Point(854, 455);
            this.txt_new_seatsNo.Name = "txt_new_seatsNo";
            this.txt_new_seatsNo.Size = new System.Drawing.Size(150, 22);
            this.txt_new_seatsNo.TabIndex = 34;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(352, 334);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(50, 16);
            this.lab2.TabIndex = 36;
            this.lab2.Text = "Source";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Destination";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Train ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(703, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "New Train Name ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(703, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "New Number of seats";
            // 
            // add_train
            // 
            this.add_train.BackColor = System.Drawing.Color.Bisque;
            this.add_train.Location = new System.Drawing.Point(1172, 512);
            this.add_train.Name = "add_train";
            this.add_train.Size = new System.Drawing.Size(105, 38);
            this.add_train.TabIndex = 22;
            this.add_train.Text = "Add Train";
            this.add_train.UseVisualStyleBackColor = false;
            this.add_train.Click += new System.EventHandler(this.add_train_Click);
            // 
            // txt_seatsNo
            // 
            this.txt_seatsNo.Location = new System.Drawing.Point(1145, 443);
            this.txt_seatsNo.Name = "txt_seatsNo";
            this.txt_seatsNo.Size = new System.Drawing.Size(150, 22);
            this.txt_seatsNo.TabIndex = 29;
            // 
            // txt_trainName
            // 
            this.txt_trainName.Location = new System.Drawing.Point(1145, 340);
            this.txt_trainName.Name = "txt_trainName";
            this.txt_trainName.Size = new System.Drawing.Size(150, 22);
            this.txt_trainName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1031, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Train Name ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1031, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Number of seats";
            // 
            // txt_tripNo
            // 
            this.txt_tripNo.Location = new System.Drawing.Point(452, 278);
            this.txt_tripNo.Name = "txt_tripNo";
            this.txt_tripNo.Size = new System.Drawing.Size(150, 22);
            this.txt_tripNo.TabIndex = 44;
            // 
            // txt_tripDate
            // 
            this.txt_tripDate.Location = new System.Drawing.Point(452, 487);
            this.txt_tripDate.Name = "txt_tripDate";
            this.txt_tripDate.Size = new System.Drawing.Size(150, 22);
            this.txt_tripDate.TabIndex = 45;
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(452, 384);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.Size = new System.Drawing.Size(150, 22);
            this.txt_destination.TabIndex = 46;
            // 
            // txt_tripTime
            // 
            this.txt_tripTime.Location = new System.Drawing.Point(452, 438);
            this.txt_tripTime.Name = "txt_tripTime";
            this.txt_tripTime.Size = new System.Drawing.Size(150, 22);
            this.txt_tripTime.TabIndex = 47;
            // 
            // txt_sourse
            // 
            this.txt_sourse.Location = new System.Drawing.Point(452, 326);
            this.txt_sourse.Name = "txt_sourse";
            this.txt_sourse.Size = new System.Drawing.Size(150, 22);
            this.txt_sourse.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(352, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "Trip Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "Trip Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 395);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "New Destination";
            // 
            // txt_new_sourse
            // 
            this.txt_new_sourse.Location = new System.Drawing.Point(160, 328);
            this.txt_new_sourse.Name = "txt_new_sourse";
            this.txt_new_sourse.Size = new System.Drawing.Size(150, 22);
            this.txt_new_sourse.TabIndex = 56;
            // 
            // txt_new_tripTime
            // 
            this.txt_new_tripTime.Location = new System.Drawing.Point(160, 438);
            this.txt_new_tripTime.Name = "txt_new_tripTime";
            this.txt_new_tripTime.Size = new System.Drawing.Size(150, 22);
            this.txt_new_tripTime.TabIndex = 55;
            // 
            // txt_new_destination
            // 
            this.txt_new_destination.Location = new System.Drawing.Point(160, 384);
            this.txt_new_destination.Name = "txt_new_destination";
            this.txt_new_destination.Size = new System.Drawing.Size(150, 22);
            this.txt_new_destination.TabIndex = 54;
            // 
            // txt_new_tripDate
            // 
            this.txt_new_tripDate.Location = new System.Drawing.Point(160, 487);
            this.txt_new_tripDate.Name = "txt_new_tripDate";
            this.txt_new_tripDate.Size = new System.Drawing.Size(150, 22);
            this.txt_new_tripDate.TabIndex = 53;
            // 
            // txt_Up_tripNo
            // 
            this.txt_Up_tripNo.Location = new System.Drawing.Point(160, 278);
            this.txt_Up_tripNo.Name = "txt_Up_tripNo";
            this.txt_Up_tripNo.Size = new System.Drawing.Size(150, 22);
            this.txt_Up_tripNo.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 16);
            this.label16.TabIndex = 57;
            this.label16.Text = "Trip Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 501);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 16);
            this.label17.TabIndex = 58;
            this.label17.Text = "New Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 337);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 16);
            this.label18.TabIndex = 59;
            this.label18.Text = "New Sourse";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 452);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 16);
            this.label19.TabIndex = 60;
            this.label19.Text = "New Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 61;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1231, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 62;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 185);
            this.dataGridView1.TabIndex = 63;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Bisque;
            this.button5.Location = new System.Drawing.Point(1002, 576);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 26);
            this.button5.TabIndex = 64;
            this.button5.Text = "Show Trains details";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Linen;
            this.button6.Location = new System.Drawing.Point(299, 576);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 26);
            this.button6.TabIndex = 65;
            this.button6.Text = "Show Trip details";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1010, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Train ID";
            // 
            // txt_trianIDdelet
            // 
            this.txt_trianIDdelet.Location = new System.Drawing.Point(1098, 135);
            this.txt_trianIDdelet.Name = "txt_trianIDdelet";
            this.txt_trianIDdelet.Size = new System.Drawing.Size(150, 22);
            this.txt_trianIDdelet.TabIndex = 66;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Bisque;
            this.button7.Location = new System.Drawing.Point(1054, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 38);
            this.button7.TabIndex = 68;
            this.button7.Text = "Delete Train";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Linen;
            this.button8.Location = new System.Drawing.Point(101, 190);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 38);
            this.button8.TabIndex = 69;
            this.button8.Text = "Delete Trip";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txt_tripNumber
            // 
            this.txt_tripNumber.Location = new System.Drawing.Point(125, 138);
            this.txt_tripNumber.Name = "txt_tripNumber";
            this.txt_tripNumber.Size = new System.Drawing.Size(150, 22);
            this.txt_tripNumber.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Train ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(42, 284);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 16);
            this.label20.TabIndex = 73;
            this.label20.Text = "Train ID";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 616);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tripNumber);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_trianIDdelet);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_new_sourse);
            this.Controls.Add(this.txt_new_tripTime);
            this.Controls.Add(this.txt_new_destination);
            this.Controls.Add(this.txt_new_tripDate);
            this.Controls.Add(this.txt_Up_tripNo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_sourse);
            this.Controls.Add(this.txt_tripTime);
            this.Controls.Add(this.txt_destination);
            this.Controls.Add(this.txt_tripDate);
            this.Controls.Add(this.txt_tripNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_new_seatsNo);
            this.Controls.Add(this.txt_new_trainName);
            this.Controls.Add(this.txt_trainName);
            this.Controls.Add(this.txt_Up_trainID);
            this.Controls.Add(this.txt_seatsNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Update_train);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_train);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Update_train;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Up_trainID;
        private System.Windows.Forms.TextBox txt_new_trainName;
        private System.Windows.Forms.TextBox txt_new_seatsNo;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button add_train;
        private System.Windows.Forms.TextBox txt_seatsNo;
        private System.Windows.Forms.TextBox txt_trainName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tripNo;
        private System.Windows.Forms.TextBox txt_tripDate;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.TextBox txt_tripTime;
        private System.Windows.Forms.TextBox txt_sourse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_new_sourse;
        private System.Windows.Forms.TextBox txt_new_tripTime;
        private System.Windows.Forms.TextBox txt_new_destination;
        private System.Windows.Forms.TextBox txt_new_tripDate;
        private System.Windows.Forms.TextBox txt_Up_tripNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_trianIDdelet;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txt_tripNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
    }
}