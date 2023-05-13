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
            groupBox1 = new GroupBox();
            dRB = new RadioButton();
            cRB = new RadioButton();
            bRB = new RadioButton();
            aRB = new RadioButton();
            qLB = new Label();
            aLB = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dRB);
            groupBox1.Controls.Add(cRB);
            groupBox1.Controls.Add(bRB);
            groupBox1.Controls.Add(aRB);
            groupBox1.Location = new Point(12, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(90, 190);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // dRB
            // 
            dRB.AutoSize = true;
            dRB.Location = new Point(15, 145);
            dRB.Name = "dRB";
            dRB.Size = new Size(40, 27);
            dRB.TabIndex = 3;
            dRB.Text = "D";
            dRB.UseVisualStyleBackColor = true;
            // 
            // cRB
            // 
            cRB.AutoSize = true;
            cRB.Location = new Point(15, 112);
            cRB.Name = "cRB";
            cRB.Size = new Size(38, 27);
            cRB.TabIndex = 2;
            cRB.Text = "C";
            cRB.UseVisualStyleBackColor = true;
            // 
            // bRB
            // 
            bRB.AutoSize = true;
            bRB.Location = new Point(15, 79);
            bRB.Name = "bRB";
            bRB.Size = new Size(38, 27);
            bRB.TabIndex = 1;
            bRB.Text = "B";
            bRB.UseVisualStyleBackColor = true;
            // 
            // aRB
            // 
            aRB.AutoSize = true;
            aRB.Location = new Point(15, 46);
            aRB.Name = "aRB";
            aRB.Size = new Size(39, 27);
            aRB.TabIndex = 0;
            aRB.Text = "A";
            aRB.UseVisualStyleBackColor = true;
            // 
            // qLB
            // 
            qLB.AutoSize = true;
            qLB.Location = new Point(12, 106);
            qLB.Name = "qLB";
            qLB.Size = new Size(81, 23);
            qLB.TabIndex = 1;
            qLB.Text = "Question";
            // 
            // aLB
            // 
            aLB.AutoSize = true;
            aLB.Location = new Point(12, 362);
            aLB.Name = "aLB";
            aLB.Size = new Size(69, 23);
            aLB.TabIndex = 2;
            aLB.Text = "Answer";
            aLB.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 69);
            label1.TabIndex = 3;
            label1.Text = "No need questions\r\nJust click to options\r\n(Im lazy)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 402);
            Controls.Add(label1);
            Controls.Add(aLB);
            Controls.Add(qLB);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Harjoitus 12";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton dRB;
        private RadioButton cRB;
        private RadioButton bRB;
        private RadioButton aRB;
        private Label qLB;
        private Label aLB;
        private Label label1;
    }
}