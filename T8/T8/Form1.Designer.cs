namespace T8
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
            this.ResultLB = new System.Windows.Forms.Label();
            this.ConvertBT = new System.Windows.Forms.Button();
            this.NoTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number between 1-3999";
            // 
            // ResultLB
            // 
            this.ResultLB.AutoSize = true;
            this.ResultLB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultLB.ForeColor = System.Drawing.Color.Red;
            this.ResultLB.Location = new System.Drawing.Point(12, 57);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(65, 26);
            this.ResultLB.TabIndex = 1;
            this.ResultLB.Text = "label2";
            this.ResultLB.Visible = false;
            // 
            // ConvertBT
            // 
            this.ConvertBT.Location = new System.Drawing.Point(331, 54);
            this.ConvertBT.Name = "ConvertBT";
            this.ConvertBT.Size = new System.Drawing.Size(101, 33);
            this.ConvertBT.TabIndex = 2;
            this.ConvertBT.Text = "Convert";
            this.ConvertBT.UseVisualStyleBackColor = true;
            this.ConvertBT.Click += new System.EventHandler(this.ConvertBT_Click);
            // 
            // NoTB
            // 
            this.NoTB.Location = new System.Drawing.Point(332, 6);
            this.NoTB.Name = "NoTB";
            this.NoTB.Size = new System.Drawing.Size(100, 33);
            this.NoTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(450, 104);
            this.Controls.Add(this.NoTB);
            this.Controls.Add(this.ConvertBT);
            this.Controls.Add(this.ResultLB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label ResultLB;
        private Button ConvertBT;
        private TextBox NoTB;
    }
}