namespace T4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.YearLB = new System.Windows.Forms.Label();
            this.MonthLB = new System.Windows.Forms.Label();
            this.DayLB = new System.Windows.Forms.Label();
            this.HourLB = new System.Windows.Forms.Label();
            this.MinuteLB = new System.Windows.Forms.Label();
            this.SecondLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(327, 33);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeBT.Location = new System.Drawing.Point(365, 12);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(98, 33);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // YearLB
            // 
            this.YearLB.AutoSize = true;
            this.YearLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearLB.Location = new System.Drawing.Point(12, 76);
            this.YearLB.Name = "YearLB";
            this.YearLB.Size = new System.Drawing.Size(55, 26);
            this.YearLB.TabIndex = 2;
            this.YearLB.Text = "Years";
            // 
            // MonthLB
            // 
            this.MonthLB.AutoSize = true;
            this.MonthLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthLB.Location = new System.Drawing.Point(12, 115);
            this.MonthLB.Name = "MonthLB";
            this.MonthLB.Size = new System.Drawing.Size(78, 26);
            this.MonthLB.TabIndex = 3;
            this.MonthLB.Text = "Months";
            // 
            // DayLB
            // 
            this.DayLB.AutoSize = true;
            this.DayLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DayLB.Location = new System.Drawing.Point(12, 157);
            this.DayLB.Name = "DayLB";
            this.DayLB.Size = new System.Drawing.Size(53, 26);
            this.DayLB.TabIndex = 4;
            this.DayLB.Text = "Days";
            // 
            // HourLB
            // 
            this.HourLB.AutoSize = true;
            this.HourLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HourLB.Location = new System.Drawing.Point(257, 76);
            this.HourLB.Name = "HourLB";
            this.HourLB.Size = new System.Drawing.Size(62, 26);
            this.HourLB.TabIndex = 5;
            this.HourLB.Text = "Hours";
            // 
            // MinuteLB
            // 
            this.MinuteLB.AutoSize = true;
            this.MinuteLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinuteLB.Location = new System.Drawing.Point(257, 115);
            this.MinuteLB.Name = "MinuteLB";
            this.MinuteLB.Size = new System.Drawing.Size(82, 26);
            this.MinuteLB.TabIndex = 6;
            this.MinuteLB.Text = "Minutes";
            // 
            // SecondLB
            // 
            this.SecondLB.AutoSize = true;
            this.SecondLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondLB.Location = new System.Drawing.Point(257, 157);
            this.SecondLB.Name = "SecondLB";
            this.SecondLB.Size = new System.Drawing.Size(82, 26);
            this.SecondLB.TabIndex = 7;
            this.SecondLB.Text = "Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 193);
            this.Controls.Add(this.SecondLB);
            this.Controls.Add(this.MinuteLB);
            this.Controls.Add(this.HourLB);
            this.Controls.Add(this.DayLB);
            this.Controls.Add(this.MonthLB);
            this.Controls.Add(this.YearLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button LaskeBT;
        private Label YearLB;
        private Label MonthLB;
        private Label DayLB;
        private Label HourLB;
        private Label MinuteLB;
        private Label SecondLB;
    }
}