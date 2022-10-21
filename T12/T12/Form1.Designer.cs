namespace T12
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dRB = new System.Windows.Forms.RadioButton();
            this.cRB = new System.Windows.Forms.RadioButton();
            this.bRB = new System.Windows.Forms.RadioButton();
            this.aRB = new System.Windows.Forms.RadioButton();
            this.qLB = new System.Windows.Forms.Label();
            this.aLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dRB);
            this.groupBox1.Controls.Add(this.cRB);
            this.groupBox1.Controls.Add(this.bRB);
            this.groupBox1.Controls.Add(this.aRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // dRB
            // 
            this.dRB.AutoSize = true;
            this.dRB.Location = new System.Drawing.Point(15, 145);
            this.dRB.Name = "dRB";
            this.dRB.Size = new System.Drawing.Size(40, 27);
            this.dRB.TabIndex = 3;
            this.dRB.Text = "D";
            this.dRB.UseVisualStyleBackColor = true;
            // 
            // cRB
            // 
            this.cRB.AutoSize = true;
            this.cRB.Location = new System.Drawing.Point(15, 112);
            this.cRB.Name = "cRB";
            this.cRB.Size = new System.Drawing.Size(38, 27);
            this.cRB.TabIndex = 2;
            this.cRB.Text = "C";
            this.cRB.UseVisualStyleBackColor = true;
            // 
            // bRB
            // 
            this.bRB.AutoSize = true;
            this.bRB.Location = new System.Drawing.Point(15, 79);
            this.bRB.Name = "bRB";
            this.bRB.Size = new System.Drawing.Size(38, 27);
            this.bRB.TabIndex = 1;
            this.bRB.Text = "B";
            this.bRB.UseVisualStyleBackColor = true;
            // 
            // aRB
            // 
            this.aRB.AutoSize = true;
            this.aRB.Location = new System.Drawing.Point(15, 46);
            this.aRB.Name = "aRB";
            this.aRB.Size = new System.Drawing.Size(39, 27);
            this.aRB.TabIndex = 0;
            this.aRB.Text = "A";
            this.aRB.UseVisualStyleBackColor = true;
            // 
            // qLB
            // 
            this.qLB.AutoSize = true;
            this.qLB.Location = new System.Drawing.Point(12, 9);
            this.qLB.Name = "qLB";
            this.qLB.Size = new System.Drawing.Size(81, 23);
            this.qLB.TabIndex = 1;
            this.qLB.Text = "Question";
            // 
            // aLB
            // 
            this.aLB.AutoSize = true;
            this.aLB.Location = new System.Drawing.Point(12, 265);
            this.aLB.Name = "aLB";
            this.aLB.Size = new System.Drawing.Size(69, 23);
            this.aLB.TabIndex = 2;
            this.aLB.Text = "Answer";
            this.aLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 307);
            this.Controls.Add(this.aLB);
            this.Controls.Add(this.qLB);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Harjoitus 12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton dRB;
        private RadioButton cRB;
        private RadioButton bRB;
        private RadioButton aRB;
        private Label qLB;
        private Label aLB;
    }
}