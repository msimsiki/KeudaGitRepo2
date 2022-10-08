namespace T5
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
            this.TitleLB = new System.Windows.Forms.Label();
            this.ResultLB = new System.Windows.Forms.Label();
            this.NewNoTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Location = new System.Drawing.Point(12, 9);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(170, 23);
            this.TitleLB.TabIndex = 0;
            this.TitleLB.Text = "Enter Number (-999)";
            // 
            // ResultLB
            // 
            this.ResultLB.AutoSize = true;
            this.ResultLB.Location = new System.Drawing.Point(12, 47);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(57, 23);
            this.ResultLB.TabIndex = 1;
            this.ResultLB.Text = "Result";
            // 
            // NewNoTB
            // 
            this.NewNoTB.Location = new System.Drawing.Point(205, 9);
            this.NewNoTB.Name = "NewNoTB";
            this.NewNoTB.Size = new System.Drawing.Size(143, 31);
            this.NewNoTB.TabIndex = 2;
            this.NewNoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewNoTB_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 80);
            this.Controls.Add(this.NewNoTB);
            this.Controls.Add(this.ResultLB);
            this.Controls.Add(this.TitleLB);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLB;
        private Label ResultLB;
        private TextBox NewNoTB;
    }
}