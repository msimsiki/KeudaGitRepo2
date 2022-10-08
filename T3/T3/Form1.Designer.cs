namespace T3
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
            this.NOneTB = new System.Windows.Forms.TextBox();
            this.NTwoTB = new System.Windows.Forms.TextBox();
            this.CalcCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerLB = new System.Windows.Forms.Label();
            this.CalcBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NOneTB
            // 
            this.NOneTB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NOneTB.Location = new System.Drawing.Point(12, 12);
            this.NOneTB.Name = "NOneTB";
            this.NOneTB.Size = new System.Drawing.Size(100, 33);
            this.NOneTB.TabIndex = 0;
            // 
            // NTwoTB
            // 
            this.NTwoTB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NTwoTB.Location = new System.Drawing.Point(203, 12);
            this.NTwoTB.Name = "NTwoTB";
            this.NTwoTB.Size = new System.Drawing.Size(100, 33);
            this.NTwoTB.TabIndex = 1;
            // 
            // CalcCB
            // 
            this.CalcCB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalcCB.FormattingEnabled = true;
            this.CalcCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CalcCB.Location = new System.Drawing.Point(118, 12);
            this.CalcCB.Name = "CalcCB";
            this.CalcCB.Size = new System.Drawing.Size(79, 34);
            this.CalcCB.TabIndex = 2;
            this.CalcCB.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // AnswerLB
            // 
            this.AnswerLB.AutoSize = true;
            this.AnswerLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnswerLB.Location = new System.Drawing.Point(337, 15);
            this.AnswerLB.Name = "AnswerLB";
            this.AnswerLB.Size = new System.Drawing.Size(24, 26);
            this.AnswerLB.TabIndex = 4;
            this.AnswerLB.Text = "X";
            // 
            // CalcBT
            // 
            this.CalcBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CalcBT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalcBT.Location = new System.Drawing.Point(472, 12);
            this.CalcBT.Name = "CalcBT";
            this.CalcBT.Size = new System.Drawing.Size(98, 33);
            this.CalcBT.TabIndex = 5;
            this.CalcBT.Text = "Calculate";
            this.CalcBT.UseVisualStyleBackColor = true;
            this.CalcBT.Click += new System.EventHandler(this.CalcBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 183);
            this.Controls.Add(this.CalcBT);
            this.Controls.Add(this.AnswerLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcCB);
            this.Controls.Add(this.NTwoTB);
            this.Controls.Add(this.NOneTB);
            this.Name = "Form1";
            this.Text = "Harjoitus 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NOneTB;
        private TextBox NTwoTB;
        private ComboBox CalcCB;
        private Label label1;
        private Label AnswerLB;
        private Button CalcBT;
    }
}