namespace T10
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
            this.WeightLB = new System.Windows.Forms.Label();
            this.HeightLB = new System.Windows.Forms.Label();
            this.ResultLB = new System.Windows.Forms.Label();
            this.CalculateBT = new System.Windows.Forms.Button();
            this.WeightTB = new System.Windows.Forms.TextBox();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.BmiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeightLB
            // 
            this.WeightLB.AutoSize = true;
            this.WeightLB.Location = new System.Drawing.Point(12, 9);
            this.WeightLB.Name = "WeightLB";
            this.WeightLB.Size = new System.Drawing.Size(73, 26);
            this.WeightLB.TabIndex = 0;
            this.WeightLB.Text = "Weight";
            // 
            // HeightLB
            // 
            this.HeightLB.AutoSize = true;
            this.HeightLB.Location = new System.Drawing.Point(12, 49);
            this.HeightLB.Name = "HeightLB";
            this.HeightLB.Size = new System.Drawing.Size(68, 26);
            this.HeightLB.TabIndex = 1;
            this.HeightLB.Text = "Height";
            // 
            // ResultLB
            // 
            this.ResultLB.AutoSize = true;
            this.ResultLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultLB.ForeColor = System.Drawing.Color.Black;
            this.ResultLB.Location = new System.Drawing.Point(12, 178);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(66, 26);
            this.ResultLB.TabIndex = 2;
            this.ResultLB.Text = "Result";
            this.ResultLB.Visible = false;
            // 
            // CalculateBT
            // 
            this.CalculateBT.Location = new System.Drawing.Point(12, 89);
            this.CalculateBT.Name = "CalculateBT";
            this.CalculateBT.Size = new System.Drawing.Size(189, 35);
            this.CalculateBT.TabIndex = 3;
            this.CalculateBT.Text = "Calculate BMI";
            this.CalculateBT.UseVisualStyleBackColor = true;
            this.CalculateBT.Click += new System.EventHandler(this.CalculateBT_Click);
            // 
            // WeightTB
            // 
            this.WeightTB.Location = new System.Drawing.Point(101, 6);
            this.WeightTB.Name = "WeightTB";
            this.WeightTB.Size = new System.Drawing.Size(100, 33);
            this.WeightTB.TabIndex = 4;
            // 
            // HeightTB
            // 
            this.HeightTB.Location = new System.Drawing.Point(101, 48);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(100, 33);
            this.HeightTB.TabIndex = 5;
            // 
            // BmiLB
            // 
            this.BmiLB.AutoSize = true;
            this.BmiLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BmiLB.Location = new System.Drawing.Point(12, 138);
            this.BmiLB.Name = "BmiLB";
            this.BmiLB.Size = new System.Drawing.Size(61, 26);
            this.BmiLB.TabIndex = 6;
            this.BmiLB.Text = "Index";
            this.BmiLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(246, 217);
            this.Controls.Add(this.BmiLB);
            this.Controls.Add(this.HeightTB);
            this.Controls.Add(this.WeightTB);
            this.Controls.Add(this.CalculateBT);
            this.Controls.Add(this.ResultLB);
            this.Controls.Add(this.HeightLB);
            this.Controls.Add(this.WeightLB);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Harjoitus 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WeightLB;
        private Label HeightLB;
        private Label ResultLB;
        private Button CalculateBT;
        private TextBox WeightTB;
        private TextBox HeightTB;
        private Label BmiLB;
    }
}