namespace EGECalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.subject = new System.Windows.Forms.ComboBox();
            this.firstpoint = new System.Windows.Forms.ComboBox();
            this.min = new System.Windows.Forms.Label();
            this.testpoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testpointlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reservedate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.years = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.max = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // subject
            // 
            this.subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subject.FormattingEnabled = true;
            this.subject.Location = new System.Drawing.Point(144, 52);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(130, 21);
            this.subject.TabIndex = 0;
            this.subject.SelectedValueChanged += new System.EventHandler(this.subject_SelectedValueChanged);
            // 
            // firstpoint
            // 
            this.firstpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstpoint.FormattingEnabled = true;
            this.firstpoint.Location = new System.Drawing.Point(144, 81);
            this.firstpoint.Name = "firstpoint";
            this.firstpoint.Size = new System.Drawing.Size(130, 21);
            this.firstpoint.TabIndex = 1;
            this.firstpoint.SelectedValueChanged += new System.EventHandler(this.firstpoint_SelectedValueChanged);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(141, 27);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(13, 13);
            this.min.TabIndex = 2;
            this.min.Text = "0";
            // 
            // testpoint
            // 
            this.testpoint.AutoSize = true;
            this.testpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testpoint.Location = new System.Drawing.Point(141, 82);
            this.testpoint.Name = "testpoint";
            this.testpoint.Size = new System.Drawing.Size(14, 13);
            this.testpoint.TabIndex = 3;
            this.testpoint.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Минимум:";
            // 
            // testpointlbl
            // 
            this.testpointlbl.AutoSize = true;
            this.testpointlbl.Location = new System.Drawing.Point(22, 82);
            this.testpointlbl.Name = "testpointlbl";
            this.testpointlbl.Size = new System.Drawing.Size(87, 13);
            this.testpointlbl.TabIndex = 5;
            this.testpointlbl.Text = "Тестовый балл:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Предмет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Первичный балл:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата сдачи:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(141, 27);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(13, 13);
            this.date.TabIndex = 9;
            this.date.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Резерв:";
            // 
            // reservedate
            // 
            this.reservedate.AutoSize = true;
            this.reservedate.Location = new System.Drawing.Point(141, 56);
            this.reservedate.Name = "reservedate";
            this.reservedate.Size = new System.Drawing.Size(13, 13);
            this.reservedate.TabIndex = 11;
            this.reservedate.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.years);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.subject);
            this.groupBox1.Controls.Add(this.firstpoint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 117);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Предмет";
            // 
            // years
            // 
            this.years.BackColor = System.Drawing.SystemColors.Window;
            this.years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.years.FormattingEnabled = true;
            this.years.Items.AddRange(new object[] {
            "2014",
            "2015"});
            this.years.Location = new System.Drawing.Point(144, 22);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(130, 21);
            this.years.TabIndex = 9;
            this.years.SelectedValueChanged += new System.EventHandler(this.years_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Год:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.reservedate);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 117);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(141, 85);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(13, 13);
            this.time.TabIndex = 13;
            this.time.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Время:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.max);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.testpointlbl);
            this.groupBox3.Controls.Add(this.min);
            this.groupBox3.Controls.Add(this.testpoint);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 117);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Баллы";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(141, 53);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(19, 13);
            this.max.TabIndex = 6;
            this.max.Text = "81";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Максимум:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "О программе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Информация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::EGECalculator.Properties.Resources._2016;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 84);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЕГЭ Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox subject;
        private System.Windows.Forms.ComboBox firstpoint;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label testpoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label testpointlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label reservedate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox years;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label9;
    }
}

