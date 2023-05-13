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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ResultLB = new Label();
            LoanTB = new TextBox();
            LiquidTB = new TextBox();
            InsuranceTB = new TextBox();
            OtherTB = new TextBox();
            FuelTB = new TextBox();
            WashTB = new TextBox();
            MaintenanceTB = new TextBox();
            TiresTB = new TextBox();
            KmCB = new ComboBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 0;
            label1.Text = "Loan with interest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Liquids";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 2;
            label3.Text = "Insurance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 3;
            label4.Text = "Other";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 4;
            label5.Text = "Fuel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 59);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 5;
            label6.Text = "Wash";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 98);
            label7.Name = "label7";
            label7.Size = new Size(110, 23);
            label7.TabIndex = 6;
            label7.Text = "Maintenance";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(374, 136);
            label8.Name = "label8";
            label8.Size = new Size(47, 23);
            label8.TabIndex = 7;
            label8.Text = "Tires";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(374, 177);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 8;
            label9.Text = "Km / year";
            // 
            // ResultLB
            // 
            ResultLB.AutoSize = true;
            ResultLB.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ResultLB.ForeColor = Color.Red;
            ResultLB.Location = new Point(12, 257);
            ResultLB.Name = "ResultLB";
            ResultLB.Size = new Size(104, 23);
            ResultLB.TabIndex = 9;
            ResultLB.Text = "Cost per km";
            ResultLB.Visible = false;
            // 
            // LoanTB
            // 
            LoanTB.Location = new Point(182, 56);
            LoanTB.Name = "LoanTB";
            LoanTB.Size = new Size(135, 31);
            LoanTB.TabIndex = 10;
            // 
            // LiquidTB
            // 
            LiquidTB.Location = new Point(182, 95);
            LiquidTB.Name = "LiquidTB";
            LiquidTB.Size = new Size(135, 31);
            LiquidTB.TabIndex = 11;
            // 
            // InsuranceTB
            // 
            InsuranceTB.Location = new Point(182, 133);
            InsuranceTB.Name = "InsuranceTB";
            InsuranceTB.Size = new Size(135, 31);
            InsuranceTB.TabIndex = 12;
            // 
            // OtherTB
            // 
            OtherTB.Location = new Point(182, 174);
            OtherTB.Name = "OtherTB";
            OtherTB.Size = new Size(135, 31);
            OtherTB.TabIndex = 13;
            // 
            // FuelTB
            // 
            FuelTB.Location = new Point(182, 216);
            FuelTB.Name = "FuelTB";
            FuelTB.Size = new Size(135, 31);
            FuelTB.TabIndex = 14;
            // 
            // WashTB
            // 
            WashTB.Location = new Point(513, 56);
            WashTB.Name = "WashTB";
            WashTB.Size = new Size(135, 31);
            WashTB.TabIndex = 15;
            // 
            // MaintenanceTB
            // 
            MaintenanceTB.Location = new Point(513, 95);
            MaintenanceTB.Name = "MaintenanceTB";
            MaintenanceTB.Size = new Size(135, 31);
            MaintenanceTB.TabIndex = 16;
            // 
            // TiresTB
            // 
            TiresTB.Location = new Point(513, 133);
            TiresTB.Name = "TiresTB";
            TiresTB.Size = new Size(135, 31);
            TiresTB.TabIndex = 17;
            // 
            // KmCB
            // 
            KmCB.FormattingEnabled = true;
            KmCB.Items.AddRange(new object[] { "1000", "5000", "10000", "30000", "50000", "100000" });
            KmCB.Location = new Point(513, 174);
            KmCB.Name = "KmCB";
            KmCB.Size = new Size(135, 31);
            KmCB.TabIndex = 18;
            KmCB.Text = "Select";
            KmCB.SelectedIndexChanged += KmCB_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(336, 25);
            label10.TabIndex = 19;
            label10.Text = "Fill all the fields then select Km / year";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 293);
            Controls.Add(label10);
            Controls.Add(KmCB);
            Controls.Add(TiresTB);
            Controls.Add(MaintenanceTB);
            Controls.Add(WashTB);
            Controls.Add(FuelTB);
            Controls.Add(OtherTB);
            Controls.Add(InsuranceTB);
            Controls.Add(LiquidTB);
            Controls.Add(LoanTB);
            Controls.Add(ResultLB);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Harjoitus 7";
            ResumeLayout(false);
            PerformLayout();
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
        private Label label10;
    }
}