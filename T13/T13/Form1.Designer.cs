namespace T13
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
            this.rLB = new System.Windows.Forms.Label();
            this.CheckBT = new System.Windows.Forms.Button();
            this.CheckTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a name starting with capital letter. (ie. Aleksi)";
            // 
            // rLB
            // 
            this.rLB.AutoSize = true;
            this.rLB.Location = new System.Drawing.Point(33, 107);
            this.rLB.Name = "rLB";
            this.rLB.Size = new System.Drawing.Size(0, 23);
            this.rLB.TabIndex = 1;
            // 
            // CheckBT
            // 
            this.CheckBT.Location = new System.Drawing.Point(624, 98);
            this.CheckBT.Name = "CheckBT";
            this.CheckBT.Size = new System.Drawing.Size(95, 32);
            this.CheckBT.TabIndex = 2;
            this.CheckBT.Text = "CHECK";
            this.CheckBT.UseVisualStyleBackColor = true;
            this.CheckBT.Click += new System.EventHandler(this.CheckBT_Click);
            // 
            // CheckTB
            // 
            this.CheckTB.Location = new System.Drawing.Point(522, 23);
            this.CheckTB.Name = "CheckTB";
            this.CheckTB.Size = new System.Drawing.Size(197, 31);
            this.CheckTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 156);
            this.Controls.Add(this.CheckTB);
            this.Controls.Add(this.CheckBT);
            this.Controls.Add(this.rLB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label rLB;
        private Button CheckBT;
        private TextBox CheckTB;
    }
}