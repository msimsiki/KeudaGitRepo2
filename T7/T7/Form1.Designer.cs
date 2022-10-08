namespace T7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ResultLB = new System.Windows.Forms.Label();
            this.LoanTB = new System.Windows.Forms.TextBox();
            this.LiquidTB = new System.Windows.Forms.TextBox();
            this.InsuranceTB = new System.Windows.Forms.TextBox();
            this.OtherTB = new System.Windows.Forms.TextBox();
            this.FuelTB = new System.Windows.Forms.TextBox();
            this.WashTB = new System.Windows.Forms.TextBox();
            this.MaintenanceTB = new System.Windows.Forms.TextBox();
            this.TiresTB = new System.Windows.Forms.TextBox();
            this.KmCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan with interest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liquids";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insurance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Other";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fuel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wash";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Maintenance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tires";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Km / year";
            // 
            // ResultLB
            // 
            this.ResultLB.AutoSize = true;
            this.ResultLB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultLB.ForeColor = System.Drawing.Color.Red;
            this.ResultLB.Location = new System.Drawing.Point(12, 207);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(104, 23);
            this.ResultLB.TabIndex = 9;
            this.ResultLB.Text = "Cost per km";
            this.ResultLB.Visible = false;
            // 
            // LoanTB
            // 
            this.LoanTB.Location = new System.Drawing.Point(182, 6);
            this.LoanTB.Name = "LoanTB";
            this.LoanTB.Size = new System.Drawing.Size(135, 31);
            this.LoanTB.TabIndex = 10;
            // 
            // LiquidTB
            // 
            this.LiquidTB.Location = new System.Drawing.Point(182, 45);
            this.LiquidTB.Name = "LiquidTB";
            this.LiquidTB.Size = new System.Drawing.Size(135, 31);
            this.LiquidTB.TabIndex = 11;
            // 
            // InsuranceTB
            // 
            this.InsuranceTB.Location = new System.Drawing.Point(182, 83);
            this.InsuranceTB.Name = "InsuranceTB";
            this.InsuranceTB.Size = new System.Drawing.Size(135, 31);
            this.InsuranceTB.TabIndex = 12;
            // 
            // OtherTB
            // 
            this.OtherTB.Location = new System.Drawing.Point(182, 124);
            this.OtherTB.Name = "OtherTB";
            this.OtherTB.Size = new System.Drawing.Size(135, 31);
            this.OtherTB.TabIndex = 13;
            // 
            // FuelTB
            // 
            this.FuelTB.Location = new System.Drawing.Point(182, 166);
            this.FuelTB.Name = "FuelTB";
            this.FuelTB.Size = new System.Drawing.Size(135, 31);
            this.FuelTB.TabIndex = 14;
            // 
            // WashTB
            // 
            this.WashTB.Location = new System.Drawing.Point(513, 6);
            this.WashTB.Name = "WashTB";
            this.WashTB.Size = new System.Drawing.Size(135, 31);
            this.WashTB.TabIndex = 15;
            // 
            // MaintenanceTB
            // 
            this.MaintenanceTB.Location = new System.Drawing.Point(513, 45);
            this.MaintenanceTB.Name = "MaintenanceTB";
            this.MaintenanceTB.Size = new System.Drawing.Size(135, 31);
            this.MaintenanceTB.TabIndex = 16;
            // 
            // TiresTB
            // 
            this.TiresTB.Location = new System.Drawing.Point(513, 83);
            this.TiresTB.Name = "TiresTB";
            this.TiresTB.Size = new System.Drawing.Size(135, 31);
            this.TiresTB.TabIndex = 17;
            // 
            // KmCB
            // 
            this.KmCB.FormattingEnabled = true;
            this.KmCB.Items.AddRange(new object[] {
            "1000",
            "5000",
            "10000",
            "30000",
            "50000",
            "100000"});
            this.KmCB.Location = new System.Drawing.Point(513, 124);
            this.KmCB.Name = "KmCB";
            this.KmCB.Size = new System.Drawing.Size(135, 31);
            this.KmCB.TabIndex = 18;
            this.KmCB.Text = "Select";
            this.KmCB.SelectedIndexChanged += new System.EventHandler(this.KmCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 239);
            this.Controls.Add(this.KmCB);
            this.Controls.Add(this.TiresTB);
            this.Controls.Add(this.MaintenanceTB);
            this.Controls.Add(this.WashTB);
            this.Controls.Add(this.FuelTB);
            this.Controls.Add(this.OtherTB);
            this.Controls.Add(this.InsuranceTB);
            this.Controls.Add(this.LiquidTB);
            this.Controls.Add(this.LoanTB);
            this.Controls.Add(this.ResultLB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label ResultLB;
        private TextBox LoanTB;
        private TextBox LiquidTB;
        private TextBox InsuranceTB;
        private TextBox OtherTB;
        private TextBox FuelTB;
        private TextBox WashTB;
        private TextBox MaintenanceTB;
        private TextBox TiresTB;
        private ComboBox KmCB;
    }
}